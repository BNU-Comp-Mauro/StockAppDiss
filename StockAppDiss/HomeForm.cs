using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockAppDiss
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ManageProducts prod = new ManageProducts();
            prod.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ManageUsers users = new ManageUsers();
            users.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ManageCategories Cat = new ManageCategories();
            Cat.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ManageCustomers Cust = new ManageCustomers();
            Cust.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            ManageOrders Orders = new ManageOrders();
            Orders.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }
    }
}
