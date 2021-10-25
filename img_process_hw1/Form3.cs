using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace img_process_hw1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        Bitmap tmpImg;
        Bitmap Img;
        public void SetImage(Bitmap img)
        {
            tmpImg = img;
            SourceBox.Image = img;
            Img = new Bitmap(img);
            // 灰階化
            for(int i = 0; i < img.Width; i++)
            {
                for(int j = 0; j < img.Height; j++)
                {
                    Color pxl = img.GetPixel(i, j);
                    int avg = (pxl.R + pxl.G + pxl.B) / 3;
                    Img.SetPixel(i, j, Color.FromArgb(avg, avg, avg)); 
                }
            }
        }

        bool IsToForm1 = false;
        protected override void OnClosing(CancelEventArgs e)    // 在視窗關閉時觸發
        {
            base.OnClosing(e);
            if (IsToForm1)    // 判斷是否回Form1
            {
                this.DialogResult = DialogResult.Yes; // 利用DialogResult傳遞訊息
                //Form1 form1 = (Form1)this.Owner; // 取得父視窗的參考
            }
            else
            {
                this.DialogResult = DialogResult.No;
            }
        }

        private void undo_Click(object sender, EventArgs e)
        {
            IsToForm1 = true;
            this.Close();   // 強制關閉form2
        }

        private void result_Click(object sender, EventArgs e)
        {
            Bitmap meanMap = new Bitmap(Img.Width, Img.Height);
            Bitmap medianMap = new Bitmap(Img.Width, Img.Height);
            int sum = 0;
            for(int i = 0; i < Img.Width; i++)
            {
                for(int j = 0; j < Img.Height; j++)
                {
                    sum = 0;
                    for(int v = -1; v < 2; v++)
                    {
                        for(int u = -1; u < 2; u++)
                        {
                            if (i + u < 0 || j + v < 0 || i + u >= Img.Width || j + v >= Img.Height)
                                sum += 0;
                            else
                                sum += Img.GetPixel(i + u, j + v).R;
                        }
                    }
                    sum = sum / 9;
                    meanMap.SetPixel(i, j, Color.FromArgb(sum, sum, sum));
                }
            }
            MeanBox.Image = meanMap;

            int[] array = new int[10];
            int index = 0, median, tmp;
            for (int i = 0; i < Img.Width; i++)
            {
                for (int j = 0; j < Img.Height; j++)
                {
                    index = 0;
                    for (int v = -1; v < 2; v++)
                    {
                        for(int u = -1; u < 2; u++)
                        {
                            if (i + u < 0 || j + v < 0 || i + u >= Img.Width || j + v >= Img.Height)
                                array[index++] = 0;
                            else
                                array[index++] = Img.GetPixel(i + u, j + v).R;

                        }
                    }

                    for(int u = 0; u < 9; u++)
                    {
                        for(int v = u; v < 9; v++)
                        {
                            if(array[u] > array[v])
                            {
                                tmp = array[u];
                                array[u] = array[v];
                                array[v] = tmp;
                            }
                        }
                    }
                    median = array[4];
                    medianMap.SetPixel(i, j, Color.FromArgb(median, median, median));
                }
            }
            MedianBox.Image = medianMap;
        }
    }
}
