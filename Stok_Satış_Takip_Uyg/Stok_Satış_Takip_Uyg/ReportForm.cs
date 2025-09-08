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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void RaporlariYukle()
        {
            string conn = "Server=FURKAN\\SQLEXPRESS;Database=StokTakipDB;Trusted_Connection=True;TrustServerCertificate=True;";
            using (SqlConnection baglanti = new SqlConnection(conn))
            {
                baglanti.Open();

                // Toplam kullanıcı sayısı
                SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM Users", baglanti);
                lblToplamKullanici.Text = cmd1.ExecuteScalar().ToString();

                // Admin sayısı
                SqlCommand cmd2 = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Rol = 'Admin/Yönetici'", baglanti);
                lblAdminSayisi.Text = cmd2.ExecuteScalar().ToString();

                // Personel sayısı
                SqlCommand cmd3 = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Rol != 'Admin/Yönetici'", baglanti);
                lblPersonelSayisi.Text = cmd3.ExecuteScalar().ToString();

                // En popüler birim
                using (SqlCommand cmd4 = new SqlCommand(@"
    SELECT TOP 1 Birimler AS Birim, COUNT(*) AS Adet
    FROM Users
    GROUP BY Birimler
    ORDER BY Adet DESC;", baglanti))
                {
                    using (SqlDataReader dr = cmd4.ExecuteReader())
                    {
                        if (dr.Read())
                            lblEnPopulerBirim.Text = dr["Birim"].ToString(); // alias sayesinde tutarlı
                        else
                            lblEnPopulerBirim.Text = "-";
                    }
                }


                baglanti.Close();
            }
        }



        private void ReportForm_Load(object sender, EventArgs e)
        {

            RaporlariYukle();



            //Ekran Metinleri
            lblBaslik.Text = "Sistem Raporları";
            lblToplamBaslik.Text = "Toplam Kullanıcı";
            lblToplamKullanici.Text = " ";
            lblAdminBaslik.Text = "Admin Sayısı";
            lblAdminSayisi.Text = " ";
            lblPersonelBaslik.Text = "Personel Sayısı";
            lblPersonelSayisi.Text = " ";
            lblBirimBaslik.Text = "En Popüler Birim";
            lblEnPopulerBirim.Text = " ";
            btnYenile.Text = "Verileri Yenile";


        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            RaporlariYukle();

            if (AktifKullanici.Rol == "Admin/Yönetici")
                new ReportForm().Show();
            else
                MessageBox.Show("Bu ekrana sadece yöneticiler erişebilir!", "Yetkisiz Erişim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void pnlAdmin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

