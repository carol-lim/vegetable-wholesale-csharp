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
    public partial class FormAdminLogin : Form
    {
        AdminLogin AdminLogin = new AdminLogin();
        string message, title;

        public FormAdminLogin()
        {
            InitializeComponent();
        }
        private void checkInput(string a, string b)
        {
            if (String.IsNullOrEmpty(a) & String.IsNullOrEmpty(b))
                throw new myExceptions("Please enter all the blank!");
            else if (String.IsNullOrEmpty(a))
                throw new myExceptions("Please enter name!");
            else if (String.IsNullOrEmpty(b))
                throw new myExceptions("Please enter password!");
        }

        private void Login()
        {
            try
            {
                checkInput(textBoxName.Text, textBoxPass.Text);
                AdminLogin.AID = int.Parse(textBoxName.Text);
                AdminLogin.APass = textBoxPass.Text;
                AdminLogin.SearchAdmin();
                if (AdminLogin.Flag == true)
                {
                    MessageBox.Show("Login successfully!");
                    buttonLogin.Enabled = false;

                    var formAdminHome = new FormAdminHome();
                    formAdminHome.MdiParent = this.MdiParent;
                    formAdminHome.Dock = DockStyle.Fill;
                    formAdminHome.Show();
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Admin does not exists. Please fill in register form!");
                }
            }
            catch (myExceptions excep)
            {
                MessageBox.Show(excep.Message);
            }
        }

        private void Reset()
        {
            message = "Do you really want to reset form?";
            title = "Reset Form";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                textBoxName.Text = string.Empty;
                textBoxPass.Text = string.Empty;
            }
        }
        private void Form7_Load(object sender, EventArgs e)
        {
            buttonReset.Enabled = false;
            pictureBoxAdmin.SizeMode = PictureBoxSizeMode.CenterImage;
            //pictureBoxAdmin.ImageLocation = $"C:\\Users\\admin\\Downloads\\EBProject\\Admin.jpg";

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Login();
        }


        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            buttonReset.Enabled = true;
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '_' & !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Admin_Login(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
                Login();
        }

        private void Reset_Form(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Reset();
        }

        private void pictureBoxAdmin_Click(object sender, EventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
