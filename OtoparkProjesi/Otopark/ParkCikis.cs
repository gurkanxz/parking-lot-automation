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
    public partial class ParkCikis : Form
    {
        public ParkCikis()
        {
            InitializeComponent();
        }
        public Button basilan;
        VTI.Veritabani vt = new VTI.Veritabani();
        private void ParkCikis_Load(object sender, EventArgs e)
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


            DataTable dt = vt.Select(@"select park_id,arac_id,girisTarihi,girisSaati from tbl_park
                            where parkYeri_id="+basilan.Name+" and cikisTarihi is null");
            dtp_girisTarihi.Value = (DateTime)dt.Rows[0]["girisTarihi"];
            dtp_girisSaati.Value = Convert.ToDateTime("01.01.1900 "+dt.Rows[0]["girisSaati"]);

            cbx_parkYeri.SelectedValue = basilan.Name;
            cbx_arac.SelectedValue= dt.Rows[0]["arac_id"];

            park_id = Convert.ToInt32(dt.Rows[0]["park_id"]);
        }
        int park_id;
        private void btn_cikisYap_Click(object sender, EventArgs e)
        {
            vt.UpdateDelete(@"update tbl_park set 
            cikisTarihi='"+dtp_cikisTarihi.Value.ToString("yyyy-MM-dd")+"',cikisSaati='"+dtp_cikisSaati.Value.ToString("HH:mm:ss") +@"'
            where park_id = "+park_id);

            vt.UpdateDelete("update tbl_parkYeri set doluMu=0 where parkYeri_id="+basilan.Name);
            basilan.BackColor = Color.Green;
            MessageBox.Show("Çıkış yapıldı. form kapatılıyor.");
            this.Close();
        }


        bool move;
        int mouse_x;
        int mouse_y;

        private void ParkCikis_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void ParkCikis_MouseMove(object sender, MouseEventArgs e)
        {

            if (move == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void ParkCikis_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
