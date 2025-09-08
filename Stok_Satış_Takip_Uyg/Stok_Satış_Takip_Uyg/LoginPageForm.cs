using System;
using System.Windows.Forms;

namespace Stok_Satış_Takip_Uyg
{
    public partial class LoginPageForm : Form
    {
        string UpdateUser = "Kullanıcı Bilgilerini Güncelle";







        private readonly string _username;
        private readonly string _role;

        public LoginPageForm(string username, string role)
        {
            InitializeComponent();
            _username = username;
            _role = role;

            // Wire events (if not wired in Designer)
            this.Load += LoginPageForm_Load;
            this.btnUpdateUser.Click += btnUpdateUser_Click;
        }

        private void LoginPageForm_Load(object sender, EventArgs e)
        {
            string UpdateButton = "Bilgileri Güncelle";
            var ListUserButton = "Kullanıcıları Listele";
            var ReportButton = "Raporları Gör";

            btnUpdateUser.Text = UpdateButton;
            btnKullaniciListele.Text = ListUserButton;
            btnRaporlar.Text = ReportButton;


            // Example: show who logged in
            lblLogin.Text = $"Hoşgeldin, {_username} ({_role})";

            // Show the button only for Admin/Yönetici
            btnUpdateUser.Visible = string.Equals(_role, "Admin/Yönetici",
                                     StringComparison.OrdinalIgnoreCase);
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            // Open UpdateUserForm. Admin can edit any user.
            using (var dlg = new UpdateUserForm()) // or new UpdateUserForm(_username) to edit self
            {
                dlg.StartPosition = FormStartPosition.CenterParent;
                dlg.ShowDialog(this);
            }
        }

        private void btnKullaniciListele_Click(object sender, EventArgs e)
        {
            new UserListForm().Show();

            if (AktifKullanici.Rol == "Admin/Yönetici")
                btnKullaniciListele.Visible = true;
            else
                btnKullaniciListele.Visible = false;

        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            if (AktifKullanici.Rol == "Admin/Yönetici")
            {
                new ReportForm().Show();
            }
            else
            {
                MessageBox.Show("Bu ekrana sadece yöneticiler erişebilir!", "Yetkisiz Erişim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}

