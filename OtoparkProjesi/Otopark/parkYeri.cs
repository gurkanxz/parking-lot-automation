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
    public partial class parkYeri : Form
    {
        public parkYeri()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        private void parkYeri_Load(object sender, EventArgs e)
        {
            ParkYeriGridiDoldur();
            cbx_parkYeriTur.ValueMember = "parkYeriTur_id";
            cbx_parkYeriTur.DisplayMember = "parkYeriTur";
            cbx_parkYeriTur.DataSource = vt.Select("select parkYeriTur_id,parkYeriTur from tbl_parkYeriTur");
        }
        private void ParkYeriGridiDoldur()
        {
            dgv_parkYerleri.DataSource = vt.Select(@"SELECT
                    pa.parkYeri_id,pa.parkYeriAd,pa.parkYeriTur_id,pyt.parkYeriTur,k.ad + ' ' + k.soyad AS AdSoyad,par.girisTarihi,par.girisSaati,par.cikisTarihi,par.cikisSaati,par.kullanici_id,pa.doluMu
                FROM tbl_parkYeri pa
                LEFT JOIN tbl_parkYeriTur pyt ON pa.parkYeriTur_id = pyt.parkYeriTur_id
                LEFT JOIN (
                    SELECT *
                    FROM tbl_park
                    WHERE cikisTarihi IS NULL 
                ) par ON pa.parkYeri_id = par.parkYeri_id
                LEFT JOIN tbl_kullanici k ON k.kullanici_id = par.kullanici_id;");
            dgv_parkYerleri.Columns["parkYeri_id"].Visible = false;
            dgv_parkYerleri.Columns["parkYeriTur_id"].Visible = false;
            dgv_parkYerleri.Columns["kullanici_id"].Visible = false;
            dgv_parkYerleri.Columns["cikisTarihi"].Visible = false;
            dgv_parkYerleri.Columns["cikisSaati"].Visible = false;
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (tx_parkYeriAd.Text.Length < 2 || tx_parkYeriAd.Text.Length > 4)
            {
                MessageBox.Show("Park Yeri Adı En Az 2 Karakter En Fazla 4 Karakter olabilir...");
                return;
            }
            if (cbx_parkYeriTur.SelectedIndex == -1)
            {
                MessageBox.Show("Park Yeri Türü Seçiniz...");
                return;
            }

            DataTable dtt = vt.Select(@"SELECT  parkYeriAd
             FROM tbl_parkYeri
             WHERE parkYeriAd = '" + tx_parkYeriAd.Text + "'");
            if (dtt.Rows.Count == 1)
            {
                MessageBox.Show("Böyle Bir Park Yeri Adı Bulunuyor...");
                return;
            }

            vt.Insert(@"insert into tbl_parkYeri(parkYeriAd,parkYeriTur_id)
                        values('" + tx_parkYeriAd.Text + "'," + cbx_parkYeriTur.SelectedValue + ")");
            ParkYeriGridiDoldur();
            MessageBox.Show("Park Yeri Eklendi");
        }

        private void dgv_parkYerleri_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_parkYerleri.SelectedRows.Count == 0)
            {
                return;
            }
            tx_parkYeriAd.Text = dgv_parkYerleri.SelectedRows[0].Cells["parkYeriAd"].Value.ToString();
            cbx_parkYeriTur.SelectedValue = dgv_parkYerleri.SelectedRows[0].Cells["parkYeriTur_id"].Value;
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_parkYerleri.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silinecek park Seçiniz...");
                return;
            }

            DialogResult secenek = MessageBox.Show("Bu ParkYerini Silmek Bu ParkYerine Ait 'Eski-Yeni' Kayıtları Silebilir Devam Etmek İstiyor musunuz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                vt.UpdateDelete("delete from tbl_parkYeri where parkYeri_id=" + dgv_parkYerleri.SelectedRows[0].Cells["parkYeri_id"].Value);
                ParkYeriGridiDoldur();
                MessageBox.Show("Park Yeri Silindi");
            }
            else if (secenek == DialogResult.No)
            {
                return;
            }

        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            cbx_parkYeriTur.SelectedIndex = -1;
            tx_parkYeriAd.Text = "";
            if (dgv_parkYerleri.SelectedRows.Count != 0)
                dgv_parkYerleri.SelectedRows[0].Selected = false;
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (dgv_parkYerleri.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellenecek araç Seçiniz...");
                return;
            }
            if (tx_parkYeriAd.Text.Length < 2 || tx_parkYeriAd.Text.Length > 4)
            {
                MessageBox.Show("Plaka En Az 2 Karakter En Fazla 4 Karakter olabilir...");
                return;
            }
            if (cbx_parkYeriTur.SelectedIndex == -1)
            {
                MessageBox.Show("Park Yeri Türü Seçiniz...");
                return;
            }

            DataTable dtt = vt.Select(@"SELECT  parkYeriAd
             FROM tbl_parkYeri
             WHERE parkYeriAd = '" + tx_parkYeriAd.Text + "'");
            if (dtt.Rows.Count == 1)
            {
                MessageBox.Show("Böyle Bir Park Yeri Adı Bulunuyor...");
                return;
            }

            DialogResult secenek = MessageBox.Show("Bu ParkYerini Güncellemek Bu ParkYerine Ait 'Eski-Yeni' Kayıtları Güncelleyebilir Devam Etmek İstiyor musunuz??", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                vt.UpdateDelete(@"update tbl_parkYeri
                set parkYeriAd='" + tx_parkYeriAd.Text + @"',
	                parkYeriTur_id=" + cbx_parkYeriTur.SelectedValue + @"
	                where parkYeri_id=" + dgv_parkYerleri.SelectedRows[0].Cells["parkYeri_id"].Value);
                ParkYeriGridiDoldur();
                MessageBox.Show("Park Yeri Güncellendi");
            }
            else if (secenek == DialogResult.No)
            {
                return;
            }

            
        }

        bool move;
        int mouse_x;
        int mouse_y;

        private void parkYeri_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void parkYeri_MouseMove(object sender, MouseEventArgs e)
        {

            if (move == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void parkYeri_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
