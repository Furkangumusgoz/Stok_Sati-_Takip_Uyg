using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_Satış_Takip_Uyg
{
    public partial class UpdateUserForm : Form
    {
        public UpdateUserForm()
        {
            InitializeComponent();
            this.btnUpdate.Click += btnUpdate_Click;
            this.Load += UpdateUserForm_Load; 

        }


        public static string SifreHashle(string sifre)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(sifre));
                return Convert.ToBase64String(bytes);
            }
        }


        private void UpdateUserForm_Load(object sender, EventArgs e)
        {
            string UpdateUser = "Kullanıcı Bilgilerini Güncelleme Ekranı";
            var UserName = "Yeni Kullanıcı Adı";
            var GetUserName = "";
            var Password = "Yeni Şifre";
            var GetPassword = "";
            var Mail = "Yeni E-posta";
            var GetMail = "";
            var Role = "Yeni Birim";
            var Units = "Yeni Birimler";
            var UpdateButton = "Bilgileri Güncelle";




            lblUpdateUser.Text = UpdateUser;
            lblUserName.Text = UserName;
            txtUserName.Text = GetUserName;
            lblPassword.Text = Password;
            txtPassword.Text = GetPassword;
            lblMail.Text = Mail;
            txtMail.Text = GetMail;
            lblRole.Text = Role;
            lblUnits.Text = Units;
            btnUpdate.Text = UpdateButton;



            // Rol listesi
            cmbRole.Items.Add("Admin/Yönetici");
            cmbRole.Items.Add("Depo Görevlisi");
            cmbRole.Items.Add("Üretim Sorumlusu");
            cmbRole.Items.Add("Satış Personeli");
            cmbRole.Items.Add("Kasa Sorumlusu");
            cmbRole.SelectedIndex = 0;

            //Birimler Listesi
            string[] UnitsName = {
                "Genel Müdürlük","Bolu Fabrika",
                "Üsküdar Mağaza","Çorlu Mağaza","Kayseri Mağaza",
                "Konya Mağaza","Bursa Mağaza","Çanakkale Mağaza"
            };

            foreach (string u in UnitsName)
            {
                clbUnits.Items.Add(u);
            }




        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
          

            // 1) Admin doğrulama 
            if (cmbRole.Text != "Admin/Yönetici")
            {
                MessageBox.Show("Bu ekrana sadece yöneticiler erişebilir!", "Yetkisiz Erişim",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2) Kullanıcı doğrulama 
            string UserName = txtUserName.Text?.Trim();
            string Mail = txtMail.Text?.Trim();
            string Password = txtPassword.Text?.Trim();
            string Role = cmbRole.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(UserName))
            {
                MessageBox.Show("Kullanıcı adı boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(Mail))
            {
                MessageBox.Show("Email boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(Role))
            {
                MessageBox.Show("Lütfen bir rol seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // birimlerin virgül ile birleştirilmesi
            var selectedUnits = string.Join(", ", clbUnits.CheckedItems.Cast<object>().Select(i => i.ToString()));

            //Boş bırakılırsa şifre alanı eski parola tutulur 
            bool willUpdatePassword = !string.IsNullOrWhiteSpace(Password);
            string passwordHash = willUpdatePassword ? SifreHashle(Password) : null;

            

            // Kullanıcı şifre sütununu boş bırakırsa, SQL'i dinamik olarak atlayacak şekilde oluşturun
            string sql = willUpdatePassword
                ? @"UPDATE Users
            SET Sifre=@Sifre, Email=@Email, Rol=@Rol, Birimler=@Birimler
            WHERE KullaniciAdi=@KullaniciAdi"
                : @"UPDATE Users
            SET Email=@Email, Rol=@Rol, Birimler=@Birimler
            WHERE KullaniciAdi=@KullaniciAdi";

            string connString =
                "Server=FURKAN\\SQLEXPRESS;Database=StokTakipDB;Trusted_Connection=True;TrustServerCertificate=True;";

            try
            {
                using (var conn = new SqlConnection(connString))
                using (var cmd = new SqlCommand(sql, conn))
                {
                    // 3) Parametreler
                    cmd.Parameters.Add("@KullaniciAdi", SqlDbType.NVarChar, 100).Value = UserName;
                    cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 256).Value = Mail;
                    cmd.Parameters.Add("@Rol", SqlDbType.NVarChar, 50).Value = Role ?? (object)DBNull.Value;
                    cmd.Parameters.Add("@Birimler", SqlDbType.NVarChar, -1).Value =
                        string.IsNullOrWhiteSpace(selectedUnits) ? (object)DBNull.Value : selectedUnits;

                    if (willUpdatePassword)
                        cmd.Parameters.Add("@Sifre", SqlDbType.NVarChar, 256).Value = passwordHash;

                    conn.Open();
                    int affected = cmd.ExecuteNonQuery();

                    if (affected > 0)
                    {
                        MessageBox.Show("✅ Bilgiler başarıyla güncellendi!", "Bilgi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
 
                    }
                    else
                    {
                        MessageBox.Show("⚠ Kullanıcı bulunamadı!", "Uyarı",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmeyen hata: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }   


}
