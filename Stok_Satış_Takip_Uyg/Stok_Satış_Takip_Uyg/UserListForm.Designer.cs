namespace Stok_Satış_Takip_Uyg
{
    partial class UserListForm
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
            dgvUsers = new DataGridView();
            txtNameSurname = new TextBox();
            lblNameSurname = new Label();
            lblUnits = new Label();
            lblRole = new Label();
            lblMail = new Label();
            lblUserName = new Label();
            txtUserName = new TextBox();
            txtMail = new TextBox();
            clbBirimler = new CheckedListBox();
            cmbRole = new ComboBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(87, 12);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.Size = new Size(595, 188);
            dgvUsers.TabIndex = 0;
            dgvUsers.CellContentClick += dgvUsers_CellContentClick;
            // 
            // txtNameSurname
            // 
            txtNameSurname.Location = new Point(215, 225);
            txtNameSurname.Name = "txtNameSurname";
            txtNameSurname.Size = new Size(160, 27);
            txtNameSurname.TabIndex = 1;
            // 
            // lblNameSurname
            // 
            lblNameSurname.AutoSize = true;
            lblNameSurname.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNameSurname.Location = new Point(87, 225);
            lblNameSurname.Name = "lblNameSurname";
            lblNameSurname.Size = new Size(53, 23);
            lblNameSurname.TabIndex = 2;
            lblNameSurname.Text = "label1";
            // 
            // lblUnits
            // 
            lblUnits.AutoSize = true;
            lblUnits.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUnits.Location = new Point(87, 400);
            lblUnits.Name = "lblUnits";
            lblUnits.Size = new Size(53, 23);
            lblUnits.TabIndex = 3;
            lblUnits.Text = "label1";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(87, 341);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(53, 23);
            lblRole.TabIndex = 4;
            lblRole.Text = "label1";
            lblRole.Click += label2_Click;
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMail.Location = new Point(87, 304);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(53, 23);
            lblMail.TabIndex = 5;
            lblMail.Text = "label1";
            lblMail.Click += label3_Click;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.Location = new Point(87, 270);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(53, 23);
            lblUserName.TabIndex = 6;
            lblUserName.Text = "label1";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(215, 270);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(160, 27);
            txtUserName.TabIndex = 7;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(215, 303);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(160, 27);
            txtMail.TabIndex = 8;
            txtMail.TextChanged += txtMail_TextChanged;
            // 
            // clbBirimler
            // 
            clbBirimler.FormattingEnabled = true;
            clbBirimler.Location = new Point(215, 387);
            clbBirimler.Name = "clbBirimler";
            clbBirimler.Size = new Size(160, 48);
            clbBirimler.TabIndex = 9;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(215, 341);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(160, 28);
            cmbRole.TabIndex = 10;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(215, 466);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "button1";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(324, 466);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "button2";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // UserListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 546);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(cmbRole);
            Controls.Add(clbBirimler);
            Controls.Add(txtMail);
            Controls.Add(txtUserName);
            Controls.Add(lblUserName);
            Controls.Add(lblMail);
            Controls.Add(lblRole);
            Controls.Add(lblUnits);
            Controls.Add(lblNameSurname);
            Controls.Add(txtNameSurname);
            Controls.Add(dgvUsers);
            Name = "UserListForm";
            Text = "UserListForm";
            Load += UserListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsers;
        private TextBox txtNameSurname;
        private Label lblNameSurname;
        private Label lblUnits;
        private Label lblRole;
        private Label lblMail;
        private Label lblUserName;
        private TextBox txtUserName;
        private TextBox txtMail;
        private CheckedListBox clbBirimler;
        private ComboBox cmbRole;
        private Button btnUpdate;
        private Button btnDelete;
    }
}