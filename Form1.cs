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
            mainPage = new MainPage(allData, user_log, TemperaturecartesianChart, humiditycartesianChart, InsolationcartesianChart,tabControl2);
            mainPage.Initialize();
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

        private void materialRadioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            mainPage.StartTimer();
            
        }

        private void StopmaterialRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            mainPage.StopTimer();
        }

        /////Obs³uga Chart page
        private void DrawchartmaterialButton_Click(object sender, EventArgs e)
        {
            chartPage.GenerateChart();
        }
    }
}
