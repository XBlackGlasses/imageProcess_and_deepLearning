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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Bitmap openImg;
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All Files|*.*|Bitmap Files (.bmp)|*.bmp|Jpeg File(.jpg)|*.jpg";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openImg = new Bitmap(openFileDialog1.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = openImg;
            }
        }

        private void Q1_Click(object sender, EventArgs e)
        {
            if (openImg != null)
            {
                this.Hide();    // 隱藏父視窗
                Form2 form2 = new Form2();  // 建立子視窗
                form2.SetImage(openImg);
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
            else
                MessageBox.Show("you need to input image !");
            //SaveFileDialog sfd = new SaveFileDialog();
            //sfd.Filter = "All Files|*.*|Bitmap Files (.bmp)|*.bmp|Jpeg File(.jpg)|*.jpg";

            //if(sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //}
        }

        private void Q2_Click(object sender, EventArgs e)
        {
            if (openImg != null)
            {
                this.Hide();    // 隱藏父視窗
                Form3 form3 = new Form3();  // 建立子視窗
                form3.SetImage(openImg);
                switch (form3.ShowDialog(this))  // Form2中按下undo鈕
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
            else
                MessageBox.Show("you need to input image !");
        }

        private void Q3_Click(object sender, EventArgs e)
        {
            if (openImg != null)
            {

                this.Hide();    // 隱藏父視窗
                Form4 form4 = new Form4();  // 建立子視窗
                form4.SetImage(openImg);
                switch (form4.ShowDialog(this))  // Form3中按下undo鈕
                {
                    case DialogResult.Yes:
                        this.Show();    //顯示父視窗
                        break;
                    case DialogResult.No:   // Form3中按下關閉鈕
                        this.Close();   // 關閉父視窗 (同時結束程式)
                        break;
                    default:
                        break;
                }
            }
            else
                MessageBox.Show("you need to input image !");


        }

        private void Q4_Click(object sender, EventArgs e)
        {

            if (openImg != null)
            {
                this.Hide();    // 隱藏父視窗
                Form5 form5 = new Form5();  // 建立子視窗
                form5.SetImage(openImg);
                switch (form5.ShowDialog(this))  // Form3中按下undo鈕
                {
                    case DialogResult.Yes:
                        this.Show();    //顯示父視窗
                        break;
                    case DialogResult.No:   // Form3中按下關閉鈕
                        this.Close();   // 關閉父視窗 (同時結束程式)
                        break;
                    default:
                        break;
                }

            }
            else
                MessageBox.Show("you need to input image !");


        }

        private void Q5_Click(object sender, EventArgs e)
        {
            if (openImg != null)
            {

                this.Hide();    // 隱藏父視窗
                Form6 form6 = new Form6();  // 建立子視窗
                form6.SetImage(openImg);
                switch (form6.ShowDialog(this))  // Form3中按下undo鈕
                {
                    case DialogResult.Yes:
                        this.Show();    //顯示父視窗
                        break;
                    case DialogResult.No:   // Form3中按下關閉鈕
                        this.Close();   // 關閉父視窗 (同時結束程式)
                        break;
                    default:
                        break;
                }
            }
            else
                MessageBox.Show("you need to input image !");




        }

        private void Q6_Click(object sender, EventArgs e)
        {
            if (openImg != null)
            {
                this.Hide();    // 隱藏父視窗
                Form7 form7 = new Form7();  // 建立子視窗
                form7.SetImage(openImg);
                switch (form7.ShowDialog(this))  // Form3中按下undo鈕
                {
                    case DialogResult.Yes:
                        this.Show();    //顯示父視窗
                        break;
                    case DialogResult.No:   // Form3中按下關閉鈕
                        this.Close();   // 關閉父視窗 (同時結束程式)
                        break;
                    default:
                        break;
                }

            }
            else
                MessageBox.Show("you need to input image !");


        }

        private void Q7_Click(object sender, EventArgs e)
        {

            if (openImg != null)
            {
                this.Hide();    // 隱藏父視窗
                Form8 form8 = new Form8();  // 建立子視窗
                form8.SetImage(openImg);
                switch (form8.ShowDialog(this))  // Form3中按下undo鈕
                {
                    case DialogResult.Yes:
                        this.Show();    //顯示父視窗
                        break;
                    case DialogResult.No:   // Form3中按下關閉鈕
                        this.Close();   // 關閉父視窗 (同時結束程式)
                        break;
                    default:
                        break;
                }

            }
            else
                MessageBox.Show("you need to input image !");

        }

        private void Q8_Click(object sender, EventArgs e)
        {
            if (openImg != null)
            {
                this.Hide();    // 隱藏父視窗
                Form9 form9 = new Form9();  // 建立子視窗
                form9.SetImage(openImg);
                switch (form9.ShowDialog(this))  // Form3中按下undo鈕
                {
                    case DialogResult.Yes:
                        this.Show();    //顯示父視窗
                        break;
                    case DialogResult.No:   // Form3中按下關閉鈕
                        this.Close();   // 關閉父視窗 (同時結束程式)
                        break;
                    default:
                        break;
                }
            }
            else
                MessageBox.Show("You need to input image !");
        }
    }
}
