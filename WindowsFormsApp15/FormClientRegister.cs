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
    public partial class FormClientRegister : Form
    {
        Register register = new Register();
        string message, title;
        private void checkInput(string a, string b, string c)
        {
            if (String.IsNullOrEmpty(a) & String.IsNullOrEmpty(b) & String.IsNullOrEmpty(c))
                throw new myExceptions("Please enter all the blanks!");
            else if (String.IsNullOrEmpty(a))
                throw new myExceptions("Please enter name!");
            else if (String.IsNullOrEmpty(b))
                throw new myExceptions("Please enter telephone number!");
            else if (String.IsNullOrEmpty(c))
                throw new myExceptions("Please enter password!");
        }

        private void ResetForm()
        {
            message = "Do you really want to reset form?";
            title = "Reset Form";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                labelClientID.Text = "";
                textBoxName.Text = string.Empty;
                textBoxTelNo.Text = string.Empty;
                textBoxPass.Text = string.Empty;
            }
        }

        private void Register()
        {
            try
            {
                checkInput(textBoxName.Text, textBoxTelNo.Text, textBoxPass.Text);

                // check if name is unique
                if (register.CheckName(textBoxName.Text) == true)
                {

                    message = "Are you sure to register?";
                    title = "Confirm Register";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        labelClientID.Text = register.CID;
                        register.CName = textBoxName.Text;
                        register.CPhone = textBoxTelNo.Text;
                        register.CPass = textBoxPass.Text;
                        register.InsertClient();
                        MessageBox.Show("Register successfully!");
                        buttonRegister.Enabled = false;
                        var formLogin = new Form5();
                        formLogin.MdiParent = this.MdiParent;
                        formLogin.Dock = DockStyle.Fill;
                        formLogin.Show();
                        this.Close();
                    }
                }
                else
                {
                    message = "Name already exist. Please Choose other name.";
                    title = "Fail to Register";
                    MessageBox.Show(message, title);

                }
            }
            catch (myExceptions excep)
            {
                MessageBox.Show(excep.Message);
            }
        }
        public FormClientRegister()
        {
            InitializeComponent();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetForm();       
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            buttonReset.Enabled = false;
            pictureBoxDeco.SizeMode = PictureBoxSizeMode.CenterImage;
            //pictureBoxDeco.ImageLocation = $"C:\\Users\\admin\\Downloads\\EBProject\\Seller.png";
            register.GenerateCustomeriD();

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            Register();
        }

        private void textBoxTelNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTelNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '-' )
            {
                e.Handled = true;
            }
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar != Keys.Back & !char.IsLetter(e.KeyChar) & e.KeyChar != '_'& !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Register(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Register();
        }

        private void Reset_Form(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                ResetForm();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            buttonReset.Enabled = true;
        }
    }
}
