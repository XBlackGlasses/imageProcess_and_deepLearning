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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Stack<Bitmap> Img_List = new Stack<Bitmap>();

        private void Load_Click(object sender, EventArgs e)
        {
            if (chart1.Series != null)
                chart1.Series[0].Points.Clear();
            if (chart2.Series != null)
                chart2.Series[0].Points.Clear();
            if (process_pictureBox.Image != null)
                process_pictureBox.Image = null;

            Img_List.Clear();

            openFileDialog1.Filter = "All Files|*.*|Bitmap Files (.bmp)|*.bmp|Jpeg File(.jpg)|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap openImg = new Bitmap(openFileDialog1.FileName);
                source_pictureBox.Image = openImg;
                Img_List.Push(openImg);
            }
        }
        private void R_Click(object sender, EventArgs e)
        {
            if (source_pictureBox.Image == null)
                MessageBox.Show("You need input image");
            else
            {

                Bitmap img = new Bitmap(Img_List.Peek());
                int i, j;
                Color pix;
                for(i = 0; i < img.Width; ++i)
                    for(j = 0; j < img.Height; ++j)
                    {
                        pix = img.GetPixel(i, j);
                        img.SetPixel(i, j, Color.FromArgb(pix.R, pix.R, pix.R));
                    }
                process_pictureBox.Image = img;
                Img_List.Push(img);
            }
        }

        private void G_Click(object sender, EventArgs e)
        {
            if (source_pictureBox.Image == null)
                MessageBox.Show("You need input image");
            else
            {

                Bitmap img = new Bitmap(Img_List.Peek());
                int i, j;
                Color pix;
                for (i = 0; i < img.Width; ++i)
                    for (j = 0; j < img.Height; ++j)
                    {
                        pix = img.GetPixel(i, j);
                        img.SetPixel(i, j, Color.FromArgb(pix.G, pix.G, pix.G));
                    }
                process_pictureBox.Image = img;
                Img_List.Push(img);
            }
        }

        private void B_Click(object sender, EventArgs e)
        {
            if (source_pictureBox.Image == null)
                MessageBox.Show("You need input image");
            else
            {
                Bitmap img = new Bitmap(Img_List.Peek());
                int i, j;
                Color pix;
                for (i = 0; i < img.Width; ++i)
                    for (j = 0; j < img.Height; ++j)
                    {
                        pix = img.GetPixel(i, j);
                        img.SetPixel(i, j, Color.FromArgb(pix.B, pix.B, pix.B));
                    }
                process_pictureBox.Image = img;
                Img_List.Push(img);
            }
        }

        private void gray_Click(object sender, EventArgs e)
        {
            if (source_pictureBox.Image == null)
                MessageBox.Show("You need input image");
            else
            {

                Bitmap img = new Bitmap(Img_List.Peek());
                int i, j, gray;
                Color pix;
                for (i = 0; i < img.Width; ++i)
                    for (j = 0; j < img.Height; ++j)
                    {
                        pix = img.GetPixel(i, j);
                        gray = (int)(0.299 * (double)pix.R + 0.587 * (double)pix.G + 0.114 * (double)pix.B);
                        img.SetPixel(i, j, Color.FromArgb(pix.R, pix.R, pix.R));
                    }
                process_pictureBox.Image = img;
                Img_List.Push(img);
            }
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            if (chart1.Series != null)
                chart1.Series[0].Points.Clear();
            if (chart2.Series != null)
                chart2.Series[0].Points.Clear();

            if (Img_List.Count == 1)
                MessageBox.Show("It's the last undo");
            else
            {
                Img_List.Pop();
                Bitmap img = new Bitmap(Img_List.Peek());
                process_pictureBox.Image = img;
                
            }
        }

        private void mean_filter_Click(object sender, EventArgs e)
        {
            if (source_pictureBox.Image == null)
                MessageBox.Show("You need input image");
            else
            {
                Bitmap img = new Bitmap(Img_List.Peek());
                Bitmap meanMap = new Bitmap(img.Width, img.Height);
                int i, j;
                
                int sum = 0;
                for (i = 0; i < img.Width; ++i)
                {
                    for (j = 0; j < img.Height; ++j)
                    {
                        sum = 0;
                        for (int v = -1; v < 2; ++v)
                        {
                            for (int u = -1; u < 2; ++u)
                            {
                                if (i + u < 0 || j + v < 0 || i + u >= img.Width || j + v >= img.Height)
                                    sum += 0;
                                else
                                    sum += img.GetPixel(i + u, j + v).R;
                            }
                        }
                        sum = sum / 9;
                        meanMap.SetPixel(i, j, Color.FromArgb(sum, sum, sum));
                    }
                }

                process_pictureBox.Image = meanMap;
                Img_List.Push(meanMap);
            }
        }

        private void median_filter_Click(object sender, EventArgs e)
        {
            if (source_pictureBox.Image == null)
                MessageBox.Show("You need input image");
            else
            {
                Bitmap img = new Bitmap(Img_List.Peek());
                Bitmap medianMap = new Bitmap(img.Width, img.Height);
                int i, j;
                List<int> list = new List<int>();
                int median;
                for (i = 0; i < img.Width; ++i)
                {
                    for (j = 0; j < img.Height; ++j)
                    {
                        for (int v = -1; v < 2; ++v)
                        {
                            for (int u = -1; u < 2; ++u)
                            {
                                if (i + u < 0 || j + v < 0 || i + u >= img.Width || j + v >= img.Height)
                                    list.Add(0);
                                //sum += 0;
                                else
                                    list.Add(img.GetPixel(i + u, j + v).R);
                                //sum += img.GetPixel(i + u, j + v).R;
                                list.Sort();
                            }
                        }
                        median = list[4];
                        medianMap.SetPixel(i, j, Color.FromArgb(median, median, median));
                        list.Clear();
                    }
                }

                process_pictureBox.Image = medianMap;
                Img_List.Push(medianMap);
            }
        }

        private void Hist_Eq_Click(object sender, EventArgs e)
        {
            if (source_pictureBox.Image == null)
                MessageBox.Show("You need input image");
            else
            {
                Bitmap img = new Bitmap(Img_List.Peek());

                // 直方圖
                int pix;
                int[] values = new int[256];
                for (int i = 0; i < 256; i++)
                    values[i] = 0;
                for (int i = 0; i < img.Width; i++)
                {
                    for (int j = 0; j < img.Height; j++)
                    {
                        pix = img.GetPixel(i, j).R;
                        values[pix]++;
                    }
                }
                // 繪製histogram
                if (chart1.Series != null)
                    chart1.Series[0].Points.Clear();
                for (int i = 0; i < 256; i++)
                    chart1.Series[0].Points.Add(values[i]);


                // result
                for (int i = 0; i < 256; i++)
                    values[i] = 0;
                for (int i = 0; i < img.Width; i++)
                {
                    for (int j = 0; j < img.Height; j++)
                    {
                        pix = img.GetPixel(i, j).R;
                        values[pix]++;
                    }
                }

                Bitmap result = new Bitmap(img);
                float[] pdf = new float[256];
                float[] cdf = new float[256];
                for (int i = 0; i < 256; i++)
                    pdf[i] = (float)values[i] / (float)(img.Height * img.Width);
                cdf[0] = pdf[0];
                for (int i = 1; i < 256; i++)
                    cdf[i] = cdf[i - 1] + pdf[i];

                int[] eq_value = new int[256];
                for (int i = 0; i < 256; i++)
                    eq_value[i] = (int)(255 * cdf[i]);

                int val = 0;
                int[] data = new int[256];
                for (int i = 0; i < 256; i++)
                    data[i] = 0;

                for (int i = 0; i < img.Width; i++)
                    for (int j = 0; j < img.Height; j++)
                    {
                        pix = img.GetPixel(i, j).R;
                        val = eq_value[pix];
                        data[val]++;
                        result.SetPixel(i, j, Color.FromArgb(val, val, val));
                    }

                process_pictureBox.Image = result;
                Img_List.Push(result);
                // 繪製histogram
                if (chart2.Series != null)
                    chart2.Series[0].Points.Clear();
                for (int i = 0; i < 256; i++)
                    chart2.Series[0].Points.Add(data[i]);

            }
        }

        private void threshold_Click(object sender, EventArgs e)
        {
            // check threshold
            int threshold;
            if (thresh_text.Text != String.Empty)
            {
                try
                {
                    int num = Int32.Parse(thresh_text.Text);
                    threshold = num;
                    //MessageBox.Show("Set threshold to : " + num);
                    if (source_pictureBox.Image == null)
                        MessageBox.Show("You need input image");
                    else
                    {
                        Bitmap img = new Bitmap(Img_List.Peek());
                        int value;
                        for (int i = 0; i < img.Width; i++)
                            for (int j = 0; j < img.Height; j++)
                            {
                                value = img.GetPixel(i, j).R;
                                if (value < threshold)
                                    img.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                                else
                                    img.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                            }
                        process_pictureBox.Image = img;
                        Img_List.Push(img);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Didn't Work! You need input integer number");
                }
            }
            else
            {
                MessageBox.Show("Can't be Empty!");
            }
        }

        private void Vertical_Click(object sender, EventArgs e)
        {
            if (source_pictureBox.Image == null)
                MessageBox.Show("You need input image");
            else
            {
                Bitmap img = new Bitmap(Img_List.Peek());

                Bitmap padimg = new Bitmap(img.Width + 2, img.Height + 2);
                int pix = 0;
                for (int i = 0; i < img.Width + 2; i++)
                    for (int j = 0; j < img.Height + 2; j++)
                    {
                        if (i == 0 || j == 0 || i == img.Width + 1 || j == img.Height + 1)
                            padimg.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                        else
                        {
                            pix = img.GetPixel(i - 1, j - 1).R;
                            padimg.SetPixel(i, j, Color.FromArgb(pix, pix, pix));
                        }
                    }

                Bitmap Vimg = new Bitmap(img);

                for (int i = 0; i < img.Width; i++)
                    for (int j = 0; j < img.Height; j++)
                    {
                        pix = (padimg.GetPixel(i + 2, j).R + 2 * padimg.GetPixel(i + 2, j + 1).R + padimg.GetPixel(i + 2, j + 2).R)
                                - (padimg.GetPixel(i, j).R + 2 * padimg.GetPixel(i, j + 1).R + padimg.GetPixel(i, j + 2).R);
                        if (pix < 0) pix = 0 - pix;
                        if (pix > 255) pix = 255;
                        Vimg.SetPixel(i, j, Color.FromArgb(pix, pix, pix));
                    }
                process_pictureBox.Image = Vimg;
                Img_List.Push(Vimg);
            }
        }

        private void Horizon_Click(object sender, EventArgs e)
        {
            if (source_pictureBox.Image == null)
                MessageBox.Show("You need input image");
            else
            {
                Bitmap img = new Bitmap(Img_List.Peek());

                Bitmap padimg = new Bitmap(img.Width + 2, img.Height + 2);
                int pix = 0;
                for (int i = 0; i < img.Width + 2; i++)
                    for (int j = 0; j < img.Height + 2; j++)
                    {
                        if (i == 0 || j == 0 || i == img.Width + 1 || j == img.Height + 1)
                            padimg.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                        else
                        {
                            pix = img.GetPixel(i - 1, j - 1).R;
                            padimg.SetPixel(i, j, Color.FromArgb(pix, pix, pix));
                        }
                    }

                Bitmap Himg = new Bitmap(img);

                for (int i = 0; i < img.Width; i++)
                    for (int j = 0; j < img.Height; j++)
                    {
                        pix = (padimg.GetPixel(i, j + 2).R + 2 * padimg.GetPixel(i + 1, j + 2).R + padimg.GetPixel(i + 2, j + 2).R)
                            - (padimg.GetPixel(i, j).R + 2 * padimg.GetPixel(i + 1, j).R + padimg.GetPixel(i + 2, j).R);
                        if (pix < 0) pix = 0 - pix;
                        if (pix > 255) pix = 255;
                        Himg.SetPixel(i, j, Color.FromArgb(pix, pix, pix));
                    }
                process_pictureBox.Image = Himg;
                Img_List.Push(Himg);
            }
        }

        private void combine_Click(object sender, EventArgs e)
        {
            if (source_pictureBox.Image == null)
                MessageBox.Show("You need input image");
            else
            {
                Bitmap img = new Bitmap(Img_List.Peek());

                Bitmap padimg = new Bitmap(img.Width + 2, img.Height + 2);
                int pix = 0;
                for (int i = 0; i < img.Width + 2; i++)
                    for (int j = 0; j < img.Height + 2; j++)
                    {
                        if (i == 0 || j == 0 || i == img.Width + 1 || j == img.Height + 1)
                            padimg.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                        else
                        {
                            pix = img.GetPixel(i - 1, j - 1).R;
                            padimg.SetPixel(i, j, Color.FromArgb(pix, pix, pix));
                        }
                    }

                Bitmap Grayimg = new Bitmap(img);
                int px, py, mix;
                for (int i = 0; i < img.Width; i++)
                    for (int j = 0; j < img.Height; j++)
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
                        Grayimg.SetPixel(i, j, Color.FromArgb(mix, mix, mix));
                    }
                process_pictureBox.Image = Grayimg;
                Img_List.Push(Grayimg);
            }
        }

        private void edge_overlap_Click(object sender, EventArgs e)
        {
            int threshold;
            if (Thes2_text.Text != String.Empty)
            {
                try
                {
                    int num = Int32.Parse(Thes2_text.Text);
                    threshold = num;
                    //MessageBox.Show("Set threshold to : " + num);
                    if (source_pictureBox.Image == null)
                        MessageBox.Show("You need input image");
                    else
                    {
                        Bitmap img = new Bitmap(Img_List.Peek());

                        Bitmap padimg = new Bitmap(img.Width + 2, img.Height + 2);
                        int pix = 0;
                        for (int i = 0; i < img.Width + 2; i++)
                            for (int j = 0; j < img.Height + 2; j++)
                            {
                                if (i == 0 || j == 0 || i == img.Width + 1 || j == img.Height + 1)
                                    padimg.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                                else
                                {
                                    pix = img.GetPixel(i - 1, j - 1).R;
                                    padimg.SetPixel(i, j, Color.FromArgb(pix, pix, pix));
                                }
                            }

                        Bitmap Grayimg = new Bitmap(img);
                        Bitmap overlap = new Bitmap(img);
                        int px, py, mix;
                        for (int i = 0; i < img.Width; i++)
                            for (int j = 0; j < img.Height; j++)
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
                                if (mix >= threshold)
                                    overlap.SetPixel(i, j, Color.FromArgb(img.GetPixel(i, j).R, 255, img.GetPixel(i, j).B));
                            }
                        process_pictureBox.Image = overlap;
                        Img_List.Push(overlap);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Didn't Work! You need input integer number");
                }
            }
            else
            {
                MessageBox.Show("Can't be Empty!");
            }
        }

        int[] set;
        int[,] label;
        private int Find_Group(int x)
        {
            while (x != set[x])
                x = set[x];

            return x;
        }

        private void Union(int x, int y)
        {
            int Gx = Find_Group(x);
            int Gy = Find_Group(y);
            if (Gx == Gy)
                return;
            set[Gy] = Gx;
        }

        private void Connect_Cp_Click(object sender, EventArgs e)
        {
            if (source_pictureBox.Image == null)
                MessageBox.Show("You need input image");
            else
            {
                Bitmap img = new Bitmap(Img_List.Peek());

                int width = img.Width;
                int height = img.Height;
                label = new int[width + 2, height + 2];
                int labelcnt = 1, pix;
                for (int row = 0; row < height + 2; row++)
                    for (int col = 0; col < width + 2; col++)
                        label[col, row] = 0;

                Bitmap padimg = new Bitmap(img.Width + 2, img.Height + 2);
                for (int i = 0; i < img.Width + 2; i++)
                    for (int j = 0; j < img.Height + 2; j++)
                    {
                        if (i == 0 || j == 0 || i == img.Width + 1 || j == img.Height + 1)
                            padimg.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                        else
                        {
                            pix = img.GetPixel(i - 1, j - 1).R;
                            padimg.SetPixel(i, j, Color.FromArgb(pix, pix, pix));
                        }
                    }

                set = new int[width * height];
                int v1, v2, v3, v4;
                List<int> L = new List<int>();
                

                for (int row = 1; row < height; row++)
                    for (int col = 1; col < width; col++)
                    {
                        L.Clear();
                        pix = padimg.GetPixel(col, row).R;
                        if (pix != 255 && label[col, row] == 0)
                        {
                            v1 = label[col - 1, row];  //左
                            if (v1 != 0)
                                L.Add(v1);
                            v2 = label[col - 1, row - 1];   //左上
                            if (v2 != 0)
                                L.Add(v2);
                            v3 = label[col, row - 1];   //上
                            if (v3 != 0)
                                L.Add(v3);
                            v4 = label[col + 1, row - 1];   // 右上
                            if (v4 != 0)
                                L.Add(v4);

                            if (v1 == 0 && v2 == 0 && v3 == 0 && v4 == 0)
                            {
                                label[col, row] = labelcnt;
                                set[labelcnt] = labelcnt;
                                labelcnt++;
                            }
                            else if ((v1 == v2) && (v2 == v3) && (v3 == v4))
                                label[col, row] = v1;
                            else
                            {
                                label[col, row] = L.Min();
                                foreach (int i in L)
                                {
                                    if (i != label[col, row])    // 不等於 min
                                        Union(label[col, row], i);
                                }
                            }
                        }
                    }



                for (int row = 0; row < height; row++)
                    for (int col = 0; col < width; col++)
                    {
                        if (label[col, row] != 0)
                            label[col, row] = Find_Group(label[col, row]);
                    }
                List<int> sum = new List<int>();
                for(int row = 0; row < height; row++)
                    for(int col = 0; col < width; col++)
                    {
                        if (label[col, row] != 0 && !sum.Contains(label[col, row]))
                            sum.Add(label[col, row]);
                    }
  

                labelcnt = sum.Count;
                int num;
                Bitmap Nimg = new Bitmap(img);
                int r, g, b;
                for (int row = 0; row < height; row++)
                    for (int col = 0; col < width; col++)
                    {
                        if (label[col, row] != 0)
                        {
                            num = label[col, row];
                            num = (int)((float)num / sum.Max() * 255);
                           
                            if (num % 3 == 0)
                            {
                                if(num > 120)
                                {
                                    b = num - 80;
                                    g = (num - 100);
                                    r = 30;
                                }
                                else
                                {
                                    b = 120;
                                    g = num / sum.Max();
                                    r = 60;
                                }
                            }
                            else if (label[col, row] % 3 == 1)
                            {
                                if(num > 120)
                                {
                                    g = num;
                                    r = num - 80;
                                    b = num / 2 ;
                                }
                                else
                                {
                                    g = 0;
                                    r = num;
                                    b = num * 2;

                                }
                            }
                            else
                            {
                                if(num > 130)
                                {
                                    r = num / 2;
                                    g = (int)((float)num * sum.Max() / 255);
                                    b = num / sum.Max() ;
                                }
                                else
                                {
                                    r = num + 100;
                                    g = num / 2;
                                    b = num + 40;
                                }
                            }

                            if (r > 255)
                                r = 200;
                            if (g > 255)
                                g = num / sum.Max();
                            if (b > 255)
                                b = 120;
                            Nimg.SetPixel(col, row, Color.FromArgb(r, g, b));
                            //System.Console.WriteLine(label[i, j]);
                        }
                        else
                            Nimg.SetPixel(col, row, Color.FromArgb(255, 255, 255));
                    }

                process_pictureBox.Image = Nimg;
                Img_List.Push(Nimg);
                MessageBox.Show("number of label = " + labelcnt);
            }
        }
        private void recursive(int i, int j, int labelcnt, Bitmap Img)
        {
            if (i < 0 || j < 0 || i >= Img.Width || j >= Img.Height)
                return;
            int pix = Img.GetPixel(i, j).R;
            if (pix != 255 && label[i, j] == 0)
            {
                label[i, j] = labelcnt;
                recursive(i - 1, j - 1, labelcnt, Img);
                recursive(i, j - 1, labelcnt, Img);
                recursive(i + 1, j - 1, labelcnt, Img);
                recursive(i - 1, j, labelcnt, Img);
                recursive(i + 1, j, labelcnt, Img);
                recursive(i - 1, j + 1, labelcnt, Img);
                recursive(i, j + 1, labelcnt, Img);
                recursive(i + 1, j + 1, labelcnt, Img);
            }
            else
                return;
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            if (source_pictureBox.Image == null)
                MessageBox.Show("You need input image");
            else
            {
                Bitmap img = new Bitmap(Img_List.Peek());
                this.Hide();    // 隱藏父視窗
                Q8 form2 = new Q8();  // 建立子視窗
                form2.SetImage(img);
                switch (form2.ShowDialog(this))  // Form2中按下undo鈕
                {
                    case DialogResult.Yes:
                        this.Show();    //顯示父視窗
                        break;
                    case DialogResult.No:   // Form2中按下關閉鈕
                        this.Close();   // 關閉父視窗 (同時結束程式)
                        break;
                    default:
                        break;
                }
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(Img_List.Peek());
            saveFileDialog1.Filter = "All Files|*.*|Bitmap Files (.bmp)|*.bmp|Jpeg File(.jpg)|*.jpg";
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                img.Save(saveFileDialog1.FileName);
        }
    }
}
