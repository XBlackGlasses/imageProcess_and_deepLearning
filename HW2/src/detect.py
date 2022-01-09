import os.path
import io
import numpy as np
import math
import json
import cv2
from torch import nn
import torch
from torch import device
from torch.utils.data.dataset import random_split
from torchvision import datasets, transforms, models
import torchvision
from detectron2.layers.rotated_boxes import pairwise_iou_rotated

a = torch.FloatTensor([15, 15, 30, 30, 0])
b = torch.FloatTensor([15, 15, 100, 30, 0])

x = pairwise_iou_rotated(a, b)
x = x.numpy()
print(x[0,0])
# json_file = './detect.json'
# with open(json_file, 'r') as f:
#     json_dict = json.load(f)
# annot = json_dict['annotations']
# imgs = json_dict['images']

# bboxs = []
# for i, img in enumerate(imgs):
#     if i == 11:
#         id = img['id']
#         max_score = 0
#         for anot in annot:
#             if anot['image_id'] == id:
#                 if max_score < anot['score']:
#                     max_score = anot['score']
#                     bboxs.append(anot['segmentation'])
#         img_file = './test/image/' + imgs[i]['file_name']
#         image = cv2.imread(img_file)
#         for bbox in bboxs:
#             points = bbox[0]
#             print(points)
#             points = np.array([ [points[0],points[1]], [points[2], points[3]], [points[4], points[5]],
#                             [points[6],points[7]] ]    , np.int32)
#             points.reshape((-1, 1, 2))
#             print(points)
#             cv2.polylines(image, pts=[points], isClosed=True, color=(0,0,255), thickness=2)
    
# cv2.imshow('1',image)
# cv2.waitKey(0)