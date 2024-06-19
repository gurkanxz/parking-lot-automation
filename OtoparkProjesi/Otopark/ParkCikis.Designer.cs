namespace Gorsel2_Ders05_01_OtoPark
{
    partial class ParkCikis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParkCikis));
            this.btn_cikisYap = new System.Windows.Forms.Button();
            this.dtp_girisSaati = new System.Windows.Forms.DateTimePicker();
            this.dtp_girisTarihi = new System.Windows.Forms.DateTimePicker();
            this.cbx_arac = new System.Windows.Forms.ComboBox();
            this.cbx_parkYeri = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_cikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtp_cikisSaati = new System.Windows.Forms.DateTimePicker();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cikisYap
            // 
            this.btn_cikisYap.Location = new System.Drawing.Point(222, 328);
            this.btn_cikisYap.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cikisYap.Name = "btn_cikisYap";
            this.btn_cikisYap.Size = new System.Drawing.Size(100, 28);
            this.btn_cikisYap.TabIndex = 12;
            this.btn_cikisYap.Text = "Çıkış Yap";
            this.btn_cikisYap.UseVisualStyleBackColor = true;
            this.btn_cikisYap.Click += new System.EventHandler(this.btn_cikisYap_Click);
            // 
            // dtp_girisSaati
            // 
            this.dtp_girisSaati.Enabled = false;
            this.dtp_girisSaati.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_girisSaati.Location = new System.Drawing.Point(204, 192);
            this.dtp_girisSaati.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_girisSaati.Name = "dtp_girisSaati";
            this.dtp_girisSaati.Size = new System.Drawing.Size(116, 22);
            this.dtp_girisSaati.TabIndex = 10;
            // 
            // dtp_girisTarihi
            // 
            this.dtp_girisTarihi.Enabled = false;
            this.dtp_girisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_girisTarihi.Location = new System.Drawing.Point(204, 154);
            this.dtp_girisTarihi.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_girisTarihi.Name = "dtp_girisTarihi";
            this.dtp_girisTarihi.Size = new System.Drawing.Size(116, 22);
            this.dtp_girisTarihi.TabIndex = 11;
            // 
            // cbx_arac
            // 
            this.cbx_arac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_arac.FormattingEnabled = true;
            this.cbx_arac.Location = new System.Drawing.Point(204, 113);
            this.cbx_arac.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_arac.Name = "cbx_arac";
            this.cbx_arac.Size = new System.Drawing.Size(160, 24);
            this.cbx_arac.TabIndex = 8;
            // 
            // cbx_parkYeri
            // 
            this.cbx_parkYeri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_parkYeri.Enabled = false;
            this.cbx_parkYeri.FormattingEnabled = true;
            this.cbx_parkYeri.Location = new System.Drawing.Point(204, 75);
            this.cbx_parkYeri.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_parkYeri.Name = "cbx_parkYeri";
            this.cbx_parkYeri.Size = new System.Drawing.Size(160, 24);
            this.cbx_parkYeri.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(115, 199);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giriş Saati:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(108, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Giriş Tarihi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(144, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Araç :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(116, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Park Yeri :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(108, 231);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Çıkış Tarihi :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(115, 269);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Çıkış Saati:";
            // 
            // dtp_cikisTarihi
            // 
            this.dtp_cikisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_cikisTarihi.Location = new System.Drawing.Point(204, 224);
            this.dtp_cikisTarihi.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_cikisTarihi.Name = "dtp_cikisTarihi";
            this.dtp_cikisTarihi.Size = new System.Drawing.Size(116, 22);
            this.dtp_cikisTarihi.TabIndex = 11;
            // 
            // dtp_cikisSaati
            // 
            this.dtp_cikisSaati.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_cikisSaati.Location = new System.Drawing.Point(204, 262);
            this.dtp_cikisSaati.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_cikisSaati.Name = "dtp_cikisSaati";
            this.dtp_cikisSaati.Size = new System.Drawing.Size(116, 22);
            this.dtp_cikisSaati.TabIndex = 10;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderRadius = 1;
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox2);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox4);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(23)))), ((int)(((byte)(65)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(523, 59);
            this.bunifuGradientPanel1.TabIndex = 13;
            this.bunifuGradientPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ParkCikis_MouseDown);
            this.bunifuGradientPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ParkCikis_MouseMove);
            this.bunifuGradientPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ParkCikis_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Gorsel2_Ders05_01_OtoPark.Properties.Resources.x_23_512;
            this.pictureBox2.Location = new System.Drawing.Point(485, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Gorsel2_Ders05_01_OtoPark.Properties.Resources.x_23_512;
            this.pictureBox4.Location = new System.Drawing.Point(893, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 34);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gorsel2_Ders05_01_OtoPark.Properties.Resources.istockphoto_1434058712_612x612;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ParkCikis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(523, 368);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.btn_cikisYap);
            this.Controls.Add(this.dtp_cikisSaati);
            this.Controls.Add(this.dtp_girisSaati);
            this.Controls.Add(this.dtp_cikisTarihi);
            this.Controls.Add(this.dtp_girisTarihi);
            this.Controls.Add(this.cbx_arac);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbx_parkYeri);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ParkCikis";
            this.Text = "ParkCikis";
            this.Load += new System.EventHandler(this.ParkCikis_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ParkCikis_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ParkCikis_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ParkCikis_MouseUp);
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cikisYap;
        private System.Windows.Forms.DateTimePicker dtp_girisSaati;
        private System.Windows.Forms.DateTimePicker dtp_girisTarihi;
        private System.Windows.Forms.ComboBox cbx_arac;
        private System.Windows.Forms.ComboBox cbx_parkYeri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_cikisTarihi;
        private System.Windows.Forms.DateTimePicker dtp_cikisSaati;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}