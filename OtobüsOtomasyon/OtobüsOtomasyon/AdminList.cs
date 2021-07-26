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
    public partial class AdminList : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-89P0D6Q;Initial Catalog=OtobüsOtomasyon;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        public AdminList()
        {
            InitializeComponent();
        }
        private void toplamVeri(string veriler)
        {
            con.Open();
            SqlCommand komut = new SqlCommand(veriler, con);
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                sumveri.Text = dr[0].ToString();
            }
            con.Close();
        }
        public void verileriGöster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, con);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridViewAdmin.DataSource = ds.Tables[0];

            dataGridViewAdmin.Columns[0].HeaderText = "Admin No";
            dataGridViewAdmin.Columns[1].HeaderText = "Admin Adı";
            dataGridViewAdmin.Columns[2].HeaderText = "Admin Şifresi";
            dataGridViewAdmin.Columns[3].HeaderText = "Admin Yetkisi";
        }

        private void AdminShowBtn_Click(object sender, EventArgs e)
        {
            idlbl.Visible = true;
            AdminTxt.Visible = true;
            verileriGöster("Select * From Admin");
            toplamVeri("Select count(*) from Admin");
        }

        private void dataGridViewAdmin_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            AdminTxt.Text = dataGridViewAdmin.CurrentRow.Cells[0].Value.ToString();
            NickTxtBox.Text = dataGridViewAdmin.CurrentRow.Cells[1].Value.ToString();
            PassTxtBox.Text = dataGridViewAdmin.CurrentRow.Cells[2].Value.ToString();
            YetkiTxt.Text = dataGridViewAdmin.CurrentRow.Cells[3].Value.ToString();
        }

        private void SilmeBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("Delete From Admin Where Admin_id = @id", con);
            komut.Parameters.AddWithValue("@id", AdminTxt.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Veri başarı ile silindi.");
            verileriGöster("Select * From Admin");
            con.Close();
        }

        private void EkleBtn_Click(object sender, EventArgs e)
        {
            Yönetici.kAdi = NickTxtBox.Text;
            Yönetici.sifre = PassTxtBox.Text;
            Yönetici.yetki = YetkiTxt.Text;
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Admin (Kullanıcı_Adi,Sifre,Yetki) Values ('" + Yönetici.kAdi + "','" + Yönetici.sifre + "','" + Yönetici.yetki + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Başarılı Kayıt");
            con.Close();
            
        }

        private void KapatBtn_Click(object sender, EventArgs e)
        {
            dataGridViewAdmin.DataSource = null;
            dataGridViewAdmin.Rows.Clear();
            YetkiTxt.Text = "";
            PassTxtBox.Text = "";
            NickTxtBox.Text = "";
            AdminTxt.Text = "";
            AdminTxt.Visible = false;
            idlbl.Visible = false;
            sumveri.Text = "";
        }

        private void GüncelleBtn_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(NickTxtBox.Text.Trim()) || String.IsNullOrEmpty(PassTxtBox.Text.Trim()) || String.IsNullOrEmpty(YetkiTxt.Text.Trim()))
            {
                MessageBox.Show("Boş alan bırakmayınız.");
            }
            else
            {
                Yönetici.kAdi = NickTxtBox.Text;
                Yönetici.sifre = PassTxtBox.Text;
                Yönetici.yetki = YetkiTxt.Text;
                Yönetici.adminid = AdminTxt.Text;
                con.Open();
                SqlCommand cmd = new SqlCommand("Update Admin set Kullanıcı_Adi='"+Yönetici.kAdi+"' , Sifre ='"+Yönetici.sifre+"'  , Yetki = '"+Yönetici.yetki+"' where Admin_id = '"+Yönetici.adminid+"'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Başarılı Güncelleme");
                con.Close();
            }
            
        }
    }
}
