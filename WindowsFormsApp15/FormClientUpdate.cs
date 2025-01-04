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
    public partial class FormClientUpdate : Form
    {
        ClientUpdate update = new ClientUpdate();
        public string message, title;
        private MessageBoxButtons buttons = MessageBoxButtons.YesNo;
        delegate void DelegateInfo(string info, string alert);
        private DelegateInfo DisplayInfo = delegate (string info, string alert)
        {
            MessageBox.Show(info, alert);
        };

        private void checkInput(string a, string b)
        {
            if (String.IsNullOrEmpty(a) & String.IsNullOrEmpty(b))
                throw new myExceptions("Please enter all the blanks!");
            else if (String.IsNullOrEmpty(a))
                throw new myExceptions("Please enter telephone number!");
            else if (String.IsNullOrEmpty(b))
                throw new myExceptions("Please enter password!");
        }

        public FormClientUpdate()
        {
            InitializeComponent();
        }
        
        public void Update_data()
        {
            try
            {
                checkInput(textBoxPhone.Text, textBoxPass.Text);

                message = "Are you sure to update information?";
                title = "Update Information";
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    update.CPhone = textBoxPhone.Text;
                    update.CPass = textBoxPass.Text;
                    update.UpdateCustomer();

                    DisplayInfo("Client details has been updated! ", "Update Now");
                }
            }
            catch (myExceptions excep)
            {
                MessageBox.Show(excep.Message);
            }
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            pictureBoxDeco.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxDeco.ImageLocation = $"C:\\Users\\admin\\Downloads\\EBProject\\Fork.jpg";

            //update.CID = Login.CID;
            update.Load();

            labelClientID.Text = Login.CID;
            labelName.Text = update.CName;
            textBoxPhone.Text = update.CPhone;
            textBoxPass.Text = update.CPass;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void textBoxTelNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void Update(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Update_data();
        }

        private void Back(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Update_data();

        }
    }
}
