namespace img_process_hw1
{
    partial class Form9
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
            this.button1 = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Button();
            this.undo = new System.Windows.Forms.Button();
            this.sourceBox = new System.Windows.Forms.PictureBox();
            this.refBox = new System.Windows.Forms.PictureBox();
            this.resultBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.slabelx = new System.Windows.Forms.Label();
            this.slabely = new System.Windows.Forms.Label();
            this.rlabelx = new System.Windows.Forms.Label();
            this.rlabely = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sP1 = new System.Windows.Forms.Label();
            this.sP2 = new System.Windows.Forms.Label();
            this.sP3 = new System.Windows.Forms.Label();
            this.sP4 = new System.Windows.Forms.Label();
            this.rP1 = new System.Windows.Forms.Label();
            this.rP2 = new System.Windows.Forms.Label();
            this.rP3 = new System.Windows.Forms.Label();
            this.rP4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sourceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(74, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "select reference image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.result.Location = new System.Drawing.Point(370, 28);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(174, 51);
            this.result.TabIndex = 1;
            this.result.Text = "result";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // undo
            // 
            this.undo.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.undo.Location = new System.Drawing.Point(650, 29);
            this.undo.Name = "undo";
            this.undo.Size = new System.Drawing.Size(174, 50);
            this.undo.TabIndex = 2;
            this.undo.Text = "undo";
            this.undo.UseVisualStyleBackColor = true;
            this.undo.Click += new System.EventHandler(this.undo_Click);
            // 
            // sourceBox
            // 
            this.sourceBox.Location = new System.Drawing.Point(32, 308);
            this.sourceBox.Name = "sourceBox";
            this.sourceBox.Size = new System.Drawing.Size(275, 257);
            this.sourceBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.sourceBox.TabIndex = 3;
            this.sourceBox.TabStop = false;
            this.sourceBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sourceBox_MouseClick);
            this.sourceBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sourceBox_MouseMove);
            // 
            // refBox
            // 
            this.refBox.Location = new System.Drawing.Point(1146, 308);
            this.refBox.Name = "refBox";
            this.refBox.Size = new System.Drawing.Size(275, 257);
            this.refBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.refBox.TabIndex = 4;
            this.refBox.TabStop = false;
            this.refBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.refBox_MouseClick);
            this.refBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.refBox_MouseMove);
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(613, 308);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(275, 257);
            this.resultBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.resultBox.TabIndex = 5;
            this.resultBox.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(99, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "source image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(1234, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "reference image";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(691, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "result image";
            // 
            // slabelx
            // 
            this.slabelx.AutoSize = true;
            this.slabelx.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.slabelx.Location = new System.Drawing.Point(46, 286);
            this.slabelx.Name = "slabelx";
            this.slabelx.Size = new System.Drawing.Size(33, 19);
            this.slabelx.TabIndex = 9;
            this.slabelx.Text = "x : ";
            // 
            // slabely
            // 
            this.slabely.AutoSize = true;
            this.slabely.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.slabely.Location = new System.Drawing.Point(164, 286);
            this.slabely.Name = "slabely";
            this.slabely.Size = new System.Drawing.Size(33, 19);
            this.slabely.TabIndex = 10;
            this.slabely.Text = "y : ";
            // 
            // rlabelx
            // 
            this.rlabelx.AutoSize = true;
            this.rlabelx.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rlabelx.Location = new System.Drawing.Point(1234, 286);
            this.rlabelx.Name = "rlabelx";
            this.rlabelx.Size = new System.Drawing.Size(33, 19);
            this.rlabelx.TabIndex = 11;
            this.rlabelx.Text = "x : ";
            // 
            // rlabely
            // 
            this.rlabely.AutoSize = true;
            this.rlabely.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rlabely.Location = new System.Drawing.Point(1356, 286);
            this.rlabely.Name = "rlabely";
            this.rlabely.Size = new System.Drawing.Size(33, 19);
            this.rlabely.TabIndex = 12;
            this.rlabely.Text = "y : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(70, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(484, 76);
            this.label4.TabIndex = 13;
            this.label4.Text = "請先選擇reference image \r\n接著在兩張圖片上由左上開始逆時針選擇4個點\r\n請照左上、左下、右下、右上的順序選取，否則會有錯誤\r\n選完按result" +
    "就OK了\r\n";
            // 
            // sP1
            // 
            this.sP1.AutoSize = true;
            this.sP1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sP1.Location = new System.Drawing.Point(43, 656);
            this.sP1.Name = "sP1";
            this.sP1.Size = new System.Drawing.Size(36, 16);
            this.sP1.TabIndex = 14;
            this.sP1.Text = "P1 : ";
            // 
            // sP2
            // 
            this.sP2.AutoSize = true;
            this.sP2.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sP2.Location = new System.Drawing.Point(43, 683);
            this.sP2.Name = "sP2";
            this.sP2.Size = new System.Drawing.Size(36, 16);
            this.sP2.TabIndex = 15;
            this.sP2.Text = "P2 : ";
            // 
            // sP3
            // 
            this.sP3.AutoSize = true;
            this.sP3.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sP3.Location = new System.Drawing.Point(43, 709);
            this.sP3.Name = "sP3";
            this.sP3.Size = new System.Drawing.Size(32, 16);
            this.sP3.TabIndex = 16;
            this.sP3.Text = "P3 :";
            // 
            // sP4
            // 
            this.sP4.AutoSize = true;
            this.sP4.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sP4.Location = new System.Drawing.Point(43, 734);
            this.sP4.Name = "sP4";
            this.sP4.Size = new System.Drawing.Size(32, 16);
            this.sP4.TabIndex = 17;
            this.sP4.Text = "P4 :";
            // 
            // rP1
            // 
            this.rP1.AutoSize = true;
            this.rP1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rP1.Location = new System.Drawing.Point(1193, 709);
            this.rP1.Name = "rP1";
            this.rP1.Size = new System.Drawing.Size(36, 16);
            this.rP1.TabIndex = 18;
            this.rP1.Text = "P1 : ";
            // 
            // rP2
            // 
            this.rP2.AutoSize = true;
            this.rP2.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rP2.Location = new System.Drawing.Point(1193, 736);
            this.rP2.Name = "rP2";
            this.rP2.Size = new System.Drawing.Size(36, 16);
            this.rP2.TabIndex = 19;
            this.rP2.Text = "P2 : ";
            // 
            // rP3
            // 
            this.rP3.AutoSize = true;
            this.rP3.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rP3.Location = new System.Drawing.Point(1193, 762);
            this.rP3.Name = "rP3";
            this.rP3.Size = new System.Drawing.Size(32, 16);
            this.rP3.TabIndex = 20;
            this.rP3.Text = "P3 :";
            // 
            // rP4
            // 
            this.rP4.AutoSize = true;
            this.rP4.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rP4.Location = new System.Drawing.Point(1193, 787);
            this.rP4.Name = "rP4";
            this.rP4.Size = new System.Drawing.Size(32, 16);
            this.rP4.TabIndex = 21;
            this.rP4.Text = "P4 :";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(663, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 42);
            this.button2.TabIndex = 22;
            this.button2.Text = "clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1661, 816);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rP4);
            this.Controls.Add(this.rP3);
            this.Controls.Add(this.rP2);
            this.Controls.Add(this.rP1);
            this.Controls.Add(this.sP4);
            this.Controls.Add(this.sP3);
            this.Controls.Add(this.sP2);
            this.Controls.Add(this.sP1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rlabely);
            this.Controls.Add(this.rlabelx);
            this.Controls.Add(this.slabely);
            this.Controls.Add(this.slabelx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.refBox);
            this.Controls.Add(this.sourceBox);
            this.Controls.Add(this.undo);
            this.Controls.Add(this.result);
            this.Controls.Add(this.button1);
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sourceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.Button undo;
        private System.Windows.Forms.PictureBox sourceBox;
        private System.Windows.Forms.PictureBox refBox;
        private System.Windows.Forms.PictureBox resultBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label slabelx;
        private System.Windows.Forms.Label slabely;
        private System.Windows.Forms.Label rlabelx;
        private System.Windows.Forms.Label rlabely;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label sP1;
        private System.Windows.Forms.Label sP2;
        private System.Windows.Forms.Label sP3;
        private System.Windows.Forms.Label sP4;
        private System.Windows.Forms.Label rP1;
        private System.Windows.Forms.Label rP2;
        private System.Windows.Forms.Label rP3;
        private System.Windows.Forms.Label rP4;
        private System.Windows.Forms.Button button2;
    }
}