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
    public partial class GirisSayfasi : Form
    {
        AdminPage As = new AdminPage();
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-89P0D6Q;Initial Catalog=OtobüsOtomasyon;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        


        public GirisSayfasi()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Yönetici.kAdi = NickTxt.Text;
            Yönetici.sifre = SifreTxt.Text;
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select Admin_id From Admin where Kullanıcı_Adi='" + Yönetici.kAdi + "' AND Sifre='" + Yönetici.sifre + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Yönetici.adminid = dr[0].ToString();
                this.Hide();
                As.Show();
            }
            dr.Close();
            con.Close();
            
        }

        private void PassShowBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (PassShowBtn.Checked)
            {
                SifreTxt.UseSystemPasswordChar = false;
            }
            else
            {
                SifreTxt.UseSystemPasswordChar = true;
            }
        }
    }
}
