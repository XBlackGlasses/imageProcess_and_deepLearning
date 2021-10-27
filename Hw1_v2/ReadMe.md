# Report

* **environment**：Visual Studio 2015
* **language**：C#
* **version 2，加入可以重複undo的功能**



## Q1：RGB Extraction & Transformation

* #### 問題描述：

  Extract the R, G, B channel from the color image and transform it to gray scale image.

* #### method：

  提取圖片中的每個pixel   $P(i,j)$ 的RGB數值，可用 $image.GetPixel(int\ posx, int\ poy)$ function取得，分別存在不同圖片上就能完成，設定圖片pixel的function為 $Imgae.SetPixel(int\ posx, int\ posy, System.Draw.Color\ color)$。 為了讓Gray Level看起來較自然，利用公式 $0.299 \times R + 0.587 \times G + 0.114 \times B$  計算。

* #### result：

  ​	                                                                                ![image](https://user-images.githubusercontent.com/43801766/138693919-91b54be9-5945-47be-a627-36b1234d9b39.png)


* #### discussion：

  ​	這題很簡單，只要知道怎麼用C#拿到各個pixel的數值就好，然後dray level 可以用 $\frac{R+G+B}{3}$ 得到，可能用上面提到的公式，其實不會差很多。
  
* #### Conclusion：

  這題只要會知道C#的指令就好，如果想跟別人有一點點不一樣，大概就是gray level算法那邊可以裝清高一下。

## Q2：Smooth filter(mean and median)

* #### 問題描述：

  利用mean & median filter 過濾圖片

* #### method：

  從圖片$(0,0)$ 開始做 3 x 3 的filter。Mean filter只要在pixel$(i,j)$的周圍 3 x 3 區域內對每個像素做平均，輸出值為pixel$(i,j)$的新像素值，filter超過邊界則+0，達到zero padding的效果；median filter在pixel$(i,j)$的周圍 3 x 3 區域內選擇中間值作為$(i,j)$的新輸出，filter超過邊界也是當作0。

* #### result：

  ​											                     ![image](https://user-images.githubusercontent.com/43801766/138694009-379e4d4f-f7ea-467b-854e-3ccf07b82e86.png)


  可以從上面的result觀察到，Mean Filter只是對圖片做模糊，對於原圖那種Salt-and-Pepper Noise並沒有太好的效果，反倒是直接選中間值對於這種noise的smooth效果會好很多。

* #### conclusion：

  Mean filter主要是對圖片做模糊化，但對於這種類型的noise並沒有太好的效果。感覺還是要根據noise選擇filter效果比較好。

## Q3：Histogram Equalization(HE)

* #### 問題描述：

  對輸入圖片進行Histogram Equalization

* #### method：

  Histogram Equalization 是希望讓gray level分布能更均勻。大致流程如下

  1. 計算每個gray level出現的機率
      $$
      p\left(r_{k}\right)=n_{k} / n
      $$
      $n$為圖形中pixel的總數。
      
      $r_k$ is the $k$th gray level and $n_k$ is number of pixels in the image having gray level $r_k$.
      
  2. 計算機率累加函式$cdf$
      $$
      cdf[i] = cdf[i] + p[i-1]\\
      where\ cdf[0] = p[0]\ ,\ i=1\dots k
      $$

  3. 最後將$cdf$ normalize 到 0~255 ，就能將原本的gray level對應到新的gray level。

* #### result：

  ​												![image](https://user-images.githubusercontent.com/43801766/138694078-81efc5f6-f617-4757-b132-02b9a6a0871f.png)
  

* #### discussion：

  HE 可以將gray level的分布更加均勻，不過會有一些gray level沒有被分配到，因為灰階值的數值式整數，因此算出來的數值需要四捨五入。然後因為HE是對整張圖片做計算，原本圖片亮的部分會有過曝的情況，這是因為原圖整體偏暗，$cdf$累加後亮的地方會被推到gray level更高的地方。

* #### conclusion：

  HE雖然可以讓gray level分布更均勻，不過容易有多數暴力的問題，可以考慮用local HE或是CLAHE之類的方式改善。

## Q4：A user-defined threshold

* #### 問題描述：

  Given a threshold t. The intensity of a pixel which is higher than or equal to t will be set as white (255), otherwise set as black (0).

* #### method：

  使用者輸入任意整數的threshold，計算每個pixel的gray level，如果gray level 小於theshold則設為0，否則設為255。

* #### result：

  ​											![image](https://user-images.githubusercontent.com/43801766/138694120-fde973ae-3914-4c01-b488-738595f11221.png)


* #### discussion：

  這題很簡單，純粹是對圖片做二值化，感覺沒甚麼雷點。頂多就多寫幾個if判斷給的值有沒有在0~255，不過我覺得沒差，大於就當255算也不會出錯，小於0的拿來算也是OK，就全黑跟全白而已。

* #### conclusion：

  這個應該只要會if就會寫了，判斷大於小於的問題而已。



## Q5：Sobel edge detection

* #### 問題描述：

  利用Sobel  filter對圖片做邊緣偵測，分垂直、水平、兩者組合。

* #### method：

  Sobel operators分為垂直跟水平的 

  $G_x$ 水平：![image](https://user-images.githubusercontent.com/43801766/138694181-13002eab-2a5a-49f4-97d8-ecddb3d13b67.png)


  $G_y$ 垂直：![image](https://user-images.githubusercontent.com/43801766/138694222-542d13f5-5825-4efb-8ae7-22caf3167b46.png)


  整張圖片的edge detection只要將垂直跟水平處理後的結果相加就好，實作上我是都乘以0.5再相加。

  先對圖片周圍做1 pixel 的 zero padding，因此在做完Sobel Filter後圖片的大小不會變。實作上不用真的做一個 3x3 的matrix，直接套入Sobel裡的數值對對應的pixel做計算就好。

* #### result：

  ![image](https://user-images.githubusercontent.com/43801766/138694609-be209949-28c2-44c0-8b41-ff706c5dfcb7.png)


* #### discussion：

  原本有試過在產生combined時直接將vertical與horizontal的數值直接相加，不過感覺有點亮，感覺乘以0.5後相加視覺上比較舒服。

* #### conclusion：

  combined那邊可能就看個人喜好，應該也是能在兩個都重疊的地方再乘0.5，不過我覺得做出來沒有差很多，所以就都乘0.5了。

## Q6：Threshold the result of (5) to binary image and overlap on the original image

* #### 問題描述：

  將Sobel detect 後的結果經過2值化，將邊緣以綠色覆蓋上原圖

* #### method：

  透過Q5的方法，得到整張圖片邊緣，再以Q4的方法對得到的邊緣圖片做2值化，可以將一些模糊的地方去除掉，最後將2值化後還有數值的pixel在原圖上改為綠色。

* #### result：

  ![image](https://user-images.githubusercontent.com/43801766/138694648-db7823ad-e461-43d0-9c51-be0020aea69d.png)


* #### discussion：

  Sobel的部分跟Q6一樣，如果直接相加，再二值化後感覺不重要的線條還會被保留，看起來會很雜，所以偏好先乘0.5再相加。

* #### conclusion：

  這題就是拿前面兩題做結合，如果前面做得出來這題應該也沒困難。

## Q7：Connected Component

* #### 問題描述：

  找到圖片中相連的pixel，將他表示為同一個區塊，最後以不同顏色表示出來。這邊要檢查8個方向(8-adjacency)。

* #### method：

  以遞迴的方法實作，如果檢查過的點給予不同的label，因為圖片會先經過2值化，物體表示為黑色，背景為白色。所以只要是白色就label為0；當遇到黑色時，檢視是否已經有label，如果沒有，則給予他新的label並遞迴檢查他的8個方向，遞迴中遇到的pixel如果沒label且不是白的則給予相同label，否則就return。掃過整張圖片就完成了。

* #### result：

  ![image](https://user-images.githubusercontent.com/43801766/138694692-676192ad-1c00-48f6-be12-937c2a92737f.png)

* #### discussion：

  有同學試過用for loop寫，不過感覺要考慮很多條件很麻煩，如果4-adjacency感覺還OK，8-adjacency就太複雜了。

* #### conclusion：

  感覺這題目用recursive比較方便且不會出錯，我覺得比較麻煩的是有要求相鄰的components不能同顏色，在顏色付值那邊感覺比找components還麻煩。
  後來發現recursive實作的話，系統的stack會爆掉，所以後面就用for loop實作，主要透過 union、find group 的功能來完成pixel的分群。

## Q8：Image registration

* #### 問題描述：

  會給兩張image A、B， B是由A 轉換過來的，我們要修正B回到A。這邊的transform只有用到rotate & scale，沒有transition。

* #### method：

  因為只有rotate & scale，所以只要B對A的縮放量以及旋轉角度就能透過公式將B轉回A，主要的公式如下：

  ![image](https://user-images.githubusercontent.com/43801766/138694768-033611dc-26b6-40e9-a20e-45dd753f9e53.png)


  因為沒有平移，因此我們只需要用到 2x2 的矩陣計算就好。scale 由 (A的周長 / B的周長) 求得要縮放多少， 角度能有A與B中相應的某的邊的斜率m1 與 m2求得![image](https://user-images.githubusercontent.com/43801766/138694836-9a368f4f-c0fd-4ae3-beec-66062daa36b3.png)

  最後將B圖的pixel透過上面轉換矩陣轉回A圖上。

  不過這邊的transform是用A的pixel轉到B上對應的位置，這個discussion會討論到。

* #### result：

  ![image](https://user-images.githubusercontent.com/43801766/138694869-d8f81f23-b288-45ed-bf4b-c6a36ced7591.png)


* #### discussion：

  這題比較要注意的是transform的問題，如果計算source image($src$)轉到result image($res$)的Transform Matrix $T$，當用正轉換 $src$的pixel 到 $res$時，也就是說 $src\times T = res$， 因為產生的位置很多都是float，他是4捨5入到int找pixel的位置，這會讓有些pixel沒被對到，所以產生不少空白。

  因此這邊用逆轉換比較好，也就是$src = res \times T^{-1}$  ，看result image中的pixel $p(i,j)$ 會對應到source image的哪裡，這樣可以確保產生的圖片每一點都有值。如果對應到的位置是小數，可以用差值法計算$p(i,j)$的數值應該要是多少。在實作時有用雙線性差值實驗過，但是覺得圖片變得太模糊，因此直接用4捨5入的方法做。

  此外在旋轉時要找到圖片的中心再旋轉，因為圖片的原點在左上角，直接轉會跑出奇怪的結果。因此在算的時候要先將pixel位置減去圖片中心，讓旋轉中心固定在中心，transform結束後再加回來。

  因為兩張圖片的大小不同，所以圖片中位置不一樣，計算後的pixel位置還要修正到result image的中心。

* #### conclusion：

  因為少了transition所以計算上少了很多麻煩，只要知道角度跟縮放量就能計算出結果。discussion內的重點有注意到大概就能算出來了。差值法那邊用雙線性差值反而會變模糊，所以就簡單用around。小心圖片中心不一樣就好。 然後 題目的pdf p.11 Rotation 右邊的公式寫錯了，多找了1小時的bug ...XD 

