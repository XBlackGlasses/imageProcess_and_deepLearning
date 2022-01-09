import os
import cv2
from detectron2.utils.logger import setup_logger

from detectron2.engine import DefaultPredictor
from detectron2.config import get_cfg
from detectron2.utils.visualizer import Visualizer
from detectron2.data import MetadataCatalog
from train_net import myVisualization
import matplotlib.pyplot as plt
import numpy as np
if __name__ == "__main__":
    setup_logger()

    cfg = get_cfg()
    cfg.merge_from_file("output/config.yaml")
   
    cfg.MODEL.WEIGHTS = "output/model_final.pth"
    predictor = DefaultPredictor(cfg)
    img = cv2.imread("./data/1/train/08092913-AP0.bmp")
    outputs = predictor(img)

    pred_classes = outputs["instances"].pred_classes.cpu().numpy()
    pred_boxes = outputs["instances"].pred_boxes.tensor.cpu().numpy()
    print(pred_classes)
    print(pred_boxes)
    ctrx = pred_boxes[0][0]
    ctry = pred_boxes[0][1]
    wid = pred_boxes[0][2]
    hei = pred_boxes[0][3]
    angle = -pred_boxes[0][4]

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
    cv2.polylines(img, pts=[seg], isClosed=True, color=(0, 0, 255), thickness=3)
    cv2.imshow('1', img)
    cv2.waitKey(0)
    # v = myVisualization(img[:, :, ::-1], metadata=MetadataCatalog.get(cfg.DATASETS.TRAIN[0]), scale=0.5)
    
    # out = v.draw_instance_predictions(outputs["instances"].to("cpu"))
    # plt.imshow(out.get_image()[:, :, ::-1])
    # plt.show()
    