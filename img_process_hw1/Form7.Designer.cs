namespace img_process_hw1
{
    partial class Form7
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Button();
            this.undo = new System.Windows.Forms.Button();
            this.sourceBox = new System.Windows.Forms.PictureBox();
            this.source = new System.Windows.Forms.Label();
            this.thresholdBox = new System.Windows.Forms.PictureBox();
            this.SobelBox = new System.Windows.Forms.PictureBox();
            this.overlapBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sourceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SobelBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.overlapBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(92, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "input threshold (default is 120)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 22);
            this.textBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 22);
            this.button1.TabIndex = 8;
            this.button1.Text = "確認thrshold";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(388, 70);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(146, 52);
            this.result.TabIndex = 9;
            this.result.Text = "result";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // undo
            // 
            this.undo.Location = new System.Drawing.Point(596, 69);
            this.undo.Name = "undo";
            this.undo.Size = new System.Drawing.Size(146, 53);
            this.undo.TabIndex = 10;
            this.undo.Text = "undo";
            this.undo.UseVisualStyleBackColor = true;
            this.undo.Click += new System.EventHandler(this.undo_Click);
            // 
            // sourceBox
            // 
            this.sourceBox.Location = new System.Drawing.Point(95, 154);
            this.sourceBox.Name = "sourceBox";
            this.sourceBox.Size = new System.Drawing.Size(257, 211);
            this.sourceBox.TabIndex = 11;
            this.sourceBox.TabStop = false;
            // 
            // source
            // 
            this.source.AutoSize = true;
            this.source.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.source.Location = new System.Drawing.Point(358, 227);
            this.source.Name = "source";
            this.source.Size = new System.Drawing.Size(110, 21);
            this.source.TabIndex = 12;
            this.source.Text = "origin image";
            // 
            // thresholdBox
            // 
            this.thresholdBox.Location = new System.Drawing.Point(362, 436);
            this.thresholdBox.Name = "thresholdBox";
            this.thresholdBox.Size = new System.Drawing.Size(252, 232);
            this.thresholdBox.TabIndex = 14;
            this.thresholdBox.TabStop = false;
            // 
            // SobelBox
            // 
            this.SobelBox.Location = new System.Drawing.Point(65, 436);
            this.SobelBox.Name = "SobelBox";
            this.SobelBox.Size = new System.Drawing.Size(252, 232);
            this.SobelBox.TabIndex = 15;
            this.SobelBox.TabStop = false;
            // 
            // overlapBox
            // 
            this.overlapBox.Location = new System.Drawing.Point(664, 436);
            this.overlapBox.Name = "overlapBox";
            this.overlapBox.Size = new System.Drawing.Size(252, 232);
            this.overlapBox.TabIndex = 16;
            this.overlapBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(159, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Sobel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(442, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "threshold";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(739, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "overlap";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 749);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.overlapBox);
            this.Controls.Add(this.SobelBox);
            this.Controls.Add(this.thresholdBox);
            this.Controls.Add(this.source);
            this.Controls.Add(this.sourceBox);
            this.Controls.Add(this.undo);
            this.Controls.Add(this.result);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sourceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SobelBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.overlapBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.Button undo;
        private System.Windows.Forms.PictureBox sourceBox;
        private System.Windows.Forms.Label source;
        private System.Windows.Forms.PictureBox thresholdBox;
        private System.Windows.Forms.PictureBox SobelBox;
        private System.Windows.Forms.PictureBox overlapBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}