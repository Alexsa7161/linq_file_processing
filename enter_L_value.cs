﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class enter_l_value : Form
    {
        public static int L;
        public enter_l_value()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            L = Convert.ToInt32(textBox1.Text);
            this.Close();
        }
        public static int Form6_Return()
        {
            return L;
        }
    }
}
