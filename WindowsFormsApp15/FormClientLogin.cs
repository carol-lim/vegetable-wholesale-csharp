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
    public partial class Form5 : Form
    {
        Login login = new Login();

        string message, title;

        public Form5()
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

                login.CName = textBoxName.Text;
                login.CPass = textBoxPass.Text;
                login.SearchCustomer();
                if (login.Flag == true)
                {
                    MessageBox.Show("Login successfully!");
                    buttonLogin.Enabled = false;

                    var frmChoose = new Form8();
                    frmChoose.MdiParent = this.MdiParent;
                    frmChoose.Dock = DockStyle.Fill;
                    frmChoose.Show();
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Customer does not exists. Please fill in register form!");
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
        private void Form5_Load(object sender, EventArgs e)
        {
            buttonReset.Enabled = false;
            pictureBoxDeco.SizeMode = PictureBoxSizeMode.CenterImage;
            //pictureBoxDeco.ImageLocation = $"C:\\Users\\admin\\Downloads\\EBProject\\Van.jpg";

        }

        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            Login();
        }

        private void buttonReset_Click_1(object sender, EventArgs e)
        {
            Reset();
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar != Keys.Back & !char.IsLetter(e.KeyChar) & e.KeyChar != '_' & !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Login(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Login();
        }

        private void Reset_Form(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Reset();
        }

        private void textBoxName_TextChanged_1(object sender, EventArgs e)
        {
            buttonReset.Enabled = true;
        }
    }
}
