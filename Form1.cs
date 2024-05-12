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
        private User user_log;
        private MainPage mainPage;
        private ChartPage chartPage;
        public Form1(User x)
        {
            user_log = x;
            InitializeComponent();
            allData = new All_data();
            this.WindowState = FormWindowState.Maximized;
            Username_materialTextBox.Text = user_log.get_name();

            ///Main page
            TemperaturecartesianChart.Visible = false;
            humiditycartesianChart.Visible = false;
            InsolationcartesianChart.Visible = false;
            mainPage = new MainPage(allData, user_log, TemperaturecartesianChart, humiditycartesianChart, InsolationcartesianChart, tabControl2, TemperatureProgressBar, HumidityProgressBar,
                InsolationProgressBar, temperaturematerialLabel, humiditymaterialLabel, insolationmaterialLabel, TemperatureAlarmButton, HumidityAlarmButton, InsolationAlarmButton, TempMinTextBox,
                TempMaxTextBox, HumMinTextBox, HumMaxTextBox, InsMinTextBox, InsMaxTextBox);
            mainPage.Initialize();
            ///Alarmy
            TemperatureAlarmButton.Visible = false;
            HumidityAlarmButton.Visible = false;
            InsolationAlarmButton.Visible = false;
            ///Chart page
            cartesianChart.Visible = false;
            chartPage = new ChartPage(allData, user_log, mainPage, ParametermaterialComboBox, TimeFramematerialComboBox, cartesianChart, dateTimePicker);
            chartPage.InitializeComboBox();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// Obsl³uga Main page
        private void logoutmaterialButton_Click(object sender, EventArgs e)
        {
            // Zamknij bie¿¹cy formularz
            this.Hide();
            // Otwórz ponownie formularz logowania
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }

        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialSwitch1.Checked == true)
            {
                mainPage.StartTimer();
            }
            else
            {
                mainPage.StopTimer();
            }
        }
        /////Obs³uga Chart page
        private void DrawchartmaterialButton_Click(object sender, EventArgs e)
        {
            chartPage.GenerateChart();
        }
        /// Obs³uga alarmów
        private void TemperatureAlarmButton_Click(object sender, EventArgs e)
        {
            TemperatureAlarmButton.Visible=false;
        }

        private void HumidityAlarmButton_Click(object sender, EventArgs e)
        {
            HumidityAlarmButton.Visible=false;
        }

        private void InsolationAlarmButton_Click(object sender, EventArgs e)
        {
            InsolationAlarmButton.Visible=false;
        }
    }
}
