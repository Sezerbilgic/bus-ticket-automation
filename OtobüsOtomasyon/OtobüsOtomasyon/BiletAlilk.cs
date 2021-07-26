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

    public partial class BiletAlilk : Form
    {
        public string CustomFormat { get; set; }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-89P0D6Q;Initial Catalog=OtobüsOtomasyon;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        public BiletAlilk()
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

        public void Reset()
        {
            DataGridViewSefer.DataSource = null;
            DataGridViewSefer.Rows.Clear();
            NrdnCombo.ResetText();
            NryCombo.ResetText();
            NeredenTxt.Clear();
            NereyeTxt.Clear();
            TarihTxt.Clear();
            SaatTxt.Clear();
            UcretTxt.Clear();
        }

        private void KoltukSecBtn_Click(object sender, EventArgs e)
        {
            BiletBilgi.nereden = NeredenTxt.Text;
            BiletBilgi.nereye = NereyeTxt.Text;
            BiletBilgi.tarih = TarihTxt.Text;
            BiletBilgi.saat = SaatTxt.Text;
            BiletBilgi.ucret = UcretTxt.Text;

            BiletAlDevam Bad = new BiletAlDevam();

           /* BackBtn.Visible = true;
            Panel.Visible = true;
            Bad.Dock = DockStyle.Fill;
            Bad.TopLevel = false;
            Bad.FormBorderStyle = FormBorderStyle.None;
            Panel.Controls.Add(Bad);*/

            Bad.Show();
            


        }

        

        public void verileriGöster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, con);
            DataSet ds = new DataSet();
            da.Fill(ds);

            DataGridViewSefer.DataSource = ds.Tables[0];

            DataGridViewSefer.Columns[0].HeaderText = "Sefer No";
            DataGridViewSefer.Columns[1].HeaderText = "Nereden";
            DataGridViewSefer.Columns[2].HeaderText = "Nereye";
            DataGridViewSefer.Columns[3].HeaderText = "Tarih";
            DataGridViewSefer.Columns[4].HeaderText = "Saat";
            DataGridViewSefer.Columns[5].HeaderText = "Ucret";
        }

        private void SeferBtn_Click(object sender, EventArgs e)
        {

            verileriGöster("Select * from Seferler where nereden ='" + NrdnCombo.Text + "' and nereye = '" + NryCombo.Text + "' and tarih='"+TarihTxtBox.Text+"'");
            toplamVeri("Select count(*) from Seferler where nereden ='" + NrdnCombo.Text + "' and nereye = '" + NryCombo.Text + "' and tarih='" + TarihTxtBox.Text + "'");
        }

        private void DataGridViewSefer_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            NeredenTxt.Text = DataGridViewSefer.CurrentRow.Cells[1].Value.ToString();
            NereyeTxt.Text = DataGridViewSefer.CurrentRow.Cells[2].Value.ToString();
            TarihTxt.Text = DataGridViewSefer.CurrentRow.Cells[3].Value.ToString();
            SaatTxt.Text = DataGridViewSefer.CurrentRow.Cells[4].Value.ToString();
            UcretTxt.Text = DataGridViewSefer.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
