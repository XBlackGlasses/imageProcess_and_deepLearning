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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        Bitmap Img;
        public void SetImage(Bitmap img)
        {
            Img = new Bitmap(img);
            // 2值化
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color pxl = img.GetPixel(i, j);
                    int avg = (pxl.R + pxl.G + pxl.B) / 3;
                    if(avg < 120)
                        Img.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                    else
                        Img.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                }
            }
            sourceBox.Image = Img;
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
            this.Close();   // 強制關閉form
        }

        int[,] label; 
        private void result_Click(object sender, EventArgs e)
        {
            int width = Img.Width;
            int height = Img.Height;
            label = new int[width, height];
            int labelcnt = 1, pix;
            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                    label[i, j] = 0;


            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                {
                    pix = Img.GetPixel(i, j).R; ;
                    if (pix != 255 && label[i, j] == 0)
                    {
                        recursive(i, j, labelcnt);
                        labelcnt++;
                    }
                }

            labelcnt = labelcnt - 1;

            Bitmap Nimg = new Bitmap(Img);
            int r, g, b;
            for(int i = 0; i < width; i++)
                for(int j = 0; j < height; j++)
                {
                    if (label[i, j] != 0)
                    {

                        if (label[i, j] < 20)
                        {
                            r = label[i, j] * 8;
                            g = label[i, j] * 11;
                            b = label[i, j] * 6;
                        }
                        else
                        {
                            r = label[i, j] * 5;
                            g = label[i, j] * 2;
                            b = label[i, j] * 3;
                        }

                        if (g < 40)
                            g = 100;
                        if (r < 20)
                            r = 40;
                        if (b < 10)
                            b = 80;
                        if (label[i, j] % 3 == 0)
                            b = 0;
                        else if (label[i, j] % 3 == 1)
                            g = 0;
                        else
                            r = 0;
                        if (r > 255)
                            r = 255;
                        if (g > 255)
                            g = 255;
                        if (b > 255)
                            b = 255;
                        Nimg.SetPixel(i, j, Color.FromArgb(r, g, b));
                        //System.Console.WriteLine(label[i, j]);
                    }
                    else
                        Nimg.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                }
            pictureBox.Image = Nimg;
            MessageBox.Show("number of label = " + labelcnt);
        }

        private void recursive(int i, int j, int labelcnt)
        {
            if (i < 0 || j < 0 || i >= Img.Width || j >= Img.Height)
                return;
            int pix = Img.GetPixel(i, j).R;
            if (pix != 255 && label[i, j] == 0)
            {
                label[i, j] = labelcnt;
                recursive(i - 1, j - 1, labelcnt);
                recursive(i, j - 1, labelcnt);
                recursive(i + 1, j - 1, labelcnt);
                recursive(i - 1, j, labelcnt);
                recursive(i + 1, j, labelcnt);
                recursive(i - 1, j + 1, labelcnt);
                recursive(i, j + 1, labelcnt);
                recursive(i + 1, j + 1, labelcnt);
            }
            else
                return;
        }
    }
}
