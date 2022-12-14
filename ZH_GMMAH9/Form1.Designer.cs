namespace ZH_GMMAH9
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.listStudent = new System.Windows.Forms.ListBox();
            this.listOrder = new System.Windows.Forms.ListBox();
            this.listTextBook = new System.Windows.Forms.ListBox();
            this.txtStudent = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtTextBook = new System.Windows.Forms.TextBox();
            this.txtRendeles = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(503, 124);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 72);
            this.btnRemove.TabIndex = 0;
            this.btnRemove.Text = "-";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(503, 223);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 69);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // listStudent
            // 
            this.listStudent.FormattingEnabled = true;
            this.listStudent.ItemHeight = 15;
            this.listStudent.Location = new System.Drawing.Point(56, 76);
            this.listStudent.Name = "listStudent";
            this.listStudent.Size = new System.Drawing.Size(164, 319);
            this.listStudent.TabIndex = 2;
            this.listStudent.SelectedIndexChanged += new System.EventHandler(this.listStudent_SelectedIndexChanged);
            // 
            // listOrder
            // 
            this.listOrder.FormattingEnabled = true;
            this.listOrder.ItemHeight = 15;
            this.listOrder.Location = new System.Drawing.Point(294, 76);
            this.listOrder.Name = "listOrder";
            this.listOrder.Size = new System.Drawing.Size(159, 319);
            this.listOrder.TabIndex = 3;
            // 
            // listTextBook
            // 
            this.listTextBook.FormattingEnabled = true;
            this.listTextBook.ItemHeight = 15;
            this.listTextBook.Location = new System.Drawing.Point(614, 76);
            this.listTextBook.Name = "listTextBook";
            this.listTextBook.Size = new System.Drawing.Size(150, 319);
            this.listTextBook.TabIndex = 4;
            this.listTextBook.SelectedIndexChanged += new System.EventHandler(this.listTextBook_SelectedIndexChanged);
            // 
            // txtStudent
            // 
            this.txtStudent.Location = new System.Drawing.Point(56, 25);
            this.txtStudent.Name = "txtStudent";
            this.txtStudent.Size = new System.Drawing.Size(164, 23);
            this.txtStudent.TabIndex = 5;
            this.txtStudent.TextChanged += new System.EventHandler(this.txtStudent_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(294, 25);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(159, 23);
            this.textBox3.TabIndex = 6;
            // 
            // txtTextBook
            // 
            this.txtTextBook.Location = new System.Drawing.Point(614, 25);
            this.txtTextBook.Name = "txtTextBook";
            this.txtTextBook.Size = new System.Drawing.Size(159, 23);
            this.txtTextBook.TabIndex = 7;
            this.txtTextBook.TextChanged += new System.EventHandler(this.txtTextBook_TextChanged);
            // 
            // txtRendeles
            // 
            this.txtRendeles.Location = new System.Drawing.Point(605, 415);
            this.txtRendeles.Name = "txtRendeles";
            this.txtRendeles.Size = new System.Drawing.Size(159, 23);
            this.txtRendeles.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hallgató neve : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(615, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tankönyv keresése :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(523, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Összesen :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Megrendelt könyvek :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(614, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tankönyv lista :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Kereső";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Keresés Neptun kód alapján :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(414, 410);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Kereső";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(318, 414);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Data Grid View :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRendeles);
            this.Controls.Add(this.txtTextBook);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtStudent);
            this.Controls.Add(this.listTextBook);
            this.Controls.Add(this.listOrder);
            this.Controls.Add(this.listStudent);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRemove);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRemove;
        private Button btnAdd;
        private ListBox listStudent;
        private ListBox listOrder;
        private ListBox listTextBook;
        private TextBox txtStudent;
        private TextBox textBox3;
        private TextBox txtTextBook;
        private TextBox txtRendeles;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Label label6;
        private Button button2;
        private Label label7;
    }
}