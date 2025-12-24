using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeHazırlık1
{
    public partial class Form2_1 : Form
    {
        public Form2_1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            // 1. Kutucuklar boş mu kontrol et
            // (Buradaki txtUserName ve txtPassword isimlerini kendi textbox isminle değiştir)
            if (string.IsNullOrWhiteSpace(bunifuTextBox1.Text) || string.IsNullOrWhiteSpace(bunifuTextBox2.Text))
            {
                MessageBox.Show("Please enter your username and password.");
                return;
            }

            // 2. Veritabanı bağlantısı ve Ekleme işlemi
            string connectionString = "Data Source=information.db;Version=3;";

            // ID otomatik artacağı için (INTEGER PRIMARY KEY) sorguya eklememize gerek yok.
            string sorgu = "INSERT INTO users (name, password) VALUES (@pName, @pPass)";

            try
            {
                using (SQLiteConnection baglanti = new SQLiteConnection(connectionString))
                {
                    baglanti.Open();

                    using (SQLiteCommand komut = new SQLiteCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@pName", bunifuTextBox1.Text.Trim());
                        komut.Parameters.AddWithValue("@pPass", bunifuTextBox2.Text.Trim());

                        int sonuc = komut.ExecuteNonQuery();

                        if (sonuc > 0)
                        {
                            MessageBox.Show("You have successfully registered!");
                            bunifuTextBox1.Text = "";
                            bunifuTextBox2.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("There was an error!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}
