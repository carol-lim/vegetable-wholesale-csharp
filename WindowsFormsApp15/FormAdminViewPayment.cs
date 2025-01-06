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
    public partial class FormAdminViewPayment : Form
    {
        public FormAdminViewPayment()
        {
            InitializeComponent();
        }

        private void FormViewPayment_Load(object sender, EventArgs e)
        {
        }

        private void FormAdminViewPayment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cookiesDataSet1.Vegetable' table. You can move, or remove it, as needed.
            this.vegetableTableAdapter1.Fill(this.cookiesDataSet1.Vegetable);
            // TODO: This line of code loads data into the 'cookiesDataSet1.Vege_Order' table. You can move, or remove it, as needed.
            this.vege_OrderTableAdapter1.Fill(this.cookiesDataSet1.Vege_Order);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var formAdminHome = new FormAdminHome();
            formAdminHome.MdiParent = this.MdiParent;
            formAdminHome.Dock = DockStyle.Fill;
            formAdminHome.Show();
            this.Close();
        }
    }
}
