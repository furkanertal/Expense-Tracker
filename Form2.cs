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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            if (!checkBoxShowpassword.Checked)
            {
                // If checkbox is checked, show the actual password
                bunifuTextBox2.PasswordChar = '*'; // Mask with asterisks

            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            string username = bunifuTextBox1.Text; // Textbox for username
            string password = bunifuTextBox2.Text; // Textbox for password

                try
                {
                    // Use an absolute path for the database file
                    string connectionString = "Data source=.\\information.db;Version=3";

                    using (var conn = new SQLiteConnection(connectionString))
                        {
                            conn.Open();

                            // Corrected query: Remove quotes around parameters
                            string query = "SELECT COUNT(*) FROM users WHERE name = @name AND Password = @password";

                            using (var cmd = new SQLiteCommand(query, conn))
                            {
                                // Add parameters safely to prevent SQL injection
                                cmd.Parameters.AddWithValue("@name", bunifuTextBox1.Text.Trim());
                                cmd.Parameters.AddWithValue("@password", bunifuTextBox2.Text.Trim());

                                // ExecuteScalar returns the count directly
                                int userCount = Convert.ToInt32(cmd.ExecuteScalar());

                                if (userCount == 1) // Successful login
                                {
                                    MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // Open FormMain and hide the current form
                                    FormMain mainForm = new FormMain();
                                    mainForm.Show();
                                    this.Hide();
                                }
                                else
                                {
                                // Show an error message when credentials don't match
                                MessageBox.Show("Invalid name or password!!", "Failiure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                    }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Show any errors for debugging purposes
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            

        }

        private void LabelSecure_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxShowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxShowpassword.Checked)
            {
                // If checkbox is checked, show the actual password
                bunifuTextBox2.PasswordChar = '*'; // Mask with asterisks
                                                   
            }
            else
            {
                // If checkbox is unchecked, mask the password
                
                bunifuTextBox2.PasswordChar = '\0';// Empty char means no masking
            }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            Form2_1 formEkle = new Form2_1();
            formEkle.Show(); // Show() hem ana formu hem bunu aynı anda kullanmanı sağlar.
                             // Eğer sadece bu formla ilgilenilsin istiyorsan: formEkle.ShowDialog();
        }
    }
}

