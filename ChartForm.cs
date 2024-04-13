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
using MySql.Data.MySqlClient;
namespace GreenHouse
{
    public partial class ChartForm : Form
    {
        private All_data allData;
        private DateTime specificDate;
        public ChartForm()
        {

            InitializeComponent();
            InitializeComboBox();
            allData = new All_data();


           

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
                DrawChart(data);
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

            chart1.Series.Clear();
            chart1.ChartAreas.Clear();


            ChartArea chartArea = new ChartArea();
            chart1.ChartAreas.Add(chartArea);

            // Dodaj nową serię danych
            Series series = new Series();
            series.ChartType = SeriesChartType.Column;
            chart1.Series.Add(series);

            // Oblicz szerokość słupków na podstawie ilości danych
            double barWidth = 0.8;


            foreach (var entry in data)
            {
                series.Points.AddXY(entry.Key, entry.Value);
            }


            series["PixelPointWidth"] = barWidth.ToString();
        }


    }
    /// <summary>
    /// /////////////////////////////////////////////////////////////////////////////////////////////Klasa tymczasowoa do generowania danych
    /// </summary>
    /// 


}