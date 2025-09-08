using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Stok_Satış_Takip_Uyg
{
    public partial class LoginForm : Form
    {
        private const string ConnString =
            "Server=FURKAN\\SQLEXPRESS;Database=StokTakipDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public LoginForm()
        {
            InitializeComponent();
            // Ensure the click is wired to THIS handler:
            this.btnLogin.Click += btnLogin_Click;
            this.btnRegister.Click += btnRegister_Click;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            lblLogin.Text = "Giriş Ekranına Hoşgeldiniz";
            lblUserName.Text = "Kullanıcı Adı";
            lblPassword.Text = "Şifre";
            btnLogin.Text = "Giriş";
            btnRegister.Text = "Kayıt Ol";

            txtUserName.Clear();
            txtPassword.Clear();

            // Optional: Pressing Enter triggers login
            this.AcceptButton = btnLogin;
        }

        // === CLEAN LOGIN ===
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string UserName = txtUserName.Text.Trim();
            string Password = txtPassword.Text; // If you hash on register, hash here too.

            if (string.IsNullOrWhiteSpace(UserName) || string.IsNullOrWhiteSpace(Password))
            {
                MessageBox.Show("Kullanıcı adı ve şifre gerekli.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var con = new SqlConnection(ConnString))
                using (var cmd = new SqlCommand(@"
SELECT Rol 
FROM Users -- <- Eğer gerçek tablon 'Kullanicilar' ise burayı Kullanicilar yap
WHERE KullaniciAdi = @KullaniciAdi AND Sifre = @Sifre;", con))
                {
                    cmd.Parameters.Add("@KullaniciAdi", SqlDbType.NVarChar, 50).Value = UserName;
                    cmd.Parameters.Add("@Sifre", SqlDbType.NVarChar, 255).Value = Password;
                    // NOTE: Eğer kayıtları HASH ile tutuyorsan:
                    // cmd.Parameters["@Sifre"].Value = HashPassword(Password);

                    con.Open();
                    object roleObj = cmd.ExecuteScalar(); // null if no match
                    if (roleObj == null)
                    {
                        MessageBox.Show("Hatalı kullanıcı adı veya şifre!", "Hata",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string role = roleObj.ToString();

                    // Share context if you have a static holder
                    AktifKullanici.KullaniciAdi = UserName;
                    AktifKullanici.Rol = role;

                    MessageBox.Show("Giriş başarılı!", "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // ... role bulunduğu yerden hemen sonra:
                    var main = new LoginPageForm(UserName, role);
                    main.FormClosed += (_, __) => this.Close();
                    main.StartPosition = FormStartPosition.CenterScreen;
                    main.Show();
                    this.Hide();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var reg = new RegisterForm();
            reg.StartPosition = FormStartPosition.CenterScreen;
            reg.FormClosed += (_, __) => this.Show(); // kayıt kapanınca login tekrar gösterilsin
            reg.Show();
            this.Hide();
        }

        // If you decide to hash later, implement it (and also hash on register).
        // private static string HashPassword(string pwd) { ... }
    }
}
