namespace Gorsel2_Ders05_01_OtoPark
{
    partial class ParkGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParkGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_parkYeri = new System.Windows.Forms.ComboBox();
            this.cbx_arac = new System.Windows.Forms.ComboBox();
            this.dtp_girisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtp_girisSaati = new System.Windows.Forms.DateTimePicker();
            this.btn_girisYap = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(82, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Park Yeri :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(110, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Araç :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(74, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giriş Tarihi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(81, 245);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giriş Saati:";
            // 
            // cbx_parkYeri
            // 
            this.cbx_parkYeri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_parkYeri.Enabled = false;
            this.cbx_parkYeri.FormattingEnabled = true;
            this.cbx_parkYeri.Location = new System.Drawing.Point(170, 120);
            this.cbx_parkYeri.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_parkYeri.Name = "cbx_parkYeri";
            this.cbx_parkYeri.Size = new System.Drawing.Size(160, 24);
            this.cbx_parkYeri.TabIndex = 1;
            // 
            // cbx_arac
            // 
            this.cbx_arac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_arac.FormattingEnabled = true;
            this.cbx_arac.Location = new System.Drawing.Point(170, 158);
            this.cbx_arac.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_arac.Name = "cbx_arac";
            this.cbx_arac.Size = new System.Drawing.Size(160, 24);
            this.cbx_arac.TabIndex = 1;
            // 
            // dtp_girisTarihi
            // 
            this.dtp_girisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_girisTarihi.Location = new System.Drawing.Point(170, 199);
            this.dtp_girisTarihi.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_girisTarihi.Name = "dtp_girisTarihi";
            this.dtp_girisTarihi.Size = new System.Drawing.Size(116, 22);
            this.dtp_girisTarihi.TabIndex = 2;
            this.dtp_girisTarihi.ValueChanged += new System.EventHandler(this.dtp_girisTarihi_ValueChanged);
            // 
            // dtp_girisSaati
            // 
            this.dtp_girisSaati.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_girisSaati.Location = new System.Drawing.Point(170, 237);
            this.dtp_girisSaati.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_girisSaati.Name = "dtp_girisSaati";
            this.dtp_girisSaati.Size = new System.Drawing.Size(116, 22);
            this.dtp_girisSaati.TabIndex = 2;
            // 
            // btn_girisYap
            // 
            this.btn_girisYap.Location = new System.Drawing.Point(187, 317);
            this.btn_girisYap.Margin = new System.Windows.Forms.Padding(4);
            this.btn_girisYap.Name = "btn_girisYap";
            this.btn_girisYap.Size = new System.Drawing.Size(100, 28);
            this.btn_girisYap.TabIndex = 3;
            this.btn_girisYap.Text = "Giriş Yap";
            this.btn_girisYap.UseVisualStyleBackColor = true;
            this.btn_girisYap.Click += new System.EventHandler(this.btn_girisYap_Click);
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
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox3);
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
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(449, 59);
            this.bunifuGradientPanel1.TabIndex = 14;
            this.bunifuGradientPanel1.Click += new System.EventHandler(this.bunifuGradientPanel1_Click);
            this.bunifuGradientPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ParkGiris_MouseDown);
            this.bunifuGradientPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ParkGiris_MouseMove);
            this.bunifuGradientPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ParkGiris_MouseUp);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Gorsel2_Ders05_01_OtoPark.Properties.Resources.x_23_512;
            this.pictureBox3.Location = new System.Drawing.Point(411, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
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
            // ParkGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(449, 410);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.btn_girisYap);
            this.Controls.Add(this.dtp_girisSaati);
            this.Controls.Add(this.dtp_girisTarihi);
            this.Controls.Add(this.cbx_arac);
            this.Controls.Add(this.cbx_parkYeri);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ParkGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ParkGiris";
            this.Load += new System.EventHandler(this.ParkGiris_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ParkGiris_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ParkGiris_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ParkGiris_MouseUp);
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbx_parkYeri;
        private System.Windows.Forms.ComboBox cbx_arac;
        private System.Windows.Forms.DateTimePicker dtp_girisTarihi;
        private System.Windows.Forms.DateTimePicker dtp_girisSaati;
        private System.Windows.Forms.Button btn_girisYap;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}