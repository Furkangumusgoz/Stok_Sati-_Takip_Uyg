namespace Stok_Satış_Takip_Uyg
{
    partial class LoginPageForm
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
            lblLogin = new Label();
            btnUpdateUser = new Button();
            btnKullaniciListele = new Button();
            btnRaporlar = new Button();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(491, 70);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(70, 28);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "label1";
            // 
            // btnUpdateUser
            // 
            btnUpdateUser.Location = new Point(491, 153);
            btnUpdateUser.Name = "btnUpdateUser";
            btnUpdateUser.Size = new Size(229, 29);
            btnUpdateUser.TabIndex = 1;
            btnUpdateUser.UseVisualStyleBackColor = true;
            // 
            // btnKullaniciListele
            // 
            btnKullaniciListele.Location = new Point(297, 153);
            btnKullaniciListele.Name = "btnKullaniciListele";
            btnKullaniciListele.Size = new Size(162, 29);
            btnKullaniciListele.TabIndex = 2;
            btnKullaniciListele.Text = "button1";
            btnKullaniciListele.UseVisualStyleBackColor = true;
            btnKullaniciListele.Click += btnKullaniciListele_Click;
            // 
            // btnRaporlar
            // 
            btnRaporlar.Location = new Point(150, 153);
            btnRaporlar.Name = "btnRaporlar";
            btnRaporlar.Size = new Size(113, 29);
            btnRaporlar.TabIndex = 3;
            btnRaporlar.Text = "button1";
            btnRaporlar.UseVisualStyleBackColor = true;
            btnRaporlar.Click += btnRaporlar_Click;
            // 
            // LoginPageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 450);
            Controls.Add(btnRaporlar);
            Controls.Add(btnKullaniciListele);
            Controls.Add(btnUpdateUser);
            Controls.Add(lblLogin);
            Name = "LoginPageForm";
            Text = "LoginPageForm";
            Load += LoginPageForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private Button btnUpdateUser;
        private Button btnKullaniciListele;
        private Button btnRaporlar;
    }
}