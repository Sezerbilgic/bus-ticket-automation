namespace OtobüsOtomasyon
{
    partial class Biletler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Biletler));
            this.AdminShowBtn = new System.Windows.Forms.Button();
            this.dataGridViewBlt = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.IsimTxt = new System.Windows.Forms.TextBox();
            this.SoyisimTxt = new System.Windows.Forms.TextBox();
            this.TcTxt = new System.Windows.Forms.TextBox();
            this.KoltukTxt = new System.Windows.Forms.TextBox();
            this.UcretTxt = new System.Windows.Forms.TextBox();
            this.NeredenTxt = new System.Windows.Forms.ComboBox();
            this.NereyeTxt = new System.Windows.Forms.ComboBox();
            this.TelefonTxt = new System.Windows.Forms.MaskedTextBox();
            this.BiletSilBtn = new System.Windows.Forms.Button();
            this.BiletUpdateBtn = new System.Windows.Forms.Button();
            this.TarihTxt = new System.Windows.Forms.TextBox();
            this.SaatTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.sumveri = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBlt)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminShowBtn
            // 
            this.AdminShowBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.AdminShowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminShowBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AdminShowBtn.Image = ((System.Drawing.Image)(resources.GetObject("AdminShowBtn.Image")));
            this.AdminShowBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdminShowBtn.Location = new System.Drawing.Point(28, 31);
            this.AdminShowBtn.Name = "AdminShowBtn";
            this.AdminShowBtn.Size = new System.Drawing.Size(237, 49);
            this.AdminShowBtn.TabIndex = 2;
            this.AdminShowBtn.Text = "Biletleri Göster";
            this.AdminShowBtn.UseVisualStyleBackColor = false;
            this.AdminShowBtn.Click += new System.EventHandler(this.AdminShowBtn_Click);
            // 
            // dataGridViewBlt
            // 
            this.dataGridViewBlt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBlt.Location = new System.Drawing.Point(26, 86);
            this.dataGridViewBlt.Name = "dataGridViewBlt";
            this.dataGridViewBlt.RowHeadersWidth = 51;
            this.dataGridViewBlt.RowTemplate.Height = 24;
            this.dataGridViewBlt.Size = new System.Drawing.Size(729, 611);
            this.dataGridViewBlt.TabIndex = 3;
            this.dataGridViewBlt.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBlt_CellEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(798, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "İsim :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(774, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Soyisim :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(774, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefon :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(784, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tc No :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(761, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Koltuk No :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(767, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nereden :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(776, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Nereye :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(789, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Tarih :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(789, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Ücret :";
            // 
            // IsimTxt
            // 
            this.IsimTxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IsimTxt.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IsimTxt.Location = new System.Drawing.Point(844, 115);
            this.IsimTxt.Name = "IsimTxt";
            this.IsimTxt.Size = new System.Drawing.Size(199, 23);
            this.IsimTxt.TabIndex = 13;
            // 
            // SoyisimTxt
            // 
            this.SoyisimTxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SoyisimTxt.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SoyisimTxt.Location = new System.Drawing.Point(844, 141);
            this.SoyisimTxt.Name = "SoyisimTxt";
            this.SoyisimTxt.Size = new System.Drawing.Size(199, 23);
            this.SoyisimTxt.TabIndex = 14;
            // 
            // TcTxt
            // 
            this.TcTxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TcTxt.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TcTxt.Location = new System.Drawing.Point(844, 199);
            this.TcTxt.Name = "TcTxt";
            this.TcTxt.Size = new System.Drawing.Size(199, 23);
            this.TcTxt.TabIndex = 16;
            // 
            // KoltukTxt
            // 
            this.KoltukTxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.KoltukTxt.Enabled = false;
            this.KoltukTxt.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KoltukTxt.Location = new System.Drawing.Point(844, 290);
            this.KoltukTxt.Name = "KoltukTxt";
            this.KoltukTxt.Size = new System.Drawing.Size(199, 23);
            this.KoltukTxt.TabIndex = 17;
            // 
            // UcretTxt
            // 
            this.UcretTxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UcretTxt.Enabled = false;
            this.UcretTxt.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UcretTxt.Location = new System.Drawing.Point(844, 344);
            this.UcretTxt.Name = "UcretTxt";
            this.UcretTxt.Size = new System.Drawing.Size(199, 23);
            this.UcretTxt.TabIndex = 21;
            // 
            // NeredenTxt
            // 
            this.NeredenTxt.Enabled = false;
            this.NeredenTxt.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NeredenTxt.FormattingEnabled = true;
            this.NeredenTxt.Location = new System.Drawing.Point(844, 228);
            this.NeredenTxt.Name = "NeredenTxt";
            this.NeredenTxt.Size = new System.Drawing.Size(200, 25);
            this.NeredenTxt.TabIndex = 23;
            // 
            // NereyeTxt
            // 
            this.NereyeTxt.Enabled = false;
            this.NereyeTxt.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NereyeTxt.FormattingEnabled = true;
            this.NereyeTxt.Location = new System.Drawing.Point(844, 259);
            this.NereyeTxt.Name = "NereyeTxt";
            this.NereyeTxt.Size = new System.Drawing.Size(200, 25);
            this.NereyeTxt.TabIndex = 24;
            // 
            // TelefonTxt
            // 
            this.TelefonTxt.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TelefonTxt.Location = new System.Drawing.Point(844, 170);
            this.TelefonTxt.Mask = "(999) 000-0000";
            this.TelefonTxt.Name = "TelefonTxt";
            this.TelefonTxt.Size = new System.Drawing.Size(199, 23);
            this.TelefonTxt.TabIndex = 25;
            // 
            // BiletSilBtn
            // 
            this.BiletSilBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.BiletSilBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BiletSilBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BiletSilBtn.Image = ((System.Drawing.Image)(resources.GetObject("BiletSilBtn.Image")));
            this.BiletSilBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BiletSilBtn.Location = new System.Drawing.Point(845, 419);
            this.BiletSilBtn.Name = "BiletSilBtn";
            this.BiletSilBtn.Size = new System.Drawing.Size(199, 46);
            this.BiletSilBtn.TabIndex = 26;
            this.BiletSilBtn.Text = "Bileti Sil";
            this.BiletSilBtn.UseVisualStyleBackColor = false;
            this.BiletSilBtn.Click += new System.EventHandler(this.BiletSilBtn_Click);
            // 
            // BiletUpdateBtn
            // 
            this.BiletUpdateBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.BiletUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BiletUpdateBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BiletUpdateBtn.Image = ((System.Drawing.Image)(resources.GetObject("BiletUpdateBtn.Image")));
            this.BiletUpdateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BiletUpdateBtn.Location = new System.Drawing.Point(845, 471);
            this.BiletUpdateBtn.Name = "BiletUpdateBtn";
            this.BiletUpdateBtn.Size = new System.Drawing.Size(200, 43);
            this.BiletUpdateBtn.TabIndex = 27;
            this.BiletUpdateBtn.Text = "Güncelle";
            this.BiletUpdateBtn.UseVisualStyleBackColor = false;
            this.BiletUpdateBtn.Click += new System.EventHandler(this.BiletUpdateBtn_Click);
            // 
            // TarihTxt
            // 
            this.TarihTxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TarihTxt.Enabled = false;
            this.TarihTxt.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TarihTxt.Location = new System.Drawing.Point(844, 318);
            this.TarihTxt.Name = "TarihTxt";
            this.TarihTxt.Size = new System.Drawing.Size(199, 23);
            this.TarihTxt.TabIndex = 28;
            // 
            // SaatTxt
            // 
            this.SaatTxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SaatTxt.Enabled = false;
            this.SaatTxt.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SaatTxt.Location = new System.Drawing.Point(844, 373);
            this.SaatTxt.Name = "SaatTxt";
            this.SaatTxt.Size = new System.Drawing.Size(199, 23);
            this.SaatTxt.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(793, 376);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 17);
            this.label10.TabIndex = 30;
            this.label10.Text = "Saat :";
            // 
            // idTxt
            // 
            this.idTxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.idTxt.Enabled = false;
            this.idTxt.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.idTxt.Location = new System.Drawing.Point(844, 86);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(199, 23);
            this.idTxt.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(773, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 17);
            this.label11.TabIndex = 32;
            this.label11.Text = "Bilet No :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(37, 712);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 17);
            this.label12.TabIndex = 33;
            this.label12.Text = "Toplam Bilet :";
            // 
            // sumveri
            // 
            this.sumveri.AutoSize = true;
            this.sumveri.Location = new System.Drawing.Point(137, 712);
            this.sumveri.Name = "sumveri";
            this.sumveri.Size = new System.Drawing.Size(0, 17);
            this.sumveri.TabIndex = 34;
            // 
            // Biletler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1055, 747);
            this.Controls.Add(this.sumveri);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.SaatTxt);
            this.Controls.Add(this.TarihTxt);
            this.Controls.Add(this.BiletUpdateBtn);
            this.Controls.Add(this.BiletSilBtn);
            this.Controls.Add(this.TelefonTxt);
            this.Controls.Add(this.NereyeTxt);
            this.Controls.Add(this.NeredenTxt);
            this.Controls.Add(this.UcretTxt);
            this.Controls.Add(this.KoltukTxt);
            this.Controls.Add(this.TcTxt);
            this.Controls.Add(this.SoyisimTxt);
            this.Controls.Add(this.IsimTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewBlt);
            this.Controls.Add(this.AdminShowBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Biletler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Biletler";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBlt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AdminShowBtn;
        private System.Windows.Forms.DataGridView dataGridViewBlt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox IsimTxt;
        private System.Windows.Forms.TextBox SoyisimTxt;
        private System.Windows.Forms.TextBox TcTxt;
        private System.Windows.Forms.TextBox KoltukTxt;
        private System.Windows.Forms.TextBox UcretTxt;
        private System.Windows.Forms.ComboBox NeredenTxt;
        private System.Windows.Forms.ComboBox NereyeTxt;
        private System.Windows.Forms.MaskedTextBox TelefonTxt;
        private System.Windows.Forms.Button BiletSilBtn;
        private System.Windows.Forms.Button BiletUpdateBtn;
        private System.Windows.Forms.TextBox TarihTxt;
        private System.Windows.Forms.TextBox SaatTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label sumveri;
    }
}