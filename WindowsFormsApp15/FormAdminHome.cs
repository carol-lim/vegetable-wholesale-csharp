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
    public partial class FormAdminHome : Form
    {
        cookiesDataContext db = new cookiesDataContext();
        string message, title;
        public FormAdminHome()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            pictureBoxDeco.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxDeco.ImageLocation = $"C:\\Users\\admin\\Downloads\\EBProject\\Border.jpg";
        }

        private void buttonClientData_Click(object sender, EventArgs e)
        {
            var formViewClientData = new FormAdminViewClientData();
            formViewClientData.MdiParent = this.MdiParent;
            formViewClientData.Dock = DockStyle.Fill;
            formViewClientData.Show();
            this.Close();
        }

        private void buttonClientOrder_Click_1(object sender, EventArgs e)
        {
            var formViewClientOrder = new FormAdminViewClientOrder();
            formViewClientOrder.MdiParent = this.MdiParent;
            formViewClientOrder.Dock = DockStyle.Fill;
            formViewClientOrder.Show();
            this.Close();
        }

        private void buttonPayment_Click_1(object sender, EventArgs e)
        {
            var formViewPayment = new FormAdminViewPayment();
            formViewPayment.MdiParent = this.MdiParent;
            formViewPayment.Dock = DockStyle.Fill;
            formViewPayment.Show();
            this.Close();
        }

        private void linkLabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            message = "Are you sure to logout?";
            title = "Confirm Logout";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
