# transform json to yolo txt data, and split data into train & test
import json
import cv2
import os
import shutil

classes = {'Scaphoid' : 0}     # only one class
jsonPath = '../Scaphoid/Annotations/Scaphoid_Slice/'
ImgPath = '../yoloData/images/'
trainPath = '../yoloData/train/'
train_cfg = '../yoloData/cfg/train.txt'
testPath = '../yoloData/test/'
test_cfg = '../yoloData/cfg/test.txt'

# Delete origin files in directory
if not os.path.exists(trainPath):
    os.mkdir(trainPath)
else:
    lsdir = os.listdir(trainPath)
    for name in lsdir:
        if name.endswith('.txt') or name.endswith('.bmp'):
            os.remove(os.path.join(trainPath, name))

if not os.path.exists(testPath):
    os.mkdir(testPath)
else:
    lsdir = os.listdir(testPath)
    for name in lsdir:
        if name.endswith('.txt') or name.endswith('.bmp'):
            os.remove(os.path.join(testPath, name))


json_file = os.listdir(jsonPath)
num_files = len(json_file)
test_num = num_files / 10

for filename in json_file:
    eachFile = jsonPath + filename
    with open(eachFile, 'r') as load_f:
        # open json
        load_dict = json.load(load_f)
                        # move out 'json'
    img_path = ImgPath + filename[:-4] + str('bmp')
    #print(img_path)
    img = cv2.imread(img_path)
    size = img.shape
    # size for normalize the yolo data
    img_h, img_w = size[0], size[1]
    label = classes[load_dict[0]['name']]   # all 0
    
    info = []
    for num in load_dict[0]['bbox']:
        info.append(int(num))
    x1 = info[0]
    y1 = info[1]
    x2 = info[2]
    y2 = info[3]
    x_center = (x1 + x2) / 2 / img_w
    y_center = (y1 + y2) / 2 / img_h
    w = (x2 - x1) / img_w
    h = (y2 - y1) / img_h
    
    if test_num > 0: # validation
        # copy image to target path
        shutil.copyfile(img_path, testPath + filename[:-4] + str('bmp'))
        # record image path in txt
        with open(test_cfg, 'a') as f:
            line_txt = [testPath + filename[:-4] + str('bmp'), '\n']
            f.writelines(line_txt)
    
         # save yolo txt format 
        with open(testPath + filename[:-4] + 'txt', 'a+') as f:
            f.write('%s %s %s %s %s\n' % (label, x_center, y_center, w, h))
        test_num = test_num - 1
    else:   # training
        # copy image to target path
        shutil.copyfile(img_path, trainPath + filename[:-4] + str('bmp'))
        # record image path in txt
        with open(train_cfg, 'a') as f:
            line_txt = [trainPath + filename[:-4] + str('bmp'), '\n']
            f.writelines(line_txt)
        
        # save yolo txt format 
        with open(trainPath + filename[:-4] + 'txt', 'a+') as f:
            f.write('%s %s %s %s %s\n' % (label, x_center, y_center, w, h))

print('Finish')