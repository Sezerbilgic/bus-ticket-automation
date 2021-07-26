namespace OtobüsOtomasyon
{
    partial class AdminList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminList));
            this.dataGridViewAdmin = new System.Windows.Forms.DataGridView();
            this.AdminShowBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NickTxtBox = new System.Windows.Forms.TextBox();
            this.PassTxtBox = new System.Windows.Forms.TextBox();
            this.EkleBtn = new System.Windows.Forms.Button();
            this.SilmeBtn = new System.Windows.Forms.Button();
            this.GüncelleBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.YetkiTxt = new System.Windows.Forms.ComboBox();
            this.AdminTxt = new System.Windows.Forms.TextBox();
            this.idlbl = new System.Windows.Forms.Label();
            this.KapatBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.sumveri = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAdmin
            // 
            this.dataGridViewAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdmin.Location = new System.Drawing.Point(26, 86);
            this.dataGridViewAdmin.Name = "dataGridViewAdmin";
            this.dataGridViewAdmin.RowHeadersWidth = 51;
            this.dataGridViewAdmin.RowTemplate.Height = 24;
            this.dataGridViewAdmin.Size = new System.Drawing.Size(605, 595);
            this.dataGridViewAdmin.TabIndex = 0;
            this.dataGridViewAdmin.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAdmin_CellEnter);
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
            this.AdminShowBtn.Size = new System.Drawing.Size(211, 39);
            this.AdminShowBtn.TabIndex = 1;
            this.AdminShowBtn.Text = "  Çalışanları Göster";
            this.AdminShowBtn.UseVisualStyleBackColor = false;
            this.AdminShowBtn.Click += new System.EventHandler(this.AdminShowBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(668, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(753, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre :";
            // 
            // NickTxtBox
            // 
            this.NickTxtBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NickTxtBox.Location = new System.Drawing.Point(818, 176);
            this.NickTxtBox.Name = "NickTxtBox";
            this.NickTxtBox.Size = new System.Drawing.Size(209, 28);
            this.NickTxtBox.TabIndex = 4;
            // 
            // PassTxtBox
            // 
            this.PassTxtBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassTxtBox.Location = new System.Drawing.Point(818, 224);
            this.PassTxtBox.Name = "PassTxtBox";
            this.PassTxtBox.Size = new System.Drawing.Size(209, 28);
            this.PassTxtBox.TabIndex = 5;
            // 
            // EkleBtn
            // 
            this.EkleBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.EkleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EkleBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EkleBtn.Image = ((System.Drawing.Image)(resources.GetObject("EkleBtn.Image")));
            this.EkleBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EkleBtn.Location = new System.Drawing.Point(818, 337);
            this.EkleBtn.Name = "EkleBtn";
            this.EkleBtn.Size = new System.Drawing.Size(208, 43);
            this.EkleBtn.TabIndex = 6;
            this.EkleBtn.Text = "Çalışan Ekle";
            this.EkleBtn.UseVisualStyleBackColor = false;
            this.EkleBtn.Click += new System.EventHandler(this.EkleBtn_Click);
            // 
            // SilmeBtn
            // 
            this.SilmeBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.SilmeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SilmeBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SilmeBtn.Image = ((System.Drawing.Image)(resources.GetObject("SilmeBtn.Image")));
            this.SilmeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SilmeBtn.Location = new System.Drawing.Point(818, 397);
            this.SilmeBtn.Name = "SilmeBtn";
            this.SilmeBtn.Size = new System.Drawing.Size(208, 43);
            this.SilmeBtn.TabIndex = 7;
            this.SilmeBtn.Text = "Çalışanı Sil";
            this.SilmeBtn.UseVisualStyleBackColor = false;
            this.SilmeBtn.Click += new System.EventHandler(this.SilmeBtn_Click);
            // 
            // GüncelleBtn
            // 
            this.GüncelleBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.GüncelleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GüncelleBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GüncelleBtn.Image = ((System.Drawing.Image)(resources.GetObject("GüncelleBtn.Image")));
            this.GüncelleBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GüncelleBtn.Location = new System.Drawing.Point(818, 460);
            this.GüncelleBtn.Name = "GüncelleBtn";
            this.GüncelleBtn.Size = new System.Drawing.Size(208, 43);
            this.GüncelleBtn.TabIndex = 8;
            this.GüncelleBtn.Text = "Güncelle";
            this.GüncelleBtn.UseVisualStyleBackColor = false;
            this.GüncelleBtn.Click += new System.EventHandler(this.GüncelleBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(745, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Yetki :";
            // 
            // YetkiTxt
            // 
            this.YetkiTxt.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.YetkiTxt.FormattingEnabled = true;
            this.YetkiTxt.Items.AddRange(new object[] {
            "Yönetici",
            "Görevli"});
            this.YetkiTxt.Location = new System.Drawing.Point(819, 267);
            this.YetkiTxt.Name = "YetkiTxt";
            this.YetkiTxt.Size = new System.Drawing.Size(208, 29);
            this.YetkiTxt.TabIndex = 11;
            // 
            // AdminTxt
            // 
            this.AdminTxt.Enabled = false;
            this.AdminTxt.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminTxt.Location = new System.Drawing.Point(819, 127);
            this.AdminTxt.Name = "AdminTxt";
            this.AdminTxt.Size = new System.Drawing.Size(209, 28);
            this.AdminTxt.TabIndex = 12;
            this.AdminTxt.Visible = false;
            // 
            // idlbl
            // 
            this.idlbl.AutoSize = true;
            this.idlbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.idlbl.Location = new System.Drawing.Point(694, 128);
            this.idlbl.Name = "idlbl";
            this.idlbl.Size = new System.Drawing.Size(111, 23);
            this.idlbl.TabIndex = 13;
            this.idlbl.Text = "Admin_id :";
            this.idlbl.Visible = false;
            // 
            // KapatBtn
            // 
            this.KapatBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.KapatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KapatBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KapatBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KapatBtn.Location = new System.Drawing.Point(255, 31);
            this.KapatBtn.Name = "KapatBtn";
            this.KapatBtn.Size = new System.Drawing.Size(165, 39);
            this.KapatBtn.TabIndex = 14;
            this.KapatBtn.Text = "Çalışanları Kapat";
            this.KapatBtn.UseVisualStyleBackColor = false;
            this.KapatBtn.Click += new System.EventHandler(this.KapatBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 709);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Toplam Çalışan :";
            // 
            // sumveri
            // 
            this.sumveri.AutoSize = true;
            this.sumveri.Location = new System.Drawing.Point(161, 709);
            this.sumveri.Name = "sumveri";
            this.sumveri.Size = new System.Drawing.Size(0, 17);
            this.sumveri.TabIndex = 16;
            // 
            // AdminList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1055, 747);
            this.Controls.Add(this.sumveri);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.KapatBtn);
            this.Controls.Add(this.idlbl);
            this.Controls.Add(this.AdminTxt);
            this.Controls.Add(this.YetkiTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GüncelleBtn);
            this.Controls.Add(this.SilmeBtn);
            this.Controls.Add(this.EkleBtn);
            this.Controls.Add(this.PassTxtBox);
            this.Controls.Add(this.NickTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdminShowBtn);
            this.Controls.Add(this.dataGridViewAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AdminList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAdmin;
        private System.Windows.Forms.Button AdminShowBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NickTxtBox;
        private System.Windows.Forms.TextBox PassTxtBox;
        private System.Windows.Forms.Button EkleBtn;
        private System.Windows.Forms.Button SilmeBtn;
        private System.Windows.Forms.Button GüncelleBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox YetkiTxt;
        private System.Windows.Forms.TextBox AdminTxt;
        private System.Windows.Forms.Label idlbl;
        private System.Windows.Forms.Button KapatBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label sumveri;
    }
}