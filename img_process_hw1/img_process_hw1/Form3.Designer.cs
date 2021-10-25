namespace img_process_hw1
{
    partial class Form3
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
            this.SourceBox = new System.Windows.Forms.PictureBox();
            this.MeanBox = new System.Windows.Forms.PictureBox();
            this.MedianBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SourceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeanBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MedianBox)).BeginInit();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(38, 47);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(142, 52);
            this.result.TabIndex = 0;
            this.result.Text = "result";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // undo
            // 
            this.undo.Location = new System.Drawing.Point(209, 47);
            this.undo.Name = "undo";
            this.undo.Size = new System.Drawing.Size(134, 52);
            this.undo.TabIndex = 1;
            this.undo.Text = "undo";
            this.undo.UseVisualStyleBackColor = true;
            this.undo.Click += new System.EventHandler(this.undo_Click);
            // 
            // SourceBox
            // 
            this.SourceBox.Location = new System.Drawing.Point(406, 47);
            this.SourceBox.Name = "SourceBox";
            this.SourceBox.Size = new System.Drawing.Size(287, 236);
            this.SourceBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SourceBox.TabIndex = 2;
            this.SourceBox.TabStop = false;
            // 
            // MeanBox
            // 
            this.MeanBox.Location = new System.Drawing.Point(51, 346);
            this.MeanBox.Name = "MeanBox";
            this.MeanBox.Size = new System.Drawing.Size(351, 309);
            this.MeanBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MeanBox.TabIndex = 3;
            this.MeanBox.TabStop = false;
            // 
            // MedianBox
            // 
            this.MedianBox.Location = new System.Drawing.Point(470, 347);
            this.MedianBox.Name = "MedianBox";
            this.MedianBox.Size = new System.Drawing.Size(369, 308);
            this.MedianBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MedianBox.TabIndex = 4;
            this.MedianBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(187, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mean";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(588, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Median";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 720);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MedianBox);
            this.Controls.Add(this.MeanBox);
            this.Controls.Add(this.SourceBox);
            this.Controls.Add(this.undo);
            this.Controls.Add(this.result);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SourceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeanBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MedianBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button result;
        private System.Windows.Forms.Button undo;
        private System.Windows.Forms.PictureBox SourceBox;
        private System.Windows.Forms.PictureBox MeanBox;
        private System.Windows.Forms.PictureBox MedianBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}