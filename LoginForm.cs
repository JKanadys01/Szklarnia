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
            string username = login_textBox.Text;
            string password = password_textBox.Text;

            if (userManager.Authenticate(username, password)) 
            {
                this.Hide();

                Form1 mainForm = new Form1();
                mainForm.LoggedInUsername = username;
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Nieprawidłowy login lub hasło. Spróbuj ponownie.", "Błąd logowania", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
