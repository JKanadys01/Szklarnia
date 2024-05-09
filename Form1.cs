using Google.Protobuf.WellKnownTypes;
using LiveCharts;
using LiveCharts.Definitions.Charts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace GreenHouse
{
    public partial class Form1 : MaterialForm
    {
        private All_data allData;
        private DateTime specificDate;
        private System.Windows.Forms.Timer timer;
        private User user_log;
        public Form1(User x)
        {
            user_log = x;
            InitializeComponent();
            allData = new All_data();
            this.WindowState = FormWindowState.Maximized;
            Username_materialTextBox.Text = user_log.get_name();
            // Inicjalizacja timera
            timer = new System.Windows.Forms.Timer(); // Zmieniono Timer na System.Windows.Forms.Timer
            timer.Interval = 5000; // Ustawienie interwa³u na 5 sekund
            timer.Tick += Timer_Tick;
            ///Main page
            TemperaturecartesianChart.Visible = false;
            humiditycartesianChart.Visible = false;
            InsolationcartesianChart.Visible = false;
            ///Chart page
            cartesianChart.Visible = false;
            InitializeComboBox();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// Obsl³uga Main page
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
                        value = record.humidity; // Za³ó¿my, ¿e mamy pole humidity w rekordzie
                        break;
                    case "InsolationTabPage":
                        value = record.humidity; // Za³ó¿my, ¿e mamy pole insolation w rekordzie
                        break;
                    default:
                        break;

                }
                data.Add(record.date_time, value);
            }
            return data;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(user_log.get_mysqlconn());

            mySqlConnection.Open();

            //TEST
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
                MessageBox.Show("Nie masz dostêpnu do tych danych", "Notatka", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Nie znaleziono danych dla podanego przedzia³u czasowego.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        private LiveCharts.WinForms.CartesianChart GetChartByName(string tableName)
        {
            switch (tableName)
            {
                case "TemperatureTabPage":
                    return TemperaturecartesianChart;
                case "HumidityTabPage":
                    return humiditycartesianChart;
                case "InsolationTabPage":
                    return InsolationcartesianChart;
                default:
                    return null; // Obs³uga, gdy nazwa wykresu nie pasuje do ¿adnego przypadku
            }
        }


        private void DrawChart(Dictionary<DateTime, double> data)
        {
            string tableName = tabControl2.SelectedTab.Name.ToString();


            GetChartByName(tableName).Series.Clear();
            GetChartByName(tableName).AxisX.Clear();
            GetChartByName(tableName).AxisY.Clear();
            GetChartByName(tableName).Visible = true;


            // Tworzenie nowej serii danych (np. LineSeries dla wykresu liniowego)
            LineSeries series = new LineSeries();


            series.Values = new ChartValues<double>(); // Wartoœci punktów danych

            // Dodawanie danych do serii
            foreach (var entry in data)
            {
                series.Values.Add(entry.Value);
            }

            // Dodawanie serii do kolekcji serii wykresu
            GetChartByName(tableName).Series.Add(series);

            if (tableName == "TemperatureTabPage")
            {
                series.Title = "Temperature";
                GetChartByName(tableName).AxisY.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Temperature (°C)", // Tytu³ osi Y
                    LabelFormatter = data => data.ToString("N2") + "°C"
                });
            }
            else if (tableName == "HumidityTabPage")
            {
                series.Title = "Humidity";
                GetChartByName(tableName).AxisY.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Humidity (%)", // Tytu³ osi Y
                    LabelFormatter = data => data.ToString("N2") + "%"
                });
            }
            else if (tableName == "InsolationTabPage")
            {
                series.Title = "Insolation";
                GetChartByName(tableName).AxisY.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Insolation (%)", // Tytu³ osi Y
                    LabelFormatter = data => data.ToString("N2") + "%"
                });

            }

            GetChartByName(tableName).AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Time", // Tytu³ osi X
                Labels = data.Keys.Select(key => key.ToString("HH:mm:ss")).ToList() // Etykiety osi X
            });


        }

        private void logoutmaterialButton_Click(object sender, EventArgs e)
        {
            // Zamknij bie¿¹cy formularz
            this.Hide();
            // Otwórz ponownie formularz logowania
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }

        private void materialRadioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void StopmaterialRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            timer.Stop();
        }






        /////Obs³uga Chart page


        private void InitializeComboBox()
        {
            ParametermaterialComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ParametermaterialComboBox.Items.AddRange(new object[] { "Temperature", "Humidity", "Insolation" });
            ParametermaterialComboBox.SelectedIndex = 0;

            TimeFramematerialComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TimeFramematerialComboBox.Items.AddRange(new object[] { "Today", "Last Week", "Last Month", "Specific Day" });
            TimeFramematerialComboBox.SelectedIndex = 0;
        }

        private void DrawchartmaterialButton_Click(object sender, EventArgs e)
        {
            string selectedParameter = ParametermaterialComboBox.SelectedItem?.ToString();
            string selectedTimeFrame = TimeFramematerialComboBox.SelectedItem?.ToString();


            MySqlConnection mySqlConnection = new MySqlConnection(user_log.get_mysqlconn());

            mySqlConnection.Open();

            //TEST
            try
            {


                MySqlCommand cmd = new MySqlCommand("select * from szklarnia_1", mySqlConnection);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    allData.Add(new Record(reader.GetInt32(0), reader.GetDouble(1), reader.GetDouble(2), reader.GetDateTime(3)));
                }


            }
            catch (Exception ex)
            {
                timer.Stop();
              //  MessageBox.Show("Nie masz dostêpnu do tych danych", "Notatka", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            mySqlConnection.Close();

            if (selectedParameter != null && selectedTimeFrame != null)
            {
                if (selectedTimeFrame == "Specific Day")
                {
                    // Pobieramy wybran¹ datê z kontrolki DateTimePicker
                    specificDate = dateTimePicker.Value;

                }

                // Pobierz dane dla wybranego parametru i przedzia³u czasowego
                Dictionary<DateTime, double> data = GetDataForChartChart(selectedParameter, selectedTimeFrame);

                if (data.Count > 0)
                {
                    DrawChartChart(data, selectedParameter);
                }
                else
                {
                    timer.Stop();
                    MessageBox.Show("Nie znaleziono danych dla podanego przedzia³u czasowego.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Wybierz parametr i przedzia³ czasowy.");
            }
        }


        private Dictionary<DateTime, double> GetDataForChartChart(string parameter, string timeFrame)
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
                        value = record.humidity; // Za³ó¿my, ¿e mamy pole humidity w rekordzie
                        break;
                    case "Insolation":
                        value = record.humidity; // Za³ó¿my, ¿e mamy pole insolation w rekordzie
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


        private void DrawChartChart(Dictionary<DateTime, double> data, string parameter)
        {
            // Czyszczenie serii danych i obszarów wykresu
            cartesianChart.Series.Clear();
            cartesianChart.AxisX.Clear();
            cartesianChart.AxisY.Clear();
            cartesianChart.Visible = true;

            // Tworzenie nowej serii danych (np. LineSeries dla wykresu liniowego)
            LineSeries series = new LineSeries();


            series.Values = new ChartValues<double>(); // Wartoœci punktów danych

            // Dodawanie danych do serii
            foreach (var entry in data)
            {
                series.Values.Add(entry.Value);
            }

            // Dodawanie serii do kolekcji serii wykresu
            cartesianChart.Series.Add(series);

            if (ParametermaterialComboBox.SelectedItem.ToString() == "Temperature")
            {
                series.Title = "Temperature";
                cartesianChart.AxisY.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Temperature (°C)", // Tytu³ osi Y
                    LabelFormatter = data => data.ToString("N2") + "°C"
                });
            }
            else if (ParametermaterialComboBox.SelectedItem.ToString() == "Humidity")
            {
                series.Title = "Humidity";
                cartesianChart.AxisY.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Humidity (%)", // Tytu³ osi Y
                    LabelFormatter = data => data.ToString("N2") + "%"
                });
            }
            else if (ParametermaterialComboBox.SelectedItem.ToString() == "Insolation")
            {
                series.Title = "Insolation";
                cartesianChart.AxisY.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Insolation (%)", // Tytu³ osi Y
                    LabelFormatter = data => data.ToString("N2") + "%"
                });

            }


            // Ustawianie formatu osi X w zale¿noœci od wybranej opcji czasowej
            if (TimeFramematerialComboBox.SelectedItem.ToString() == "Specific Day" || TimeFramematerialComboBox.SelectedItem.ToString() == "Today")
            {
                cartesianChart.AxisX.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Time", // Tytu³ osi X
                    Labels = data.Keys.Select(key => key.ToString("HH:mm:ss")).ToList() // Etykiety osi X
                });
            }
            else
            {
                cartesianChart.AxisX.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Date", // Tytu³ osi X
                    Labels = data.Keys.Select(key => key.ToString("MM/dd HH:mm:ss")).ToList() // Etykiety osi X
                });
            }



        }


    }
}
