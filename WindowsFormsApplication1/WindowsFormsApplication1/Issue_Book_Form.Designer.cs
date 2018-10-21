namespace WindowsFormsApplication1
{
    partial class Issue_Book_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1RollNo = new System.Windows.Forms.TextBox();
            this.textBox2StdName = new System.Windows.Forms.TextBox();
            this.textBox3Department = new System.Windows.Forms.TextBox();
            this.textBox4email = new System.Windows.Forms.TextBox();
            this.textBox5bookName = new System.Windows.Forms.TextBox();
            this.textBox6issueDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1Search = new System.Windows.Forms.Button();
            this.button2Issue = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.button2Issue);
            this.panel1.Controls.Add(this.button1Search);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox6issueDate);
            this.panel1.Controls.Add(this.textBox5bookName);
            this.panel1.Controls.Add(this.textBox4email);
            this.panel1.Controls.Add(this.textBox3Department);
            this.panel1.Controls.Add(this.textBox2StdName);
            this.panel1.Controls.Add(this.textBox1RollNo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 411);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Roll No";
            // 
            // textBox1RollNo
            // 
            this.textBox1RollNo.Location = new System.Drawing.Point(138, 39);
            this.textBox1RollNo.Name = "textBox1RollNo";
            this.textBox1RollNo.Size = new System.Drawing.Size(147, 20);
            this.textBox1RollNo.TabIndex = 1;
            // 
            // textBox2StdName
            // 
            this.textBox2StdName.Location = new System.Drawing.Point(584, 20);
            this.textBox2StdName.Name = "textBox2StdName";
            this.textBox2StdName.Size = new System.Drawing.Size(100, 20);
            this.textBox2StdName.TabIndex = 2;
            // 
            // textBox3Department
            // 
            this.textBox3Department.Location = new System.Drawing.Point(584, 75);
            this.textBox3Department.Name = "textBox3Department";
            this.textBox3Department.Size = new System.Drawing.Size(100, 20);
            this.textBox3Department.TabIndex = 3;
            // 
            // textBox4email
            // 
            this.textBox4email.Location = new System.Drawing.Point(584, 124);
            this.textBox4email.Name = "textBox4email";
            this.textBox4email.Size = new System.Drawing.Size(100, 20);
            this.textBox4email.TabIndex = 4;
            // 
            // textBox5bookName
            // 
            this.textBox5bookName.Location = new System.Drawing.Point(584, 238);
            this.textBox5bookName.Name = "textBox5bookName";
            this.textBox5bookName.Size = new System.Drawing.Size(120, 20);
            this.textBox5bookName.TabIndex = 5;
            this.textBox5bookName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox5bookName_KeyDown);
            this.textBox5bookName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox5bookName_KeyUp);
            // 
            // textBox6issueDate
            // 
            this.textBox6issueDate.Location = new System.Drawing.Point(584, 174);
            this.textBox6issueDate.Name = "textBox6issueDate";
            this.textBox6issueDate.Size = new System.Drawing.Size(120, 20);
            this.textBox6issueDate.TabIndex = 6;
            this.textBox6issueDate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox6issueDate_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(479, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Student Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(482, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(485, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(488, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Book Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(482, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Issue Date";
            // 
            // button1Search
            // 
            this.button1Search.Location = new System.Drawing.Point(100, 91);
            this.button1Search.Name = "button1Search";
            this.button1Search.Size = new System.Drawing.Size(75, 23);
            this.button1Search.TabIndex = 14;
            this.button1Search.Text = "Search";
            this.button1Search.UseVisualStyleBackColor = true;
            this.button1Search.Click += new System.EventHandler(this.button1Search_Click);
            // 
            // button2Issue
            // 
            this.button2Issue.Location = new System.Drawing.Point(469, 361);
            this.button2Issue.Name = "button2Issue";
            this.button2Issue.Size = new System.Drawing.Size(75, 23);
            this.button2Issue.TabIndex = 15;
            this.button2Issue.Text = "Issue Book";
            this.button2Issue.UseVisualStyleBackColor = true;
            this.button2Issue.Click += new System.EventHandler(this.button2Issue_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(584, 264);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 16;
            this.listBox1.Visible = false;
            this.listBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseClick);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyDown);
            // 
            // Issue_Book_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 487);
            this.Controls.Add(this.panel1);
            this.Name = "Issue_Book_Form";
            this.Text = "Issue_Book_Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2Issue;
        private System.Windows.Forms.Button button1Search;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox6issueDate;
        private System.Windows.Forms.TextBox textBox5bookName;
        private System.Windows.Forms.TextBox textBox4email;
        private System.Windows.Forms.TextBox textBox3Department;
        private System.Windows.Forms.TextBox textBox2StdName;
        private System.Windows.Forms.TextBox textBox1RollNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
    }
}