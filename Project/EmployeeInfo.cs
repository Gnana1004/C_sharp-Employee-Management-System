using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project
{
    public partial class EmployeeInfo : Form
    {
        public EmployeeInfo()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-T4B37I5\\SQLEXPRESS;Initial Catalog=employeedb;Integrated Security=True");



        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cnn = new SqlCommand("Select * from emptab", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);

            DataTable table = new DataTable();

            da.Fill(table);

            dataGridView1.DataSource = table;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
