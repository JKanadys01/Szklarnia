using MaterialSkin.Controls;
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
        private UserManager userManager;
        public LoginForm()
        {
            InitializeComponent();

            passwordmaterialTextBox.Password = true;
            userManager = new UserManager();
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {

        }


        private void materialButton1_Click(object sender, EventArgs e)
        {
            User user_log = new User(loginmaterialTextBox.Text, passwordmaterialTextBox.Text);
            MySqlConnection mySqlConnection;

            try
            {
                mySqlConnection = new MySqlConnection(user_log.get_mysqlconn());

                mySqlConnection.Open();

                // MessageBox.Show("Git", "Notatka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mySqlConnection.Close();
                
                Form1 mainForm = new Form1(user_log);
                this.Hide();
                mainForm.ShowDialog();
                
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Błędne login lub hasło", "Notatka", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
