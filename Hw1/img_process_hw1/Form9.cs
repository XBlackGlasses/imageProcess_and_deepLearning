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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        Bitmap Img, refImg;
        Point[] srcpoint = new Point[5];
        int sindex = 0, rindex = 0;
        Point[] refpoint = new Point[5];
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
            this.Close();   // 強制關閉form
        }


        private double getlen(Point A, Point B)
        {
            double ax = A.X;
            double ay = A.Y;
            double bx = B.X;
            double by = B.Y;
            return Math.Pow(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2), 0.5);
        }

        private void result_Click(object sender, EventArgs e)
        {
            if (refImg != null)
            {
                if (sindex == 4 && rindex == 4)
                { 
                    double srclen = 0, reflen = 0;
                    double srcT, refT;
                    // 求長度及斜率
                    srclen = getlen(srcpoint[0], srcpoint[1]);
                    srclen += getlen(srcpoint[1], srcpoint[2]);
                    srclen += getlen(srcpoint[2], srcpoint[3]);
                    srclen += getlen(srcpoint[3], srcpoint[0]);
                    srclen /= 4;
                    double dx = srcpoint[0].X - srcpoint[1].X;
                    double dy = srcpoint[0].Y - srcpoint[1].Y;
                    if (dx < 2)
                        srcT = 1e9;
                    else
                        srcT = dy / dx;

                    reflen = getlen(refpoint[0], refpoint[1]);
                    reflen += getlen(refpoint[1], refpoint[2]);
                    reflen += getlen(refpoint[2], refpoint[3]);
                    reflen += getlen(refpoint[3], refpoint[0]);
                    reflen /= 4;
                    dx = refpoint[0].X - refpoint[1].X;
                    dy = refpoint[0].Y - refpoint[1].Y;
                    if (dx < 2)
                        refT = 1e9;
                    else
                        refT = dy / dx;
                    // 求scale & rotation
                    double scale = srclen / reflen;
                    //scale = 1.35;
                    double angle;
                    if (refT * srcT == -1)
                        angle = 90;
                    else
                        angle = Math.Atan((refT - srcT) / (1 + srcT * refT)) * 180 / Math.PI;

                    //angle = 30;
                    double degree = -(int)Math.Round(angle, 1) * Math.PI / 180;

                    Bitmap result = new Bitmap(Img.Width , Img.Height);

                    double centerX = (double)refImg.Width / 2;
                    double centerY = (double)refImg.Height / 2;

                    double cX = (double)Img.Width / 2;
                    double cY = (double)Img.Height / 2;

                    //double floorx, ceilx, floory, ceily;
                    for (int i = 0; i < Img.Width; i++)
                        for (int j = 0; j < Img.Height; j++)
                        {
                            double x = (double)i;// - centerX;
                            double y = (double)j;// - centerY;

                            double A = 1 / scale * Math.Cos(degree);
                            double B = 1 / scale * Math.Sin(degree);


                            double x1 = x * A + y * B + (-cX * A - cY * B + cX);
                            double y1 = -x * B + y * A + (cX * B - cY * A + cY);


                            double disX = centerX - cX;
                            double disY = centerY - cY;
                            x1 += disX;
                            y1 += disY;


                            if (x1 < 0 || y1 < 0 || x1 >= refImg.Width || y1 >= refImg.Height)
                                continue;
                            else
                            {
                                //floorx = Math.Floor(x1);    // 小於
                                //floory = Math.Floor(y1);
                                //ceilx = Math.Ceiling(x1);   // 大於
                                //ceily = Math.Ceiling(y1);
                                //if (floory >= refImg.Height)
                                //    floory = (double)refImg.Height - 1;
                                //if (floorx >= refImg.Width)
                                //    floorx = (double)refImg.Width - 1;

                                //int ulpix = refImg.GetPixel((int)floorx, (int)floory).G;
                                //int dlpix = refImg.GetPixel((int)floorx, (int)ceily).G;
                                //int urpix = refImg.GetPixel((int)ceilx, (int)floory).G;
                                //int drpix = refImg.GetPixel((int)ceilx, (int)ceily).G;
                                int px = (int)Math.Round(x1, 1);
                                int py = (int)Math.Round(y1, 1);
                                if (px >= refImg.Width)
                                    px = refImg.Width - 1;
                                if (py >= refImg.Height)
                                    py = refImg.Height - 1;
                                //if (floorx != x1 && floory != y1)
                                //{
                                //    double u = x1 - floorx;
                                //    double v = y1 - floory;
                                //    pix = (int)((1 - v) * (1 - u) * (double)ulpix + (1 - v) * u * (double)dlpix + v * (1 - u) * (double)urpix + u * v * (double)drpix);
                                //}

                                int pix = refImg.GetPixel(px, py).G;

                                result.SetPixel(i, j, Color.FromArgb(pix, pix, pix));
                            }
                        }
                    resultBox.Image = result;
                    int sum = 0;
                    for(int i = 0; i < Img.Width; i++)
                        for(int j = 0; j < Img.Height; j++)
                        {
                            int srcpix = Img.GetPixel(i, j).R;
                            int respix = result.GetPixel(i, j).R;
                            sum += Math.Abs(respix - srcpix);
                        }
                    double Dpix = (double)sum / (Img.Width * Img.Height);

                    MessageBox.Show("scale = " + (1 / scale) + "\n" + "angle = " + (int)(-angle)
                        + "\n" + "Dpixel = " + Dpix);

                }
                else
                    MessageBox.Show("you need to choose 4 points in both images !");
            }
            else
                MessageBox.Show("you need to input reference image first !");
        }

        private void sourceBox_MouseMove(object sender, MouseEventArgs e)
        {
            slabelx.Text = "x : " + e.Location.X;
            slabely.Text = "y : " + e.Location.Y;
        }

        private void refBox_MouseMove(object sender, MouseEventArgs e)
        {
            rlabelx.Text = "x : " + e.Location.X;
            rlabely.Text = "y : " + e.Location.Y;
        }

        private void refBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (refImg != null)
            {
                if (rindex >= 4)
                    MessageBox.Show("you just can choose 4 points");
                else
                {
                    if (rindex == 0)
                        rP1.Text = "P1: x = " + e.Location.X + ", y = " + e.Location.Y;
                    else if (rindex == 1)
                        rP2.Text = "P2: x = " + e.Location.X + ", y = " + e.Location.Y;
                    else if (rindex == 2)
                        rP3.Text = "P3: x = " + e.Location.X + ", y = " + e.Location.Y;
                    else
                        rP4.Text = "P4: x = " + e.Location.X + ", y = " + e.Location.Y;
                    refpoint[rindex++] = e.Location;
                }
            }
            else
                MessageBox.Show("Input image first");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sindex = 0;
            rindex = 0;
            for(int i = 0; i < 3; i++)
            {
                srcpoint[i].X = srcpoint[i].Y = 0;
                refpoint[i].X = refpoint[i].Y = 0;
            }
            sP1.Text = "P1 :";
            sP2.Text = "P2 :";
            sP3.Text = "P3 :";
            sP4.Text = "P4 :";
            rP1.Text = "P1 :";
            rP2.Text = "P2 :";
            rP3.Text = "P3 :";
            rP4.Text = "P4 :";
            resultBox.Image = null;
           
        }

        private void sourceBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (Img != null)
            {
                if (sindex >= 4)
                    MessageBox.Show("you just can choose 4 points");
                else
                {
                    if (sindex == 0)
                        sP1.Text = "P1: x = " + e.Location.X + ", y = " + e.Location.Y;
                    else if(sindex == 1)
                        sP2.Text = "P2: x = " + e.Location.X + ", y = " + e.Location.Y;
                    else if(sindex == 2)
                        sP3.Text = "P3: x = " + e.Location.X + ", y = " + e.Location.Y;
                    else
                        sP4.Text = "P4: x = " + e.Location.X + ", y = " + e.Location.Y;
                    srcpoint[sindex++] = e.Location;
                }
            }
            else
                MessageBox.Show("Input image first");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All Files|*.*|Bitmap Files (.bmp)|*.bmp|Jpeg File(.jpg)|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                refImg = new Bitmap(openFileDialog1.FileName);
                refBox.Image = refImg;
            }
        }
    }
}
