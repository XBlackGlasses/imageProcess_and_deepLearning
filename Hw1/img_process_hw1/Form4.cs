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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        Bitmap tmpImg;
        Bitmap Img;
        public void SetImage(Bitmap img)
        {
            tmpImg = img;
            Img = new Bitmap(img);
            // 灰階化
            int avg = 0;
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color pxl = img.GetPixel(i, j);
                    avg = (pxl.R + pxl.G + pxl.B) / 3;
                    Img.SetPixel(i, j, Color.FromArgb(avg, avg, avg));
                }
            }
            pictureBox1.Image = Img;

            // 直方圖
            int[] values = new int[256];
            for (int i = 0; i < 256; i++)
                values[i] = 0;
            for(int i = 0; i < Img.Width; i++)
            {
                for(int j = 0; j < Img.Height; j++)
                {
                    avg = Img.GetPixel(i, j).R;
                    values[avg]++;
                }
            }
            // 繪製histogram
            for(int i = 0; i < 256; i++)
                chart1.Series[0].Points.Add(values[i]);
        }

      

        bool IsToForm1 = false;
        private void undo_Click(object sender, EventArgs e)
        {
            IsToForm1 = true;
            this.Close();   // 強制關閉form4
        }

        protected override void OnClosing(CancelEventArgs e)    // 在視窗關閉時觸發
        {
            base.OnClosing(e);
            if (IsToForm1)    // 判斷是否回Form1
            {
                this.DialogResult = DialogResult.Yes; // 利用DialogResult傳遞訊息
                
            }
            else
            {
                this.DialogResult = DialogResult.No;
            }
        }

        private void result_Click(object sender, EventArgs e)
        {
            // 直方圖
            int avg = 0;
            int[] values = new int[256];
            for (int i = 0; i < 256; i++)
                values[i] = 0;
            for (int i = 0; i < Img.Width; i++)
            {
                for (int j = 0; j < Img.Height; j++)
                {
                    avg = Img.GetPixel(i, j).R;
                    values[avg]++;
                }
            }

            float[] pdf = new float[256];
            float[] cdf = new float[256];
            for (int i = 0; i < 256; i++)
                pdf[i] = (float)values[i] / (float)(Img.Height * Img.Width);
            cdf[0] = pdf[0];
            for (int i = 1; i < 256; i++)
                cdf[i] = cdf[i - 1] + pdf[i];

            int[] eq_value = new int[256];
            for (int i = 0; i < 256; i++)
                eq_value[i] = (int)(255 * cdf[i]);

            int pix = 0, val = 0;
            int[] data = new int[256];
            for (int i = 0; i < 256; i++)
                data[i] = 0;
            Bitmap result = new Bitmap(Img);
            for (int i = 0; i < Img.Width; i++)
                for (int j = 0; j < Img.Height; j++)
                {
                    pix = Img.GetPixel(i, j).R;
                    val = eq_value[pix];
                    data[val]++;
                    result.SetPixel(i, j, Color.FromArgb(val, val, val));
                }
            // 繪製histogram
            for (int i = 0; i < 256; i++)
                chart2.Series[0].Points.Add(data[i]);
            pictureBox2.Image = result;
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
