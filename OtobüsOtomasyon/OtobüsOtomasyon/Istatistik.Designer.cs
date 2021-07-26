namespace OtobüsOtomasyon
{
    partial class Istatistik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Istatistik));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.AllTimeShowBtn = new System.Windows.Forms.Button();
            this.MoreCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sumUcret = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TodayShowBtn = new System.Windows.Forms.Button();
            this.DegerShowBtn = new System.Windows.Forms.Button();
            this.ZamanTxt = new System.Windows.Forms.TextBox();
            this.BiletTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // AllTimeShowBtn
            // 
            this.AllTimeShowBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.AllTimeShowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllTimeShowBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AllTimeShowBtn.Image = ((System.Drawing.Image)(resources.GetObject("AllTimeShowBtn.Image")));
            this.AllTimeShowBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AllTimeShowBtn.Location = new System.Drawing.Point(26, 30);
            this.AllTimeShowBtn.Name = "AllTimeShowBtn";
            this.AllTimeShowBtn.Size = new System.Drawing.Size(211, 39);
            this.AllTimeShowBtn.TabIndex = 2;
            this.AllTimeShowBtn.Text = "      Tüm Zamanları Göster";
            this.AllTimeShowBtn.UseVisualStyleBackColor = false;
            this.AllTimeShowBtn.Click += new System.EventHandler(this.AllTimeShowBtn_Click);
            // 
            // MoreCheckBox
            // 
            this.MoreCheckBox.AutoSize = true;
            this.MoreCheckBox.Location = new System.Drawing.Point(836, 42);
            this.MoreCheckBox.Name = "MoreCheckBox";
            this.MoreCheckBox.Size = new System.Drawing.Size(84, 21);
            this.MoreCheckBox.TabIndex = 3;
            this.MoreCheckBox.Text = "Daha Az";
            this.MoreCheckBox.UseVisualStyleBackColor = true;
            this.MoreCheckBox.CheckedChanged += new System.EventHandler(this.MoreCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Toplam Bilet Ücreti";
            // 
            // sumUcret
            // 
            this.sumUcret.Enabled = false;
            this.sumUcret.Location = new System.Drawing.Point(57, 203);
            this.sumUcret.Name = "sumUcret";
            this.sumUcret.Size = new System.Drawing.Size(124, 22);
            this.sumUcret.TabIndex = 5;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Linen;
            this.chart1.BorderlineColor = System.Drawing.Color.Linen;
            chartArea1.BackColor = System.Drawing.Color.Linen;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(278, 148);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.LabelBackColor = System.Drawing.Color.Linen;
            series1.Legend = "Legend1";
            series1.Name = "Çalışanlar";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(730, 480);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "Çalışanlar";
            // 
            // TodayShowBtn
            // 
            this.TodayShowBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.TodayShowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TodayShowBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TodayShowBtn.Image = ((System.Drawing.Image)(resources.GetObject("TodayShowBtn.Image")));
            this.TodayShowBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TodayShowBtn.Location = new System.Drawing.Point(243, 30);
            this.TodayShowBtn.Name = "TodayShowBtn";
            this.TodayShowBtn.Size = new System.Drawing.Size(211, 39);
            this.TodayShowBtn.TabIndex = 7;
            this.TodayShowBtn.Text = "      Bugünü Göster";
            this.TodayShowBtn.UseVisualStyleBackColor = false;
            this.TodayShowBtn.Click += new System.EventHandler(this.TodayShowBtn_Click);
            // 
            // DegerShowBtn
            // 
            this.DegerShowBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.DegerShowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DegerShowBtn.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DegerShowBtn.Image = ((System.Drawing.Image)(resources.GetObject("DegerShowBtn.Image")));
            this.DegerShowBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DegerShowBtn.Location = new System.Drawing.Point(619, 31);
            this.DegerShowBtn.Name = "DegerShowBtn";
            this.DegerShowBtn.Size = new System.Drawing.Size(211, 39);
            this.DegerShowBtn.TabIndex = 8;
            this.DegerShowBtn.Text = "         Girilen Tarihi Göster";
            this.DegerShowBtn.UseVisualStyleBackColor = false;
            this.DegerShowBtn.Click += new System.EventHandler(this.DegerShowBtn_Click);
            // 
            // ZamanTxt
            // 
            this.ZamanTxt.Location = new System.Drawing.Point(460, 40);
            this.ZamanTxt.Name = "ZamanTxt";
            this.ZamanTxt.Size = new System.Drawing.Size(153, 22);
            this.ZamanTxt.TabIndex = 9;
            // 
            // BiletTxt
            // 
            this.BiletTxt.Enabled = false;
            this.BiletTxt.Location = new System.Drawing.Point(57, 321);
            this.BiletTxt.Name = "BiletTxt";
            this.BiletTxt.Size = new System.Drawing.Size(124, 22);
            this.BiletTxt.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "En çok Bilet Satan İsim";
            // 
            // Istatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1037, 700);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BiletTxt);
            this.Controls.Add(this.ZamanTxt);
            this.Controls.Add(this.DegerShowBtn);
            this.Controls.Add(this.TodayShowBtn);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.sumUcret);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MoreCheckBox);
            this.Controls.Add(this.AllTimeShowBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Istatistik";
            this.Text = "Istatistik";
            this.Load += new System.EventHandler(this.Istatistik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AllTimeShowBtn;
        private System.Windows.Forms.CheckBox MoreCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sumUcret;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button TodayShowBtn;
        private System.Windows.Forms.Button DegerShowBtn;
        private System.Windows.Forms.TextBox ZamanTxt;
        private System.Windows.Forms.TextBox BiletTxt;
        private System.Windows.Forms.Label label2;
    }
}