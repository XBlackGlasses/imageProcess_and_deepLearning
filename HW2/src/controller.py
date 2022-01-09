from PyQt5 import QtWidgets, QtGui, QtCore
from numpy.lib.function_base import select
import torch
#from torch._C import preserve_format
from UI import Ui_MainWindow
from PyQt5.QtWidgets import QMessageBox, QGraphicsScene, QGraphicsPixmapItem
from PyQt5.QtGui import QImage, QPixmap
import cv2
import numpy as np
import matplotlib.pyplot as plt
import os
import json
import csv
import math

from detectron2.utils.logger import setup_logger

from detectron2.engine import DefaultPredictor
from detectron2.config import get_cfg
from detectron2.utils.visualizer import Visualizer
from detectron2.data import MetadataCatalog
import matplotlib.pyplot as plt
from detectron2.layers.rotated_boxes import pairwise_iou_rotated
setup_logger()

def getSegmentPoints(bbox):
    ctrx = bbox[0]
    ctry = bbox[1]
    wid = bbox[2]
    hei = bbox[3]
    angle = bbox[4]
    # left-top
    x1 = ctrx - (wid / 2)
    y1 = ctry - (hei / 2)
    # left-button
    x2 = ctrx - (wid / 2)
    y2 = ctry + (hei / 2)
    # right-button
    x3 = ctrx + (wid / 2)
    y3 = ctry + (hei / 2)
    # right-up
    x4 = ctrx + (wid / 2)
    y4 = ctry - (hei / 2)
    # rotated matrix
    M = cv2.getRotationMatrix2D(center=(ctrx, ctry), angle = -angle, scale = 1)
    # coordinatize
    p1 = np.array([x1, y1, 1])
    p2 = np.array([x2, y2, 1])
    p3 = np.array([x3, y3, 1])
    p4 = np.array([x4, y4, 1])
    # points after rotation
    point1 = M.dot(p1.T)
    point2 = M.dot(p2.T)
    point3 = M.dot(p3.T)
    point4 = M.dot(p4.T)
    # segmentation
    seg = np.array([[point1[0], point1[1]], [point2[0], point2[1]], 
            [point3[0], point3[1]], [point4[0], point4[1]]], np.int32)
    
    return seg

def compute_iou(rec1, rec2):
    """
    computing IoU
    :param rec1: (y0, x0, y1, x1), which reflects
            (top, left, bottom, right)
    :param rec2: (y0, x0, y1, x1)
    :return: scala value of IoU
    """
    # computing area of each rectangles
    S_rec1 = (rec1[2] - rec1[0]) * (rec1[3] - rec1[1])
    S_rec2 = (rec2[2] - rec2[0]) * (rec2[3] - rec2[1])

    # computing the sum_area
    sum_area = S_rec1 + S_rec2

    # find the each edge of intersect rectangle
    left_line = max(rec1[1], rec2[1])
    right_line = min(rec1[3], rec2[3])
    top_line = max(rec1[0], rec2[0])
    bottom_line = min(rec1[2], rec2[2])

    # judge if there is an intersect
    if left_line >= right_line or top_line >= bottom_line:
        return 0
    else:
        intersect = (right_line - left_line) * (bottom_line - top_line)
        return intersect / (sum_area - intersect)


class MainWindow(QtWidgets.QMainWindow):
    def __init__(self):
        super().__init__()
        self.ui = Ui_MainWindow()
        self.ui.setupUi(self)
        self.setup_control()
        self.folder = None
        self.imgList = []
        self.scapList = []
        self.fracList = []
        self.paint_imgs = []
        self.scap_imgs = []
        self.frac_imgs = []
        self.scaphIOU = []
        self.fracIOU = []
        self.cut_img = 0
        self.id = -1
        self.tp = 0
        self.tn = 0
        self.fp = 0
        self.fn = 0

        # yolov4 model
        net = cv2.dnn.readNet('yolo_cfg/yolov4-custom.cfg', 'yolo_cfg/yolov4-custom_best.weights')
        self.model = cv2.dnn_DetectionModel(net)

        # detectron2 model
        self.cfg = get_cfg()
        self.cfg.merge_from_file("detectron_cfg/myconfig.yaml")
        self.cfg.MODEL.ROI_HEADS.SCORE_THRESH_TEST = 0.5  # 模型阈值
        self.cfg.MODEL.WEIGHTS = "detectron_cfg/model_final2.pth"
        self.predictor = DefaultPredictor(self.cfg)

    def setup_control(self):
        self.warnMsg = QMessageBox()
        self.ui.Folder_Button.clicked.connect(self.__Folder)
        self.ui.horizontalSlider.valueChanged.connect(self.__SliderValue)
    

    def showImage(self, img, viewbox):
        height, width, bytesPerComponent = img.shape
        bytesPerLine = bytesPerComponent * width
        # cv2.cvtColor(img, cv2.COLOR_BGR2RGB, img)
        QImg = QImage(img.data, width, height, bytesPerLine, QImage.Format_RGB888)
        pixmap = QPixmap.fromImage(QImg)
        item = QGraphicsPixmapItem(pixmap)
        scene = QGraphicsScene()
        scene.addItem(item)
        if viewbox == 'origin':
            self.ui.ori_graph.setScene(scene)
            self.ui.ori_graph.fitInView(item)
            self.ui.ori_graph.show()
        elif viewbox == 'detect':
            self.ui.det_graph.setScene(scene)
            self.ui.det_graph.fitInView(item)
            self.ui.det_graph.show()
        elif viewbox == 'after_cut':
            self.ui.after_graph.setScene(scene)
            self.ui.after_graph.fitInView(item)
            self.ui.after_graph.show()
        elif viewbox == 'classify':
            self.ui.class_graph.setScene(scene)
            self.ui.class_graph.fitInView(item)
            self.ui.class_graph.show()


    def __Folder(self):
        self.folder = None
        self.imgList = []
        self.scapList = []
        self.fracList = []
        self.cut_img = 0
        self.id = -1

        # yolov4 model
        self.folder = QtWidgets.QFileDialog.getExistingDirectory(None, "choose dir", '/')   
        img_dir = os.listdir(self.folder + '/Images')
        annot_dir = os.listdir(self.folder + '/Annotations')
        print(img_dir)
        print(annot_dir)
        fracture_id = -1
        for dir in img_dir:
            images = os.listdir(self.folder + '/Images/' + dir)   
            for img in images:
                img_is_fracutre = False
                # fracture data
                if dir == 'Fracture':
                    with open(self.folder + '/Annotations/Fracture_Coordinate/' + img[:-3] + 'csv', newline='') as f:
                        rows = csv.reader(f)   
                        rows = list(rows)
                        f.close()
                    ctrx = float(rows[1][0])
                    ctry = float(rows[1][1])
                    wid = float(rows[1][2])
                    hei = float(rows[1][3])
                    angle =  float(rows[1][4])
                    bbox = [ctrx, ctry, wid, hei, angle]
                    self.fracList.append(bbox)
                    fracture_id += 1
                    img_is_fracutre = True

                # scaphoid data
                with open(self.folder + '/Annotations/Scaphoid_Slice/' + img[:-3] + 'json', 'r') as f:
                    load_dict = json.load(f)
                sbbox = [int(p) for p in load_dict[0]['bbox'] ]
               # print(bbox)
                self.scapList.append(sbbox)

                # image
                img_path = self.folder + '/Images/' + dir + '/' + img        
               # print(img_path)
                image = cv2.imread(img_path)
                if img_is_fracutre == True:
                    data = {
                        "image" : image,
                        "is_fracture" : True,
                        "fracture_id" : fracture_id,
                        "scaphoid_data" : sbbox
                        }
                else:
                    data = {
                        "image" : image,
                        "is_fracture" : False,
                        "fracture_id" : -1,
                        "scaphoid_data" : sbbox
                        }
                self.imgList.append(data)
        num_frac = fracture_id + 1
        #print(num_frac)
        print("average AP at yolo iou threshold50\n\t99.2%")

        print("average AP at detectron2\n\t45.552%")
        self.__FindScaphoid()

        self.num_imgs = len(self.imgList)
        self.ui.horizontalSlider.setMinimum(1)
        self.ui.horizontalSlider.setMaximum(self.num_imgs)
        self.ui.horizontalSlider.setSingleStep(1)
        self.ui.scroll_label.setFont(QtGui.QFont('Arial', 24))
        self.ui.scroll_label.setText("1 / " + str(self.num_imgs))
        scaphoid_IOU = sum(self.scaphIOU) / len(self.scaphIOU)
        frac_IOU = sum(self.fracIOU) / num_frac
        
        accuracy = (self.tp + self.tn) / (self.tp + self.tn + self.fp + self.fn)
        precision = self.tp / (self.tp + self.fp)
        recall = self.tp / (self.tp + self.fn)
        f1 = 2 * (precision * recall) / (precision + recall)

        self.ui.folder_label.setFont(QtGui.QFont('Arial', 16))
        self.ui.folder_label.setText("Folder\nScaphoid IOU: " + str(scaphoid_IOU)
                                    + "\nFrac IOU: " + str(frac_IOU)
                                    + "\nAccuracy: " + str(accuracy)
                                    + "\nPrecision: " + str(precision)
                                    + "\nRecall: " + str(recall)
                                    + "\nF1-Score: " + str(f1))


    def __SliderValue(self):
        if self.imgList == []:
            self.warnMsg.setText("Need to choose dir first")
            self.warnMsg.show()
            self.ui.horizontalSlider.setValue(1)
            self.warnMsg.exec()
        else:
            id = self.ui.horizontalSlider.value()
            self.ui.scroll_label.setText(str(id) + " / " + str(self.num_imgs))
            self.id = id - 1
            img = self.imgList[self.id]["image"]
            cv2.cvtColor(img, cv2.COLOR_BGR2RGB, img)
            self.showImage(img, 'origin')
            self.showImage(self.paint_imgs[self.id], 'detect')
            self.showImage(self.scap_imgs[self.id], 'after_cut')
            self.showImage(self.frac_imgs[self.id], 'classify')

            if self.conditions[self.id] == 1:
                self.ui.type_label.setFont(QtGui.QFont('Arial', 16))
                self.ui.type_label.setText("Type: abnormal \nPredict: abnormal")
            elif self.conditions[self.id] == 2:
                self.ui.type_label.setFont(QtGui.QFont('Arial', 16))
                self.ui.type_label.setText("Type: abnormal \nPredict: normal")
            elif self.conditions[self.id] == 3:
                self.ui.type_label.setFont(QtGui.QFont('Arial', 16))
                self.ui.type_label.setText("Type: normal \nPredict: abnormal")
            elif self.conditions[self.id] == 4:
                self.ui.type_label.setFont(QtGui.QFont('Arial', 16))
                self.ui.type_label.setText("Type: normal \nPredict: normal")
            
            self.ui.img_label.setFont(QtGui.QFont('Arial', 16))
            self.ui.img_label.setText("Current Image:\nScaphoid IOU: " + str(self.scaphIOU[self.id])
                                    + "\nFracture IOU: " + str(self.fracIOU[self.id]))
    
    # get scaphoid
    def __FindScaphoid(self):
        self.conditions = []
        condition = 0
        for imgdata in self.imgList:
            self.model.setInputParams(size=(416, 416), scale=1/255.0)
            self.model.setInputSwapRB(True)
            confident = 0
            input = imgdata["image"].copy()
            classes, confs, boxes = self.model.detect(input, 0.4, 0.1)
            img = imgdata["image"].copy()
            # predict bbox
            if len(boxes) != 0: 
                for (classid, conf, box) in zip(classes, confs, boxes):
                    if(conf > confident):
                        confident = conf
                        cv2.rectangle(img, box, color = (255, 0, 0), thickness = 3)
            # ground true
            groundTrue = imgdata["scaphoid_data"]
            x1 = groundTrue[0]
            y1 = groundTrue[1]
            x2 = groundTrue[2]
            y2 = groundTrue[3]
            cv2.rectangle(img, (x1, y1), (x2, y2) , color = (0, 0, 255), thickness = 3)
            #self.showImage(img, 'detect')
            cv2.cvtColor(img, cv2.COLOR_BGR2RGB, img)
            self.paint_imgs.append(img)
            # compute IOU
            yoloBox = [box[0], box[1], box[0]+box[2], box[1]+box[3]]
            #print(groundTrue)
            #print(yoloBox)
            yolo_iou = compute_iou(yoloBox, groundTrue)
            self.scaphIOU.append(yolo_iou)
            #box = box.tolist()
            # left up point
            if len(boxes) != 0:
                x1 = box[0]
                y1 = box[1]
                w = box[2]
                h = box[3]
            else:
                x1 = groundTrue[0]
                y1 = groundTrue[1]
                x2 = groundTrue[2]
                y2 = groundTrue[3]
                w = x2 - x1
                h = y2 - y1
            # cutted image use predicted box
            img = imgdata["image"].copy()
            cut_img = img[y1: y1 + h, x1: x1 + w].copy()
            self.cut_img = cut_img.copy()
            #cv2.imshow('1', self.cut_img)
            #self.showImage(self.cut_img, 'after_cut')
            cv2.cvtColor(img, cv2.COLOR_BGR2RGB, img)
            self.scap_imgs.append(cut_img)
        
            # for correction fracture ground true
            if imgdata["is_fracture"]:
                frac_id = imgdata["fracture_id"]
                fracbox = self.fracList[frac_id]
                img = self.cut_img.copy()
                
                # regulate points
                ctrx = fracbox[0]
                ctry = fracbox[1]
                # get origin coordinate of centers
                ctrx += groundTrue[0]
                ctry += groundTrue[1]
                # get relative coordinates
                ctrx -= box[0]
                ctry -= box[1]
                fracbox[0] = ctrx
                fracbox[1] = ctry
                points = getSegmentPoints(fracbox)
                # paint groung true
                cv2.polylines(img, pts=[points], isClosed=True, color=(0, 0, 255), thickness=2)
                
                # predict
                input = self.cut_img.copy()
                outputs = self.predictor(input)
                #pred_classes = outputs["instances"].pred_classes
                pred_boxes = outputs["instances"].pred_boxes
                #pred_classes = outputs["instances"].pred_classes.cpu().numpy()
                pred_boxes = outputs["instances"].pred_boxes.tensor.cpu().numpy()
                if len (pred_boxes) != 0:   # predict abnormal
                    bbox = [pred_boxes[0][0], pred_boxes[0][1], pred_boxes[0][2], pred_boxes[0][3], -pred_boxes[0][4]]
                    points = getSegmentPoints(bbox)
                    cv2.polylines(img, pts=[points], isClosed=True, color=(255, 0, 0), thickness=2)
                    condition = 1
                    rotate_iou = pairwise_iou_rotated(torch.FloatTensor(bbox),
                                                    torch.FloatTensor(fracbox))
                    rotate_iou = rotate_iou.numpy()
                    self.fracIOU.append(rotate_iou[0,0])
                    self.tp += 1
                else:   # predict normal
                    condition = 2
                    self.fracIOU.append(0)
                    self.fn += 1
                    # self.ui.type_label.setFont(QtGui.QFont('Arial', 16))
                    # self.ui.type_label.setText("Type: abnormal \nPredict: normal")
                # cv2.imshow('1', img)
                # print(fracbox)
                # cv2.waitKey(0)
                cv2.cvtColor(img, cv2.COLOR_BGR2RGB, img)
                self.frac_imgs.append(img.copy())
            else:
                # predict
                img = self.cut_img.copy()
                input = self.cut_img.copy()
                outputs = self.predictor(input)
                #pred_classes = outputs["instances"].pred_classes
                pred_boxes = outputs["instances"].pred_boxes
                #pred_classes = outputs["instances"].pred_classes.cpu().numpy()
                pred_boxes = outputs["instances"].pred_boxes.tensor.cpu().numpy()
                if len (pred_boxes) != 0:
                    bbox = [pred_boxes[0][0], pred_boxes[0][1], pred_boxes[0][2], pred_boxes[0][3], -pred_boxes[0][4]]
                    points = getSegmentPoints(bbox)
                    cv2.polylines(img, pts=[points], isClosed=True, color=(255, 0, 0), thickness=2)
                    condition = 3
                    # self.ui.type_label.setFont(QtGui.QFont('Arial', 16))
                    # self.ui.type_label.setText("Type: normal \nPredict: abnormal")
                    self.fracIOU.append(0)
                    self.tn += 1
                else:
                    self.fracIOU.append(0)
                    condition = 4
                    self.fp += 1
                    # self.ui.type_label.setFont(QtGui.QFont('Arial', 16))
                    # self.ui.type_label.setText("Type: normal \nPredict: normal")
                cv2.cvtColor(img, cv2.COLOR_BGR2RGB, img)
                self.frac_imgs.append(img.copy())
            self.conditions.append(condition)
