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
    public partial class Seferler : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-89P0D6Q;Initial Catalog=OtobüsOtomasyon;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        public Seferler()
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

            dataGridViewSefer.DataSource = ds.Tables[0];

            dataGridViewSefer.Columns[0].HeaderText = "Sefer No";
            dataGridViewSefer.Columns[1].HeaderText = "Nereden";
            dataGridViewSefer.Columns[2].HeaderText = "Nereye";
            dataGridViewSefer.Columns[3].HeaderText = "Tarih";
            dataGridViewSefer.Columns[4].HeaderText = "Saat";
            dataGridViewSefer.Columns[5].HeaderText = "Ucret";

            dataGridViewSefer.Columns[0].Width = 70;
            dataGridViewSefer.Columns[1].Width = 100;
            dataGridViewSefer.Columns[2].Width = 100;
            dataGridViewSefer.Columns[3].Width = 80;
            dataGridViewSefer.Columns[4].Width = 70;
            dataGridViewSefer.Columns[5].Width = 70;
        }

        private void SeferGösterBtn_Click(object sender, EventArgs e)
        {
            SeferTxt.Visible = true;
            idlbl.Visible = true;
            verileriGöster("Select * From Seferler");
            toplamVeri("Select count(*) from Seferler");            
        }

        private void dataGridViewSefer_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            SeferTxt.Text = dataGridViewSefer.CurrentRow.Cells[0].Value.ToString();
            BaslangicTxtBox.Text = dataGridViewSefer.CurrentRow.Cells[1].Value.ToString();
            BitişTxtBox.Text = dataGridViewSefer.CurrentRow.Cells[2].Value.ToString();
            TarihTxtBox.Text = dataGridViewSefer.CurrentRow.Cells[3].Value.ToString();
            SaatTxtBox.Text = dataGridViewSefer.CurrentRow.Cells[4].Value.ToString();
            UcretTxtBox.Text = dataGridViewSefer.CurrentRow.Cells[5].Value.ToString();
        }

        private void SilmeBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("Delete From Seferler Where sefer_id = @id", con);
            komut.Parameters.AddWithValue("@id", SeferTxt.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Veri başarı ile silindi.");
            verileriGöster("Select * From Seferler");
            con.Close();

        }

        private void EkleBtn_Click(object sender, EventArgs e)
        {
            BiletBilgi.nereden = BaslangicTxtBox.Text;
            BiletBilgi.nereye = BitişTxtBox.Text;
            BiletBilgi.tarih = TarihTxtBox.Text;
            BiletBilgi.saat = SaatTxtBox.Text;
            BiletBilgi.ucret = UcretTxtBox.Text;
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Seferler (nereden,nereye,tarih,saat,ucret) Values ('" + BiletBilgi.nereden + "','" + BiletBilgi.nereye + "','" + BiletBilgi.tarih + "','"+BiletBilgi.saat+"','"+BiletBilgi.ucret+"')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Başarılı Kayıt");
            con.Close();
        }
    }
}
