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
    public partial class LoginForm : Form
    {
        private UserManager userManager;
        public LoginForm()
        {
            InitializeComponent();
            password_textBox.UseSystemPasswordChar = true;
            userManager = new UserManager();
        }

        private void login_button_Click(object sender, EventArgs e)
        {

           
            User user_log=new User(login_textBox.Text,password_textBox.Text);
            MySqlConnection mySqlConnection;

            try
            {
             mySqlConnection = new MySqlConnection(user_log.get_mysqlconn());

                mySqlConnection.Open();

               // MessageBox.Show("Git", "Notatka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mySqlConnection.Close();

                Form1 mainForm = new Form1(user_log);
                mainForm.ShowDialog();
                this.Close();

            }
            catch(Exception ex) 
            {
                MessageBox.Show("Błędne login lub hasło", "Notatka", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         

        }
    }
}
