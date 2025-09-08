using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Stok_Satış_Takip_Uyg
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            // Olay bağlama (Designer’da zaten bağlıysa gerek yok)
            this.Load += RegisterForm_Load;
            this.btnKayit.Click += btnKayit_Click;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            // Ekran metinleri
            lblKullaniciKayit.Text = "Kullanıcı Kayıt Ekranına Hoşgeldiniz";
            lblNameSurname.Text = "Ad Soyad";
            lblUserName.Text = "Kullanıcı Adı";
            lblMail.Text = "E-Posta";
            lblpassword.Text = "Şifre Giriniz";
            lblPassword2.Text = "Şifreyi Tekrar Giriniz";
            lblRole.Text = "Kullanıcı Rolü Seçiniz";
            lblUnits.Text = "Birim Seçimi Yapınız";
            btnKayit.Text = "Kayıt Ol";

            // TextBox başlangıçlarını temizle
            txtNameSurname.Clear();
            txtUserName.Clear();
            txtMail.Clear();
            txtPassword.Clear();
            txtPassword2.Clear();



            if (cmbRol.Items.Count == 0)
            {
                cmbRol.Items.AddRange(new object[] { "Admin/Yönetici", "Depo Görevlisi", "Üretim Sorumlusu", "Satış Personeli", "Kasa Sorumlusu" });
                cmbRol.SelectedIndex = 0;
            }

            // Birimler (CheckedListBox) dolu değilse örnek değerler
            if (clbBirimler.Items.Count == 0)
            {
                clbBirimler.Items.Add("Genel Müdürlük");
                clbBirimler.Items.Add("Bolu Fabrika");
                clbBirimler.Items.Add("Üsküdar Mağaza");
                clbBirimler.Items.Add("Çorlu Mağaza");
                clbBirimler.Items.Add("Kayseri Mağaza");
                clbBirimler.Items.Add("Çanakkale Mağaza");
            }
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            // 1) Inputlar
            string AdSoyad = (txtNameSurname.Text ?? "").Trim();
            string KullaniciAdi = (txtUserName.Text ?? "").Trim();
            string Sifre = txtPassword.Text ?? "";
            string Sifre2 = txtPassword2.Text ?? "";
            string Email = (txtMail.Text ?? "").Trim();
            string Rol = (cmbRol.SelectedItem?.ToString() ?? "Admin/Yönetici").Trim();
            string Birimler = GetSelectedUnitsCsv();

            // 2) Basit doğrulamalar
            if (string.IsNullOrWhiteSpace(AdSoyad))
            {
                MessageBox.Show("Ad Soyad gerekli.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNameSurname.Focus(); return;
            }
            if (string.IsNullOrWhiteSpace(KullaniciAdi))
            {
                MessageBox.Show("Kullanıcı adı gerekli.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus(); return;
            }
            if (string.IsNullOrEmpty(Sifre))
            {
                MessageBox.Show("Şifre gerekli.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus(); return;
            }
            if (Sifre != Sifre2)
            {
                MessageBox.Show("Şifreler eşleşmiyor.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword2.Focus(); return;
            }


            try
            {
                // 3) Kullanıcı adı benzersiz mi?
                using (var con = Db.Open())
                using (var check = new SqlCommand("SELECT COUNT(1) FROM Users WHERE KullaniciAdi=@u", con))
                {
                    check.Parameters.AddWithValue("@u", KullaniciAdi);
                    int exists = Convert.ToInt32(check.ExecuteScalar());
                    if (exists > 0)
                    {
                        MessageBox.Show("Bu kullanıcı adı zaten kayıtlı.", "Uyarı",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // 4) Kayıt (NOT: Kolon isimlerini kendi tablonla eşleştir)
                using (var con = Db.Open())
                using (var cmd = new SqlCommand(@"
INSERT INTO Users(AdSoyad, KullaniciAdi, Sifre, Email, Rol, Birimler, CreatedAt)
VALUES (@AdSoyad, @KullaniciAdi, @Sifre, @Email, @Rol, @Birimler, @CreatedAt);", con))
                {
                    cmd.Parameters.AddWithValue("@AdSoyad", AdSoyad);
                    cmd.Parameters.AddWithValue("@KullaniciAdi", KullaniciAdi);
                    cmd.Parameters.AddWithValue("@Sifre", Sifre); // Not: PBKDF2/BCrypt ile hash’a çevirmek önerilir
                    cmd.Parameters.AddWithValue("@Email", (object)Email ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Rol", Rol);
                    cmd.Parameters.AddWithValue("@Birimler", (object)Birimler ?? DBNull.Value);
                    cmd.Parameters.Add("@CreatedAt", System.Data.SqlDbType.DateTime).Value = DateTime.Now;

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Kayıt başarılı! Artık giriş yapabilirsiniz.", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close(); // Kayıt bitti → formu kapat (LoginForm’a geri dönülür)
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt sırasında hata oluştu:\n" + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string? GetSelectedUnitsCsv()
        {
            if (clbBirimler.CheckedItems == null || clbBirimler.CheckedItems.Count == 0) return null;
            var arr = clbBirimler.CheckedItems.Cast<object>().Select(x => x.ToString().Trim());
            return string.Join(",", arr);
        }

        private void RegisterForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
