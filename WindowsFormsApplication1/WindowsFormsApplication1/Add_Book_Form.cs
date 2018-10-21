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
    public partial class Add_Book_Form : Form
    {
        public Add_Book_Form()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=SAJID-PC\SQLEXPRESS;Initial Catalog=Library_Management;Integrated Security=True;Pooling=False";
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText="INSERT INTO tbl_books(bookName,bookAuthorName,bookPurchaseDate,bookPrice,bookQuantity) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text+ "'," + textBox4.Text + "," + textBox5.Text + ")";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Book is Added Successfully");
        }
    }
}
