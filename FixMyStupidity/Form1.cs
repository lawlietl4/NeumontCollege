﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixMyStupidity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(String.Format("{0} the date is {1}{2}", "hello", DateTime.Now, Environment.NewLine));
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}