using System;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProjeHazırlık1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void ButtonDatabase_Click(object sender, EventArgs e)
        {
            FormDatabase database = new FormDatabase();
            database.Show();
            this.Hide();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Initialize chart appearance when form loads
            InitializeChart();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ButtonDBUpdate_Click(object sender, EventArgs e)
        {
            string dbPath = "Data Source=information.db"; // SQLite DB Path
            string query = "SELECT Month, Amount, Catogory FROM Statistics";

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
            // Initialize the chart control
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.Titles.Clear();

            // Add a ChartArea
            ChartArea chartArea = new ChartArea("MainArea");
            chart1.ChartAreas.Add(chartArea);

            // Set Chart Title
            chart1.Titles.Add("İstatistikler");
        }

        private void UpdateChart(DataTable dataTable)
        {
            chart1.Series.Clear();

            // Get distinct categories
            var categories = dataTable.AsEnumerable()
                                      .Select(row => row.Field<string>("Catogory"))
                                      .Distinct();

            foreach (string category in categories)
            {
                // Create a series for each category
                Series series = new Series(category)
                {
                    ChartType = SeriesChartType.Column
                };

                // Filter rows for this category and add data points
                var rows = dataTable.Select($"Catogory = '{category}'");

                foreach (var row in rows)
                {
                    string month = row["Month"].ToString();
                    int amount = Convert.ToInt32(row["Amount"]);

                    series.Points.AddXY(month, amount);
                }

                chart1.Series.Add(series);
            }
        }
    }
}
