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
    public partial class FormBusinessPrinciple : Form
    {
        public FormBusinessPrinciple()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            pictureBoxCartoon.SizeMode = PictureBoxSizeMode.StretchImage;
            //pictureBoxCartoon.ImageLocation = $"C:\\Users\\admin\\Downloads\\EBProject\\Cartoon.png";

            pictureBoxHonesty.SizeMode = PictureBoxSizeMode.StretchImage;
            //pictureBoxHonesty.ImageLocation = $"C:\\Users\\admin\\Downloads\\EBProject\\Honesty.png";
            pictureBoxExcellence.SizeMode = PictureBoxSizeMode.StretchImage;
            //pictureBoxExcellence.ImageLocation = $"C:\\Users\\admin\\Downloads\\EBProject\\Excellence.png";
            pictureBoxResilience.SizeMode = PictureBoxSizeMode.StretchImage;
            //pictureBoxResilience.ImageLocation = $"C:\\Users\\admin\\Downloads\\EBProject\\Resilence.png";
        }

        private void pictureBoxHonesty_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
