using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_Satış_Takip_Uyg
{
    public partial class UserListForm : Form
    {

        public UserListForm()
        {
            InitializeComponent();
        }

        private void KullaniciListele()
        {
            string conn = "Server=FURKAN\\SQLEXPRESS;Database=StokTakipDB;Trusted_Connection=True;TrustServerCertificate=True;";
            using (SqlConnection baglanti = new SqlConnection(conn))
            {
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT ID, AdSoyad, KullaniciAdi, Email, Rol, Birimler FROM Users", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUsers.DataSource = dt;
            }
        }

        private void UserListForm_Load(object sender, EventArgs e)
        {
            KullaniciListele();

            if (AktifKullanici.Rol != "Admin/Yönetici")
            {
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
            }


            //Ekran Metinleri
            lblNameSurname.Text = "Ad Soyad";
            lblUserName.Text = "Kullancı Adı";
            lblMail.Text = "E-Posta";
            lblRole.Text = "Kullanıcı Rolleri";
            lblUnits.Text = "Kullanıcı Birimleri";

            //Textbox Başlangıçlarını Temizle
            txtNameSurname.Clear();
            txtUserName.Clear();
            txtMail.Clear();




            string DeleteButton = "Sil";
            var RefreshButton = "Güncelle";



            btnDelete.Text = DeleteButton;
            btnUpdate.Text = RefreshButton;


        }




        private void btnRefresh_Click(object sender, EventArgs e)
        {
            KullaniciListele();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsers.Rows[e.RowIndex];
                txtNameSurname.Text = row.Cells["AdSoyad"].Value.ToString();
                txtUserName.Text = row.Cells["KullaniciAdi"].Value.ToString();
                txtMail.Text = row.Cells["Email"].Value.ToString();
                cmbRole.Text = row.Cells["Rol"].Value.ToString();
                clbBirimler.Text = row.Cells["Birimler"].Value.ToString();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string conn = "Server=FURKAN\\SQLEXPRESS;Database=StokTakipDB;Trusted_Connection=True;TrustServerCertificate=True;";

            using (var baglanti = new SqlConnection(conn))
            using (var cmd = new SqlCommand(@"
        UPDATE Users
        SET AdSoyad=@ad, Email=@mail, Rol=@rol, Birimler=@birim
        WHERE kullaniciAdi=@kullaniciAdi;", baglanti))
            {
                baglanti.Open();

                // Better than AddWithValue: specify types/sizes if you know them
                cmd.Parameters.Add("@ad", SqlDbType.NVarChar, 100).Value = txtNameSurname.Text.Trim();
                cmd.Parameters.Add("@mail", SqlDbType.NVarChar, 255).Value = txtMail.Text.Trim();
                cmd.Parameters.Add("@rol", SqlDbType.NVarChar, 50).Value = cmbRole.Text.Trim();
                cmd.Parameters.Add("@birim", SqlDbType.NVarChar, 200).Value = clbBirimler.Text.Trim();
                cmd.Parameters.Add("@kullaniciAdi", SqlDbType.NVarChar, 50).Value = txtUserName.Text.Trim(); // <-- FIX

                int affected = cmd.ExecuteNonQuery();
                if (affected > 0)
                    MessageBox.Show("Update successful.");
                else
                    MessageBox.Show("No row matched this username.");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult onay = MessageBox.Show("Bu kullanıcıyı silmek istiyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (onay == DialogResult.Yes)
            {
                string conn = "Server=FURKAN\\SQLEXPRESS;Database=StokTakipDB;Trusted_Connection=True;TrustServerCertificate=True;";
                using (SqlConnection baglanti = new SqlConnection(conn))
                {
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Users WHERE KullaniciAdi=@KullaniciAdi", baglanti);
                    cmd.Parameters.AddWithValue("@KullaniciAdi", txtUserName.Text.Trim());

                    int etki = cmd.ExecuteNonQuery();
                    if (etki > 0)
                    {
                        MessageBox.Show("🗑️ Kullanıcı silindi!");
                        KullaniciListele();
                    }
                    else
                    {
                        MessageBox.Show("❌ Silme başarısız!");
                    }
                }
            }

        }
    }
}
