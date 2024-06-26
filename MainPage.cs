﻿using LiveCharts.Wpf;
using LiveCharts;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin.Controls;
using System.Data;

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
        private MaterialTextBox TempMinTextBox;
        private MaterialTextBox TempMaxTextBox;
        private MaterialComboBox AlarmCombobox;
        private double temperatureMinAlarm;
        private double temperatureMaxAlarm;
        private MaterialComboBox DeviceCombobox;
        private MaterialMultiLineTextBox AlarmTextBox;
        //Konstruktor przy pomocy którego możliwe jest odwołanie do obiektów Form1
        public MainPage(All_data allData, User userLog, LiveCharts.WinForms.CartesianChart temperatureChart, LiveCharts.WinForms.CartesianChart humidityChart,
            LiveCharts.WinForms.CartesianChart insolationChart, TabControl tabControl2,MaterialProgressBar temperatureProgresBar, MaterialProgressBar humidityProgresBar,
            MaterialProgressBar insolationProgresBar, MaterialLabel temperatureLabel, MaterialLabel humidityLabel, MaterialLabel insolationLabel, 
            MaterialTextBox tempminTextBox,MaterialTextBox tempmaxTextBox, MaterialComboBox alarmComboBox,MaterialComboBox deviceComboBox,MaterialMultiLineTextBox  alarmTextBox)
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
            TempMinTextBox = tempminTextBox;
            TempMaxTextBox = tempmaxTextBox;
            AlarmCombobox = alarmComboBox;
            DeviceCombobox = deviceComboBox;
            temperatureMinAlarm = 20.0;
            temperatureMaxAlarm = 30.0;
            AlarmTextBox = alarmTextBox;
            TempMinTextBox.Text = temperatureMinAlarm.ToString();
            TempMaxTextBox.Text = temperatureMaxAlarm.ToString();
            
        }

        public void InitializeComboBox()
        {
            AlarmCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            AlarmCombobox.Items.Clear();
            AlarmCombobox.Items.AddRange(new object[] { "Temperature", "Humidity", "Insolation" });
            AlarmCombobox.SelectedIndex = 0;
            DeviceCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            DeviceCombobox.Items.Clear();
            MySqlConnection mySqlConnection;
            List<Device> device = new List<Device>();

            try
            {
                mySqlConnection = new MySqlConnection("server=127.0.0.1;user=root;database=szklarnia_v3;password=");

                mySqlConnection.Open();

                MySqlCommand cmd = new MySqlCommand("GetAllDevices", mySqlConnection);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userToken", user_log.token);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    device.Add(new Device(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetString(3)));
                }
                mySqlConnection.Close();
                foreach(Device i in device)
                {
                    DeviceCombobox.Items.Add(i.serial_number);

                }
                DeviceCombobox.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to download the list", "Failed to download the list", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


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
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection("server=127.0.0.1;user=root;database=szklarnia_v3;password=");

                mySqlConnection.Open();

                MySqlCommand cmd = new MySqlCommand("GetMeasurementsByDeviceId", mySqlConnection);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userToken", user_log.token);
                cmd.Parameters.AddWithValue("@deviceId", DeviceCombobox.SelectedItem); 
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    allData.Add(new Record(reader.GetInt32(0), reader.GetDouble(3), reader.GetDouble(4), reader.GetDateTime(2),reader.GetInt32(1),reader.GetDouble(5)));
                }
                mySqlConnection.Close();
                UpdateProgressBars();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to download data", "Failed to download data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
           
            //Tutaj dopisałem zaczytanie pojedyńczego
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection("server=127.0.0.1;user=root;database=szklarnia_v3;password=");

                mySqlConnection.Open();

                MySqlCommand cmd = new MySqlCommand("GetLatestMeasurementByDeviceId", mySqlConnection);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userToken", user_log.token);
                cmd.Parameters.AddWithValue("@deviceId", DeviceCombobox.SelectedItem); //Tutaj zmienić trzeba na to urządzenie które jest wybrane
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    allData.Add(new Record(reader.GetInt32(0), reader.GetDouble(3), reader.GetDouble(4), reader.GetDateTime(2), reader.GetInt32(1), reader.GetDouble(5)));
                }
                mySqlConnection.Close();
                UpdateProgressBars();
                CHeckAlarms();
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to download data", "Failed to download data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            

            Dictionary<DateTime, double> data = GetDataForChart();
            if (data.Count > 0)
            {
                DrawChart(data);
            }
            else
            {
                timer.Stop();
                MessageBox.Show("No data was found for the specified time period or device.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //Funckja odśewająca dane
        private Dictionary<DateTime, double> GetDataForChart()
        {
            List<Record> allRecords = allData.records;
            Dictionary<DateTime, double> data = new Dictionary<DateTime, double>();
            List<Record> selectedRecords = allRecords.Where(record => record.serial_number == int.Parse(DeviceCombobox.SelectedItem.ToString()) && record.date_time.Date == DateTime.Today.Date).ToList();
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
                        value = record.insolation;
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
                    LabelFormatter = data => data.ToString("N2") + "Lx"
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
                InsolationLabel.Text = $"Insolation:{latestRecord.insolation}Lx";
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

        public void CHeckAlarms()
        {
            AlarmTextBox.Clear();
            MySqlConnection mySqlConnection;
            List<Alarm> alarm = new List<Alarm>();
            List<AlarmParameter> alarmParameter = new List<AlarmParameter>();

            try
            {
                mySqlConnection = new MySqlConnection("server=127.0.0.1;user=root;database=szklarnia_v3;password=");

                mySqlConnection.Open();

                MySqlCommand cmd1 = new MySqlCommand("GetAlarmParametersByTokenAndDeviceId", mySqlConnection);

                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@user_token", user_log.token);
                cmd1.Parameters.AddWithValue("@device_id", DeviceCombobox.SelectedItem);
                MySqlDataReader reader1 = cmd1.ExecuteReader();

                while (reader1.Read())
                {
                    alarmParameter.Add(new AlarmParameter(reader1.GetInt32(0), reader1.GetInt32(2), reader1.GetString(3), reader1.GetFloat(4), reader1.GetFloat(5)));

                }
                mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to download the list", "Failed to download the list", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            try
            {
                mySqlConnection = new MySqlConnection("server=127.0.0.1;user=root;database=szklarnia_v3;password=");

                mySqlConnection.Open();

                MySqlCommand cmd = new MySqlCommand("GetUserAlarmsByDevice", mySqlConnection);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user_token", user_log.token);
                cmd.Parameters.AddWithValue("@device_id", DeviceCombobox.SelectedItem);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    alarm.Add(new Alarm(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), 
                        alarmParameter.FirstOrDefault(x => x.id == reader.GetInt32(1)), allData.records.FirstOrDefault(x => x.id == reader.GetInt32(2))));

                }
                mySqlConnection.Close();
                foreach (Alarm i in alarm)
                {
                    AlarmTextBox.Text += i.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to download the list", "Failed to download the list", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
