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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        Bitmap Img;
        int threshold = 120;
        public void SetImage(Bitmap img)
        {
            Img = new Bitmap(img);
            // 灰階化
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color pxl = img.GetPixel(i, j);
                    int avg = (pxl.R + pxl.G + pxl.B) / 3;
                    Img.SetPixel(i, j, Color.FromArgb(avg, avg, avg));
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
            this.Close();   // 強制關閉form5
        }

        private void button1_Click(object sender, EventArgs e)
        {
            threshold = 120;
            if (textBox1.Text != String.Empty)
            {
                try
                {
                    int num = Int32.Parse(textBox1.Text);
                    threshold = num;
                    MessageBox.Show("Set threshold to : " + num);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Didn't Work! You need input integer number");
                }
            }
            else
            {
                MessageBox.Show("Empty! threshold set to zero");
                threshold = 0;
            }
        }

        private void result_Click(object sender, EventArgs e)
        {
            Bitmap padimg = new Bitmap(Img.Width + 2, Img.Height + 2);
            int pix = 0;
            for (int i = 0; i < Img.Width + 2; i++)
                for (int j = 0; j < Img.Height + 2; j++)
                {
                    if (i == 0 || j == 0 || i == Img.Width + 1 || j == Img.Height + 1)
                        padimg.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                    else
                    {
                        pix = Img.GetPixel(i - 1, j - 1).R;
                        padimg.SetPixel(i, j, Color.FromArgb(pix, pix, pix));
                    }
                }

            Bitmap Cmbimg = new Bitmap(Img);
            Bitmap thresimg = new Bitmap(Img);
            Bitmap overlap = new Bitmap(Img);
            int px, py, mix;
            for (int i = 0; i < Img.Width; i++)
                for (int j = 0; j < Img.Height; j++)
                {
                    px = (padimg.GetPixel(i, j + 2).R + 2 * padimg.GetPixel(i + 1, j + 2).R + padimg.GetPixel(i + 2, j + 2).R)
                            - (padimg.GetPixel(i, j).R + 2 * padimg.GetPixel(i + 1, j).R + padimg.GetPixel(i + 2, j).R);
                    if (px < 0) px = 0 - px;
                    if (px > 255) px = 255;

                    py = (padimg.GetPixel(i + 2, j).R + 2 * padimg.GetPixel(i + 2, j + 1).R + padimg.GetPixel(i + 2, j + 2).R)
                            - (padimg.GetPixel(i, j).R + 2 * padimg.GetPixel(i, j + 1).R + padimg.GetPixel(i, j + 2).R);
                    if (py < 0) py = 0 - py;
                    if (py > 255) py = 255;

                    mix = (int)(0.5 * px + 0.5 * py);
                   
                    Cmbimg.SetPixel(i, j, Color.FromArgb(mix, mix, mix));
                    if (mix < threshold)
                        thresimg.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                    else
                    {
                        thresimg.SetPixel(i, j, Color.FromArgb(mix, mix, mix));
                        overlap.SetPixel(i, j, Color.FromArgb(Img.GetPixel(i,j).R, 255, Img.GetPixel(i, j).R));
                    }
                    
                }
            SobelBox.Image = Cmbimg;
            thresholdBox.Image = thresimg;
            overlapBox.Image = overlap;
        }
    }
}
