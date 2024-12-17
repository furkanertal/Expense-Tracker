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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjeHazırlık1
{
    public partial class FormDatabase : Form
    {
        public FormDatabase()
        {
            InitializeComponent();

        }

        private void FormDatabase_Load(object sender, EventArgs e)
        {

        }

        void Listele()
        {
            string sql = "SELECT * from Statistics";
            dataGridView1.DataSource = CRUD.Listele(sql);
        }

        private void ButtonDuzenle_Click(object sender, EventArgs e)
        {
            int seciliid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["CatogoryId"].Value.ToString());
            FormKaydet form = new FormKaydet(seciliid);
            form.ShowDialog();
            form.radioButtonGelir.Text = dataGridView1.CurrentRow.Cells["Type"].Value.ToString();
            form.comboBoxGelir.Text = dataGridView1.CurrentRow.Cells["Catogory"].Value.ToString();
            form.radioButtonGider.Text = dataGridView1.CurrentRow.Cells["Type"].Value.ToString();
            form.comboBoxGider.Text = dataGridView1.CurrentRow.Cells["Catogory"].Value.ToString(); 
            form.comboBoxAy.Text = dataGridView1.CurrentRow.Cells["Month"].Value.ToString();
            form.textBoxIslemler.Text = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Amount"].Value).ToString();


        }



        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void ButtonGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void ButtonEkle_Click(object sender, EventArgs e)
        {
            FormKaydet form = new FormKaydet();
            form.ShowDialog();
            if (form.Kaydedildi)
            {
                Listele();
            }
        }

        private void ButtonTamam_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain.Show();
            this.Hide();
        }

        private void comboBoxGelir_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonGelir_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ButtonSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili kayıt silinsin mi?", "Uyarı", MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes) {
                int seciliid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["CatogoryId"].Value.ToString());
                string sql = "Delete from Statistics Where CatogoryId='" + seciliid + "' ";
                if (CRUD.ESD(sql))
                {
                    Listele();
                }
            }
        }
    }
    public class Baglan
    {
        public static SQLiteConnection connection = new SQLiteConnection("Data source=.\\information.db;Version=3");
    }

    public class CRUD
    {
        public static DataTable dt;
        public static DataTable Listele(string sql)
        {
            dt = new DataTable();
            SQLiteDataAdapter adtr = new SQLiteDataAdapter(sql, Baglan.connection);
            adtr.Fill(dt);
            return dt;
        }

        public static bool ESD(string sql)
        {
            int dogrula = 0;
            SQLiteCommand command = new SQLiteCommand(sql, Baglan.connection);
            Baglan.connection.Open();
            dogrula = command.ExecuteNonQuery();

            Baglan.connection.Close();
            if (dogrula == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }


}
