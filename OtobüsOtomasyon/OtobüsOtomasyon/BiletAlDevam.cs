using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OtobüsOtomasyon
{
    public partial class BiletAlDevam : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-89P0D6Q;Initial Catalog=OtobüsOtomasyon;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        

        public void GecmisBilgi()
        {
            con.Open();
            
            SqlCommand cmd = new SqlCommand("Select * from Biletler where Baslangic ='" + BiletBilgi.nereden + "' and Bitis ='" + BiletBilgi.nereye + "' and Tarih = '" + BiletBilgi.tarih + "' and Saat ='" + BiletBilgi.saat + "'",con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                BiletBilgi.koltukno = dr[9].ToString();
                this.Controls.Find("btn" + BiletBilgi.koltukno, true)[0].BackColor = Color.Red;
                this.Controls.Find("btn" + BiletBilgi.koltukno, true)[0].Enabled = false;

            }
            con.Close();
            
        }
        

        public BiletAlDevam()
        {
            InitializeComponent();
        }

        private void BtnKoltuk_Click(object sender, EventArgs e)
        {
            if (((Button)sender).BackColor == Color.YellowGreen)
            {
                ((Button)sender).BackColor = Color.Cyan;
                KoltukNoTxtBox.Text = ((Button)sender).Text;
            }
            else if(((Button)sender).BackColor == Color.Cyan)
            {
                ((Button)sender).BackColor = Color.YellowGreen;
                KoltukNoTxtBox.Text = "";
            }
        }
        private void BiletAlDevam_Load(object sender, EventArgs e)
        {
            NeredenTxtBox.Text = BiletBilgi.nereden;
            NereyeTxtBox.Text = BiletBilgi.nereye;
            TarihTxtBox.Text = BiletBilgi.tarih;
            SaatTxtBox.Text = BiletBilgi.saat;
            UcretTxtBox.Text = BiletBilgi.ucret;
            GecmisBilgi();
        }
        
        public void TarihTespit()
        {
            DateTime dt = DateTime.Today;
            String yil = Convert.ToString(dt.Year);
            String ay = dt.ToString("MM");
            String gün = Convert.ToString(dt.Day);

            String Tarih = gün + "." + ay + "." + yil;

            BiletBilgi.satisTarihi = Tarih;
        }

        private void BiletAlBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(İsimTxtBox.Text) || String.IsNullOrEmpty(SoyisimTxtBox.Text) || String.IsNullOrEmpty(TelefonTxtBox.Text) || String.IsNullOrEmpty(TcnoTxtBox.Text))
            {
                MessageBox.Show("Boş alan bırakmayınız.");
            }
            else
            {
                TarihTespit();
                BiletBilgi.isim = İsimTxtBox.Text;
                BiletBilgi.soyisim = SoyisimTxtBox.Text;
                BiletBilgi.telefon = Convert.ToString(TelefonTxtBox.Text);
                BiletBilgi.tcno = TcnoTxtBox.Text;
                BiletBilgi.koltukno = KoltukNoTxtBox.Text;
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into Biletler(İsim,Soyisim,Telefon,Tc_no,Baslangic,Bitis,Tarih,Ucret,Koltuk_no,Saat,Admin_id,SatisTarihi) Values ('" + BiletBilgi.isim + "','" + BiletBilgi.soyisim + "','" + BiletBilgi.telefon + "','" + BiletBilgi.tcno + "','" + BiletBilgi.nereden + "','" + BiletBilgi.nereye + "','" + BiletBilgi.tarih + "','" + BiletBilgi.ucret + "','" + BiletBilgi.koltukno + "','" + BiletBilgi.saat + "','" + Yönetici.adminid + "','" + BiletBilgi.satisTarihi + "')", con);
                cmd.ExecuteNonQuery();
                this.Controls.Find("btn" + BiletBilgi.koltukno, true)[0].BackColor = Color.Red;
                this.Controls.Find("btn" + BiletBilgi.koltukno, true)[0].Enabled = false;
                MessageBox.Show("Başarılı Kayıt");
                con.Close();
            }
            
        }
    }
}
