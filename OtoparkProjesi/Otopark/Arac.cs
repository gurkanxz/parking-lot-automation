using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gorsel2_Ders05_01_OtoPark
{
    public partial class Arac : Form
    {
        public Arac()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        private void Arac_Load(object sender, EventArgs e)
        {
            AracGridiDoldur();

            cbx_musteri.DisplayMember = "musteri";
            cbx_musteri.ValueMember = "musteri_id";
            cbx_musteri.DataSource = vt.Select("select musteri_id,ad+' '+soyad+'-'+telefon musteri from tbl_musteri ");

            cbx_parkYeriTur.ValueMember = "parkYeriTur_id";
            cbx_parkYeriTur.DisplayMember = "parkYeriTur";
            cbx_parkYeriTur.DataSource = vt.Select("select parkYeriTur_id,parkYeriTur from tbl_parkYeriTur");

        }

        private void AracGridiDoldur()
        {
            dgv_araclar.DataSource = vt.Select(@"select a.arac_id,a.plaka,a.musteri_id,m.ad+' '+m.soyad adSoyad,m.telefon,a.parkYeriTur_id,pyt.parkYeriTur
             from tbl_arac a
            join tbl_musteri m on a.musteri_id=m.musteri_id
            join tbl_parkYeriTur pyt on a.parkYeriTur_id = pyt.parkYeriTur_id ");
            dgv_araclar.Columns["arac_id"].Visible = false;
            dgv_araclar.Columns["musteri_id"].Visible = false;
            dgv_araclar.Columns["parkYeriTur_id"].Visible = false;
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (cbx_musteri.SelectedIndex == -1)
            {
                MessageBox.Show("Müşteri Seçiniz...");
                return;
            }
            if(tx_plaka.Text.Length<7 || tx_plaka.Text.Length >10)
            {
                MessageBox.Show("Plaka En Az 7 Karakter En Fazla 10 Karakter olabilir...");
                return;
            }
            if (cbx_parkYeriTur.SelectedIndex == -1)
            {
                MessageBox.Show("Park Yeri Türü Seçiniz...");
                return;
            }
            DataTable dt = vt.Select(@"select plaka from tbl_arac
                where plaka='" + tx_plaka.Text + "'");
            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Bu Plaka Önceden Girilmiş");
                return;
            }
            vt.Insert(@"insert into tbl_arac(musteri_id,plaka,parkYeriTur_id)
                        values("+cbx_musteri.SelectedValue+",'"+tx_plaka.Text+"',"+cbx_parkYeriTur.SelectedValue+")");
            AracGridiDoldur();
            MessageBox.Show("Kayıt Eklendi");
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_araclar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silinecek araç Seçiniz...");
                return;
            }

            DialogResult secenek = MessageBox.Show("Bu Araca Ait Park Kayıtları Silinebilir Devam Etmek İstiyor musunuz ?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                vt.UpdateDelete("delete from tbl_arac where arac_id=" + dgv_araclar.SelectedRows[0].Cells["arac_id"].Value);
                AracGridiDoldur();
                MessageBox.Show("Araç Silindi");
            }
            else if (secenek == DialogResult.No)
            {
                return;
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (dgv_araclar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellenecek araç Seçiniz...");
                return;
            }
            if (cbx_musteri.SelectedIndex == -1)
            {
                MessageBox.Show("Müşteri Seçiniz...");
                return;
            }
            if (tx_plaka.Text.Length < 7 || tx_plaka.Text.Length > 10)
            {
                MessageBox.Show("Plaka En Az 7 Karakter En Fazla 10 Karakter olabilir...");
                return;
            }
            if (cbx_parkYeriTur.SelectedIndex == -1)
            {
                MessageBox.Show("Park Yeri Türü Seçiniz...");
                return;
            }
            DataTable dt = vt.Select(@"select plaka from tbl_arac
                where plaka='" + tx_plaka.Text + "'");
            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Bu Plaka Önceden Girilmiş");
                return;
            }
            DialogResult secenek = MessageBox.Show("Bu Araca Ait Park Bilgileri Bulunuyorsa Otomatik Güncellenecek Devam Etmek İstiyor musunuz ?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                vt.UpdateDelete(@"update tbl_arac
                set musteri_id=" + cbx_musteri.SelectedValue + @",
	                plaka='" + tx_plaka.Text + @"',
	                parkYeriTur_id=" + cbx_parkYeriTur.SelectedValue + @"
	                where arac_id=" + dgv_araclar.SelectedRows[0].Cells["arac_id"].Value);
                AracGridiDoldur();
                MessageBox.Show("Araç Güncellendi");
            }
            else if (secenek == DialogResult.No)
            {
                return;
            }

        }

    

        private void dgv_araclar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_araclar.SelectedRows.Count == 0)
            {
                return;
            }

            cbx_musteri.SelectedValue = dgv_araclar.SelectedRows[0].Cells["musteri_id"].Value;
            tx_plaka.Text = dgv_araclar.SelectedRows[0].Cells["plaka"].Value.ToString();
            cbx_parkYeriTur.SelectedValue = dgv_araclar.SelectedRows[0].Cells["parkYeriTur_id"].Value;

        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            cbx_musteri.SelectedIndex = -1;
            cbx_parkYeriTur.SelectedIndex = -1;
            tx_plaka.Text = "";
            if (dgv_araclar.SelectedRows.Count != 0)
                dgv_araclar.SelectedRows[0].Selected = false;

        }

        bool move;
        int mouse_x;
        int mouse_y;

        private void Arac_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void Arac_MouseMove(object sender, MouseEventArgs e)
        {

            if (move == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void Arac_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }


        private void dgv_araclar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tx_plaka_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
