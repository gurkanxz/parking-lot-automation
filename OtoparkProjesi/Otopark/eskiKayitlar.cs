using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gorsel2_Ders05_01_OtoPark
{
    public partial class eskiKayitlar : Form
    {
        public eskiKayitlar()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        private void eskiKayitlar_Load(object sender, EventArgs e)
        {
            ParkYeriGridiDoldur22();
        }

        private void ParkYeriGridiDoldur22()
        {
            dgv_parkYerleri.DataSource = vt.Select(@"select  pa.parkYeri_id,pa.parkYeriAd,pa.parkYeriTur_id,pyt.parkYeriTur,k.ad+' '+k.soyad AdSoyad,par.girisTarihi,par.girisSaati,par.cikisTarihi,par.cikisSaati,par.kullanici_id,pa.doluMu
             from tbl_parkYeri pa
            left join tbl_parkYeriTur pyt on pa.parkYeriTur_id = pyt.parkYeriTur_id
			left join tbl_park par on pa.parkYeri_id = par.parkYeri_id
			left join tbl_kullanici k on k.kullanici_id = par.kullanici_id
            WHERE  par.girisTarihi IS NOT NULL AND par.girisSaati IS NOT NULL
            ORDER BY pa.parkYeriAd ASC; ");
            dgv_parkYerleri.Columns["parkYeri_id"].Visible = false;
            dgv_parkYerleri.Columns["parkYeriTur_id"].Visible = false;
            dgv_parkYerleri.Columns["kullanici_id"].Visible = false;
        }

        private void dgv_parkYerleri_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_parkYerleri.SelectedRows.Count == 0)
            {
                return;
            }
        }

        bool move;
        int mouse_x;
        int mouse_y;

        private void eskiKayitlar_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void eskiKayitlar_MouseMove(object sender, MouseEventArgs e)
        {

            if (move == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void eskiKayitlar_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_parkYerleri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
