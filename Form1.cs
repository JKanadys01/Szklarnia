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
                InsolationProgressBar, temperaturematerialLabel, humiditymaterialLabel, insolationmaterialLabel, TempMinTextBox,
                TempMaxTextBox, AlarmComboBox, DeviceComboBox, AlarmTextBox);
            
            ///Chart page
            cartesianChart.Visible = false;
            chartPage = new ChartPage(allData, user_log, mainPage, ParametermaterialComboBox, TimeFramematerialComboBox, cartesianChart, dateTimePicker, DeviceChartsPageComboBox);
            chartPage.InitializeComboBox();
            mainPage.InitializeComboBox();
            mainPage.Initialize();
            if (user_log.login != "prime")
            {
                tabControl1.TabPages.Remove(tabPage4);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            logoutmaterialButton_Click(sender, EventArgs.Empty);
        }

        /// Obsl�uga Main page
        private void logoutmaterialButton_Click(object sender, EventArgs e)
        {
            // Zamknij bie��cy formularz

            // Otw�rz ponownie formularz logowania

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
                mainPage.StopTimer();
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to log out", "Failed to log out", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        /////Obs�uga Chart page
        private void DrawchartmaterialButton_Click(object sender, EventArgs e)
        {
            chartPage.GenerateChart();
        }
        private void SetAlarmlButton_Click(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection;

            try
            {
                mySqlConnection = new MySqlConnection("server=127.0.0.1;user=root;database=szklarnia_v3;password=");

                mySqlConnection.Open();

                MySqlCommand cmd = new MySqlCommand("UpdateAlarmParameters", mySqlConnection);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userToken", user_log.token);
                cmd.Parameters.AddWithValue("@serialNumber", DeviceComboBox.SelectedItem);
                cmd.Parameters.AddWithValue("@parameterName", AlarmComboBox.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@downValue", int.Parse(TempMinTextBox.Text));
                cmd.Parameters.AddWithValue("@topValue", int.Parse(TempMaxTextBox.Text));
                cmd.ExecuteNonQuery();


                mySqlConnection.Close();
                MessageBox.Show("Managed to set the alarm ", "Managed to set the alarm", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to set alarm", "Failed to set alarm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


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
                MessageBox.Show("User created successfully", "User created successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to create user", "Failed to create user", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PullUserListButton_Click(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection;
            List<User> users = new List<User>();
            UserListTextBox.Clear();
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
                    users.Add(new User(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(4), reader.GetString(5)));
                }
                mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to download the list", "Failed to download the list", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            UserListTextBox.Clear();
            foreach (User user in users)
            {
                UserListTextBox.Text += user.ToString() + "\n\n";
            }
        }

        private void DeviceListButton_Click(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection;
            List<Device> device = new List<Device>();

            materialMultiLineTextBox1.Clear();
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

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to download the list", "Failed to download the list", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            materialMultiLineTextBox1.Clear();
            foreach (Device dev in device)
            {
                materialMultiLineTextBox1.Text += dev.ToString() + "\n\n";
            }
        }

        private void AddDeviceButton_Click(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection;

            try
            {
                mySqlConnection = new MySqlConnection("server=127.0.0.1;user=root;database=szklarnia_v3;password=");

                mySqlConnection.Open();

                MySqlCommand cmd = new MySqlCommand("CreateNewDevice", mySqlConnection);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userToken", user_log.token);
                cmd.Parameters.AddWithValue("@serialNumber", int.Parse(DeviceIdTextBox.Text));
                cmd.Parameters.AddWithValue("@deviceDescription", DeviceDescriptionTextBox.Text);
                cmd.ExecuteNonQuery();


                mySqlConnection.Close();
                MessageBox.Show("Device created successfully", "Device created successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to create device", "Failed to create device", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            chartPage.InitializeComboBox();
            mainPage.InitializeComboBox();

        }

        private void EditUserButton_Click(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection;

            try
            {
                mySqlConnection = new MySqlConnection("server=127.0.0.1;user=root;database=szklarnia_v3;password=");

                mySqlConnection.Open();

                MySqlCommand cmd = new MySqlCommand("ChangeUserCredentials", mySqlConnection);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user_token", user_log.token);
                cmd.Parameters.AddWithValue("@user_login", UserLoginTextBox.Text);
                cmd.Parameters.AddWithValue("@new_password", UserPasswordTextBox.Text);
                cmd.Parameters.AddWithValue("@new_description", UserDescriptionTextBox.Text);
                cmd.ExecuteNonQuery();


                mySqlConnection.Close();
                MessageBox.Show("Successfully edited the user", "Successfully edited the user", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to edit user", "Failed to edit user", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void EditDeviceButton_Click(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection;

            try
            {
                mySqlConnection = new MySqlConnection("server=127.0.0.1;user=root;database=szklarnia_v3;password=");

                mySqlConnection.Open();

                MySqlCommand cmd = new MySqlCommand("ChangeDeviceDescription", mySqlConnection);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user_token", user_log.token);
                cmd.Parameters.AddWithValue("@device_serial_number", DeviceIdTextBox.Text);
                cmd.Parameters.AddWithValue("@new_description", DeviceDescriptionTextBox.Text);
                cmd.ExecuteNonQuery();


                mySqlConnection.Close();
                MessageBox.Show("Successfully edited the device", "Successfully edited the device", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to edit device", "Failed to edit device", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void AlarmCheckButton_Click(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection;

            try
            {
                mySqlConnection = new MySqlConnection("server=127.0.0.1;user=root;database=szklarnia_v3;password=");

                mySqlConnection.Open();

                MySqlCommand cmd = new MySqlCommand("UpdateAlarmStatusByTokenAndDeviceId", mySqlConnection);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user_token", user_log.token);
                cmd.Parameters.AddWithValue("@device_id", DeviceIdTextBox.Text);
                cmd.ExecuteNonQuery();


                mySqlConnection.Close();
                MessageBox.Show("Managed to receive the alarms", "Managed to receive the alarms", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to receive the alarm", "Failed to receive the alarm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
