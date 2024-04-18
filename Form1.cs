namespace GreenHouse
{
    public partial class Form1 : Form
    {
        private All_data allData;
        private string loggedInUsername;
        public Form1()
        {
            InitializeComponent();
            allData = new All_data();
            this.WindowState = FormWindowState.Maximized;
            
        }

        public string LoggedInUsername
        {
            get { return loggedInUsername; }
            set
            {
                loggedInUsername = value;
                
                username_textBox.Text = loggedInUsername;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChartForm chartForm = new ChartForm();
            chartForm.WindowState = FormWindowState.Maximized;
            chartForm.ShowDialog();
            this.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            
            // Zamknij bie¿¹cy formularz
            this.Hide();

            // Otwórz ponownie formularz logowania
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}
