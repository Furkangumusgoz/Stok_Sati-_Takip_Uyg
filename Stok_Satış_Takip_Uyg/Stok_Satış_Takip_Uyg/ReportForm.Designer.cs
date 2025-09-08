namespace Stok_Satış_Takip_Uyg
{
    partial class ReportForm
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
            lblBaslik = new Label();
            pnlToplam = new Panel();
            lblToplamKullanici = new Label();
            lblToplamBaslik = new Label();
            pnlAdmin = new Panel();
            lblAdminSayisi = new Label();
            lblAdminBaslik = new Label();
            pnlPersonel = new Panel();
            lblPersonelSayisi = new Label();
            lblPersonelBaslik = new Label();
            pnlBirim = new Panel();
            lblEnPopulerBirim = new Label();
            lblBirimBaslik = new Label();
            btnYenile = new Button();
            pnlToplam.SuspendLayout();
            pnlAdmin.SuspendLayout();
            pnlPersonel.SuspendLayout();
            pnlBirim.SuspendLayout();
            SuspendLayout();
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBaslik.Location = new Point(579, 52);
            lblBaslik.Margin = new Padding(4, 0, 4, 0);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(70, 28);
            lblBaslik.TabIndex = 0;
            lblBaslik.Text = "label1";
            // 
            // pnlToplam
            // 
            pnlToplam.BackColor = Color.DarkGray;
            pnlToplam.Controls.Add(lblToplamKullanici);
            pnlToplam.Controls.Add(lblToplamBaslik);
            pnlToplam.Location = new Point(61, 122);
            pnlToplam.Margin = new Padding(4, 3, 4, 3);
            pnlToplam.Name = "pnlToplam";
            pnlToplam.Size = new Size(258, 124);
            pnlToplam.TabIndex = 1;
            // 
            // lblToplamKullanici
            // 
            lblToplamKullanici.AutoSize = true;
            lblToplamKullanici.Location = new Point(94, 80);
            lblToplamKullanici.Margin = new Padding(4, 0, 4, 0);
            lblToplamKullanici.Name = "lblToplamKullanici";
            lblToplamKullanici.Size = new Size(55, 23);
            lblToplamKullanici.TabIndex = 1;
            lblToplamKullanici.Text = "label2";
            // 
            // lblToplamBaslik
            // 
            lblToplamBaslik.AutoSize = true;
            lblToplamBaslik.Location = new Point(94, 20);
            lblToplamBaslik.Margin = new Padding(4, 0, 4, 0);
            lblToplamBaslik.Name = "lblToplamBaslik";
            lblToplamBaslik.Size = new Size(53, 23);
            lblToplamBaslik.TabIndex = 0;
            lblToplamBaslik.Text = "label1";
            // 
            // pnlAdmin
            // 
            pnlAdmin.BackColor = Color.DarkGray;
            pnlAdmin.Controls.Add(lblAdminSayisi);
            pnlAdmin.Controls.Add(lblAdminBaslik);
            pnlAdmin.Location = new Point(384, 122);
            pnlAdmin.Margin = new Padding(4, 3, 4, 3);
            pnlAdmin.Name = "pnlAdmin";
            pnlAdmin.Size = new Size(258, 124);
            pnlAdmin.TabIndex = 2;
            pnlAdmin.Paint += pnlAdmin_Paint;
            // 
            // lblAdminSayisi
            // 
            lblAdminSayisi.AutoSize = true;
            lblAdminSayisi.Location = new Point(95, 80);
            lblAdminSayisi.Margin = new Padding(4, 0, 4, 0);
            lblAdminSayisi.Name = "lblAdminSayisi";
            lblAdminSayisi.Size = new Size(56, 23);
            lblAdminSayisi.TabIndex = 4;
            lblAdminSayisi.Text = "label4";
            // 
            // lblAdminBaslik
            // 
            lblAdminBaslik.AutoSize = true;
            lblAdminBaslik.Location = new Point(95, 20);
            lblAdminBaslik.Margin = new Padding(4, 0, 4, 0);
            lblAdminBaslik.Name = "lblAdminBaslik";
            lblAdminBaslik.Size = new Size(55, 23);
            lblAdminBaslik.TabIndex = 3;
            lblAdminBaslik.Text = "label3";
            // 
            // pnlPersonel
            // 
            pnlPersonel.BackColor = Color.DarkGray;
            pnlPersonel.Controls.Add(lblPersonelSayisi);
            pnlPersonel.Controls.Add(lblPersonelBaslik);
            pnlPersonel.Location = new Point(694, 122);
            pnlPersonel.Margin = new Padding(4, 3, 4, 3);
            pnlPersonel.Name = "pnlPersonel";
            pnlPersonel.Size = new Size(258, 124);
            pnlPersonel.TabIndex = 2;
            // 
            // lblPersonelSayisi
            // 
            lblPersonelSayisi.AutoSize = true;
            lblPersonelSayisi.Location = new Point(98, 80);
            lblPersonelSayisi.Margin = new Padding(4, 0, 4, 0);
            lblPersonelSayisi.Name = "lblPersonelSayisi";
            lblPersonelSayisi.Size = new Size(55, 23);
            lblPersonelSayisi.TabIndex = 6;
            lblPersonelSayisi.Text = "label6";
            // 
            // lblPersonelBaslik
            // 
            lblPersonelBaslik.AutoSize = true;
            lblPersonelBaslik.Location = new Point(98, 20);
            lblPersonelBaslik.Margin = new Padding(4, 0, 4, 0);
            lblPersonelBaslik.Name = "lblPersonelBaslik";
            lblPersonelBaslik.Size = new Size(55, 23);
            lblPersonelBaslik.TabIndex = 5;
            lblPersonelBaslik.Text = "label5";
            // 
            // pnlBirim
            // 
            pnlBirim.BackColor = Color.DarkGray;
            pnlBirim.Controls.Add(lblEnPopulerBirim);
            pnlBirim.Controls.Add(lblBirimBaslik);
            pnlBirim.Location = new Point(1012, 122);
            pnlBirim.Margin = new Padding(4, 3, 4, 3);
            pnlBirim.Name = "pnlBirim";
            pnlBirim.Size = new Size(258, 124);
            pnlBirim.TabIndex = 2;
            // 
            // lblEnPopulerBirim
            // 
            lblEnPopulerBirim.AutoSize = true;
            lblEnPopulerBirim.Location = new Point(96, 80);
            lblEnPopulerBirim.Margin = new Padding(4, 0, 4, 0);
            lblEnPopulerBirim.Name = "lblEnPopulerBirim";
            lblEnPopulerBirim.Size = new Size(55, 23);
            lblEnPopulerBirim.TabIndex = 8;
            lblEnPopulerBirim.Text = "label8";
            // 
            // lblBirimBaslik
            // 
            lblBirimBaslik.AutoSize = true;
            lblBirimBaslik.Location = new Point(96, 20);
            lblBirimBaslik.Margin = new Padding(4, 0, 4, 0);
            lblBirimBaslik.Name = "lblBirimBaslik";
            lblBirimBaslik.Size = new Size(55, 23);
            lblBirimBaslik.TabIndex = 7;
            lblBirimBaslik.Text = "label7";
            // 
            // btnYenile
            // 
            btnYenile.Location = new Point(1094, 340);
            btnYenile.Margin = new Padding(4, 3, 4, 3);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(176, 33);
            btnYenile.TabIndex = 3;
            btnYenile.Text = "button1";
            btnYenile.UseVisualStyleBackColor = true;
            btnYenile.Click += btnYenile_Click;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1368, 580);
            Controls.Add(btnYenile);
            Controls.Add(pnlBirim);
            Controls.Add(pnlPersonel);
            Controls.Add(pnlAdmin);
            Controls.Add(pnlToplam);
            Controls.Add(lblBaslik);
            Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ReportForm";
            Text = "ReportForm";
            Load += ReportForm_Load;
            pnlToplam.ResumeLayout(false);
            pnlToplam.PerformLayout();
            pnlAdmin.ResumeLayout(false);
            pnlAdmin.PerformLayout();
            pnlPersonel.ResumeLayout(false);
            pnlPersonel.PerformLayout();
            pnlBirim.ResumeLayout(false);
            pnlBirim.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBaslik;
        private Panel pnlToplam;
        private Panel pnlAdmin;
        private Panel pnlPersonel;
        private Panel pnlBirim;
        private Label lblToplamKullanici;
        private Label lblToplamBaslik;
        private Label lblAdminSayisi;
        private Label lblAdminBaslik;
        private Label lblPersonelSayisi;
        private Label lblPersonelBaslik;
        private Label lblEnPopulerBirim;
        private Label lblBirimBaslik;
        private Button btnYenile;
    }
}