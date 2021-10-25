namespace img_process_hw1
{
    partial class Form6
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
            this.result = new System.Windows.Forms.Button();
            this.undo = new System.Windows.Forms.Button();
            this.sourceBox = new System.Windows.Forms.PictureBox();
            this.resultBox1 = new System.Windows.Forms.PictureBox();
            this.resultBox2 = new System.Windows.Forms.PictureBox();
            this.resultBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sourceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(91, 49);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(146, 45);
            this.result.TabIndex = 0;
            this.result.Text = "result";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // undo
            // 
            this.undo.Location = new System.Drawing.Point(91, 133);
            this.undo.Name = "undo";
            this.undo.Size = new System.Drawing.Size(146, 45);
            this.undo.TabIndex = 1;
            this.undo.Text = "undo";
            this.undo.UseVisualStyleBackColor = true;
            this.undo.Click += new System.EventHandler(this.undo_Click);
            // 
            // sourceBox
            // 
            this.sourceBox.Location = new System.Drawing.Point(33, 249);
            this.sourceBox.Name = "sourceBox";
            this.sourceBox.Size = new System.Drawing.Size(258, 240);
            this.sourceBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sourceBox.TabIndex = 2;
            this.sourceBox.TabStop = false;
            // 
            // resultBox1
            // 
            this.resultBox1.Location = new System.Drawing.Point(380, 49);
            this.resultBox1.Name = "resultBox1";
            this.resultBox1.Size = new System.Drawing.Size(239, 194);
            this.resultBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resultBox1.TabIndex = 3;
            this.resultBox1.TabStop = false;
            // 
            // resultBox2
            // 
            this.resultBox2.Location = new System.Drawing.Point(379, 249);
            this.resultBox2.Name = "resultBox2";
            this.resultBox2.Size = new System.Drawing.Size(240, 205);
            this.resultBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resultBox2.TabIndex = 4;
            this.resultBox2.TabStop = false;
            // 
            // resultBox3
            // 
            this.resultBox3.Location = new System.Drawing.Point(379, 460);
            this.resultBox3.Name = "resultBox3";
            this.resultBox3.Size = new System.Drawing.Size(238, 207);
            this.resultBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resultBox3.TabIndex = 5;
            this.resultBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(632, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vertical";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(632, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Horizontal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(633, 549);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Combined";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(125, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Origin";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 698);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultBox3);
            this.Controls.Add(this.resultBox2);
            this.Controls.Add(this.resultBox1);
            this.Controls.Add(this.sourceBox);
            this.Controls.Add(this.undo);
            this.Controls.Add(this.result);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sourceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button result;
        private System.Windows.Forms.Button undo;
        private System.Windows.Forms.PictureBox sourceBox;
        private System.Windows.Forms.PictureBox resultBox1;
        private System.Windows.Forms.PictureBox resultBox2;
        private System.Windows.Forms.PictureBox resultBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}