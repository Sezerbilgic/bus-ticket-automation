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
    public partial class Istatistik : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-89P0D6Q;Initial Catalog=OtobüsOtomasyon;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        String yil;
        String ay;
        String gün;
        String Tarih;
        public Istatistik()
        {
            InitializeComponent();
        }

        public void Today()
        {
            DateTime dt = DateTime.Today;
            yil = Convert.ToString(dt.Year);
            ay = dt.ToString("MM");
            gün = Convert.ToString(dt.Day);

            Tarih = gün + "." + ay + "." + yil;
        }

        private void Istatistik_Load(object sender, EventArgs e)
        {
            TodayShowBtn.Visible = false;
            ZamanTxt.Visible = false;
            DegerShowBtn.Visible = false;
            MoreCheckBox.Location = new Point(MoreCheckBox.Location.X - 440, MoreCheckBox.Location.Y);
            MoreCheckBox.Text = "Daha Fazla";
            Today();
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select Admin.Kullanıcı_Adi, count(*) AS Adet from Admin inner join Biletler on  Admin.Admin_id = Biletler.Admin_id group by Admin.Kullanıcı_Adi ORDER BY Adet DESC";
            dr = cmd.ExecuteReader();               
            while (dr.Read())
            {
                    chart1.Series["Çalışanlar"].Points.AddXY(dr[0], dr[1]);

            }                       
            con.Close();
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select Admin.Kullanıcı_Adi, count(*) AS Adet from Admin inner join Biletler on  Admin.Admin_id = Biletler.Admin_id group by Admin.Kullanıcı_Adi ORDER BY Adet DESC";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                BiletTxt.Text = dr[0].ToString();
            }
            con.Close();
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select Sum(Ucret) from Biletler";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                sumUcret.Text = dr[0].ToString();
            }
            con.Close();

        }

        private void MoreCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MoreCheckBox.Checked)
            {
                TodayShowBtn.Visible = true;
                ZamanTxt.Visible = true;
                DegerShowBtn.Visible = true;
                MoreCheckBox.Location = new Point(MoreCheckBox.Location.X + 440, MoreCheckBox.Location.Y);
                MoreCheckBox.Text = "Daha Az";
            }
            else
            {
                TodayShowBtn.Visible = false;
                ZamanTxt.Visible = false;
                DegerShowBtn.Visible = false;
                MoreCheckBox.Location = new Point(MoreCheckBox.Location.X - 440, MoreCheckBox.Location.Y);
                MoreCheckBox.Text = "Daha Fazla";
            }
        }

        private void AllTimeShowBtn_Click(object sender, EventArgs e)
        {
            chart1.Series["Çalışanlar"].Points.Clear();
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select Admin.Kullanıcı_Adi, count(*) AS Adet from Admin inner join Biletler on  Admin.Admin_id = Biletler.Admin_id group by Admin.Kullanıcı_Adi ORDER BY Adet DESC";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                chart1.Series["Çalışanlar"].Points.AddXY(dr[0], dr[1]);
            }
            con.Close();
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select Admin.Kullanıcı_Adi, count(*) AS Adet from Admin inner join Biletler on  Admin.Admin_id = Biletler.Admin_id group by Admin.Kullanıcı_Adi ORDER BY Adet DESC";
            dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                BiletTxt.Text = dr[0].ToString();
            }
            con.Close();
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select Sum(Ucret) from Biletler";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                sumUcret.Text = dr[0].ToString();
            }
            con.Close();
        }

        private void TodayShowBtn_Click(object sender, EventArgs e)
        {
            chart1.Series["Çalışanlar"].Points.Clear();
            Today();
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select Admin.Kullanıcı_Adi, count(*) AS Adet from Admin inner join Biletler on  Admin.Admin_id = Biletler.Admin_id where SatisTarihi = '"+Tarih+ "' group by Admin.Kullanıcı_Adi ORDER BY Adet DESC";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                chart1.Series["Çalışanlar"].Points.AddXY(dr[0], dr[1]);
            }
            con.Close();
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select Admin.Kullanıcı_Adi, count(*) AS Adet from Admin inner join Biletler on  Admin.Admin_id = Biletler.Admin_id where SatisTarihi = '" + Tarih + "' group by Admin.Kullanıcı_Adi ORDER BY Adet DESC";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                BiletTxt.Text = dr[0].ToString();
            }
            con.Close();
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select Sum(Ucret) from Biletler where SatisTarihi = '" + Tarih + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                sumUcret.Text = dr[0].ToString();
            }
            con.Close();
        }

        private void DegerShowBtn_Click(object sender, EventArgs e)
        {
            if(ZamanTxt.Text == "")
            {
                MessageBox.Show("Boş bırakmayınız");
            }
            else
            {
                chart1.Series["Çalışanlar"].Points.Clear();
                // Today();
                Tarih = ZamanTxt.Text;
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Select Admin.Kullanıcı_Adi, count(*) AS Adet from Admin inner join Biletler on  Admin.Admin_id = Biletler.Admin_id where SatisTarihi = '" + Tarih + "' group by Admin.Kullanıcı_Adi ORDER BY Adet DESC";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    chart1.Series["Çalışanlar"].Points.AddXY(dr[0], dr[1]);
                }
                con.Close();
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Select Admin.Kullanıcı_Adi, count(*) AS Adet from Admin inner join Biletler on  Admin.Admin_id = Biletler.Admin_id where SatisTarihi = '"+ Tarih + "' group by Admin.Kullanıcı_Adi ORDER BY Adet DESC";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    BiletTxt.Text = dr[0].ToString();
                }
                con.Close();
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "select Sum(Ucret) from Biletler where SatisTarihi = '" + Tarih + "'";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    sumUcret.Text = dr[0].ToString();
                }
                con.Close();
            }
            
        }
    }
}
