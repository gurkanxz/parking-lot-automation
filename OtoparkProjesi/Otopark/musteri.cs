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
    public partial class musteri : Form
    {
        public musteri()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        private void musteri_Load(object sender, EventArgs e)
        {
            MusteriGridiDoldur();
        }
        private void MusteriGridiDoldur()
        {
            dgv_musteri.DataSource = vt.Select(@"SELECT 
                            m.musteri_id,
                            m.ad,
                            m.soyad,
                            m.telefon,
                            COALESCE(a.plaka, 'Plaka Bilgisi Bulunamadı!') AS plaka
                        FROM tbl_musteri m
                        LEFT JOIN tbl_arac a ON m.musteri_id = a.musteri_id;
 ");
            dgv_musteri.Columns["musteri_id"].Visible = false;
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
            if (tx_telefon.Text.Length < 11 || tx_telefon.Text.Length > 11)
            {
                MessageBox.Show("Telefon Numarası 11 Karakter  olmalı...");
                return;
            }

            DataTable dt = vt.Select(@"SELECT ad, soyad, telefon
             FROM tbl_musteri
             WHERE ad = '" + tx_ad.Text + "' AND soyad = '" + tx_soyAd.Text + "' AND telefon = '" + tx_telefon.Text + "'");
            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Böyle Bir Kullanıcı Bulunuyor...");
                return;
            }

            DataTable dtt = vt.Select(@"SELECT  telefon
             FROM tbl_musteri
             WHERE telefon = '" + tx_telefon.Text + "'");
            if (dtt.Rows.Count == 1)
            {
                MessageBox.Show("Böyle Bir Kullanıcıya Ait Telefon Bulunuyor...");
                return;
            }

            vt.Insert(@"insert into tbl_musteri(ad,soyad,telefon)
                        values('" + tx_ad.Text + "','" + tx_soyAd.Text + "','" + tx_telefon.Text + "')");
            MusteriGridiDoldur();
            MessageBox.Show("Müşteri Eklendi");
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_musteri.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silinecek müşteriyi Seçiniz...");
                return;
            }

            DialogResult secenek = MessageBox.Show("Bu Müşteriyi Silmek Bu Müşteriye Ait Araç Kayıtlarını Silebilir Devam Etmek İstiyor musunuz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                vt.UpdateDelete("delete from tbl_musteri where musteri_id=" + dgv_musteri.SelectedRows[0].Cells["musteri_id"].Value);
                MusteriGridiDoldur();
                MessageBox.Show("Müşteri Silindi");
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
            if (tx_telefon.Text.Length < 11 || tx_telefon.Text.Length > 11)
            {
                MessageBox.Show("Telefon 11 Karakter  olmalı...");
                return;
            }

            DataTable dt = vt.Select(@"SELECT ad, soyad, telefon
             FROM tbl_musteri
             WHERE ad = '" + tx_ad.Text + "' AND soyad = '" + tx_soyAd.Text + "' AND telefon = '" + tx_telefon.Text + "'");
            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Böyle Bir Kullanıcı Bulunuyor...");
                return;
            }

            DataTable dtt = vt.Select(@"SELECT  telefon
             FROM tbl_musteri
             WHERE telefon = '" + tx_telefon.Text + "'");
            if (dtt.Rows.Count == 1)
            {
                MessageBox.Show("Böyle Bir Kullanıcıya Ait Telefon Bulunuyor...");
                return;
            }


            DialogResult secenek = MessageBox.Show("Bu Müşteriyi Güncellemek Bu Müşteriye Ait Araç Kayıtlarını Güncelleyebilir Devam Etmek İstiyor musunuz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                vt.UpdateDelete(@"update tbl_musteri
                set 
	                ad='" + tx_ad.Text + @"',
	               	soyad='" + tx_soyAd.Text + @"',
	                telefon='" + tx_telefon.Text + @"'
	                where musteri_id=" + dgv_musteri.SelectedRows[0].Cells["musteri_id"].Value);
                MusteriGridiDoldur();
                MessageBox.Show("Musteri Güncellendi");
            }
            else if (secenek == DialogResult.No)
            {
                return;
            }
        }

        private void dgv_musteri_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_musteri.SelectedRows.Count == 0)
            {
                return;
            }
            tx_ad.Text = dgv_musteri.SelectedRows[0].Cells["ad"].Value.ToString();
            tx_soyAd.Text = dgv_musteri.SelectedRows[0].Cells["soyad"].Value.ToString();
            tx_telefon.Text = dgv_musteri.SelectedRows[0].Cells["telefon"].Value.ToString();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            tx_ad.Text = "";
            tx_soyAd.Text = "";
            tx_telefon.Text = "";
            if (dgv_musteri.SelectedRows.Count != 0)
                dgv_musteri.SelectedRows[0].Selected = false;
        }


        bool move;
        int mouse_x;
        int mouse_y;

        private void musteri_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void musteri_MouseMove(object sender, MouseEventArgs e)
        {

            if (move == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void musteri_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
