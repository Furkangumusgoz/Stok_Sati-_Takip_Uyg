namespace Stok_Satış_Takip_Uyg
{
    partial class LoginForm
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
            lblUserName = new Label();
            txtUserName = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(395, 74);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(63, 25);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "label1";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(273, 116);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(50, 20);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "label1";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(395, 109);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(125, 27);
            txtUserName.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(273, 157);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(50, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "label1";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(395, 157);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(426, 214);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "button1";
            btnLogin.UseVisualStyleBackColor = true;
            
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(309, 214);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "button2";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 584);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUserName);
            Controls.Add(lblUserName);
            Controls.Add(lblLogin);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private Label lblUserName;
        private TextBox txtUserName;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnRegister;
    }
}