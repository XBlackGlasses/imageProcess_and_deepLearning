namespace img_process_hw1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.Q1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Q2 = new System.Windows.Forms.Button();
            this.Q3 = new System.Windows.Forms.Button();
            this.Q4 = new System.Windows.Forms.Button();
            this.Q5 = new System.Windows.Forms.Button();
            this.Q6 = new System.Windows.Forms.Button();
            this.Q7 = new System.Windows.Forms.Button();
            this.Q8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(582, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "選擇圖片";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Q1
            // 
            this.Q1.Location = new System.Drawing.Point(731, 52);
            this.Q1.Name = "Q1";
            this.Q1.Size = new System.Drawing.Size(125, 36);
            this.Q1.TabIndex = 1;
            this.Q1.Text = "問題一";
            this.Q1.UseVisualStyleBackColor = true;
            this.Q1.Click += new System.EventHandler(this.Q1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(36, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(540, 481);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Q2
            // 
            this.Q2.Location = new System.Drawing.Point(731, 131);
            this.Q2.Name = "Q2";
            this.Q2.Size = new System.Drawing.Size(125, 34);
            this.Q2.TabIndex = 3;
            this.Q2.Text = "問題二";
            this.Q2.UseVisualStyleBackColor = true;
            this.Q2.Click += new System.EventHandler(this.Q2_Click);
            // 
            // Q3
            // 
            this.Q3.Location = new System.Drawing.Point(730, 212);
            this.Q3.Name = "Q3";
            this.Q3.Size = new System.Drawing.Size(125, 34);
            this.Q3.TabIndex = 4;
            this.Q3.Text = "問題三";
            this.Q3.UseVisualStyleBackColor = true;
            this.Q3.Click += new System.EventHandler(this.Q3_Click);
            // 
            // Q4
            // 
            this.Q4.Location = new System.Drawing.Point(729, 284);
            this.Q4.Name = "Q4";
            this.Q4.Size = new System.Drawing.Size(125, 34);
            this.Q4.TabIndex = 5;
            this.Q4.Text = "問題四";
            this.Q4.UseVisualStyleBackColor = true;
            this.Q4.Click += new System.EventHandler(this.Q4_Click);
            // 
            // Q5
            // 
            this.Q5.Location = new System.Drawing.Point(729, 355);
            this.Q5.Name = "Q5";
            this.Q5.Size = new System.Drawing.Size(125, 34);
            this.Q5.TabIndex = 6;
            this.Q5.Text = "問題五";
            this.Q5.UseVisualStyleBackColor = true;
            this.Q5.Click += new System.EventHandler(this.Q5_Click);
            // 
            // Q6
            // 
            this.Q6.Location = new System.Drawing.Point(729, 417);
            this.Q6.Name = "Q6";
            this.Q6.Size = new System.Drawing.Size(125, 34);
            this.Q6.TabIndex = 7;
            this.Q6.Text = "問題六";
            this.Q6.UseVisualStyleBackColor = true;
            this.Q6.Click += new System.EventHandler(this.Q6_Click);
            // 
            // Q7
            // 
            this.Q7.Location = new System.Drawing.Point(730, 486);
            this.Q7.Name = "Q7";
            this.Q7.Size = new System.Drawing.Size(125, 34);
            this.Q7.TabIndex = 8;
            this.Q7.Text = "問題七";
            this.Q7.UseVisualStyleBackColor = true;
            this.Q7.Click += new System.EventHandler(this.Q7_Click);
            // 
            // Q8
            // 
            this.Q8.Location = new System.Drawing.Point(731, 555);
            this.Q8.Name = "Q8";
            this.Q8.Size = new System.Drawing.Size(124, 34);
            this.Q8.TabIndex = 9;
            this.Q8.Text = "問題八";
            this.Q8.UseVisualStyleBackColor = true;
            this.Q8.Click += new System.EventHandler(this.Q8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 651);
            this.Controls.Add(this.Q8);
            this.Controls.Add(this.Q7);
            this.Controls.Add(this.Q6);
            this.Controls.Add(this.Q5);
            this.Controls.Add(this.Q4);
            this.Controls.Add(this.Q3);
            this.Controls.Add(this.Q2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Q1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Q1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button Q2;
        private System.Windows.Forms.Button Q3;
        private System.Windows.Forms.Button Q4;
        private System.Windows.Forms.Button Q5;
        private System.Windows.Forms.Button Q6;
        private System.Windows.Forms.Button Q7;
        private System.Windows.Forms.Button Q8;
    }
}

