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
    public partial class Lgin : Form
    {
       
        public Lgin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();  
            con.ConnectionString = @"Data Source=SAJID-PC\SQLEXPRESS;Initial Catalog=Library_Management;Integrated Security=True;Pooling=False";  
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from library_person where userName='" + txtBoxUserName.Text + "'and password='" + txtBoxPassword.Text + "'", con);  
            SqlDataAdapter da = new SqlDataAdapter(cmd);  
            DataTable dt = new DataTable();  
            da.Fill(dt);  
            if (dt.Rows.Count > 0)  
            {  
                MDIParent1 md = new MDIParent1();
                this.Hide();
                md.Show();
            }  
            else  
            {  
                MessageBox.Show("Invalid Login please check username and password");  
            }  
            con.Close();  
        }

        private void Lgin_Load(object sender, EventArgs e)
        {
           
        }
    }
}
