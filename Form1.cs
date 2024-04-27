namespace GreenHouse
{
    public partial class Form1 : Form
    {
        private All_data allData;
     

        private User user_log;
        public Form1(User x)
        {
            
            user_log = x;
            InitializeComponent();
            allData = new All_data();
            this.WindowState = FormWindowState.Maximized;

            username_textBox.Text = user_log.get_name();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChartForm chartForm = new ChartForm(user_log);
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
