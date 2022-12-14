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
    public partial class Form3 : Form
    {
        TankonyvContext context = new TankonyvContext();
        public Form3()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var textbooks = from x in context.Textbooks
                            where x.Title.Contains(textBox1.Text)
                            select x;

            listBox1.DataSource = textbooks.ToList();
            listBox1.DisplayMember = "Title";

            dataGridView1.DataSource = textbooks.ToList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                    }
    }
    public class Adatok
    {
        public int OrderID { get; set; }
        public string Title { get; set; }

        public double? Price { get; set; }
    }

}
