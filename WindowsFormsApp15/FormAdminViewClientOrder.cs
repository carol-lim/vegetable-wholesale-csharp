using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class FormAdminViewClientOrder : Form
    {
        cookiesDataContext db = new cookiesDataContext();

        private void displayAllData()
        {
            IEnumerable<Order> querySearch =
                from order in db.Orders
                select order;
            ViewTableClient(querySearch);
        }

        private void ViewTableClient(IEnumerable<Order> querySearch)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Order ID", typeof(string));
            dt.Columns.Add("Client ID", typeof(string));
            dt.Columns.Add("Order Date", typeof(DateTime));
            dt.Columns.Add("Payment", typeof(string));

            foreach (Order order in querySearch)
            {
                DataRow dr = dt.NewRow();
                dr["Order ID"] = order.OrderID.ToString();
                dr["Client ID"] = order.ClientID.ToString();
                dr["Order Date"] = order.OrderDate.ToString();
                dr["Payment"] = order.Payment.ToString();

                dt.Rows.Add(dr);
            }
            dataGridViewOrder.DataSource = dt;
        }

        public FormAdminViewClientOrder()
        {
            InitializeComponent();
        }

        private void buttonAsc_Click(object sender, EventArgs e)
        {
            dataGridViewOrder.Sort(dataGridViewOrder.Columns[3], ListSortDirection.Ascending);
        }

        private void buttonDesc_Click(object sender, EventArgs e)
        {
            dataGridViewOrder.Sort(dataGridViewOrder.Columns[3], ListSortDirection.Descending);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var formAdminHome = new FormAdminHome();
            formAdminHome.MdiParent = this.MdiParent;
            formAdminHome.Dock = DockStyle.Fill;
            formAdminHome.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormViewClientOrder_Load(object sender, EventArgs e)
        {
            displayAllData();
        }
    }
}
