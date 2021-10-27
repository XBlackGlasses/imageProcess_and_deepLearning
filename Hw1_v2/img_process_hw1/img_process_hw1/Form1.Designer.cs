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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea37 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend37 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series37 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea38 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend38 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series38 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.R = new System.Windows.Forms.Button();
            this.G = new System.Windows.Forms.Button();
            this.B = new System.Windows.Forms.Button();
            this.gray = new System.Windows.Forms.Button();
            this.mean_filter = new System.Windows.Forms.Button();
            this.median_filter = new System.Windows.Forms.Button();
            this.Hist_Eq = new System.Windows.Forms.Button();
            this.threshold = new System.Windows.Forms.Button();
            this.thresh_text = new System.Windows.Forms.TextBox();
            this.Vertical = new System.Windows.Forms.Button();
            this.Horizon = new System.Windows.Forms.Button();
            this.combine = new System.Windows.Forms.Button();
            this.Thes2_text = new System.Windows.Forms.TextBox();
            this.edge_overlap = new System.Windows.Forms.Button();
            this.Connect_Cp = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Undo = new System.Windows.Forms.Button();
            this.source_pictureBox = new System.Windows.Forms.PictureBox();
            this.process_pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Registration = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.source_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.process_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // R
            // 
            this.R.Location = new System.Drawing.Point(24, 24);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(115, 34);
            this.R.TabIndex = 0;
            this.R.Text = "R";
            this.R.UseVisualStyleBackColor = true;
            this.R.Click += new System.EventHandler(this.R_Click);
            // 
            // G
            // 
            this.G.Location = new System.Drawing.Point(155, 24);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(115, 34);
            this.G.TabIndex = 1;
            this.G.Text = "G";
            this.G.UseVisualStyleBackColor = true;
            this.G.Click += new System.EventHandler(this.G_Click);
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(24, 64);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(115, 34);
            this.B.TabIndex = 2;
            this.B.Text = "B";
            this.B.UseVisualStyleBackColor = true;
            this.B.Click += new System.EventHandler(this.B_Click);
            // 
            // gray
            // 
            this.gray.Location = new System.Drawing.Point(155, 64);
            this.gray.Name = "gray";
            this.gray.Size = new System.Drawing.Size(115, 34);
            this.gray.TabIndex = 3;
            this.gray.Text = "gray";
            this.gray.UseVisualStyleBackColor = true;
            this.gray.Click += new System.EventHandler(this.gray_Click);
            // 
            // mean_filter
            // 
            this.mean_filter.Location = new System.Drawing.Point(22, 26);
            this.mean_filter.Name = "mean_filter";
            this.mean_filter.Size = new System.Drawing.Size(115, 34);
            this.mean_filter.TabIndex = 4;
            this.mean_filter.Text = "Mean Filter";
            this.mean_filter.UseVisualStyleBackColor = true;
            this.mean_filter.Click += new System.EventHandler(this.mean_filter_Click);
            // 
            // median_filter
            // 
            this.median_filter.Location = new System.Drawing.Point(153, 26);
            this.median_filter.Name = "median_filter";
            this.median_filter.Size = new System.Drawing.Size(115, 34);
            this.median_filter.TabIndex = 5;
            this.median_filter.Text = "Median Filter";
            this.median_filter.UseVisualStyleBackColor = true;
            this.median_filter.Click += new System.EventHandler(this.median_filter_Click);
            // 
            // Hist_Eq
            // 
            this.Hist_Eq.Location = new System.Drawing.Point(24, 17);
            this.Hist_Eq.Name = "Hist_Eq";
            this.Hist_Eq.Size = new System.Drawing.Size(246, 34);
            this.Hist_Eq.TabIndex = 6;
            this.Hist_Eq.Text = "Histogram Equalization";
            this.Hist_Eq.UseVisualStyleBackColor = true;
            this.Hist_Eq.Click += new System.EventHandler(this.Hist_Eq_Click);
            // 
            // threshold
            // 
            this.threshold.Location = new System.Drawing.Point(143, 17);
            this.threshold.Name = "threshold";
            this.threshold.Size = new System.Drawing.Size(125, 34);
            this.threshold.TabIndex = 7;
            this.threshold.Text = "Start";
            this.threshold.UseVisualStyleBackColor = true;
            this.threshold.Click += new System.EventHandler(this.threshold_Click);
            // 
            // thresh_text
            // 
            this.thresh_text.Location = new System.Drawing.Point(22, 20);
            this.thresh_text.Name = "thresh_text";
            this.thresh_text.Size = new System.Drawing.Size(115, 27);
            this.thresh_text.TabIndex = 8;
            // 
            // Vertical
            // 
            this.Vertical.Location = new System.Drawing.Point(23, 21);
            this.Vertical.Name = "Vertical";
            this.Vertical.Size = new System.Drawing.Size(78, 34);
            this.Vertical.TabIndex = 9;
            this.Vertical.Text = "Vertical";
            this.Vertical.UseVisualStyleBackColor = true;
            this.Vertical.Click += new System.EventHandler(this.Vertical_Click);
            // 
            // Horizon
            // 
            this.Horizon.Location = new System.Drawing.Point(107, 21);
            this.Horizon.Name = "Horizon";
            this.Horizon.Size = new System.Drawing.Size(78, 34);
            this.Horizon.TabIndex = 10;
            this.Horizon.Text = "Horizontal";
            this.Horizon.UseVisualStyleBackColor = true;
            this.Horizon.Click += new System.EventHandler(this.Horizon_Click);
            // 
            // combine
            // 
            this.combine.Location = new System.Drawing.Point(189, 21);
            this.combine.Name = "combine";
            this.combine.Size = new System.Drawing.Size(78, 34);
            this.combine.TabIndex = 11;
            this.combine.Text = "combined";
            this.combine.UseVisualStyleBackColor = true;
            this.combine.Click += new System.EventHandler(this.combine_Click);
            // 
            // Thes2_text
            // 
            this.Thes2_text.Location = new System.Drawing.Point(23, 25);
            this.Thes2_text.Name = "Thes2_text";
            this.Thes2_text.Size = new System.Drawing.Size(115, 27);
            this.Thes2_text.TabIndex = 12;
            // 
            // edge_overlap
            // 
            this.edge_overlap.Location = new System.Drawing.Point(142, 21);
            this.edge_overlap.Name = "edge_overlap";
            this.edge_overlap.Size = new System.Drawing.Size(125, 34);
            this.edge_overlap.TabIndex = 13;
            this.edge_overlap.Text = "Edge Overlapping";
            this.edge_overlap.UseVisualStyleBackColor = true;
            this.edge_overlap.Click += new System.EventHandler(this.edge_overlap_Click);
            // 
            // Connect_Cp
            // 
            this.Connect_Cp.Location = new System.Drawing.Point(23, 23);
            this.Connect_Cp.Name = "Connect_Cp";
            this.Connect_Cp.Size = new System.Drawing.Size(246, 34);
            this.Connect_Cp.TabIndex = 14;
            this.Connect_Cp.Text = "Connected Component";
            this.Connect_Cp.UseVisualStyleBackColor = true;
            this.Connect_Cp.Click += new System.EventHandler(this.Connect_Cp_Click);
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(20, 18);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(78, 34);
            this.Load.TabIndex = 15;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(104, 18);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(78, 34);
            this.Save.TabIndex = 16;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Undo
            // 
            this.Undo.Location = new System.Drawing.Point(188, 18);
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(78, 34);
            this.Undo.TabIndex = 17;
            this.Undo.Text = "Undo";
            this.Undo.UseVisualStyleBackColor = true;
            this.Undo.Click += new System.EventHandler(this.Undo_Click);
            // 
            // source_pictureBox
            // 
            this.source_pictureBox.Location = new System.Drawing.Point(492, 17);
            this.source_pictureBox.Name = "source_pictureBox";
            this.source_pictureBox.Size = new System.Drawing.Size(499, 346);
            this.source_pictureBox.TabIndex = 18;
            this.source_pictureBox.TabStop = false;
            // 
            // process_pictureBox
            // 
            this.process_pictureBox.Location = new System.Drawing.Point(492, 402);
            this.process_pictureBox.Name = "process_pictureBox";
            this.process_pictureBox.Size = new System.Drawing.Size(499, 350);
            this.process_pictureBox.TabIndex = 19;
            this.process_pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(333, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 27);
            this.label1.TabIndex = 20;
            this.label1.Text = "Source Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(333, 484);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 27);
            this.label2.TabIndex = 21;
            this.label2.Text = "Process Image";
            // 
            // chart1
            // 
            chartArea37.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea37);
            legend37.Name = "Legend1";
            this.chart1.Legends.Add(legend37);
            this.chart1.Location = new System.Drawing.Point(1083, 17);
            this.chart1.Name = "chart1";
            series37.ChartArea = "ChartArea1";
            series37.Legend = "Legend1";
            series37.Name = "Series1";
            this.chart1.Series.Add(series37);
            this.chart1.Size = new System.Drawing.Size(358, 350);
            this.chart1.TabIndex = 22;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea38.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea38);
            legend38.Name = "Legend1";
            this.chart2.Legends.Add(legend38);
            this.chart2.Location = new System.Drawing.Point(1083, 389);
            this.chart2.Name = "chart2";
            series38.ChartArea = "ChartArea1";
            series38.Legend = "Legend1";
            series38.Name = "Series1";
            this.chart2.Series.Add(series38);
            this.chart2.Size = new System.Drawing.Size(358, 350);
            this.chart2.TabIndex = 23;
            this.chart2.Text = "chart2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gray);
            this.groupBox1.Controls.Add(this.B);
            this.groupBox1.Controls.Add(this.G);
            this.groupBox1.Controls.Add(this.R);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(28, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 117);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Extraction";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.median_filter);
            this.groupBox2.Controls.Add(this.mean_filter);
            this.groupBox2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(28, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 71);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Smooth Filter";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Hist_Eq);
            this.groupBox3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(28, 238);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(297, 57);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Equaliaztion";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.thresh_text);
            this.groupBox4.Controls.Add(this.threshold);
            this.groupBox4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox4.Location = new System.Drawing.Point(28, 321);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(296, 57);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Threshold";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.combine);
            this.groupBox5.Controls.Add(this.Horizon);
            this.groupBox5.Controls.Add(this.Vertical);
            this.groupBox5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox5.Location = new System.Drawing.Point(29, 389);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(294, 70);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sobel Edge Detection";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.edge_overlap);
            this.groupBox6.Controls.Add(this.Thes2_text);
            this.groupBox6.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox6.Location = new System.Drawing.Point(29, 465);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(293, 61);
            this.groupBox6.TabIndex = 29;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Edge Overlapping";
            // 
            // Registration
            // 
            this.Registration.Location = new System.Drawing.Point(19, 16);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(246, 34);
            this.Registration.TabIndex = 30;
            this.Registration.Text = "Image Registration";
            this.Registration.UseVisualStyleBackColor = true;
            this.Registration.Click += new System.EventHandler(this.Registration_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.Connect_Cp);
            this.groupBox7.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox7.Location = new System.Drawing.Point(29, 553);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(292, 63);
            this.groupBox7.TabIndex = 31;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Connected Component";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.Registration);
            this.groupBox8.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox8.Location = new System.Drawing.Point(29, 630);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(292, 60);
            this.groupBox8.TabIndex = 32;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Image Registration";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.Undo);
            this.groupBox9.Controls.Add(this.Save);
            this.groupBox9.Controls.Add(this.Load);
            this.groupBox9.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox9.Location = new System.Drawing.Point(29, 714);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(291, 63);
            this.groupBox9.TabIndex = 33;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Operations";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1501, 791);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.process_pictureBox);
            this.Controls.Add(this.source_pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.source_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.process_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button R;
        private System.Windows.Forms.Button G;
        private System.Windows.Forms.Button B;
        private System.Windows.Forms.Button gray;
        private System.Windows.Forms.Button mean_filter;
        private System.Windows.Forms.Button median_filter;
        private System.Windows.Forms.Button Hist_Eq;
        private System.Windows.Forms.Button threshold;
        private System.Windows.Forms.TextBox thresh_text;
        private System.Windows.Forms.Button Vertical;
        private System.Windows.Forms.Button Horizon;
        private System.Windows.Forms.Button combine;
        private System.Windows.Forms.TextBox Thes2_text;
        private System.Windows.Forms.Button edge_overlap;
        private System.Windows.Forms.Button Connect_Cp;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Undo;
        private System.Windows.Forms.PictureBox source_pictureBox;
        private System.Windows.Forms.PictureBox process_pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button Registration;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
    }
}

