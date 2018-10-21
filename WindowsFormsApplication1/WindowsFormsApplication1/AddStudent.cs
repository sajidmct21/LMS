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

namespace WindowsFormsApplication1
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=SAJID-PC\SQLEXPRESS;Initial Catalog=Library_Management;Integrated Security=True;Pooling=False");
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Student VALUES('" + textBox1StdName.Text + "','" + textBox2StdRollNo.Text + "','" + textBox3StdDepartment.Text + "','" + textBox4StdContactNo.Text + "','" + textBox5StdEmail.Text + "')";
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Student is added");
            con.Close();

        }
    }
}
