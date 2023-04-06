using LinqToDB.Data;
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

namespace Emp_Attendance_Desktop
{
    public partial class Employee : Form
    {
         
        public Employee()
        {
            InitializeComponent();
            chart1.Titles.Add("Employee Attendance Pi-Chart");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1_Click(sender, e);
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-QS56RUI\\SQLEXPRESS;Initial Catalog=Emp_AttendanceDb;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Id, Name, Designation, BirthDate, JoiningDate, Address, PhoneNo, Salary FROM Employees", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
  

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {



        }
    }
}
