using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZH_GMMAH9.Models;

namespace ZH_GMMAH9
{

    public partial class Form2 : Form
    {
        TankonyvContext context = new TankonyvContext();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            FilterNeptun();
        }

        private void textNeptun_TextChanged(object sender, EventArgs e)
        {
            FilterNeptun();
        }

        private void FilterNeptun()
        {
            var neptun = from x in context.Students
                         where x.Neptun.Contains(textNeptun.Text)
                         select x;

            listBox1.DataSource = neptun.ToList();
            listBox1.DisplayMember = "Neptun";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedStudent = (Student)listBox1.SelectedValue;
            var orders = from x in context.Orders
                         where x.StudentFk == selectedStudent.StudentId
                         select new Details

                         {
                             OrderID = x.OrderSk,
                             Title = x.TextbookFkNavigation.Title,
                             Price = x.TextbookFkNavigation.Price
                         };

            listBox2.DataSource = orders.ToList();
            listBox2.DisplayMember = "Title";


            var total = (from x in orders
                         select x.Price).Sum();

            txtRendeles.Text = total.ToString() + " Ft";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    public class Details
    {

        public int OrderID { get; set; }
        public string Title { get; set; }

        public double? Price { get; set; }


    }
}
