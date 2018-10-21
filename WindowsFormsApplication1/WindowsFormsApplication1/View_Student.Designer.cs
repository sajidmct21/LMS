namespace WindowsFormsApplication1
{
    partial class View_Student
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1StdName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1RollNo = new System.Windows.Forms.TextBox();
            this.button2Search = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1SName = new System.Windows.Forms.TextBox();
            this.textBox2RooNo = new System.Windows.Forms.TextBox();
            this.textBox3Dept = new System.Windows.Forms.TextBox();
            this.textBox4ContactNo = new System.Windows.Forms.TextBox();
            this.textBox5Email = new System.Windows.Forms.TextBox();
            this.button2Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(303, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(652, 230);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1StdName);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 94);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Student Name";
            // 
            // textBox1StdName
            // 
            this.textBox1StdName.Location = new System.Drawing.Point(90, 10);
            this.textBox1StdName.Name = "textBox1StdName";
            this.textBox1StdName.Size = new System.Drawing.Size(161, 20);
            this.textBox1StdName.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox1RollNo);
            this.panel2.Controls.Add(this.button2Search);
            this.panel2.Location = new System.Drawing.Point(12, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 94);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Roll No";
            // 
            // textBox1RollNo
            // 
            this.textBox1RollNo.Location = new System.Drawing.Point(90, 10);
            this.textBox1RollNo.Name = "textBox1RollNo";
            this.textBox1RollNo.Size = new System.Drawing.Size(161, 20);
            this.textBox1RollNo.TabIndex = 2;
            // 
            // button2Search
            // 
            this.button2Search.Location = new System.Drawing.Point(81, 55);
            this.button2Search.Name = "button2Search";
            this.button2Search.Size = new System.Drawing.Size(75, 23);
            this.button2Search.TabIndex = 1;
            this.button2Search.Text = "Search";
            this.button2Search.UseVisualStyleBackColor = true;
            this.button2Search.Click += new System.EventHandler(this.button2Search_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2Update);
            this.panel3.Controls.Add(this.textBox5Email);
            this.panel3.Controls.Add(this.textBox4ContactNo);
            this.panel3.Controls.Add(this.textBox3Dept);
            this.panel3.Controls.Add(this.textBox2RooNo);
            this.panel3.Controls.Add(this.textBox1SName);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(303, 294);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(652, 188);
            this.panel3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Student Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Roll No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Department";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(343, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Contact No";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Email";
            // 
            // textBox1SName
            // 
            this.textBox1SName.Location = new System.Drawing.Point(132, 20);
            this.textBox1SName.Name = "textBox1SName";
            this.textBox1SName.Size = new System.Drawing.Size(158, 20);
            this.textBox1SName.TabIndex = 5;
            // 
            // textBox2RooNo
            // 
            this.textBox2RooNo.Location = new System.Drawing.Point(425, 15);
            this.textBox2RooNo.Name = "textBox2RooNo";
            this.textBox2RooNo.Size = new System.Drawing.Size(162, 20);
            this.textBox2RooNo.TabIndex = 6;
            // 
            // textBox3Dept
            // 
            this.textBox3Dept.Location = new System.Drawing.Point(132, 82);
            this.textBox3Dept.Name = "textBox3Dept";
            this.textBox3Dept.Size = new System.Drawing.Size(158, 20);
            this.textBox3Dept.TabIndex = 7;
            // 
            // textBox4ContactNo
            // 
            this.textBox4ContactNo.Location = new System.Drawing.Point(425, 82);
            this.textBox4ContactNo.Name = "textBox4ContactNo";
            this.textBox4ContactNo.Size = new System.Drawing.Size(162, 20);
            this.textBox4ContactNo.TabIndex = 8;
            // 
            // textBox5Email
            // 
            this.textBox5Email.Location = new System.Drawing.Point(132, 136);
            this.textBox5Email.Name = "textBox5Email";
            this.textBox5Email.Size = new System.Drawing.Size(158, 20);
            this.textBox5Email.TabIndex = 9;
            // 
            // button2Update
            // 
            this.button2Update.Location = new System.Drawing.Point(393, 125);
            this.button2Update.Name = "button2Update";
            this.button2Update.Size = new System.Drawing.Size(122, 35);
            this.button2Update.TabIndex = 10;
            this.button2Update.Text = "Update";
            this.button2Update.UseVisualStyleBackColor = true;
            this.button2Update.Click += new System.EventHandler(this.button2Update_Click);
            // 
            // View_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 494);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "View_Student";
            this.Text = "View_Student";
            this.Load += new System.EventHandler(this.View_Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1StdName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1RollNo;
        private System.Windows.Forms.Button button2Search;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2Update;
        private System.Windows.Forms.TextBox textBox5Email;
        private System.Windows.Forms.TextBox textBox4ContactNo;
        private System.Windows.Forms.TextBox textBox3Dept;
        private System.Windows.Forms.TextBox textBox2RooNo;
        private System.Windows.Forms.TextBox textBox1SName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}