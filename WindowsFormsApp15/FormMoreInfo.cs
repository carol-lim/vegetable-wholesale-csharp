﻿using System;
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
    public partial class FormMoreInfo : Form
    {
        public FormMoreInfo()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {          
            pictureBoxMap.SizeMode = PictureBoxSizeMode.StretchImage;
            //pictureBoxMap.ImageLocation = $"C:\\Users\\admin\\Downloads\\EBProject\\Map.png";
        }
       
    }
}
