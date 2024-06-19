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
    public partial class kullanici : Form
    {
        public kullanici()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        private void kullanici_Load(object sender, EventArgs e)
        {
            KullaniciGridiDoldur();
        }
        private void KullaniciGridiDoldur()
        {
            dgv_kullanici.DataSource = vt.Select(@"select kullanici_id,ad,soyad,tcNo,sifre
             from tbl_kullanici ");
            dgv_kullanici.Columns["kullanici_id"].Visible = false;
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {

            if (tx_ad.Text.Length < 2 || tx_ad.Text.Length > 15)
            {
                MessageBox.Show("Ad En Az 2 Karakter En Fazla 15 Karakter olabilir...");
                return;
            }
            if (tx_soyAd.Text.Length < 2 || tx_soyAd.Text.Length > 15)
            {
                MessageBox.Show("SoyAd En Az 2 Karakter En Fazla 15 Karakter olabilir...");
                return;
            }
            if (tx_tc.Text.Length < 11 || tx_tc.Text.Length > 11)
            {
                MessageBox.Show("TC No  11 Karakter  olmalı...");
                return;
            }

            DataTable dt = vt.Select(@"select tcNo from tbl_kullanici
                where tcNo='" + tx_tc.Text + "'");
            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Bu TC No İle Önceden Kayıt Edilmiş Bir Kişi Bulunuyor...");
                return;
            }

            vt.Insert(@"insert into tbl_kullanici(ad,soyAd,tcNo,sifre)
                        values('" + tx_ad.Text + "','" + tx_soyAd.Text + "','" + tx_tc.Text + "','" + tx_sifre.Text + "')");
            KullaniciGridiDoldur();
            MessageBox.Show("Kullanici Eklendi");
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_kullanici.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silinecek kullanıcıyı Seçiniz...");
                return;
            }

            DialogResult secenek = MessageBox.Show("Bu Kullanıcı Bilgilerini Silmek O Kullanıcıya Ait Park Kayıtlarını Silebilir Devam Etmek İstiyor musunuz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                vt.UpdateDelete("delete from tbl_kullanici where kullanici_id=" + dgv_kullanici.SelectedRows[0].Cells["kullanici_id"].Value);
                KullaniciGridiDoldur();
                MessageBox.Show("Kullanici Silindi");
            }
            else if (secenek == DialogResult.No)
            {
                return;
            }

        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (tx_ad.Text.Length < 2 || tx_ad.Text.Length > 15)
            {
                MessageBox.Show("Ad En Az 2 Karakter En Fazla 15 Karakter olabilir...");
                return;
            }
            if (tx_soyAd.Text.Length < 2 || tx_soyAd.Text.Length > 15)
            {
                MessageBox.Show("SoyAd En Az 2 Karakter En Fazla 15 Karakter olabilir...");
                return;
            }
            if (tx_tc.Text.Length < 11 || tx_tc.Text.Length > 11)
            {
                MessageBox.Show("TC No  11 Karakter  olmalı...");
                return;
            }

            DataTable dt = vt.Select(@"select tcNo from tbl_kullanici
                where tcNo='" + tx_tc.Text + "'");
            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Bu TC No İle Önceden Kayıt Edilmiş Bir Kişi Bulunuyor...");
                return;
            }

            DialogResult secenek = MessageBox.Show("Bu Kullanıcı Bilgilerini Güncellemek O Kullanıcıya Ait Park Kayıtlarını da Güncelleyebilir Devam Etmek İstiyor musunuz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                vt.UpdateDelete(@"update tbl_kullanici
                set 
	                ad='" + tx_ad.Text + @"',
	               	soyAd='" + tx_soyAd.Text + @"',
	                tcNo='" + tx_tc.Text + @"',
	                sifre='" + tx_sifre.Text + @"'
	                where kullanici_id=" + dgv_kullanici.SelectedRows[0].Cells["kullanici_id"].Value);
                KullaniciGridiDoldur();
                MessageBox.Show("Kullanıcı Güncellendi");
            }
            else if (secenek == DialogResult.No)
            {
                return;
            }

        }

        private void dgv_kullanici_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_kullanici.SelectedRows.Count == 0)
            {
                return;
            }
            tx_ad.Text = dgv_kullanici.SelectedRows[0].Cells["ad"].Value.ToString();
            tx_soyAd.Text = dgv_kullanici.SelectedRows[0].Cells["soyAd"].Value.ToString();
            tx_tc.Text = dgv_kullanici.SelectedRows[0].Cells["tcNo"].Value.ToString();
            tx_sifre.Text = dgv_kullanici.SelectedRows[0].Cells["sifre"].Value.ToString();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            tx_ad.Text = "";
            tx_soyAd.Text = "";
            tx_tc.Text = "";
            tx_sifre.Text = "";
            if (dgv_kullanici.SelectedRows.Count != 0)
                dgv_kullanici.SelectedRows[0].Selected = false;
        }

        bool move;
        int mouse_x;
        int mouse_y;

        private void kullanici_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void kullanici_MouseMove(object sender, MouseEventArgs e)
        {

            if (move == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void kullanici_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}
