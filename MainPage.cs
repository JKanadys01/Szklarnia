using LiveCharts.Wpf;
using LiveCharts;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin.Controls;

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
        private MaterialProgressBar TemperatureProgresBar;
        private MaterialProgressBar HumidityProgresBar;
        private MaterialProgressBar InsolationProgresBar;
        private MaterialLabel TemperatureLabel;
        private MaterialLabel HumidityLabel;
        private MaterialLabel InsolationLabel;
        private MaterialButton TempeAlarmButton;
        private MaterialButton HumAlarmButton;
        private MaterialButton InsAlarmButton;
        private MaterialTextBox TempMinTextBox;
        private MaterialTextBox TempMaxTextBox;
        private MaterialTextBox HumMinTextBox;
        private MaterialTextBox HumMaxTextBox;
        private MaterialTextBox InsMinTextBox;
        private MaterialTextBox InsMaxTextBox;
        private double temperatureMinAlarm;
        private double temperatureMaxAlarm;
        private double humidityMinAlarm;
        private double humidityMaxAlarm;
        private double insolationMinAlarm;
        private double insolationMaxAlarm;
        //Konstruktor przy pomocy którego możliwe jest odwołanie do obiektów Form1
        public MainPage(All_data allData, User userLog, LiveCharts.WinForms.CartesianChart temperatureChart, LiveCharts.WinForms.CartesianChart humidityChart,
            LiveCharts.WinForms.CartesianChart insolationChart, TabControl tabControl2,MaterialProgressBar temperatureProgresBar, MaterialProgressBar humidityProgresBar,
            MaterialProgressBar insolationProgresBar, MaterialLabel temperatureLabel, MaterialLabel humidityLabel, MaterialLabel insolationLabel, MaterialButton temperatureButton,
            MaterialButton humidityButton, MaterialButton insolationButton, MaterialTextBox tempminTextBox,MaterialTextBox tempmaxTextBox, MaterialTextBox humminTextBox,
            MaterialTextBox hummaxTextBox, MaterialTextBox insminTextBox,MaterialTextBox insmaxTextBox)
        {
            this.allData = allData;
            user_log = userLog;
            TemperatureChart = temperatureChart;
            HumidityChart = humidityChart;
            InsolationChart = insolationChart;
            this.tabControl2 = tabControl2;
            TemperatureProgresBar = temperatureProgresBar;
            HumidityProgresBar = humidityProgresBar;
            InsolationProgresBar = insolationProgresBar;
            TemperatureLabel = temperatureLabel;
            HumidityLabel = humidityLabel;
            InsolationLabel = insolationLabel;
            TempeAlarmButton = temperatureButton;
            HumAlarmButton = humidityButton;
            InsAlarmButton = insolationButton;
            TempMinTextBox = tempminTextBox;
            TempMaxTextBox = tempmaxTextBox;
            HumMinTextBox = humminTextBox;
            HumMaxTextBox = hummaxTextBox;
            InsMinTextBox = insminTextBox;
            InsMaxTextBox = insmaxTextBox;
            temperatureMinAlarm = 20.0;
            temperatureMaxAlarm = 30.0;
            humidityMinAlarm = 40.0;
            humidityMaxAlarm = 60.0;
            insolationMinAlarm = 30.0;
            insolationMaxAlarm = 70.0;
            TempMinTextBox.Text = temperatureMinAlarm.ToString();
            TempMaxTextBox.Text = temperatureMaxAlarm.ToString();
            HumMinTextBox.Text = humidityMinAlarm.ToString();
            HumMaxTextBox.Text = humidityMaxAlarm.ToString();
            InsMinTextBox.Text = insolationMinAlarm.ToString();
            InsMaxTextBox.Text = insolationMaxAlarm.ToString();
        }
        //Inicjalizacja Timera można tu zdefiniować czas po którym Timer_Tick zostanie wywołane
        public void Initialize()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 15000;
            timer.Tick += Timer_Tick;
        }
        //Start Stop przy starcie wywołujemy od razu Timer_TIck
        public void StartTimer()
        {
            Timer_Tick(null, EventArgs.Empty);
            timer.Start();
        }

        public void StopTimer()
        {
            timer.Stop();
        }
        //Ponowne wyrysowanie wykresu, aktualizacja danych progresBar oraz ponowne sprawdzenie alarmów
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
                UpdateProgressBars();
                CHeckAlarms();
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
        //Funckja odśewająca dane
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
        //Rysowane wykresu
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
        //Funkcja pomocnicza do wyboru rysownaia wykresu
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
        //Aktualizacja progresBarow
        private void UpdateProgressBars()
        {
            if (allData.records.Count > 0)
            {
                var latestRecord = allData.records.Last();
                TemperatureLabel.Text = $"Temperature:{latestRecord.temperature}°C";
                HumidityLabel.Text = $"Humidity:{latestRecord.humidity}%";
                InsolationLabel.Text = $"Insolation:{latestRecord.humidity}%";
                // Użycie Invoke, aby aktualizować ProgressBar w wątku UI
                TemperatureProgresBar.Invoke((MethodInvoker)delegate {
                    TemperatureProgresBar.Value = (int)latestRecord.temperature;
                });

                HumidityProgresBar.Invoke((MethodInvoker)delegate {
                    HumidityProgresBar.Value = (int)latestRecord.humidity;
                });

                InsolationProgresBar.Invoke((MethodInvoker)delegate {
                    InsolationProgresBar.Value = (int)latestRecord.humidity;
                });
            }
        }

        //Alarmy pamiętać że ponowne sprawdzenie jest w funkcji Timer_Tick

        private void CHeckAlarms()
        {
            if (allData.records.Count >0)
            {
                var latestRecord = allData.records.Last();
                if (latestRecord.temperature < temperatureMinAlarm || latestRecord.temperature > temperatureMaxAlarm)
                {
                    // Temperatura poza zakresem alarmowym
                    TempeAlarmButton.BackColor = System.Drawing.Color.Red;
                    TempeAlarmButton.Visible = true;
                }

                if (latestRecord.humidity < humidityMinAlarm || latestRecord.humidity > humidityMaxAlarm)
                {
                    // Wilgotność poza zakresem alarmowym
                    HumAlarmButton.BackColor = System.Drawing.Color.Red;
                    HumAlarmButton.Visible = true;
                }

               // if (latestRecord.insolation < insolationMinAlarm || latestRecord.insolation > insolationMaxAlarm)
                //{
                    // Nasłonecznienie poza zakresem alarmowym
                  //  InsAlarmButton.BackColor = System.Drawing.Color.Red;
                    //InsAlarmButton.Visible = true;
                //}
            }
        }
    }
}
