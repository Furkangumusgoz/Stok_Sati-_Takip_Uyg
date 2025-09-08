namespace Stok_Satış_Takip_Uyg
{
    partial class UpdateUserForm
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
            lblUpdateUser = new Label();
            lblUserName = new Label();
            txtUserName = new TextBox();
            lblPassword = new Label();
            lblMail = new Label();
            lblRole = new Label();
            txtPassword = new TextBox();
            txtMail = new TextBox();
            cmbRole = new ComboBox();
            lblUnits = new Label();
            clbUnits = new CheckedListBox();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // lblUpdateUser
            // 
            lblUpdateUser.AutoSize = true;
            lblUpdateUser.Location = new Point(598, 94);
            lblUpdateUser.Margin = new Padding(4, 0, 4, 0);
            lblUpdateUser.Name = "lblUpdateUser";
            lblUpdateUser.Size = new Size(70, 28);
            lblUpdateUser.TabIndex = 0;
            lblUpdateUser.Text = "label1";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserName.Location = new Point(460, 160);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(55, 23);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "label1";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(598, 152);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(125, 34);
            txtUserName.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(460, 215);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(55, 23);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "label1";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMail.Location = new Point(460, 270);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(55, 23);
            lblMail.TabIndex = 4;
            lblMail.Text = "label1";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(460, 335);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(55, 23);
            lblRole.TabIndex = 5;
            lblRole.Text = "label1";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(598, 204);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 34);
            txtPassword.TabIndex = 6;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(598, 259);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(125, 34);
            txtMail.TabIndex = 7;
            // 
            // cmbRole
            // 
            cmbRole.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(598, 327);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(151, 31);
            cmbRole.TabIndex = 8;
            // 
            // lblUnits
            // 
            lblUnits.AutoSize = true;
            lblUnits.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUnits.Location = new Point(460, 398);
            lblUnits.Name = "lblUnits";
            lblUnits.Size = new Size(55, 23);
            lblUnits.TabIndex = 9;
            lblUnits.Text = "label1";
            // 
            // clbUnits
            // 
            clbUnits.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clbUnits.FormattingEnabled = true;
            clbUnits.Location = new Point(598, 398);
            clbUnits.Name = "clbUnits";
            clbUnits.Size = new Size(150, 120);
            clbUnits.TabIndex = 10;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(598, 553);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(151, 37);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "button1";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // UpdateUserForm
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1227, 855);
            Controls.Add(btnUpdate);
            Controls.Add(clbUnits);
            Controls.Add(lblUnits);
            Controls.Add(cmbRole);
            Controls.Add(txtMail);
            Controls.Add(txtPassword);
            Controls.Add(lblRole);
            Controls.Add(lblMail);
            Controls.Add(lblPassword);
            Controls.Add(txtUserName);
            Controls.Add(lblUserName);
            Controls.Add(lblUpdateUser);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UpdateUserForm";
            Text = "UpdateUserForm";
            Load += UpdateUserForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUpdateUser;
        private Label lblUserName;
        private TextBox txtUserName;
        private Label lblPassword;
        private Label lblMail;
        private Label lblRole;
        private TextBox txtPassword;
        private TextBox txtMail;
        private ComboBox cmbRole;
        private Label lblUnits;
        private CheckedListBox clbUnits;
        private Button btnUpdate;
    }
}