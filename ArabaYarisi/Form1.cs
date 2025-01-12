using System;
using System.Windows.Forms;

namespace ArabaYarisi
{
    public partial class Form1 : Form
    {
        // Yolu aşağı doğru hareket ettiren hız değişkeni
        int yolHizi = 5;

        // Engellerin (arabaların) aşağı doğru hareket etme hızı
        int engelHizi = 5;

        // Oyuncunun topladığı skorları tutan değişken
        int skor = 0;

        // Formun yapıcı metodu (Constructor) - başlangıç ayarlarını yapar
        public Form1()
        {
            InitializeComponent(); // Form bileşenlerini başlatır
        }

        // Zamanlayıcı her tetiklendiğinde çağrılan metot
        private void zamanlayici_Tick(object sender, EventArgs e)
        {
            // Yolun aşağı doğru hareket etmesini sağlar
            yol.Top += yolHizi;

            // Sağdaki engelin (sagaraba) aşağı doğru hareket etmesini sağlar
            sagaraba.Top += engelHizi;

            // Soldaki engelin (solaraba) aşağı doğru hareket etmesini sağlar
            solaraba.Top += engelHizi;

            // Yolun tekrar yukarıdan görünmesini sağlar (sonsuz hareket efekti)
            if (yol.Top > -72)
            {
                yol.Top = -200; // Yolun konumunu sıfırlar
            }

            // Sağdaki engel (sagaraba) ekranın dışına çıktığında yeniden yukarıdan başlar
            if (sagaraba.Top > ClientSize.Height)
            {
                sagaraba.Top = -100; // Yeni başlangıç pozisyonu
                sagaraba.Left = new Random().Next(100, ClientSize.Width - sagaraba.Width); // Rastgele yatay konum
                skor++; // Skoru artırır
            }

            // Soldaki engel (solaraba) ekranın dışına çıktığında yeniden yukarıdan başlar
            if (solaraba.Top > ClientSize.Height)
            {
                solaraba.Top = -100; // Yeni başlangıç pozisyonu
                solaraba.Left = new Random().Next(100, ClientSize.Width - solaraba.Width); // Rastgele yatay konum
                skor++; // Skoru artırır
            }

            // Skor etiketi güncellenir
            label_skor.Text = "SKOR: " + skor;

            // Çarpışma kontrolü: Oyuncunun arabası herhangi bir engelle çarpışırsa
            if (araba.Bounds.IntersectsWith(sagaraba.Bounds) ||
                araba.Bounds.IntersectsWith(solaraba.Bounds))
            {
                // Zamanlayıcı durdurulur
                zamanlayici.Stop();

                // Oyunun bittiği mesajı görüntülenir
                MessageBox.Show("Oyun bitti! Skorunuz: " + skor);

                // Uygulama yeniden başlatılır
                Application.Restart();
            }
        }

        // Klavyede bir tuşa basıldığında çağrılan metot
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Sol ok tuşuna basılırsa ve araç ekranın solunda değilse
            if (e.KeyCode == Keys.Left && araba.Left > 0)
            {
                araba.Left -= 10; // Araç sola hareket eder
            }

            // Sağ ok tuşuna basılırsa ve araç ekranın sağında değilse
            if (e.KeyCode == Keys.Right && araba.Right < ClientSize.Width)
            {
                araba.Left += 10; // Araç sağa hareket eder
            }
        }
    }
}
