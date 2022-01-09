# create images that cutted by bbox
import json
import cv2
import os
import shutil

jsonPath = '../Scaphoid/Annotations/Scaphoid_Slice/'
ImgPath = '../Scaphoid/Images/'
savePath = '../classify_img/'

img_dir = os.listdir(ImgPath)
print(img_dir)
i = 0

for dir in img_dir:
    Files = os.listdir(ImgPath + dir)
    for file in Files:
        json_file = jsonPath + file[:-3] + "json"
        #print(file[:-3])
        with open(json_file, 'r') as load_f:
            load_json = json.load(load_f)
        bbox = load_json[0]['bbox']      # save left-up and right-button two coordinate
        x1 = int(bbox[0])
        y1 = int(bbox[1])
        x2 = int(bbox[2])
        y2 = int(bbox[3])
        w = (x2 - x1)
        h = (y2 - y1) 
        
        img = cv2.imread(ImgPath + dir + '/' + file)
        cut_img = img[y1 : y1 + h, x1 : x1 + w]
        cv2.imwrite(savePath + dir + '/' + file , cut_img)
            # print(ImgPath + dir + '/' + file)
        i += 1
    print(i)
    i = 0