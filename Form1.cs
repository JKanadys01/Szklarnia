using Google.Protobuf.WellKnownTypes;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;

namespace GreenHouse
{
    public partial class Form1 : MaterialForm
    {
        private All_data allData;
        private System.Windows.Forms.Timer timer;
        private User user_log;
        public Form1(User x)
        {

            user_log = x;
            InitializeComponent();
            allData = new All_data();
            this.WindowState = FormWindowState.Maximized;
            

            username_materialTextBox.Text = user_log.get_name();

            // Inicjalizacja timera
            timer = new System.Windows.Forms.Timer(); // Zmieniono Timer na System.Windows.Forms.Timer
            timer.Interval = 5000; // Ustawienie interwa³u na 5 sekund
            timer.Tick += Timer_Tick;
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

        private void Chartmenu_materialButton_Click(object sender, EventArgs e)
        {

            ChartForm chartForm = new ChartForm(user_log);
            chartForm.WindowState = FormWindowState.Maximized;
            this.Hide();
            chartForm.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void StopmaterialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            timer.Stop();
        }
        private Dictionary<DateTime, double> GetDataForChart()
        {
            List<Record> allRecords = allData.records;
            Dictionary<DateTime, double> data = new Dictionary<DateTime, double>();
            List<Record> selectedRecords = allRecords.Where(record => record.date_time.Date == DateTime.Today.Date).ToList();
            string tableName = tabControl1.SelectedTab.Name.ToString();
            foreach (Record record in selectedRecords)
            {
                double value = 0.0;
                switch (tableName)
                {
                    case "TemperaturetabPage":
                        value = record.temperature;
                        break;
                    case "humiditytabPage":
                        value = record.humidity; // Za³ó¿my, ¿e mamy pole humidity w rekordzie
                        break;
                    case "InsolationtabPage":
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
                case "TemperaturetabPage":
                    return TemperaturecartesianChart;
                case "humiditytabPage":
                    return humiditycartesianChart;
                case "InsolationtabPage":
                    return InsolationcartesianChart;
                default:
                    return null; // Obs³uga, gdy nazwa wykresu nie pasuje do ¿adnego przypadku
            }
        }


        private void DrawChart(Dictionary<DateTime, double> data)
        {
            string tableName = tabControl1.SelectedTab.Name.ToString();
            

            GetChartByName(tableName).Series.Clear();
            GetChartByName(tableName).AxisX.Clear();
            GetChartByName(tableName).AxisY.Clear();



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

            if (tableName == "TemperaturetabPage")
            {
                series.Title = "Temperature";
                GetChartByName(tableName).AxisY.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Temperature (°C)", // Tytu³ osi Y
                    LabelFormatter = data => data.ToString("N2") + "°C"
                });
            }
            else if (tableName == "humiditytabPage")
            {
                series.Title = "Humidity";
                GetChartByName(tableName).AxisY.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Humidity (%)", // Tytu³ osi Y
                    LabelFormatter = data => data.ToString("N2") + "%"
                });
            }
            else if (tableName == "InsolationtabPage")
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

        
    }
}
