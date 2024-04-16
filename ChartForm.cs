using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using LiveCharts.Wpf;
using LiveCharts;
using MySql.Data.MySqlClient;
namespace GreenHouse
{
    public partial class ChartForm : Form
    {
        private All_data allData;
        private DateTime specificDate;
        private bool automaticUpdateEnabled = false;
        private System.Windows.Forms.Timer timer;
        public ChartForm()
        {

            InitializeComponent();
            InitializeComboBox();
            allData = new All_data();
            cartesianChart1.Visible = false;

            // Inicjalizacja timera
            timer = new System.Windows.Forms.Timer(); // Zmieniono Timer na System.Windows.Forms.Timer
            timer.Interval = 5000; // Ustawienie interwału na 5 sekund
            timer.Tick += Timer_Tick;

        }


        private void InitializeComboBox()
        {
            comboBoxParameters.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxParameters.Items.AddRange(new object[] { "Temperature", "Humidity", "Insolation" });
            comboBoxParameters.SelectedIndex = 0;

            comboBoxTimeFrame.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTimeFrame.Items.AddRange(new object[] { "Today", "Last Week", "Last Month", "Specific Day" });
            comboBoxTimeFrame.SelectedIndex = 0;
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            string selectedParameter = comboBoxParameters.SelectedItem?.ToString();
            string selectedTimeFrame = comboBoxTimeFrame.SelectedItem?.ToString();

            //TEST

            string mysqlconn = "server=127.0.0.1;user=root;database=szklarnia_v2;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlconn);

            mySqlConnection.Open();

            MySqlCommand cmd = new MySqlCommand("select * from szklarnia_1", mySqlConnection);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                allData.Add(new Record(reader.GetInt32(0), reader.GetDouble(1), reader.GetDouble(2), reader.GetDateTime(3)));
            }

            mySqlConnection.Close();

            if (selectedParameter != null && selectedTimeFrame != null)
            {
                if (selectedTimeFrame == "Specific Day")
                {
                    // Pobieramy wybraną datę z kontrolki DateTimePicker
                    specificDate = dateTimePicker1.Value;

                }

                // Pobierz dane dla wybranego parametru i przedziału czasowego
                Dictionary<DateTime, double> data = GetDataForChart(selectedParameter, selectedTimeFrame);

                if (data.Count > 0)
                {
                    DrawChart(data);
                }
                else
                {
                    MessageBox.Show("Nie znaleziono danych dla podanego przedziału czasowego.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Wybierz parametr i przedział czasowy.");
            }

        }

        private Dictionary<DateTime, double> GetDataForChart(string parameter, string timeFrame)
        {
            Dictionary<DateTime, double> data = new Dictionary<DateTime, double>();
            List<Record> selectedRecords = GetSelectedRecords(parameter, timeFrame);
            foreach (Record record in selectedRecords)
            {
                double value = 0;
                switch (parameter)
                {
                    case "Temperature":
                        value = record.temperature;
                        break;
                    case "Humidity":
                        value = record.humidity; // Załóżmy, że mamy pole humidity w rekordzie
                        break;
                    case "Insolation":
                        value = record.temperature; // Załóżmy, że mamy pole insolation w rekordzie
                        break;
                    default:
                        break;

                }
                data.Add(record.date_time, value);
            }
            return data;
        }

        private List<Record> GetSelectedRecords(string parameter, string timeFrame)
        {
            List<Record> allRecords = allData.records;
            List<Record> selectedRecords = new List<Record>();

            switch (timeFrame)
            {
                case "Today":

                    selectedRecords = allRecords.Where(record => record.date_time.Date == DateTime.Today.Date).ToList();
                    break;
                case "Last Week":

                    DateTime lastWeekStart = DateTime.Today.AddDays(-6).Date;
                    DateTime lastWeekEnd = DateTime.Today.Date;
                    selectedRecords = allRecords.Where(record => record.date_time.Date >= lastWeekStart && record.date_time.Date <= lastWeekEnd).ToList();
                    break;
                case "Last Month":

                    DateTime lastMonthStart = DateTime.Today.AddMonths(-1).Date;
                    DateTime lastMonthEnd = DateTime.Today.Date;
                    selectedRecords = allRecords.Where(record => record.date_time.Date >= lastMonthStart && record.date_time.Date <= lastMonthEnd).ToList();
                    break;
                case "Specific Day":
                    selectedRecords = allRecords.Where(record => record.date_time.Date == specificDate.Date).ToList();

                    break;
                default:
                    break;
            }
            return selectedRecords;
        }

        private void DrawChart(Dictionary<DateTime, double> data)
        {
            // Czyszczenie serii danych i obszarów wykresu
            cartesianChart1.Series.Clear();
            cartesianChart1.AxisX.Clear();

            cartesianChart1.Visible = true;
            // Tworzenie nowej serii danych (np. LineSeries dla wykresu liniowego)
            LineSeries series = new LineSeries();
            series.Title = "Data"; // Tytuł serii danych
            series.Values = new ChartValues<double>(); // Wartości punktów danych

            // Dodawanie danych do serii
            foreach (var entry in data)
            {
                series.Values.Add(entry.Value);
            }

            // Dodawanie serii do kolekcji serii wykresu
            cartesianChart1.Series.Add(series);

            // Ustawianie formatu osi X w zależności od wybranej opcji czasowej
            if (comboBoxTimeFrame.SelectedItem.ToString() == "Specific Day" || comboBoxTimeFrame.SelectedItem.ToString() == "Today")
            {
                cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Time", // Tytuł osi X
                    Labels = data.Keys.Select(key => key.ToString("HH:mm:ss")).ToList() // Etykiety osi X
                });
            }
            else
            {
                cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Date", // Tytuł osi X
                    Labels = data.Keys.Select(key => key.ToString("MM/dd")).ToList() // Etykiety osi X
                });
            }
        }

        

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Wywołaj metodę, która ponownie pobierze dane i narysuje wykres
            buttonDraw_Click(this, EventArgs.Empty);
        }
        private void live_button_Click(object sender, EventArgs e)
        {
            // Włącz lub wyłącz timer w zależności od jego aktualnego stanu
            if (!timer.Enabled)
            {
                timer.Start();
            }
            else
            {
                timer.Stop();
            }
        }
    }
}