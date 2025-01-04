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
    public partial class Form8 : Form
    {
        string message, title;
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            pictureBoxDeco.SizeMode = PictureBoxSizeMode.StretchImage;
            //pictureBoxDeco.ImageLocation = $"C:\\Users\\admin\\Downloads\\EBProject\\Border.jpg";
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            var frmViewOrder = new FormClientView();
            frmViewOrder.MdiParent = this.MdiParent;
            frmViewOrder.Dock = DockStyle.Fill;
            frmViewOrder.Show();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            var frmNewOrder = new Form1();
            frmNewOrder.MdiParent = this.MdiParent;
            frmNewOrder.Dock = DockStyle.Fill;
            frmNewOrder.Show();
            //this.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var frmUpdate = new FormClientUpdate();
            frmUpdate.MdiParent = this.MdiParent;
            frmUpdate.Dock = DockStyle.Fill;
            frmUpdate.Show();
            //this.Close();
        }

        private void pictureBoxDeco_Click(object sender, EventArgs e)
        {

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
