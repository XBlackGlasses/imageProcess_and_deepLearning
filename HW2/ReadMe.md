# Environment

python 1.7.11

(pytorch 1.10 is recommended)

pytorch 1.9 

cuda 11.1

yolo v4

detectron2 0.6

opencv 4.5.5

```
conda env create -f environment.yaml
```

```
pip install -r requirements.txt
```



## Target

detect and classify the fracture of wrist from X-ray images.

step：

1. Detect scaphoid(舟狀體) from wrist X-ray image.

   ​		<img src="https://i.imgur.com/HBEnZGI.png" style="zoom: 67%;" />

2. Detect the location of fracture and classify whether scaphoid is fracture at the meanwhile

   ​			<img src="https://i.imgur.com/RrWhENe.png" style="zoom:50%;" />

   

## Data from website

directory structure：![](https://i.imgur.com/P6KhV3c.png)

* In Scaphoid_Slice directory, scaphoid’s bounding box ground truth contains left-top and bottom-right coordinate, and corresponding image name. The information is recored in .json file.

<img src="https://i.imgur.com/2p9NI1b.png" style="zoom: 80%;" />

* In Fracture_Coordinate directory, the bounding box of the scaphoid’s fracture location including center coordinate, width, height and angle. The information is recored in .csv file.

<img src="https://i.imgur.com/NRsmkpi.png" style="zoom:80%;" />



# Method

In the step 1, detect scaphoid.  I used Yolo_v4 to train the model.

​	I write a use method of yolov4 about this project at [this file](./yolov4.md)

​	it need more preprocessing, check the file to get more information.

In the step 2,  Detect the location of fracture and classify whether scaphoid is fracture. I used dtectron2 to train the model.

​	Refer to the following URL.

​		[【Detectron2】Rotated Faster RCNN 利用 Detectron2 訓練自己的數據集](https://dinghye.gitee.io/2020/11/10/detectron2guidance2/?fbclid=IwAR12PHedZaf_xGwWIJ0IeuYHrnY67_oqTB6CiOhXYwfWjIl4oqQZNGqHz98)

​		[【Detectron2】RotateDetectron2自己的數據訓練使用Faster-RCNN](https://dinghye.gitee.io/2020/10/30/detectron2guidance/?fbclid=IwAR290_rMGEmVByUprmacFT7xxF14U_H298noBpDCEp3DYxmxy-kbbuNFdcw)

​	just follow the websites. In detectron2, almostly need to modify the code of dataloader.



# Result

use 3 fold cross-validation to train data.

In Yolov4, the three result as below.

![IOU](https://github.com/XBlackGlasses/nckue_image_process/blob/main/HW2/img/IOU1.png)

![IOU](https://github.com/XBlackGlasses/nckue_image_process/blob/main/HW2//img/IOU2.png)

![IOU](https://github.com/XBlackGlasses/nckue_image_process/blob/main/HW2/img/IOU3.png)

avg IOU :  85.1033 %

average mAP at iou threshold50 = 99.2%



In detectron2, the three result as below

![image-20220109184313283](https://github.com/XBlackGlasses/nckue_image_process/blob/main/HW2/img/1.png)

![image-20220109184412992](https://github.com/XBlackGlasses/nckue_image_process/blob/main/HW2/img/2.png)

![image-20220109184655808](https://github.com/XBlackGlasses/nckue_image_process/blob/main/HW2/img/3.png)

average AP = 45.552%



In the ui, we can see the results.

![image-20220109190226801](https://github.com/XBlackGlasses/nckue_image_process/blob/main/HW2/img/ui.png)

# Discussion

In step 1, we can get much more precise results. The main reason I think may because the bboxs just are square. Moreover, it can  more easier to augment data. 

In step 2, it's difficult to train the model with rotated bbox. In the case of rotated bbox, detectron2 just can use resizing on data augmentation. I think may it need more data in training step to get better result.

# Conclusion

the most difficult part is to train model with rotated bbox. I had tried ODTK to training the result. Actually it had better result and had more methods on data augmentation, but it isn't friendly to use the model on other environments except their own docker's environment.  I think it need more data when train on detectron2 or the result won't be great.
