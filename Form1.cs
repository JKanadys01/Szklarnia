namespace GreenHouse
{
    public partial class Form1 : Form
    {
        private All_data allData;
        public Form1()
        {
            InitializeComponent();
            allData = new All_data();
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChartForm chartForm = new ChartForm();
            chartForm.WindowState = FormWindowState.Maximized;
            chartForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
