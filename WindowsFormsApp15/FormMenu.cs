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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
      
        private void Form2_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            BackgroundImageLayout = ImageLayout.None;
            BackgroundImage = Image.FromFile("C:\\Users\\Carol\\Downloads\\EBProject\\Home.png");            
        }

        private void businessPrincipleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBusinessPrinciple frmBusinessPrinciple = new FormBusinessPrinciple();
            frmBusinessPrinciple.MdiParent = this;
            frmBusinessPrinciple.Dock = DockStyle.Fill;
            frmBusinessPrinciple.Show();
        }

        private void moreInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMoreInfo frmMoreInfo = new FormMoreInfo();
            frmMoreInfo.MdiParent = this;
            frmMoreInfo.Dock = DockStyle.Fill;
            frmMoreInfo.Show();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientRegister formRegister = new FormClientRegister();
            formRegister.MdiParent = this;
            formRegister.Dock = DockStyle.Fill;
            formRegister.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 formLogin = new Form5();
            formLogin.MdiParent = this;
            formLogin.Dock = DockStyle.Fill;
            formLogin.Show();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdminLogin formAdminLogin = new FormAdminLogin();
            formAdminLogin.MdiParent = this;
            formAdminLogin.Dock = DockStyle.Fill;
            formAdminLogin.Show();
        }
    }
}
