namespace WindowsFormsApplication1
{
    partial class AddStudent
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.textBox1StdName = new System.Windows.Forms.TextBox();
            this.textBox2StdRollNo = new System.Windows.Forms.TextBox();
            this.textBox3StdDepartment = new System.Windows.Forms.TextBox();
            this.textBox4StdContactNo = new System.Windows.Forms.TextBox();
            this.textBox5StdEmail = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox5StdEmail);
            this.panel1.Controls.Add(this.textBox4StdContactNo);
            this.panel1.Controls.Add(this.textBox3StdDepartment);
            this.panel1.Controls.Add(this.textBox2StdRollNo);
            this.panel1.Controls.Add(this.textBox1StdName);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(45, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 282);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Roll No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contact No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "E-mail";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(335, 160);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 39);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textBox1StdName
            // 
            this.textBox1StdName.Location = new System.Drawing.Point(120, 34);
            this.textBox1StdName.Name = "textBox1StdName";
            this.textBox1StdName.Size = new System.Drawing.Size(124, 20);
            this.textBox1StdName.TabIndex = 6;
            // 
            // textBox2StdRollNo
            // 
            this.textBox2StdRollNo.Location = new System.Drawing.Point(348, 36);
            this.textBox2StdRollNo.Name = "textBox2StdRollNo";
            this.textBox2StdRollNo.Size = new System.Drawing.Size(100, 20);
            this.textBox2StdRollNo.TabIndex = 7;
            // 
            // textBox3StdDepartment
            // 
            this.textBox3StdDepartment.Location = new System.Drawing.Point(120, 106);
            this.textBox3StdDepartment.Name = "textBox3StdDepartment";
            this.textBox3StdDepartment.Size = new System.Drawing.Size(124, 20);
            this.textBox3StdDepartment.TabIndex = 8;
            // 
            // textBox4StdContactNo
            // 
            this.textBox4StdContactNo.Location = new System.Drawing.Point(348, 110);
            this.textBox4StdContactNo.Name = "textBox4StdContactNo";
            this.textBox4StdContactNo.Size = new System.Drawing.Size(100, 20);
            this.textBox4StdContactNo.TabIndex = 9;
            // 
            // textBox5StdEmail
            // 
            this.textBox5StdEmail.Location = new System.Drawing.Point(120, 170);
            this.textBox5StdEmail.Name = "textBox5StdEmail";
            this.textBox5StdEmail.Size = new System.Drawing.Size(124, 20);
            this.textBox5StdEmail.TabIndex = 10;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 355);
            this.Controls.Add(this.panel1);
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox5StdEmail;
        private System.Windows.Forms.TextBox textBox4StdContactNo;
        private System.Windows.Forms.TextBox textBox3StdDepartment;
        private System.Windows.Forms.TextBox textBox2StdRollNo;
        private System.Windows.Forms.TextBox textBox1StdName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}