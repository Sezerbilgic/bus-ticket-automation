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
    public partial class AdminPage : Form
    {
        Anasayfa As = new Anasayfa();
        Istatistik Is = new Istatistik();
        AdminList Al = new AdminList();
        Biletler Ticket = new Biletler();
        BiletAlilk Ba = new BiletAlilk();
        Seferler Se = new Seferler();
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-89P0D6Q;Initial Catalog=OtobüsOtomasyon;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        

        public AdminPage()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Application.Exit();
        }

        private void AdminPicBox_Click(object sender, EventArgs e)
        {
            ShowPanel.Controls.Remove(As);
            ShowPanel.Controls.Remove(Is);
            ShowPanel.Controls.Remove(Ba);
            ShowPanel.Controls.Remove(Ticket);
            ShowPanel.Controls.Remove(Se);
            Al.Dock = DockStyle.Fill;
            Al.TopLevel = false;
            Al.FormBorderStyle = FormBorderStyle.None;
            ShowPanel.Controls.Add(Al);
            Al.Show();
        }

        private void BiletPicBox_Click(object sender, EventArgs e)
        {
            ShowPanel.Controls.Remove(As);
            ShowPanel.Controls.Remove(Is);
            ShowPanel.Controls.Remove(Ba);
            ShowPanel.Controls.Remove(Al);
            ShowPanel.Controls.Remove(Se);
            Ticket.Dock = DockStyle.Fill;
            Ticket.TopLevel = false;
            Ticket.FormBorderStyle = FormBorderStyle.None;
            ShowPanel.Controls.Add(Ticket);
            Ticket.Show();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            As.Dock = DockStyle.Fill;
            As.TopLevel = false;
            As.FormBorderStyle = FormBorderStyle.None;
            ShowPanel.Controls.Add(As);
            As.Show();
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select * From Admin where Kullanıcı_Adi='" + Yönetici.kAdi + "' AND Yetki = 'Yönetici'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                con.Close();
            }
            else
            {
                AdminPicBox.Visible = false;
                LblYönetici.Visible = false;
                SeferPicBox.Visible = false;
                LblSefer.Visible = false;
                IstatistikPicBox.Visible = false;
                lblIstatistik.Visible = false;
                BiletPicBox.Location = new Point(BiletPicBox.Location.X - 77, BiletPicBox.Location.Y);
                lblBiletler.Location = new Point(lblBiletler.Location.X - 82, lblBiletler.Location.Y);
            }
            

        }

        private void BiletAlPicBox_Click(object sender, EventArgs e)
        {
            ShowPanel.Controls.Remove(As);
            ShowPanel.Controls.Remove(Is);
            ShowPanel.Controls.Remove(Ticket);
            ShowPanel.Controls.Remove(Al);
            ShowPanel.Controls.Remove(Se);
            Ba.Dock = DockStyle.Fill;
            Ba.TopLevel = false;
            Ba.FormBorderStyle = FormBorderStyle.None;
            ShowPanel.Controls.Add(Ba);
            Ba.Show();
        }

        private void SeferPicBox_Click(object sender, EventArgs e)
        {
            ShowPanel.Controls.Remove(As);
            ShowPanel.Controls.Remove(Is);
            ShowPanel.Controls.Remove(Ticket);
            ShowPanel.Controls.Remove(Al);
            ShowPanel.Controls.Remove(Ba);
            Se.Dock = DockStyle.Fill;
            Se.TopLevel = false;
            Se.FormBorderStyle = FormBorderStyle.None;
            ShowPanel.Controls.Add(Se);
            Se.Show();
        }

        private void IstatistikPicBox_Click(object sender, EventArgs e)
        {
            ShowPanel.Controls.Remove(As);
            ShowPanel.Controls.Remove(Se);
            ShowPanel.Controls.Remove(Ticket);
            ShowPanel.Controls.Remove(Al);
            ShowPanel.Controls.Remove(Ba);
            Is.Dock = DockStyle.Fill;
            Is.TopLevel = false;
            Is.FormBorderStyle = FormBorderStyle.None;
            ShowPanel.Controls.Add(Is);
            Is.Show();
        }

        private void AnasayfaPicBox_Click(object sender, EventArgs e)
        {
            ShowPanel.Controls.Remove(Is);
            ShowPanel.Controls.Remove(Se);
            ShowPanel.Controls.Remove(Ticket);
            ShowPanel.Controls.Remove(Al);
            ShowPanel.Controls.Remove(Ba);
            As.Dock = DockStyle.Fill;
            As.TopLevel = false;
            As.FormBorderStyle = FormBorderStyle.None;
            ShowPanel.Controls.Add(As);
            As.Show();
        }

        private void IstatistikPicBox_Hover(object sender, EventArgs e)
        {
            IstatistikPicBox.Image = Image.FromFile(Application.StartupPath + "\\charthover.png");
            lblIstatistik.ForeColor = Color.Red;
        }

        private void IstatistikPicBox_Leave(object sender,EventArgs e) 
        {
            IstatistikPicBox.Image = Image.FromFile(Application.StartupPath + "\\barchart.png");
            lblIstatistik.ForeColor = Color.Black;
        }

        private void AdminPicBox_Hover(object sender, EventArgs e)
        {
            AdminPicBox.Image = Image.FromFile(Application.StartupPath + "\\Adminred.png");
            LblYönetici.ForeColor = Color.Red;
        }

        private void AdminPicBox_Leave(object sender, EventArgs e)
        {
            AdminPicBox.Image = Image.FromFile(Application.StartupPath + "\\Adminblack.png");
            LblYönetici.ForeColor = Color.Black;
        }

        private void SeferPicBox_Hover(object sender, EventArgs e)
        {
            SeferPicBox.Image = Image.FromFile(Application.StartupPath + "\\DeliveryRed.png");
            LblSefer.ForeColor = Color.Red;
        }

        private void SeferPicBox_Leave(object sender, EventArgs e)
        {
            SeferPicBox.Image = Image.FromFile(Application.StartupPath + "\\DeliveryBlack.png");
            LblSefer.ForeColor = Color.Black;
        }

        private void BiletPicBox_Hover(object sender, EventArgs e)
        {
            BiletPicBox.Image = Image.FromFile(Application.StartupPath + "\\ChecklistRed.png");
            lblBiletler.ForeColor = Color.Red;
        }

        private void BiletPicBox_Leave(object sender, EventArgs e)
        {
            BiletPicBox.Image = Image.FromFile(Application.StartupPath + "\\ChecklistBlack.png");
            lblBiletler.ForeColor = Color.Black;
        }

        private void BiletAlPicBox_Hover(object sender, EventArgs e)
        {
            BiletAlPicBox.Image = Image.FromFile(Application.StartupPath + "\\TicketRed.png");
            LblBiletAl.ForeColor = Color.Red;
        }

        private void BiletAlPicBox_Leave(object sender, EventArgs e)
        {
            BiletAlPicBox.Image = Image.FromFile(Application.StartupPath + "\\TicketBlack.png");
            LblBiletAl.ForeColor = Color.Black;
        }

        private void AnasayfaPicBox_Hover(object sender, EventArgs e)
        {
            AnasayfaPicBox.Image = Image.FromFile(Application.StartupPath + "\\HomeRed.png");
            LblHome.ForeColor = Color.Red;
        }

        private void AnasayfaPicBox_Leave(object sender, EventArgs e)
        {
            AnasayfaPicBox.Image = Image.FromFile(Application.StartupPath + "\\HomeBlack.png");
            LblHome.ForeColor = Color.Black;
        }
    }
}
