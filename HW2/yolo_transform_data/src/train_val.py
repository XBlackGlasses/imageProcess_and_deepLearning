# split train data into train & validation
import json
import cv2
import os
import shutil

basePath = '../yoloData/train/'
# choose one ------------------
#valPath = '../yoloData/Train1/val/'
#trainPath = '../yoloData/Train1/train/'
# valPath = '../yoloData/Train2/val/'
# trainPath = '../yoloData/Train2/train/'
valPath = '../yoloData/Train3/val/'
trainPath = '../yoloData/Train3/train/'

# choose one -------------------
# trainTxt = '../yoloData/cfg/train1.txt'
# valTxt = '../yoloData/cfg/val1.txt'
# trainTxt = '../yoloData/cfg/train2.txt'
# valTxt = '../yoloData/cfg/val2.txt'
trainTxt = '../yoloData/cfg/train3.txt'
valTxt = '../yoloData/cfg/val3.txt'

if not os.path.exists(valPath):
    os.mkdir(valPath)
else:
    lsdir = os.listdir(valPath)
    for name in lsdir:
        if name.endswith('.txt') or name.endswith('.bmp'):
            os.remove(os.path.join(valPath, name))
    
if not os.path.exists(trainPath):
    os.mkdir(trainPath)
else:
    lsdir = os.listdir(trainPath)
    for name in lsdir:
        if name.endswith('.txt') or name.endswith('.bmp'):
            os.remove(os.path.join(trainPath, name))

baseDir = os.listdir(basePath)
num_file = len(baseDir) / 2
#print(num_file)
# choose one------------------------
#val_num = [i for i in range(int( num_file / 3))]
#val_num = [i for i in range(int(num_file / 3), int(2 * num_file / 3))]
val_num = [i for i in range(int(2 * num_file / 3), int(num_file))]
num = 0
for filename in baseDir:
    if(filename[-3:] == 'bmp'): #just need to check one type files
        ori_img = basePath + filename
        ori_txt = basePath + filename[:-3] + str('txt')
        
        if num in val_num:  # save in val dir
            # copy file to target path
            shutil.copyfile(ori_img, valPath + filename)
            shutil.copyfile(ori_txt, valPath + filename[:-3] + str('txt'))
            # record image path in txt
            with open(valTxt, 'a') as f:
                line_txt = [valPath + filename, '\n']
                f.writelines(line_txt)
        else:   # save in train dir
            shutil.copyfile(ori_img, trainPath + filename)
            shutil.copyfile(ori_txt, trainPath + filename[:-3] + str('txt'))
            # record image path in txt
            with open(trainTxt, 'a') as f:
                line_txt = [trainPath + filename, '\n']
                f.writelines(line_txt)
        num += 1
