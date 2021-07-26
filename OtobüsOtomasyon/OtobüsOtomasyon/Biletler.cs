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
    public partial class Biletler : Form
    {
        

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-89P0D6Q;Initial Catalog=OtobüsOtomasyon;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        public Biletler()
        {
            InitializeComponent();
        }

        

        public void verileriGöster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, con);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridViewBlt.DataSource = ds.Tables[0];

            dataGridViewBlt.Columns[0].HeaderText = "Bilet No";
            dataGridViewBlt.Columns[4].HeaderText = "TC No";
            dataGridViewBlt.Columns[9].HeaderText = "Koltuk No";
            dataGridViewBlt.Columns[11].HeaderText = "Admin No";
            dataGridViewBlt.Columns[12].HeaderText = "Satış Tarihi";
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

        private void AdminShowBtn_Click(object sender, EventArgs e)
        {
            verileriGöster("Select * From Biletler");
            toplamVeri("Select count(*) from Biletler");
        }

        private void dataGridViewBlt_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            idTxt.Text = dataGridViewBlt.CurrentRow.Cells[0].Value.ToString();
            IsimTxt.Text = dataGridViewBlt.CurrentRow.Cells[1].Value.ToString();
            SoyisimTxt.Text = dataGridViewBlt.CurrentRow.Cells[2].Value.ToString();
            TelefonTxt.Text = dataGridViewBlt.CurrentRow.Cells[3].Value.ToString();
            TcTxt.Text = dataGridViewBlt.CurrentRow.Cells[4].Value.ToString();
            NeredenTxt.Text = dataGridViewBlt.CurrentRow.Cells[5].Value.ToString();
            NereyeTxt.Text = dataGridViewBlt.CurrentRow.Cells[6].Value.ToString();
            TarihTxt.Text = dataGridViewBlt.CurrentRow.Cells[7].Value.ToString();
            UcretTxt.Text = dataGridViewBlt.CurrentRow.Cells[8].Value.ToString();
            KoltukTxt.Text = dataGridViewBlt.CurrentRow.Cells[9].Value.ToString();
            SaatTxt.Text = dataGridViewBlt.CurrentRow.Cells[10].Value.ToString();
        }

        private void BiletSilBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("Delete From Biletler Where Bilet_id = @id", con);
            komut.Parameters.AddWithValue("@id", idTxt.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Veri başarı ile silindi.");
            verileriGöster("Select * From Biletler");
            con.Close();
           
        }

        private void BiletUpdateBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(IsimTxt.Text.Trim()) || String.IsNullOrEmpty(SoyisimTxt.Text.Trim()) || String.IsNullOrEmpty(TelefonTxt.Text.Trim()) || String.IsNullOrEmpty(TcTxt.Text.Trim()))
            {
                MessageBox.Show("Boş alan bırakmayınız.");
            }
            else
            {
                BiletBilgi.id = idTxt.Text;
                BiletBilgi.isim = IsimTxt.Text;
                BiletBilgi.soyisim = SoyisimTxt.Text;
                BiletBilgi.telefon = Convert.ToString(TelefonTxt.Text);
                BiletBilgi.tcno = TcTxt.Text;
                con.Open();
                SqlCommand cmd = new SqlCommand("Update Biletler set İsim ='" + BiletBilgi.isim + "' , Soyisim ='" +BiletBilgi.soyisim  + "'  , Telefon = '" + BiletBilgi.telefon + "' , Tc_no = '"+BiletBilgi.tcno+"' where Bilet_id = '" + BiletBilgi.id + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Başarılı Güncelleme");
                verileriGöster("Select * From Biletler");
                con.Close();
            }
        }
    }
}
