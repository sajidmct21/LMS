using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class search_book : Form
    {
        int i;
        public search_book()
        {
            InitializeComponent();
        }

        private void search_book_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void btn_Book_Search_Name_Click(object sender, EventArgs e)
        {
            int i = 0;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=SAJID-PC\SQLEXPRESS;Initial Catalog=Library_Management;Integrated Security=True;Pooling=False";
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_books where bookName like '%"+txtBookName.Text+"%'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            dataGridView1.DataSource = dt;
            con.Close(); 

            if(i==0)
            {
                MessageBox.Show("No Book Found");
            }
        }

        private void txtBookName_KeyUp(object sender, KeyEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=SAJID-PC\SQLEXPRESS;Initial Catalog=Library_Management;Integrated Security=True;Pooling=False";
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_books where bookName like '%" + txtBookName.Text + "%'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=SAJID-PC\SQLEXPRESS;Initial Catalog=Library_Management;Integrated Security=True;Pooling=False";
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_books where bookAuthorName like '%" + textBox1.Text + "%'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            dataGridView1.DataSource = dt;
            con.Close();
            if (i == 0)
            {
                MessageBox.Show("No Book Found");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
           //MessageBox.Show(i.ToString());
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=SAJID-PC\SQLEXPRESS;Initial Catalog=Library_Management;Integrated Security=True;Pooling=False";
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_books where id = "+i+"", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                textBox2BookName.Text = dr["bookName"].ToString();
                textBox3BookAuthorName.Text = dr["bookAuthorName"].ToString();
                textBox4BookPurchaseDate.Text = dr["bookPurchaseDate"].ToString();
                textBox5BookPrice.Text = dr["bookPrice"].ToString();
                textBox6BookQuantity.Text = dr["bookQuantity"].ToString();
            }
            con.Close();
            
        }

        private void button2UpdateRecord_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            try
            {
                
                con.ConnectionString = @"Data Source=SAJID-PC\SQLEXPRESS;Initial Catalog=Library_Management;Integrated Security=True;Pooling=False";
                con.Open();
                SqlCommand cmd = new SqlCommand("update tbl_books set bookName ='" + textBox2BookName.Text + "',bookAuthorName = '" + textBox3BookAuthorName.Text + "',bookPurchaseDate ='" + textBox4BookPurchaseDate.Text + "',bookPrice =" + textBox5BookPrice.Text + ",bookQuantity =" + textBox6BookQuantity.Text + " where id= " + i + "", con);
                cmd.ExecuteNonQuery();
                Display();
                MessageBox.Show("Record is updated successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close(); 
            }
            

            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;
            
        }

        public void Display()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=SAJID-PC\SQLEXPRESS;Initial Catalog=Library_Management;Integrated Security=True;Pooling=False";
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_books", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close(); 
        }
    }
}
