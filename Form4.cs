﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_KeyPress(object sender, KeyPressEventArgs e)
        {
            string x = e.KeyChar.ToString();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.Focus();
        }
    }
}
