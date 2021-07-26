namespace OtobüsOtomasyon
{
    partial class Seferler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Seferler));
            this.idlbl = new System.Windows.Forms.Label();
            this.SeferTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EkleBtn = new System.Windows.Forms.Button();
            this.TarihTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SeferGösterBtn = new System.Windows.Forms.Button();
            this.dataGridViewSefer = new System.Windows.Forms.DataGridView();
            this.SaatTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UcretTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BitişTxtBox = new System.Windows.Forms.ComboBox();
            this.BaslangicTxtBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sumveri = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSefer)).BeginInit();
            this.SuspendLayout();
            // 
            // idlbl
            // 
            this.idlbl.AutoSize = true;
            this.idlbl.BackColor = System.Drawing.Color.Transparent;
            this.idlbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.idlbl.Location = new System.Drawing.Point(728, 79);
            this.idlbl.Name = "idlbl";
            this.idlbl.Size = new System.Drawing.Size(96, 23);
            this.idlbl.TabIndex = 27;
            this.idlbl.Text = "Sefer_id :";
            this.idlbl.Visible = false;
            // 
            // SeferTxt
            // 
            this.SeferTxt.Enabled = false;
            this.SeferTxt.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeferTxt.Location = new System.Drawing.Point(831, 78);
            this.SeferTxt.Name = "SeferTxt";
            this.SeferTxt.Size = new System.Drawing.Size(209, 28);
            this.SeferTxt.TabIndex = 26;
            this.SeferTxt.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(759, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tarih :";
            // 
            // EkleBtn
            // 
            this.EkleBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.EkleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EkleBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EkleBtn.Image = ((System.Drawing.Image)(resources.GetObject("EkleBtn.Image")));
            this.EkleBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EkleBtn.Location = new System.Drawing.Point(832, 358);
            this.EkleBtn.Name = "EkleBtn";
            this.EkleBtn.Size = new System.Drawing.Size(208, 43);
            this.EkleBtn.TabIndex = 21;
            this.EkleBtn.Text = "Sefer Ekle";
            this.EkleBtn.UseVisualStyleBackColor = false;
            this.EkleBtn.Click += new System.EventHandler(this.EkleBtn_Click);
            // 
            // TarihTxtBox
            // 
            this.TarihTxtBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TarihTxtBox.Location = new System.Drawing.Point(833, 219);
            this.TarihTxtBox.Name = "TarihTxtBox";
            this.TarihTxtBox.Size = new System.Drawing.Size(209, 28);
            this.TarihTxtBox.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(771, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Bitiş :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(708, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Başlangıç :";
            // 
            // SeferGösterBtn
            // 
            this.SeferGösterBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.SeferGösterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeferGösterBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SeferGösterBtn.Image = ((System.Drawing.Image)(resources.GetObject("SeferGösterBtn.Image")));
            this.SeferGösterBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SeferGösterBtn.Location = new System.Drawing.Point(12, 24);
            this.SeferGösterBtn.Name = "SeferGösterBtn";
            this.SeferGösterBtn.Size = new System.Drawing.Size(228, 49);
            this.SeferGösterBtn.TabIndex = 16;
            this.SeferGösterBtn.Text = "Seferleri Göster";
            this.SeferGösterBtn.UseVisualStyleBackColor = false;
            this.SeferGösterBtn.Click += new System.EventHandler(this.SeferGösterBtn_Click);
            // 
            // dataGridViewSefer
            // 
            this.dataGridViewSefer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSefer.Location = new System.Drawing.Point(12, 79);
            this.dataGridViewSefer.Name = "dataGridViewSefer";
            this.dataGridViewSefer.RowHeadersWidth = 51;
            this.dataGridViewSefer.RowTemplate.Height = 24;
            this.dataGridViewSefer.Size = new System.Drawing.Size(690, 604);
            this.dataGridViewSefer.TabIndex = 15;
            this.dataGridViewSefer.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSefer_CellEnter);
            // 
            // SaatTxtBox
            // 
            this.SaatTxtBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaatTxtBox.Location = new System.Drawing.Point(833, 267);
            this.SaatTxtBox.Name = "SaatTxtBox";
            this.SaatTxtBox.Size = new System.Drawing.Size(209, 28);
            this.SaatTxtBox.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(759, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 23);
            this.label4.TabIndex = 29;
            this.label4.Text = "Saat :";
            // 
            // UcretTxtBox
            // 
            this.UcretTxtBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UcretTxtBox.Location = new System.Drawing.Point(833, 314);
            this.UcretTxtBox.Name = "UcretTxtBox";
            this.UcretTxtBox.Size = new System.Drawing.Size(209, 28);
            this.UcretTxtBox.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(750, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 23);
            this.label5.TabIndex = 31;
            this.label5.Text = "Ücret :";
            // 
            // BitişTxtBox
            // 
            this.BitişTxtBox.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.BitişTxtBox.FormattingEnabled = true;
            this.BitişTxtBox.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Aksaray",
            "Amasya",
            "Ankara",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkâri",
            "Hatay",
            "Iğdır",
            "Isparta",
            "İstanbul",
            "İzmir",
            "Kahramanmaraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kilis",
            "Kırıkkale",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Mardin",
            "Mersin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Şanlıurfa",
            "Siirt",
            "Sinop",
            "Sivas",
            "Şırnak",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Uşak",
            "Van",
            "Yalova",
            "Yozgat",
            "Zonguldak"});
            this.BitişTxtBox.Location = new System.Drawing.Point(833, 176);
            this.BitişTxtBox.Name = "BitişTxtBox";
            this.BitişTxtBox.Size = new System.Drawing.Size(208, 29);
            this.BitişTxtBox.TabIndex = 25;
            // 
            // BaslangicTxtBox
            // 
            this.BaslangicTxtBox.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.BaslangicTxtBox.FormattingEnabled = true;
            this.BaslangicTxtBox.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Aksaray",
            "Amasya",
            "Ankara",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkâri",
            "Hatay",
            "Iğdır",
            "Isparta",
            "İstanbul",
            "İzmir",
            "Kahramanmaraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kilis",
            "Kırıkkale",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Mardin",
            "Mersin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Şanlıurfa",
            "Siirt",
            "Sinop",
            "Sivas",
            "Şırnak",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Uşak",
            "Van",
            "Yalova",
            "Yozgat",
            "Zonguldak"});
            this.BaslangicTxtBox.Location = new System.Drawing.Point(831, 128);
            this.BaslangicTxtBox.Name = "BaslangicTxtBox";
            this.BaslangicTxtBox.Size = new System.Drawing.Size(208, 29);
            this.BaslangicTxtBox.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 708);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Toplam Sefer :";
            // 
            // sumveri
            // 
            this.sumveri.AutoSize = true;
            this.sumveri.Location = new System.Drawing.Point(139, 708);
            this.sumveri.Name = "sumveri";
            this.sumveri.Size = new System.Drawing.Size(0, 17);
            this.sumveri.TabIndex = 34;
            // 
            // Seferler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1055, 747);
            this.Controls.Add(this.sumveri);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BaslangicTxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UcretTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SaatTxtBox);
            this.Controls.Add(this.idlbl);
            this.Controls.Add(this.SeferTxt);
            this.Controls.Add(this.BitişTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EkleBtn);
            this.Controls.Add(this.TarihTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SeferGösterBtn);
            this.Controls.Add(this.dataGridViewSefer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Seferler";
            this.Text = "Seferler";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSefer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label idlbl;
        private System.Windows.Forms.TextBox SeferTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button EkleBtn;
        private System.Windows.Forms.TextBox TarihTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SeferGösterBtn;
        private System.Windows.Forms.DataGridView dataGridViewSefer;
        private System.Windows.Forms.TextBox SaatTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UcretTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox BitişTxtBox;
        private System.Windows.Forms.ComboBox BaslangicTxtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label sumveri;
    }
}