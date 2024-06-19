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
    public partial class parkYeriTur : Form
    {
        public parkYeriTur()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        private void parkYeriTür_Load(object sender, EventArgs e)
        {
            ParkYeriTurGridiDoldur();
            ParkGridiDoldur2();
        }
        private void ParkYeriTurGridiDoldur()
        {
            dgv_parkYeriTur.DataSource = vt.Select(@"select parkYeriTur, parkYeriTur_id
             from tbl_parkYeriTur");
            dgv_parkYeriTur.Columns["parkYeriTur_id"].Visible = false;
        }
        private void ParkGridiDoldur2()
        {
            dgv_park.DataSource = vt.Select(@"select parkYeriTur,pa.parkYeriAd
             from tbl_parkYeriTur as p
			 left join tbl_parkYeri pa on pa.parkYeriTur_id=p.parkYeriTur_id");
        }
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (tx_turAd.Text.Length < 2 || tx_turAd.Text.Length > 10)
            {
                MessageBox.Show("Park Yeri Türü En Az 2 Karakter En Fazla 10 Karakter olabilir...");
                return;
            }

            DataTable dtt = vt.Select(@"SELECT  parkYeriTur
             FROM tbl_parkYeriTur
             WHERE parkYeriTur = '" + tx_turAd.Text + "'");
            if (dtt.Rows.Count == 1)
            {
                MessageBox.Show("Böyle Bir Park Yeri Türü Bulunuyor...");
                return;
            }

            vt.Insert(@"insert into tbl_parkYeriTur(parkYeriTur)
                        values('" + tx_turAd.Text + "')");
            ParkYeriTurGridiDoldur();
            MessageBox.Show("Park Yeri Türü Eklendi");
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_parkYeriTur.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silinecek parkyeri türünü Seçiniz...");
                return;
            }

            DialogResult secenek = MessageBox.Show("Bu Park Türünü Silmek Bu Park Türüne Ait Park Kayıtlarını Silebilir Devam Etmek İstiyor musunuz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                vt.UpdateDelete("delete from tbl_parkYeriTur where parkYeriTur_id=" + dgv_parkYeriTur.SelectedRows[0].Cells["parkYeriTur_id"].Value);
                ParkYeriTurGridiDoldur();
                MessageBox.Show("ParkYeri Türü Silindi");
            }
            else if (secenek == DialogResult.No)
            {
                return;
            }
        }
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (dgv_parkYeriTur.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellenecek parkyeri türünü Seçiniz...");
                return;
            }
            if (tx_turAd.Text.Length < 2 || tx_turAd.Text.Length > 10)
            {
                MessageBox.Show("Plaka En Az 2 Karakter En Fazla 10 Karakter olabilir...");
                return;
            }

            DataTable dtt = vt.Select(@"SELECT  parkYeriTur
             FROM tbl_parkYeriTur
             WHERE parkYeriTur = '" + tx_turAd.Text + "'");
            if (dtt.Rows.Count == 1)
            {
                MessageBox.Show("Böyle Bir Park Yeri Türü Bulunuyor...");
                return;
            }

            DialogResult secenek = MessageBox.Show("Bu ParkYeri Türünü Güncellemek Bu ParkYeri Türüne Ait Park Bilgilerini de Günceller Devam Etmek İstiyor musunuz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                vt.UpdateDelete(@"update tbl_parkYeriTur
                set  parkYeriTur='" + tx_turAd.Text + @"'
	                where parkYeriTur_id=" + dgv_parkYeriTur.SelectedRows[0].Cells["parkYeriTur_id"].Value);
                ParkYeriTurGridiDoldur();
                MessageBox.Show("ParkYeri Türü Güncellendi");
            }
            else if (secenek == DialogResult.No)
            {
                return;
            }

        }

        private void dgv_parkYeriTur_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_parkYeriTur.SelectedRows.Count == 0)
            {
                return;
            }
            tx_turAd.Text = dgv_parkYeriTur.SelectedRows[0].Cells["parkYeriTur"].Value.ToString();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            tx_turAd.Text = "";
            if (dgv_parkYeriTur.SelectedRows.Count != 0)
                dgv_parkYeriTur.SelectedRows[0].Selected = false;
        }

        private void dgv_parkYeriTur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        bool move;
        int mouse_x;
        int mouse_y;

        private void parkYeriTur_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void parkYeriTur_MouseMove(object sender, MouseEventArgs e)
        {

            if (move == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void parkYeriTur_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
