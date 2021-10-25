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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
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
            threshold = 0;
            if(textBox1.Text != String.Empty)
            {
                try
                {
                    int num = Int32.Parse(textBox1.Text);
                    threshold = num;
                    MessageBox.Show("Set threshold to : " + num);
                }
                catch(FormatException)
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
            if (resultBox.Image != null)
            {
                resultBox.Image.Dispose();
                //resultBox.Image = null;
            }
            Bitmap tmpImg = new Bitmap(Img);
            int value;
            for(int i = 0; i < tmpImg.Width; i++)
                for(int j = 0; j < tmpImg.Height; j++)
                {
                    value = Img.GetPixel(i, j).R;
                    if (value < threshold)
                        tmpImg.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                    else
                        tmpImg.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                }

            resultBox.Image = tmpImg;
        }
    }
}
