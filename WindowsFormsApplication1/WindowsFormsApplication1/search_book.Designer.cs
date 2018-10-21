namespace WindowsFormsApplication1
{
    partial class search_book
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Book_Search_Name = new System.Windows.Forms.Button();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox6BookQuantity = new System.Windows.Forms.TextBox();
            this.textBox5BookPrice = new System.Windows.Forms.TextBox();
            this.textBox4BookPurchaseDate = new System.Windows.Forms.TextBox();
            this.textBox3BookAuthorName = new System.Windows.Forms.TextBox();
            this.textBox2BookName = new System.Windows.Forms.TextBox();
            this.button2UpdateRecord = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.dataGridView1.Location = new System.Drawing.Point(266, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(613, 252);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Book_Search_Name);
            this.panel1.Controls.Add(this.txtBookName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 105);
            this.panel1.TabIndex = 1;
            // 
            // btn_Book_Search_Name
            // 
            this.btn_Book_Search_Name.Location = new System.Drawing.Point(65, 68);
            this.btn_Book_Search_Name.Name = "btn_Book_Search_Name";
            this.btn_Book_Search_Name.Size = new System.Drawing.Size(75, 23);
            this.btn_Book_Search_Name.TabIndex = 2;
            this.btn_Book_Search_Name.Text = "Search";
            this.btn_Book_Search_Name.UseVisualStyleBackColor = true;
            this.btn_Book_Search_Name.Click += new System.EventHandler(this.btn_Book_Search_Name_Click);
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(118, 24);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(117, 20);
            this.txtBookName.TabIndex = 1;
            this.txtBookName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBookName_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Book Name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 126);
            this.panel2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter Author Name";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox6BookQuantity);
            this.panel3.Controls.Add(this.textBox5BookPrice);
            this.panel3.Controls.Add(this.textBox4BookPurchaseDate);
            this.panel3.Controls.Add(this.textBox3BookAuthorName);
            this.panel3.Controls.Add(this.textBox2BookName);
            this.panel3.Controls.Add(this.button2UpdateRecord);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(12, 294);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(867, 153);
            this.panel3.TabIndex = 3;
            // 
            // textBox6BookQuantity
            // 
            this.textBox6BookQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6BookQuantity.Location = new System.Drawing.Point(415, 81);
            this.textBox6BookQuantity.Name = "textBox6BookQuantity";
            this.textBox6BookQuantity.Size = new System.Drawing.Size(137, 26);
            this.textBox6BookQuantity.TabIndex = 10;
            // 
            // textBox5BookPrice
            // 
            this.textBox5BookPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5BookPrice.Location = new System.Drawing.Point(114, 85);
            this.textBox5BookPrice.Name = "textBox5BookPrice";
            this.textBox5BookPrice.Size = new System.Drawing.Size(132, 26);
            this.textBox5BookPrice.TabIndex = 9;
            // 
            // textBox4BookPurchaseDate
            // 
            this.textBox4BookPurchaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4BookPurchaseDate.Location = new System.Drawing.Point(729, 31);
            this.textBox4BookPurchaseDate.Name = "textBox4BookPurchaseDate";
            this.textBox4BookPurchaseDate.Size = new System.Drawing.Size(134, 26);
            this.textBox4BookPurchaseDate.TabIndex = 8;
            // 
            // textBox3BookAuthorName
            // 
            this.textBox3BookAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3BookAuthorName.Location = new System.Drawing.Point(415, 31);
            this.textBox3BookAuthorName.Name = "textBox3BookAuthorName";
            this.textBox3BookAuthorName.Size = new System.Drawing.Size(137, 26);
            this.textBox3BookAuthorName.TabIndex = 7;
            // 
            // textBox2BookName
            // 
            this.textBox2BookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2BookName.Location = new System.Drawing.Point(114, 28);
            this.textBox2BookName.Name = "textBox2BookName";
            this.textBox2BookName.Size = new System.Drawing.Size(132, 26);
            this.textBox2BookName.TabIndex = 6;
            // 
            // button2UpdateRecord
            // 
            this.button2UpdateRecord.Location = new System.Drawing.Point(618, 81);
            this.button2UpdateRecord.Name = "button2UpdateRecord";
            this.button2UpdateRecord.Size = new System.Drawing.Size(126, 38);
            this.button2UpdateRecord.TabIndex = 5;
            this.button2UpdateRecord.Text = "Update Record";
            this.button2UpdateRecord.UseVisualStyleBackColor = true;
            this.button2UpdateRecord.Click += new System.EventHandler(this.button2UpdateRecord_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(567, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Book Purchase Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(265, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Book Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Book Author Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Book Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Book Name";
            // 
            // search_book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 486);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "search_book";
            this.Text = "search_book";
            this.Load += new System.EventHandler(this.search_book_Load);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Book_Search_Name;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox6BookQuantity;
        private System.Windows.Forms.TextBox textBox5BookPrice;
        private System.Windows.Forms.TextBox textBox4BookPurchaseDate;
        private System.Windows.Forms.TextBox textBox3BookAuthorName;
        private System.Windows.Forms.TextBox textBox2BookName;
        private System.Windows.Forms.Button button2UpdateRecord;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}