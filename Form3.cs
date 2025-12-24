using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace ProjeHazırlık1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            InitializeChart(); // Grafiği hazırla
            Listele();         // Verileri tabloya getir (Bunu ekleyin)
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ButtonDBUpdate_Click(object sender, EventArgs e)
        {
            string dbPath = "Data Source=information.db"; // SQLite DB Path
            string query = "SELECT Month, Amount, Catogory, Type FROM Statistics";

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(dbPath))
                {
                    connection.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        // Update the chart with fetched data
                        UpdateChart(dataTable);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeChart()
        {
            // --- CHART 1 (SOL - INCOME) AYARLARI ---
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.Titles.Clear();

            ChartArea area1 = new ChartArea("AreaIncome");
            chart1.ChartAreas.Add(area1);
            chart1.Titles.Add("INCOME ($K)");

            // Eksen ayarları (Yazıların okunabilirliği için)
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -45;

            // --- CHART 2 (SAĞ - EXPENSE) AYARLARI ---
            chart2.Series.Clear();
            chart2.ChartAreas.Clear();
            chart2.Titles.Clear();

            ChartArea area2 = new ChartArea("AreaExpense");
            chart2.ChartAreas.Add(area2);
            chart2.Titles.Add("EXPENSES ($K)");

            chart2.ChartAreas[0].AxisX.Interval = 1;
            chart2.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
        }
        private void UpdateChart(DataTable dataTable)
        {
            // 1. Tablodaki verileri "Gelir" ve "Gider" olarak ayırıyoruz
            // Veritabanındaki "Type" sütununda "Gelir" ve "Gider" yazdığını varsayıyoruz.
            var gelirRows = dataTable.AsEnumerable()
                                     .Where(row => row.Field<string>("Type") == "Income");

            var giderRows = dataTable.AsEnumerable()
                                     .Where(row => row.Field<string>("Type") == "Expense");

            // 2. Ayrıştırılan verileri ilgili grafiklere basıyoruz
            // Eğer veri varsa grafiği doldur, yoksa boş kalsın
            if (gelirRows.Any())
                FillChart(chart1, gelirRows.CopyToDataTable());
            else
                chart1.Series.Clear();

            if (giderRows.Any())
                FillChart(chart2, giderRows.CopyToDataTable());
            else
                chart2.Series.Clear();
        }

        private void FillChart(Chart targetChart, DataTable dt)
        {
            targetChart.Series.Clear();

            // Tüm aylar (X ekseni için sabit liste)
            var allMonths = new[] { "January", "February", "March", "April", "May", "June",
                    "July", "August", "September", "October", "November", "December" };

            // Kategorileri tekilleştir (Örn: Sadece "Maaş", "Kira" vb. kalsın)
            var categories = dt.AsEnumerable()
                               .Select(row => row.Field<string>("Catogory"))
                               .Distinct();

            foreach (string category in categories)
            {
                // Her kategori için yeni bir seri oluştur
                Series series = new Series(category)
                {   
                    
                    ChartType = SeriesChartType.Line,
                    BorderWidth = 3, // Çizgi kalınlığı
                    MarkerStyle = MarkerStyle.Circle, // Noktalara işaret koyar
                    MarkerSize = 8
                    

                    //ChartType = SeriesChartType.Column,
                    //BorderWidth = 12

                    //ChartType = SeriesChartType.Spline,
                    //BorderWidth = 3,

                    //ChartType = SeriesChartType.Area,
                    //Color = Color.FromArgb(150, Color.Red)

                    //ChartType = SeriesChartType.SplineArea,
                    //Color = Color.FromArgb(150, Color.Blue)

                    //ChartType = SeriesChartType.Bar,
                };

                foreach (string month in allMonths)
                {
                    // O kategori ve o aya ait satırı bul
                    var row = dt.AsEnumerable()
                                .FirstOrDefault(r => r.Field<string>("Catogory") == category &&
                                                     r.Field<string>("Month") == month);

                    // Veri varsa Amount'u al, yoksa 0 yaz
                    int amount = row != null ? Convert.ToInt32(row["Amount"]) : 0;

                    series.Points.AddXY(month, amount);
                }

                targetChart.Series.Add(series);
            }
        }
        //rest of this is for "Database Management" section
        void Listele()
        {
            string sql = "SELECT * from Statistics";
            dataGridView1.DataSource = CRUD.Listele(sql);
        }
        private void tabPage2_Click(object sender, EventArgs e) {     }
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
                // --- DEĞİŞİKLİK BURADA: Bağlantı kontrolü ---
                if (Baglan.connection.State != ConnectionState.Open)
                {
                    Baglan.connection.Open();
                }
                try
                {
                    dogrula = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    // Bağlantıyı işimiz bitince kapatmalıyız, yoksa diğer formlar kullanamaz
                    Baglan.connection.Close();
                }

                return dogrula > 0; // 0'dan büyükse işlem başarılıdır
            }
        }
        private void ButtonEkle_Click_1(object sender, EventArgs e)
        {
            FormKaydet form = new FormKaydet();
            form.ShowDialog();
            if (form.Kaydedildi)
            {
                Listele();
            }
        }

        private void ButtonTamam_Click_1(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain.Show();
            this.Hide();

        }
        private void ButtonDuzenle_Click_1(object sender, EventArgs e)
        {
            // 1. Seçili satır var mı kontrol et
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please chose a row to update.");
                return;
            }

            try
            {
                // 2. DataGridView üzerindeki (belki de elle değiştirdiğiniz) güncel verileri al
                // Not: Sütun isimleri veritabanı ile birebir aynı olmalı
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["CatogoryId"].Value);
                string type = dataGridView1.CurrentRow.Cells["Type"].Value.ToString();
                string category = dataGridView1.CurrentRow.Cells["Catogory"].Value.ToString(); // DB'de Catogory yazıyor
                string month = dataGridView1.CurrentRow.Cells["Month"].Value.ToString();

                // Amount sayı olduğu için dönüşüm yapıyoruz
                int amount = 0;
                int.TryParse(dataGridView1.CurrentRow.Cells["Amount"].Value.ToString(), out amount);

                // 3. Veritabanı Bağlantısı ve Güncelleme Sorgusu
                // Bağlantı yolunu projenize göre ayarladık
                string connectionString = "Data Source=information.db;Version=3;";

                string sql = @"UPDATE Statistics 
                       SET Type = @pType, 
                           Catogory = @pCat, 
                           Month = @pMonth, 
                           Amount = @pAmount 
                       WHERE CatogoryId = @pId";

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
                    {
                        // Parametreleri ekle
                        cmd.Parameters.AddWithValue("@pType", type);
                        cmd.Parameters.AddWithValue("@pCat", category);
                        cmd.Parameters.AddWithValue("@pMonth", month);
                        cmd.Parameters.AddWithValue("@pAmount", amount);
                        cmd.Parameters.AddWithValue("@pId", id);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Satır başarıyla güncellendi!");

                            // Listeyi ve Grafiği yenile
                            Listele();

                            // Grafik güncelleme metodunuz DataTable istiyor, onu tekrar çekip verelim:
                            string query = "SELECT Month, Amount, Catogory, Type FROM Statistics";
                            SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection);
                            DataTable dtChart = new DataTable();
                            adapter.Fill(dtChart);
                            UpdateChart(dtChart);
                        }
                        else
                        {
                            MessageBox.Show("Update failed.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void ButtonSil_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int seciliid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["CatogoryId"].Value.ToString());
                string sql = "Delete from Statistics Where CatogoryId='" + seciliid + "' ";
                if (CRUD.ESD(sql))
                {
                    Listele();
                }
            }
        }

        private void ButtonGuncelle_Click_1(object sender, EventArgs e)
        {
            Listele();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)       {     }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}