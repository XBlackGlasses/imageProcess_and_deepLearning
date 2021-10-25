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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        Bitmap Img;
        public void SetImage(Bitmap img)
        {
            Img = img;
            pictureBox5.Image = img;
        }

        bool IsToForm1 = false;
        private void undo_Click(object sender, EventArgs e)
        {
            IsToForm1 = true;
            this.Close();   // 強制關閉form2
        }

        private void result_Click(object sender, EventArgs e)
        {
            int[,] maR = new int[Img.Width, Img.Height];
            int[,] maG = new int[Img.Width, Img.Height];
            int[,] maB = new int[Img.Width, Img.Height];
            int[,] maGray = new int[Img.Width, Img.Height];

            for (int i = 0; i < Img.Width; i++)
            {
                for(int j  = 0; j < Img.Height; j++)
                {
                    Color pixelColor = Img.GetPixel(i, j);
                    maR[i, j] = pixelColor.R;
                    maG[i, j] = pixelColor.G;
                    maB[i, j] = pixelColor.B;
                    maGray[i,j] = (int)(0.299 * (double)pixelColor.R + 0.587 * (double)pixelColor.G + 0.114 * (double)pixelColor.B);
                }
            }

            Bitmap Rmap = new Bitmap(Img.Width, Img.Height);
            Bitmap Gmap = new Bitmap(Img.Width, Img.Height);
            Bitmap Bmap = new Bitmap(Img.Width, Img.Height);
            Bitmap GrayMap = new Bitmap(Img.Width, Img.Height);
            for (int i = 0; i < Img.Width; i++)
            {
                for(int j = 0; j < Img.Height; j++)
                {
                    Color pixelR = Color.FromArgb(maR[i, j], maR[i, j], maR[i, j]);
                    Color pixelG = Color.FromArgb(maG[i, j], maG[i, j], maG[i, j]);
                    Color pixelB = Color.FromArgb(maB[i, j], maB[i, j], maB[i, j]);
                    Color pixelGray = Color.FromArgb(maGray[i, j], maGray[i, j], maGray[i, j]);
                    Rmap.SetPixel(i, j, pixelR);
                    Gmap.SetPixel(i, j, pixelG);
                    Bmap.SetPixel(i, j, pixelB);
                    GrayMap.SetPixel(i, j, pixelGray);
                }
            }
            pictureBoxR.Image = Rmap;
            pictureBoxG.Image = Gmap;
            pictureBoxB.Image = Bmap;
            pictureBoxGray.Image = GrayMap;
        }

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

      
    }
}
