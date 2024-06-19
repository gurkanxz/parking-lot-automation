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
    public partial class KullaniciGirisi : Form
    {
        public KullaniciGirisi()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        private void KullaniciGirisi_Load(object sender, EventArgs e)
        {

        }
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            label3.Visible = true;
        }

        private void btn_giris_Click_1(object sender, EventArgs e)
        {
            if (tx_kullaniciAdi.Text.Length != 11)
            {
                MessageBox.Show("Kullanici Adı 11 karakter olmalıdır.");
                return;
            }
            if (tx_sifre.Text == "")
            {
                MessageBox.Show("Şifre boş bırakılamaz. Lütfen şifrenizi giriniz!");
                return;
            }

            DataTable dt = vt.Select(@"select kullanici_id,ad+' '+soyad adSoyad
                    from tbl_kullanici
            where tcNo='" + tx_kullaniciAdi.Text + "' and sifre='" + tx_sifre.Text + "'");

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre hatalı !!!");
                return;
            }

            MessageBox.Show("Kullanici Girişi Başarılı.\nHoş Geldin :" + dt.Rows[0][1].ToString());
            Park p = new Park();
            p.kullanici_id = Convert.ToInt32(dt.Rows[0][0]);
            p.adSoyad = dt.Rows[0][1].ToString();
            p.Text = "OtO PaRk 1.0 - [" + p.adSoyad + "]";
            this.Hide();
            p.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool move;
        int mouse_x;
        int mouse_y;

        private void KullaniciGirisi_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void KullaniciGirisi_MouseMove(object sender, MouseEventArgs e)
        {
            label3.Visible = false;

            if(move==true)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void KullaniciGirisi_MouseUp(object sender, MouseEventArgs e)
        {
            move= false;
        }
    }
}
