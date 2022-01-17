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

## Preprocessing

yolov4：

​	將Scaphoid_Slice directory 裡的json檔轉成yolo txt的格式，把Fracture、Normal 裡的圖片放到images資料夾下，cfg資料夾用來放生成的train.txt(會有train set 路徑)

​	<img src="https://i.imgur.com/ZQh1hyr.png" style="zoom:80%;" /> 大概是這樣。     train.txt 放圖片路徑(相對於darknet.exe)![](https://i.imgur.com/StnFYIt.png)



## Yolov4 訓練 in win10

#### Before Training

* 下載 darknet githu

```
git clone https://github.com/AlexeyAB/darknet
```

* 進入darknet-master/build/darknet中

  選擇darknet.vcxproj，將裡面預設的cuda設為目前自己環境的cuda(這邊設為11.3，原本預設是11.1)

  <img src="https://i.imgur.com/UjT9wR9.png" style="zoom: 67%;" />

* 選擇darknet.sln準備build darknet.exe

  1. 將環境設為x64，點開darknet的屬性，在vc++裡，選擇**include目錄** 將**opencv/include**的路徑加入，如果編譯時找不到cuda，可以考慮加入cuda，或是(4.)的方法。

     ![](https://i.imgur.com/Xe7b4Wu.png)

  2. 同樣在vc++中，選擇程式庫目錄加入opencv的lib路徑， visual studio2019選擇cv15

     ​	<img src="https://i.imgur.com/j7fXNWD.png" style="zoom:67%;" />

  3. 在**輸入**的**其他相依性** 加入opencv lib

     ​	<img src="https://i.imgur.com/vXU1Tkp.png" style="zoom: 80%;" />

  4.  visual studio2019如果找不到，將**Program Files\NVIDIA GPU Computing Toolkit\CUDA\v11.3\extras\visual_studio_integration\MSBuildExtensions** 內的4個檔案

     ​	<img src="https://i.imgur.com/NwVZUxg.png" style="zoom: 67%;" />

     複製到**Program Files (x86)\Microsoft Visual Studio\2019\Community\MSBuild\Microsoft\VC\v160\BuildCustomizations** 裡。

  5. 之後就可以建立專案了。在**darknet-master\build\darknet\x64** 裡面可以找到 *darknet.exe* .

  6. 把 openCV\build\x64\vc15\lib 複製opencv_worldXXX.lib(debug版複製opencv_worldXXXd.lib) 到 *darknet.exe* 同目錄下

  7. openCV\build\x64\vc15\bin\ 複製opencv_worldXXX.dll(debug版複製opencv_worldXXXd.dll) 到 *darknet.exe* 同目錄下

  8. Finish. 下載[yolov4.weights](https://github.com/AlexeyAB/darknet/releases/download/darknet_yolo_v3_optimal/yolov4.weights)測試， 可以在darknet\x64 裡建立weights資料夾並將下載的weights放入。

  9. 執行``darknet.exe detect .\cfg\yolov4.cfg .\weights\yolov4.weights .\data\dog.jpg `` 測試。

#### yolov4-custom.cfg修改

在**darknet-master\build\darknet\x64\cfg**裡面找到*yolov4-custom.cfg*，複製到自己資料集的cfg資料夾裡，並做修改。

1. **filters**

   在檔案裡面修改filter參數 filters=(classes + 5)*3 。 這個project是設為6(只有一個class)，修改的位置在每個[yolo]層的前一個filters。

   <img src="https://i.imgur.com/kGyL2uy.png" style="zoom:67%;" />

   以這個例子，[yolo]在 line1145， 因此修改前一個filter(line1141)就好， line1134的filter不用修改

2. **classes**

   修改檔案裡所有的classes為自己資料集需要的數量

3. **anchors**

   可改可不改，用下面的指令計算自己data set的anchors，複製到.cfg檔裡面。 資料位置依照自己的資料夾設定

   ```
   darknet.exe detector calc_anchors ..\yoloData\cfg\sket.data -num_of_clusters 9 -width 416 -height 416
   ```
   
   ![](https://i.imgur.com/HZFStjb.png)
   
4. 將max_batch更改為(資料集標籤種類數（classes）*2000 但不小於訓練的圖片數量以及不小於6000)

   將第20的steps改為max_batch的0.8倍和0.9倍
   
5. 如果顯卡記憶體不足，可以把寬高調小，subdivision調高



#### obj.date、obj.names修改

在**darknet-master\build\darknet\x64\data** 裡隨意找一組 .data & .names 檔案複製到自己的資料集裡的cfg中做修改，

檔名改成自己需要的。這邊改成 **sket.data** 、**sket.names**

1. sket.names裡面放的是各個訓練資料的classes名稱。這個project只有一個需要辨識的物件

   ​			<img src="https://i.imgur.com/wJahhJf.png" style="zoom:80%;" />

2. sket.data 裡面放的是 classses 數量、訓練集路徑、valid路徑、sket.names的路徑、backup路徑(weights存放路徑)

   ​		<img src="https://i.imgur.com/k9SPQUj.png" style="zoom:80%;" />	

   

#### Training our data

##### 資料夾配置

darknet.exe 在 **darknet-master/build/darknet/x64** 裡面。

這裡將自己前處理後的dataset(yoloData)放在x64資料夾外面，

在yoloData的cfg裡，加入處理後的yolov4-custom.cfg、下載yolov4-custom.cfg的pre-trained weights [yolov4.conv.137](https://github.com/AlexeyAB/darknet/releases/download/darknet_yolo_v3_optimal/yolov4.conv.137) 、處理後的sket.data、sket.names.

* x64
  * darknet.exe
  * ... ... ...
* yoloData
  * cfg
    * weights(資料夾)
    * sket.data
    * sket.names
    * train.txt
    * val.txt
    * yolov4-custom.cfg
    * yolov4.conv.137
  * train
    * *.bmp
    * *.txt
  * val
    * *.bmp
    * *.txt
* other files

##### Training model

在 **darknet-master/build/darknet/x64** 中執行 (yolov4.conv.137 可加可不加)

```
darknet.exe detector train ../yoloData/cfg/sket.data ../yoloData/cfg/yolov4-custom.cfg ../yoloData/cfg/yolov4.conv.137 
```

##### 計算mAP

```
darknet.exe detector map ../yoloData/cfg/sket.data ../yoloData/cfg/yolov4-custom.cfg ../yoloData/cfg/weights/yolov4-obj_final.weights
```

##### 計算recall

```
darknet.exe detector recall ../yoloData/cfg/sket.data ../yoloData/cfg/yolov4-custom.cfg ../yoloData/cfg/weights/yolov4-obj_final.weights
```

##### 測試模型

修改sket.data裡的資料路徑為 test 資料集路徑

```
darknet.exe detector map ../yoloData/cfg/sket.data ../yoloData/cfg/yolov4-custom.cfg ../yoloData/cfg/weights/yolov4-obj_final.weights
```

<img src="https://i.imgur.com/V2oTKGK.png" style="zoom:80%;" />
