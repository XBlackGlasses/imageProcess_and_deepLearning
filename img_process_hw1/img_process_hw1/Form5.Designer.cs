namespace img_process_hw1
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.undo = new System.Windows.Forms.Button();
            this.sourceBox = new System.Windows.Forms.PictureBox();
            this.resultBox = new System.Windows.Forms.PictureBox();
            this.result = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sourceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBox)).BeginInit();
            this.SuspendLayout();
            // 
            // undo
            // 
            this.undo.Location = new System.Drawing.Point(596, 57);
            this.undo.Name = "undo";
            this.undo.Size = new System.Drawing.Size(146, 53);
            this.undo.TabIndex = 0;
            this.undo.Text = "undo";
            this.undo.UseVisualStyleBackColor = true;
            this.undo.Click += new System.EventHandler(this.undo_Click);
            // 
            // sourceBox
            // 
            this.sourceBox.Location = new System.Drawing.Point(61, 283);
            this.sourceBox.Name = "sourceBox";
            this.sourceBox.Size = new System.Drawing.Size(355, 331);
            this.sourceBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sourceBox.TabIndex = 1;
            this.sourceBox.TabStop = false;
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(468, 283);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(359, 331);
            this.resultBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resultBox.TabIndex = 2;
            this.resultBox.TabStop = false;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(365, 58);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(146, 52);
            this.result.TabIndex = 3;
            this.result.Text = "result";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 22);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(75, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "input threshold\r\ndefault threshold is 120\r\n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 22);
            this.button1.TabIndex = 6;
            this.button1.Text = "確認thrshold";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(170, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Origrin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(616, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Result";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 748);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.sourceBox);
            this.Controls.Add(this.undo);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sourceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button undo;
        private System.Windows.Forms.PictureBox sourceBox;
        private System.Windows.Forms.PictureBox resultBox;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}