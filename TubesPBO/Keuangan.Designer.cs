
namespace TubesPBO
{
    partial class Keuangan
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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Keuangan));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.jumlahKamar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kotakBersih = new Guna.UI2.WinForms.Guna2TextBox();
            this.kotakUpah = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kotakDisewa = new Guna.UI2.WinForms.Guna2TextBox();
            this.tanggal = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 0;
            this.guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            this.guna2Transition1.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(51, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pemasukan Per Tanggal";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // jumlahKamar
            // 
            this.guna2Transition1.SetDecoration(this.jumlahKamar, Guna.UI2.AnimatorNS.DecorationType.None);
            this.jumlahKamar.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jumlahKamar.ForeColor = System.Drawing.Color.LightGreen;
            this.jumlahKamar.Location = new System.Drawing.Point(37, 80);
            this.jumlahKamar.Name = "jumlahKamar";
            this.jumlahKamar.Size = new System.Drawing.Size(318, 71);
            this.jumlahKamar.TabIndex = 1;
            this.jumlahKamar.Text = "Jumlah Kamar Disewa (10)";
            this.jumlahKamar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.kotakBersih);
            this.panel1.Controls.Add(this.kotakUpah);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.kotakDisewa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.jumlahKamar);
            this.panel1.Controls.Add(this.tanggal);
            this.guna2Transition1.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(320, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 470);
            this.panel1.TabIndex = 2;
            // 
            // kotakBersih
            // 
            this.kotakBersih.BorderRadius = 5;
            this.kotakBersih.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.kotakBersih, Guna.UI2.AnimatorNS.DecorationType.None);
            this.kotakBersih.DefaultText = "Rp 12.000.000";
            this.kotakBersih.DisabledState.BorderColor = System.Drawing.Color.CadetBlue;
            this.kotakBersih.DisabledState.FillColor = System.Drawing.Color.White;
            this.kotakBersih.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.kotakBersih.DisabledState.Parent = this.kotakBersih;
            this.kotakBersih.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.kotakBersih.Enabled = false;
            this.kotakBersih.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.kotakBersih.FocusedState.Parent = this.kotakBersih;
            this.kotakBersih.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kotakBersih.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.kotakBersih.HoverState.Parent = this.kotakBersih;
            this.kotakBersih.Location = new System.Drawing.Point(54, 396);
            this.kotakBersih.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kotakBersih.Name = "kotakBersih";
            this.kotakBersih.PasswordChar = '\0';
            this.kotakBersih.PlaceholderText = "";
            this.kotakBersih.ReadOnly = true;
            this.kotakBersih.SelectedText = "";
            this.kotakBersih.SelectionStart = 13;
            this.kotakBersih.ShadowDecoration.Parent = this.kotakBersih;
            this.kotakBersih.Size = new System.Drawing.Size(285, 57);
            this.kotakBersih.TabIndex = 6;
            this.kotakBersih.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kotakUpah
            // 
            this.kotakUpah.BorderRadius = 5;
            this.kotakUpah.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.kotakUpah, Guna.UI2.AnimatorNS.DecorationType.None);
            this.kotakUpah.DefaultText = "Rp 12.000.000";
            this.kotakUpah.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(213)))));
            this.kotakUpah.DisabledState.FillColor = System.Drawing.Color.White;
            this.kotakUpah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.kotakUpah.DisabledState.Parent = this.kotakUpah;
            this.kotakUpah.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.kotakUpah.Enabled = false;
            this.kotakUpah.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.kotakUpah.FocusedState.Parent = this.kotakUpah;
            this.kotakUpah.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kotakUpah.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.kotakUpah.HoverState.Parent = this.kotakUpah;
            this.kotakUpah.Location = new System.Drawing.Point(54, 258);
            this.kotakUpah.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kotakUpah.Name = "kotakUpah";
            this.kotakUpah.PasswordChar = '\0';
            this.kotakUpah.PlaceholderText = "";
            this.kotakUpah.ReadOnly = true;
            this.kotakUpah.SelectedText = "";
            this.kotakUpah.SelectionStart = 13;
            this.kotakUpah.ShadowDecoration.Parent = this.kotakUpah;
            this.kotakUpah.Size = new System.Drawing.Size(285, 57);
            this.kotakUpah.TabIndex = 8;
            this.kotakUpah.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.guna2Transition1.SetDecoration(this.label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(213)))));
            this.label3.Location = new System.Drawing.Point(37, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 71);
            this.label3.TabIndex = 7;
            this.label3.Text = "Upah dan Operasional";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.guna2Transition1.SetDecoration(this.label4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CadetBlue;
            this.label4.Location = new System.Drawing.Point(37, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(318, 45);
            this.label4.TabIndex = 4;
            this.label4.Text = "Keuntungan Bersih";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kotakDisewa
            // 
            this.kotakDisewa.BorderRadius = 5;
            this.kotakDisewa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.kotakDisewa, Guna.UI2.AnimatorNS.DecorationType.None);
            this.kotakDisewa.DefaultText = "Rp 12.000.000";
            this.kotakDisewa.DisabledState.BorderColor = System.Drawing.Color.LightGreen;
            this.kotakDisewa.DisabledState.FillColor = System.Drawing.Color.White;
            this.kotakDisewa.DisabledState.ForeColor = System.Drawing.Color.LightGreen;
            this.kotakDisewa.DisabledState.Parent = this.kotakDisewa;
            this.kotakDisewa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.kotakDisewa.Enabled = false;
            this.kotakDisewa.FocusedState.BorderColor = System.Drawing.Color.LightGreen;
            this.kotakDisewa.FocusedState.Parent = this.kotakDisewa;
            this.kotakDisewa.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kotakDisewa.ForeColor = System.Drawing.Color.LightGreen;
            this.kotakDisewa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.kotakDisewa.HoverState.Parent = this.kotakDisewa;
            this.kotakDisewa.Location = new System.Drawing.Point(54, 139);
            this.kotakDisewa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kotakDisewa.Name = "kotakDisewa";
            this.kotakDisewa.PasswordChar = '\0';
            this.kotakDisewa.PlaceholderText = "";
            this.kotakDisewa.ReadOnly = true;
            this.kotakDisewa.SelectedText = "";
            this.kotakDisewa.SelectionStart = 13;
            this.kotakDisewa.ShadowDecoration.Parent = this.kotakDisewa;
            this.kotakDisewa.Size = new System.Drawing.Size(285, 57);
            this.kotakDisewa.TabIndex = 2;
            this.kotakDisewa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tanggal
            // 
            this.guna2Transition1.SetDecoration(this.tanggal, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tanggal.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tanggal.ForeColor = System.Drawing.Color.CadetBlue;
            this.tanggal.Location = new System.Drawing.Point(51, 42);
            this.tanggal.Name = "tanggal";
            this.tanggal.Size = new System.Drawing.Size(290, 46);
            this.tanggal.TabIndex = 9;
            this.tanggal.Text = "5 Desember 2020";
            this.tanggal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox1.Image = global::TubesPBO.Properties.Resources._14;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 9);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(364, 478);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 3;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation1;
            // 
            // Keuangan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 470);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.panel1);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Keuangan";
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Keuangan_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label jumlahKamar;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox kotakDisewa;
        private Guna.UI2.WinForms.Guna2TextBox kotakUpah;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox kotakBersih;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label tanggal;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
    }
}