using LiveCharts.Wpf;
using LiveCharts;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse
{
    internal class MainPage
    {
        private All_data allData;
        private User user_log;
        private System.Windows.Forms.Timer timer;
        private LiveCharts.WinForms.CartesianChart TemperatureChart;
        private LiveCharts.WinForms.CartesianChart HumidityChart;
        private LiveCharts.WinForms.CartesianChart InsolationChart;
        private TabControl tabControl2;

        public MainPage(All_data allData, User userLog, LiveCharts.WinForms.CartesianChart temperatureChart, LiveCharts.WinForms.CartesianChart humidityChart, LiveCharts.WinForms.CartesianChart insolationChart, TabControl tabControl2)
        {
            this.allData = allData;
            user_log = userLog;
            TemperatureChart = temperatureChart;
            HumidityChart = humidityChart;
            InsolationChart = insolationChart;
            this.tabControl2 = tabControl2;
            
        }

        public void Initialize()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 10000;
            timer.Tick += Timer_Tick;
        }

        public void StartTimer()
        {
            timer.Start();
        }

        public void StopTimer()
        {
            timer.Stop();
        }

        public void Timer_Tick(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(user_log.get_mysqlconn());

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
                timer.Stop();
                MessageBox.Show("Nie masz dostępu do tych danych", "Notatka", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            mySqlConnection.Close();

            Dictionary<DateTime, double> data = GetDataForChart();
            if (data.Count > 0)
            {
                DrawChart(data);
            }
            else
            {
                timer.Stop();
                MessageBox.Show("Nie znaleziono danych dla podanego przedziału czasowego.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private Dictionary<DateTime, double> GetDataForChart()
        {
            List<Record> allRecords = allData.records;
            Dictionary<DateTime, double> data = new Dictionary<DateTime, double>();
            List<Record> selectedRecords = allRecords.Where(record => record.date_time.Date == DateTime.Today.Date).ToList();
            string tableName = tabControl2.SelectedTab.Name.ToString();
            foreach (Record record in selectedRecords)
            {
                double value = 0.0;
                switch (tableName)
                {
                    case "TemperatureTabPage":
                        value = record.temperature;
                        break;
                    case "HumidityTabPage":
                        value = record.humidity;
                        break;
                    case "InsolationTabPage":
                        value = record.humidity;
                        break;
                    default:
                        break;
                }
                data.Add(record.date_time, value);
            }
            return data;
        }

        private void DrawChart(Dictionary<DateTime, double> data)
        {
            string tableName = tabControl2.SelectedTab.Name.ToString();

            GetChartByName(tableName).Series.Clear();
            GetChartByName(tableName).AxisX.Clear();
            GetChartByName(tableName).AxisY.Clear();
            GetChartByName(tableName).Visible = true;

            LineSeries series = new LineSeries();

            series.Values = new ChartValues<double>();
            foreach (var entry in data)
            {
                series.Values.Add(entry.Value);
            }

            GetChartByName(tableName).Series.Add(series);

            if (tableName == "TemperatureTabPage")
            {
                series.Title = "Temperature";
                GetChartByName(tableName).AxisY.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Temperature (°C)",
                    LabelFormatter = data => data.ToString("N2") + "°C"
                });
            }
            else if (tableName == "HumidityTabPage")
            {
                series.Title = "Humidity";
                GetChartByName(tableName).AxisY.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Humidity (%)",
                    LabelFormatter = data => data.ToString("N2") + "%"
                });
            }
            else if (tableName == "InsolationTabPage")
            {
                series.Title = "Insolation";
                GetChartByName(tableName).AxisY.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Insolation (%)",
                    LabelFormatter = data => data.ToString("N2") + "%"
                });
            }

            GetChartByName(tableName).AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Time",
                Labels = data.Keys.Select(key => key.ToString("HH:mm:ss")).ToList()
            });
        }

        private LiveCharts.WinForms.CartesianChart GetChartByName(string tableName)
        {
            switch (tableName)
            {
                case "TemperatureTabPage":
                    return TemperatureChart;
                case "HumidityTabPage":
                    return HumidityChart;
                case "InsolationTabPage":
                    return InsolationChart;
                default:
                    return null;
            }
        }
    }
}
