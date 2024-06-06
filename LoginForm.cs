using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenHouse
{

    public partial class LoginForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
        public LoginForm()
        {
            InitializeComponent();

            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Green400, Primary.Green500,
                Primary.Green800, Accent.LightGreen200, TextShade.WHITE);

            passwordmaterialTextBox.Password = true;
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {

        }


        private async void materialButton1_Click(object sender, EventArgs e)
        {
            User user_log = new User(loginmaterialTextBox.Text, passwordmaterialTextBox.Text);
            MySqlConnection mySqlConnection;
        
            try
            {
                mySqlConnection = new MySqlConnection("server=127.0.0.1;user=root;database=szklarnia_v3;password=");
                
                    mySqlConnection.Open();

                MySqlCommand cmd = new MySqlCommand("LoginUser", mySqlConnection);
                    
                        cmd.CommandType=CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@loginParam", loginmaterialTextBox.Text);
                        cmd.Parameters.AddWithValue("@passwordParam", passwordmaterialTextBox.Text);

                MySqlDataReader reader = cmd.ExecuteReader();
                        
                            if (reader.Read()) 
                            {
                                user_log.token = reader.GetInt32(0);
                            }
                            else
                            {
                                  MessageBox.Show("Wrong login or password", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           }


                mySqlConnection.Close();
                     Form1 mainForm = new Form1(user_log);

                     this.Hide();
                     mainForm.ShowDialog();

                     this.Close();
            }
            catch (Exception ex)
            {
                  MessageBox.Show("Error"+ex.Message, "Note" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
