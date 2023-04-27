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
    public partial class ViewOrders : Form
    {
        public ViewOrders()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mauro\Documents\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");
        void populateorders()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from OrdersTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                OrdersGv.DataSource = ds.Tables[0];
                Con.Close();

            }
            catch
            {

            }
        }
        private void ViewOrders_Load(object sender, EventArgs e)
        {
            populateorders();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void OrdersGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Order Summary", new Font("Century", 25, FontStyle.Bold),Brushes.Red,new Point(230));
            e.Graphics.DrawString("Order ID:"+OrdersGv.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80,100));
            e.Graphics.DrawString("Customer ID:" + OrdersGv.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 133));
            e.Graphics.DrawString("Customer Name:" + OrdersGv.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 166));
            e.Graphics.DrawString("Order Date:" + OrdersGv.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 199));
            e.Graphics.DrawString("Total Amount:" + OrdersGv.SelectedRows[0].Cells[4].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 232));
        }
    }
}
