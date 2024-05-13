using LiveCharts.Wpf;
using LiveCharts;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GreenHouse
{
    internal class ChartPage
    {
        private All_data allData;
        private DateTime specificDate;
        private User user_log;
        private MainPage mainPage;
        private MaterialComboBox ParametermaterialComboBox;
        private MaterialComboBox TimeFramematerialComboBox;
        private LiveCharts.WinForms.CartesianChart cartesianChart;
        private DateTimePicker dateTimePicker;
        //Konstruktor przy pomocy którego możliwe jest odwołanie do obiektów Form1
        public ChartPage(All_data allData, User user_log, MainPage mainPage, MaterialComboBox parameterComboBox, MaterialComboBox timeFrameComboBox, LiveCharts.WinForms.CartesianChart chart, DateTimePicker picker)
        {
            this.allData = allData;
            this.user_log = user_log;
            this.mainPage = mainPage;
            this.ParametermaterialComboBox = parameterComboBox;
            this.TimeFramematerialComboBox = timeFrameComboBox;
            this.cartesianChart = chart;
            this.dateTimePicker = picker;
        }
        //Inicjalizacja zawartości combobox
        public void InitializeComboBox()
        {
            ParametermaterialComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ParametermaterialComboBox.Items.AddRange(new object[] { "Temperature", "Humidity", "Insolation" });
            ParametermaterialComboBox.SelectedIndex = 0;

            TimeFramematerialComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TimeFramematerialComboBox.Items.AddRange(new object[] { "Today", "Last Week", "Last Month", "Specific Day" });
            TimeFramematerialComboBox.SelectedIndex = 0;
        }
        //Rysowanie wykresu
        public void DrawChart(Dictionary<DateTime, double> data, string parameter)
        {
            cartesianChart.Series.Clear();
            cartesianChart.AxisX.Clear();
            cartesianChart.AxisY.Clear();
            cartesianChart.Visible = true;

            LineSeries series = new LineSeries();

            series.Values = new ChartValues<double>();

            foreach (var entry in data)
            {
                series.Values.Add(entry.Value);
            }

            cartesianChart.Series.Add(series);

            if (ParametermaterialComboBox.SelectedItem.ToString() == "Temperature")
            {
                series.Title = "Temperature";
                cartesianChart.AxisY.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Temperature (°C)",
                    LabelFormatter = data => data.ToString("N2") + "°C"
                });
            }
            else if (ParametermaterialComboBox.SelectedItem.ToString() == "Humidity")
            {
                series.Title = "Humidity";
                cartesianChart.AxisY.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Humidity (%)",
                    LabelFormatter = data => data.ToString("N2") + "%"
                });
            }
            else if (ParametermaterialComboBox.SelectedItem.ToString() == "Insolation")
            {
                series.Title = "Insolation";
                cartesianChart.AxisY.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Insolation (%)",
                    LabelFormatter = data => data.ToString("N2") + "%"
                });

            }

            if (TimeFramematerialComboBox.SelectedItem.ToString() == "Specific Day" || TimeFramematerialComboBox.SelectedItem.ToString() == "Today")
            {
                cartesianChart.AxisX.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Time",
                    Labels = data.Keys.Select(key => key.ToString("HH:mm:ss")).ToList()
                });
            }
            else
            {
                cartesianChart.AxisX.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Date",
                    Labels = data.Keys.Select(key => key.ToString("MM/dd HH:mm:ss")).ToList()
                });
            }
        }
        //Odsiew pomiarów po parametrze
        public Dictionary<DateTime, double> GetDataForChart(string parameter, string timeFrame)
        {
            Dictionary<DateTime, double> data = new Dictionary<DateTime, double>();
            List<Record> selectedRecords = GetSelectedRecords(parameter, timeFrame);
            foreach (Record record in selectedRecords)
            {
                double value = 0.0;
                switch (parameter)
                {
                    case "Temperature":
                        value = record.temperature;
                        break;
                    case "Humidity":
                        value = record.humidity;
                        break;
                    case "Insolation":
                        value = record.humidity;
                        break;
                    default:
                        break;

                }
                data.Add(record.date_time, value);
            }
            return data;
        }
        //Odsiew pomiarów po zakresie czasowym
        public List<Record> GetSelectedRecords(string parameter, string timeFrame)
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
        // Funkcja pomocnicza by nie było informacji o braku dostepu do danych tak jak w MainPage Go_live
        public void GenerateChart()
        {
            // Pobieramy wybrane parametry z ComboBoxów
            string selectedParameter = ParametermaterialComboBox.SelectedItem?.ToString();
            string selectedTimeFrame = TimeFramematerialComboBox.SelectedItem?.ToString();

            // Sprawdzamy, czy wybrane parametry nie są puste
            if (selectedParameter != null && selectedTimeFrame != null)
            {
                // Tworzymy nowe połączenie z bazą danych
                MySqlConnection mySqlConnection = new MySqlConnection("server=127.0.0.1;user=root;database=szklarnia_v3;password=");

                mySqlConnection.Open();

                try
                {
                    MySqlCommand cmd = new MySqlCommand("select * from pomiar", mySqlConnection);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        allData.Add(new Record(reader.GetInt32(0), reader.GetDouble(3), reader.GetDouble(4), reader.GetDateTime(2)));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nie masz dostępu do tych danych", "Notatka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                mySqlConnection.Close();

                // Jeśli wybrany czas to "Specific Day", pobieramy datę z kontrolki DateTimePicker
                if (selectedTimeFrame == "Specific Day")
                {
                    specificDate = dateTimePicker.Value;
                }

                // Pobieramy dane dla wybranego parametru i przedziału czasowego
                Dictionary<DateTime, double> data = GetDataForChart(selectedParameter, selectedTimeFrame);

                // Sprawdzamy, czy dane zostały pobrane poprawnie
                if (data.Count > 0)
                {
                    // Rysujemy wykres
                    DrawChart(data, selectedParameter);
                }
                else
                {
                    // Jeśli nie znaleziono danych, wyświetlamy odpowiedni komunikat
                    MessageBox.Show("Nie znaleziono danych dla podanego przedziału czasowego.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // Jeśli nie wybrano parametrów, wyświetlamy odpowiedni komunikat
                MessageBox.Show("Wybierz parametr i przedział czasowy.");
            }
        }

    }
}
