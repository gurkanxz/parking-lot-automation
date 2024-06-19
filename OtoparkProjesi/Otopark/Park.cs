using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gorsel2_Ders05_01_OtoPark
{
    public partial class Park : Form
    {
        public Park()
        {
            InitializeComponent();
        }
        public int kullanici_id ;
        public string adSoyad = "";

        private void Park_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        private void Park_Load(object sender, EventArgs e)
        {
             DataTable dt = vt.Select(@"select parkYeri_id,parkYeriAd,doluMu,parkYeriTur_id
                 from tbl_parkYeri
                 order by parkYeriAd");

            char harf;
            int sutunSay = 0,satirSay=0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sutunSay = i % 5;
                satirSay = i / 5;
                int parkYeriTur_id = Convert.ToInt32(dt.Rows[i]["parkYeriTur_id"]);
                Button b = new Button();
                b.Size = new Size(50,35+parkYeriTur_id*15);
                b.Location = new Point(satirSay*55+150,sutunSay*85+80);
                b.Text = dt.Rows[i]["parkYeriAd"].ToString();
                b.BackColor = dt.Rows[i]["doluMu"].ToString() == "False" ? Color.Green : Color.Maroon;
                b.Name = dt.Rows[i]["parkYeri_id"].ToString();
                b.Click += B_Click;
                this.Controls.Add(b);

            }
        }

        private void B_Click(object sender, EventArgs e)
        {
            Button basilan = (Button)sender;

            if (basilan.BackColor == Color.Green)
            {
                ParkGiris pg = new ParkGiris();
                pg.parkYeri_id = Convert.ToInt32(basilan.Name);
                pg.parkYeriAd = basilan.Text;
                pg.BasilanButton = basilan;
                pg.ShowDialog();
            }
            else if (basilan.BackColor == Color.Maroon)
            {
                ParkCikis pc = new ParkCikis();
                pc.basilan = basilan;
                pc.ShowDialog();
            }
        }

        private void ts_arac_Click(object sender, EventArgs e)
        {
            Arac a = new Arac();
            a.ShowDialog();
        }

        private void ts_parkYeri_Click(object sender, EventArgs e)
        {
            parkYeri a = new parkYeri();
            a.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            parkYeriTur a = new parkYeriTur();
            a.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            kullanici a = new kullanici();
            a.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            musteri a = new musteri();
            a.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            eskiKayitlar a = new eskiKayitlar();
            a.ShowDialog();
        }

        bool move;
        int mouse_x;
        int mouse_y;

        private void Park_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void Park_MouseMove(object sender, MouseEventArgs e)
        {

            if (move == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void Park_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
