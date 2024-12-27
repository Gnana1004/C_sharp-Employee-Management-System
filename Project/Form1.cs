namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee EmployeeInfo = new Employee();

            EmployeeInfo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeInfo EmployeeInfo = new EmployeeInfo();

            EmployeeInfo.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
