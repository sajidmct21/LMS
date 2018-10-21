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
    public partial class Issue_Book_Form : Form
    {
        public Issue_Book_Form()
        {
            InitializeComponent();
        }

        private void button1Search_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=SAJID-PC\SQLEXPRESS;Initial Catalog=Library_Management;Integrated Security=True;Pooling=False");
            SqlCommand cmd = new SqlCommand("select * from Student where studentRollNo = '" + textBox1RollNo.Text + "'", con);
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
                foreach(DataRow dr in dt.Rows)
                {
                    textBox2StdName.Text = dr["studentName"].ToString();
                    textBox1RollNo.Text = dr["StudentRollNo"].ToString();
                    textBox3Department.Text = dr["studentDepartment"].ToString();
                   // textBox4ContactNo.Text = dr["studentContact"].ToString();
                    textBox4email.Text = dr["studentEmail"].ToString();
                }
                
            }
            con.Close();
        }

        private void textBox6issueDate_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5bookName_KeyUp(object sender, KeyEventArgs e)
        {
            int count = 0;
            if (e.KeyCode != Keys.Enter)
            {
                listBox1.Items.Clear();
                SqlConnection con = new SqlConnection(@"Data Source=SAJID-PC\SQLEXPRESS;Initial Catalog=Library_Management;Integrated Security=True;Pooling=False");
                SqlCommand cmd = new SqlCommand("select * from tbl_books where bookName like'%" + textBox5bookName.Text + "%'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());
                if (count > 0)
                {
                    listBox1.Visible = true;
                    foreach (DataRow dr in dt.Rows)
                    {
                        listBox1.Items.Add(dr["bookName"].ToString());
                    }
                }
            }
        }

        private void textBox5bookName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down)
            {
                listBox1.Focus();
                listBox1.SelectedIndex = 0;
            }
            
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                textBox5bookName.Text = listBox1.SelectedItem.ToString();
                listBox1.Visible = false;
            }
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox5bookName.Text = listBox1.SelectedItem.ToString();
            listBox1.Visible = false;
        }

        private void button2Issue_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=SAJID-PC\SQLEXPRESS;Initial Catalog=Library_Management;Integrated Security=True;Pooling=False");
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Issue_book VALUES('" + textBox2StdName.Text + "','" + textBox1RollNo.Text + "','" + textBox3Department.Text + "','" + textBox4email.Text + "','" + textBox5bookName.Text + "','"+textBox6issueDate.Text+"')";
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Book is issued");
            con.Close();
        }
    }
}
