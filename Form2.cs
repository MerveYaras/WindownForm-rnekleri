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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int puan = 0;
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            int formgenislik = this.Width;
            int formyükseklik = this.Height;
            int konumleft = rnd.Next(0, formgenislik-50);
            int konumtop = rnd.Next(0, formyükseklik-50);
            button1.Left = konumleft;
            button1.Top = konumtop;
            if (sayac == 50)
            {
                timer1.Interval -= 100;
                sayac = 0;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            puan = puan + 10;
            sayac += 10;
            this.Text = "Puanınız: "+puan.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "Puanınız: ";
        }
    }
}
