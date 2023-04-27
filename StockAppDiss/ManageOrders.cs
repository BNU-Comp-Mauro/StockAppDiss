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
namespace StockAppDiss
{
    public partial class ManageOrders : Form
    {
        public ManageOrders()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mauro\Documents\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from CustomerTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                CustomersGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }
        void populateproducts()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from ProductTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductsGV.DataSource = ds.Tables[0];
                Con.Close();

            }
            catch
            {

            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void CustomersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        void fillCategory()
        {
            string query = "select * from CategoryTbl";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("CatName", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                //CatCombo.ValueMember = "CatName";
                //CatCombo.DataSource = dt;
                SearchCombo.ValueMember = "CatName";
                SearchCombo.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }
        }
        void updateProduct()
        {
            
            int id = Convert.ToInt32(ProductsGV.SelectedRows[0].Cells[0].Value.ToString());
            int newQty = stock - Convert.ToInt32(QtyTb.Text);
            if (newQty < 0)
                MessageBox.Show("Operation Failed");
            else
            {
                Con.Open();
                string query = "update ProductTbl set ProdQty = " + newQty + " where ProdId=" + id + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                populateproducts();
            }
            
        }
        int num = 0;
        int uprice, totprice, qty;
        string product;
        private void ManageOrders_Load_1(object sender, EventArgs e)
        {
            populate();
            populateproducts();
            fillCategory();
            table.Columns.Add("Num", typeof(int));
            table.Columns.Add("Product", typeof(string));
            table.Columns.Add("Quantity", typeof(int));
            table.Columns.Add("Uprice", typeof(int));
            table.Columns.Add("Totprice", typeof(int));

            OrdersGv.DataSource = table;
        }

        private void SearchCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        int flag = 0;
        int stock;
        private void ProductsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        DataTable table = new DataTable();
        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0;
            if (QtyTb.Text == "")
                MessageBox.Show("Enter The Quantity of Products");
            else if (flag == 0)
                MessageBox.Show("Select The Product");
            else if (Convert.ToInt32(QtyTb.Text) > stock)
                MessageBox.Show("Not Enough Stock Available");
            else
            {
                num = num + 1;
                qty = Convert.ToInt32(QtyTb.Text);
                totprice = qty * uprice;
                table.Rows.Add(num, product, qty, uprice, totprice);
                OrdersGv.DataSource = table;
                flag = 0;
            }
            sum = sum + totprice;
            TotAmount.Text = sum.ToString();
            updateProduct();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void OrderGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(OrdersIdTb.Text == "" || CustId.Text == "" || CustName.Text =="" || TotAmount.Text == "")
            {
                MessageBox.Show("Fill the data correctly");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into ProductTbl values(" + OrdersIdTb.Text + ", " + CustId.Text + ",'" + CustName.Text + "', '" + orderdate.Text + "', " + TotAmount.Text + ")", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order Successfully Added");
                Con.Close();
                populate();
                try
                {

                }
                catch
                {

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewOrders view = new ViewOrders();
            view.Show();
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustId.Text = CustomersGV.SelectedRows[0].Cells[0].Value.ToString();
            CustName.Text = CustomersGV.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void gunaDataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            product = ProductsGV.SelectedRows[0].Cells[1].Value.ToString();
            //qty = Convert.ToInt32(QtyTb.Text);
            stock = Convert.ToInt32(ProductsGV.SelectedRows[0].Cells[2].Value.ToString());
            uprice = Convert.ToInt32(ProductsGV.SelectedRows[0].Cells[3].Value.ToString());
            //totprice = qty * uprice;
            flag = 1;
        }

        private void gunaDataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }

        private void SearchCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string Myquery = "select * from ProductTbl where ProdCat='" + SearchCombo.SelectedValue.ToString() + "'";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductsGV.DataSource = ds.Tables[0];
                Con.Close();

            }
            catch
            {

            }
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
