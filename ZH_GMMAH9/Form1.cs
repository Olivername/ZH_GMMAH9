using ZH_GMMAH9.Models;

namespace ZH_GMMAH9
{
    public partial class Form1 : Form
    {

        TankonyvContext context = new TankonyvContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FilterTextBook();
            FilterStudents();
        }

        private void txtStudent_TextChanged(object sender, EventArgs e)
        {
            FilterStudents();
        }

        private void FilterStudents()
        {
            var students = from x in context.Students
                           where x.Name.Contains(txtStudent.Text)
                           select x;

            listStudent.DataSource = students.ToList();
            listStudent.DisplayMember = "Name";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listTextBook_SelectedIndexChanged(object sender, EventArgs e)
        {
                    }

        private void txtTextBook_TextChanged(object sender, EventArgs e)
        {
            FilterTextBook();
        }

        private void FilterTextBook()
        {
            var textbooks = from x in context.Textbooks
                            where x.Title.Contains(txtTextBook.Text)
                            select x;

            listTextBook.DataSource = textbooks.ToList();
            listTextBook.DisplayMember = "Title";
        }

        private void listStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListOrders();
        }

        private void ListOrders()
        {
            var selectedStudent = (Student)listStudent.SelectedValue;
            var orders = from x in context.Orders
                         where x.StudentFk == selectedStudent.StudentId
                         select new OrderDetail

                         {
                             OrderID = x.OrderSk,
                             Title = x.TextbookFkNavigation.Title,
                             Price = x.TextbookFkNavigation.Price
                         };

            listOrder.DataSource = orders.ToList();
            listOrder.DisplayMember = "Title";


            var total = (from x in orders
                         select x.Price).Sum();

            txtRendeles.Text = total.ToString() + " Ft";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var selectedOrder = (OrderDetail)listOrder.SelectedItem;
            var orderToBeDeleted = (from x in context.Orders
                                    where x.OrderSk == selectedOrder.OrderID
                                    select x).FirstOrDefault();

            context.Orders.Remove(orderToBeDeleted);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ListOrders();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var selectedStudent = (Student)listStudent.SelectedItem;
            var selectedTextbook = (Textbook)listTextBook.SelectedItem;

            Order newOrder = new Order()
            {
                StudentFk = selectedStudent.StudentId,
                TextbookFk = selectedTextbook.TextbookId
            };

            context.Orders.Add(newOrder);


            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ListOrders();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Biztosan ki akarsz lépni?",
                "Figyelem!", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            f2 = null;
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
            f3 = null;
            this.Show();

        }
    }
    public class OrderDetail
    {
        public int OrderID { get; set; }
        public string Title { get; set; }

        public double? Price { get; set; }
    }
}