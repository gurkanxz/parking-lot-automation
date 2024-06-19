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
    public partial class ParkGiris : Form
    {
        public ParkGiris()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        public int parkYeri_id;
        public string parkYeriAd;
        public Button BasilanButton;
        private void ParkGiris_Load(object sender, EventArgs e)
        {
            cbx_parkYeri.DisplayMember = "parkYeriAd";
            cbx_parkYeri.ValueMember = "parkYeri_id";
            cbx_parkYeri.DataSource = 
                vt.Select("select parkYeri_id,parkYeriAd from tbl_parkYeri");

            cbx_arac.DisplayMember = "bilgi";
            cbx_arac.ValueMember = "arac_id";

            cbx_arac.DataSource = vt.Select(@"select a.arac_id,
                        a.plaka+' - '+m.ad+' '+m.soyad+' - '+m.telefon bilgi
                        from tbl_arac a
                        join tbl_musteri m on a.musteri_id=m.musteri_id");

            cbx_parkYeri.SelectedValue = parkYeri_id;
        }

        private void btn_girisYap_Click(object sender, EventArgs e)
        {

            if (cbx_arac.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Önce Araç Kaydı Yapınız...");
                return;
            }

            DataTable dt = vt.Select(@"SELECT p.arac_id, p.parkYeri_id, p.girisTarihi, p.girisSaati, py.parkYeriAd, p.cikisSaati, p.cikisTarihi
            FROM tbl_park p
            JOIN tbl_parkYeri py ON p.parkYeri_id = py.parkYeri_id
            WHERE p.arac_id = "+cbx_arac.SelectedValue+" AND py.parkYeriAd ="+cbx_parkYeri.DisplayMember+" AND p.cikisTarihi is NULL AND p.cikisSaati is NULL;");
            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Bu Araç Zaten Park Etmiş Durumda!...");
                return;
            }

            vt.Insert(@"insert into tbl_park(arac_id,parkYeri_id,girisTarihi,girisSaati,kullanici_id)
                        values("+cbx_arac.SelectedValue+", "+cbx_parkYeri.SelectedValue+", '"+dtp_girisTarihi.Value.ToString("yyyy-MM-dd")+"', '"+dtp_girisSaati.Value.ToString("HH:mm:ss")+"', 1)");
            BasilanButton.BackColor = Color.Maroon;

            vt.UpdateDelete("update tbl_parkYeri set doluMu=1 where parkYeri_id="+cbx_parkYeri.SelectedValue);

            MessageBox.Show("Park işlemi tamamlandı form kapatılıyor...");
            this.Close();
        }

        private void dtp_girisTarihi_ValueChanged(object sender, EventArgs e)
        {

        }


        bool move;
        int mouse_x;
        int mouse_y;

        private void ParkGiris_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void ParkGiris_MouseMove(object sender, MouseEventArgs e)
        {

            if (move == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void ParkGiris_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}
