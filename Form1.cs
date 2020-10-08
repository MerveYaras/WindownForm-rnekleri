using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Left = button1.Left + 10;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //left'e değer atayabilirsin amarigth ye atayamazsın.
            button1.Left = button1.Left - 10;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Top = button1.Top + 10;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Top = button1.Top - 10;
        }
    }
}
