﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Player
{
    public partial class Form2 : Form
    {
        private Form1 frm1;

        public Form2()
        {
            InitializeComponent();
        }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                   }

        private void Form2_Load(object sender, EventArgs e)
        {
            frm1 = new Form1();
            frm1.Show();
        }
    }
}
