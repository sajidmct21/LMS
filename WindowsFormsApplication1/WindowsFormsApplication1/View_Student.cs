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
    public partial class View_Student : Form
    {
        int i = 0;
        public View_Student()
        {
            InitializeComponent();
        }

        private void View_Student_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=SAJID-PC\SQLEXPRESS;Initial Catalog=Library_Management;Integrated Security=True;Pooling=False");
            SqlCommand cmd = new SqlCommand("select * from Student", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=SAJID-PC\SQLEXPRESS;Initial Catalog=Library_Management;Integrated Security=True;Pooling=False");
            SqlCommand cmd = new SqlCommand("select * from Student where studentName like '%"+textBox1StdName.Text+"%'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count == 0)
            {
                textBox1StdName.Clear();
                MessageBox.Show("Record is not avaiable");
                textBox1StdName.Focus();
            }
            else
            {
                dataGridView1.DataSource = dt;
            }
            
        }

        private void button2Search_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=SAJID-PC\SQLEXPRESS;Initial Catalog=Library_Management;Integrated Security=True;Pooling=False");
            SqlCommand cmd = new SqlCommand("select * from Student where studentRollNo like '%" + textBox1RollNo.Text + "%'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                textBox1RollNo.Text = "";
                
                MessageBox.Show("Record is not avaiable");
                textBox1RollNo.Focus();
            }
            else
            {
                dataGridView1.DataSource = dt;
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            //MessageBox.Show(i.ToString());
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=SAJID-PC\SQLEXPRESS;Initial Catalog=Library_Management;Integrated Security=True;Pooling=False";
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from student where id = " + i + "", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                textBox1SName.Text = dr["studentName"].ToString();
                textBox2RooNo.Text = dr["StudentRollNo"].ToString();
                textBox3Dept.Text = dr["studentDepartment"].ToString();
                textBox4ContactNo.Text = dr["studentContact"].ToString();
                textBox5Email.Text = dr["studentEmail"].ToString();
            }
            con.Close();
        }

        private void button2Update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            try
            {

                con.ConnectionString = @"Data Source=SAJID-PC\SQLEXPRESS;Initial Catalog=Library_Management;Integrated Security=True;Pooling=False";
                con.Open();
                SqlCommand cmd = new SqlCommand("update Student set studentName ='" +textBox1SName.Text+ "',StudentRollNo = '" + textBox2RooNo.Text + "',studentDepartment ='" + textBox3Dept.Text + "',studentContact ='" + textBox4ContactNo.Text + "',studentEmail ='" + textBox5Email.Text + "' where id= " + i + "", con);
                cmd.ExecuteNonQuery();
                View_Student_Load(sender, e);
                MessageBox.Show("Record is updated successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
