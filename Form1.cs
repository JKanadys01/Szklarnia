using Google.Protobuf.WellKnownTypes;
using LiveCharts;
using LiveCharts.Definitions.Charts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using System.Data;
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
            Username_materialTextBox.Text = user_log.token.ToString();

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

            // Otwórz ponownie formularz logowania

            MySqlConnection mySqlConnection;

            try
            {
                mySqlConnection = new MySqlConnection("server=127.0.0.1;user=root;database=szklarnia_v3;password=");

                mySqlConnection.Open();

                MySqlCommand cmd = new MySqlCommand("ResetUserStatusByToken", mySqlConnection);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userToken", user_log.token);
                cmd.ExecuteNonQuery();


                mySqlConnection.Close();
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie uda³o siê wylogowaæ", "Nie uda³o siê wylogowaæ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }




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
            TemperatureAlarmButton.Visible = false;
        }

        private void HumidityAlarmButton_Click(object sender, EventArgs e)
        {
            HumidityAlarmButton.Visible = false;
        }

        private void InsolationAlarmButton_Click(object sender, EventArgs e)
        {
            InsolationAlarmButton.Visible = false;
        }

        private void SetAlarmlButton_Click(object sender, EventArgs e)
        {
            // procedura setowania alarmu
        }

        private void UserCreatelButton_Click(object sender, EventArgs e)
        {




        }

        private void UserCreatelButton_Click_1(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection;

            try
            {
                mySqlConnection = new MySqlConnection("server=127.0.0.1;user=root;database=szklarnia_v3;password=");

                mySqlConnection.Open();

                MySqlCommand cmd = new MySqlCommand("CreateNewUser", mySqlConnection);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userToken", user_log.token);
                cmd.Parameters.AddWithValue("@userLogin", UserLoginTextBox.Text);
                cmd.Parameters.AddWithValue("@userPassword", UserPasswordTextBox.Text);
                cmd.Parameters.AddWithValue("@userDescription", UserDescriptionTextBox.Text);
                cmd.ExecuteNonQuery();


                mySqlConnection.Close();
                MessageBox.Show("Uda³o siê", "Uda³o siê", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie uda³o siê utworzyæ u¿ytkownika", "Nie uda³o siê utworzyæ u¿ytkownika", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PullUserListButton_Click(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection;
            List<User> users = new List<User>();

            try
            {
                mySqlConnection = new MySqlConnection("server=127.0.0.1;user=root;database=szklarnia_v3;password=");

                mySqlConnection.Open();

                MySqlCommand cmd = new MySqlCommand("GetAllUsersExceptCaller", mySqlConnection);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userToken", user_log.token);
               MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    users.Add(new User(reader.GetInt32(0),reader.GetString(1), reader.GetString(2),reader.GetInt32(4)));
                }
                mySqlConnection.Close();

               


            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie uda³o siê utworzyæ u¿ytkownika", "Nie uda³o siê utworzyæ u¿ytkownika", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
