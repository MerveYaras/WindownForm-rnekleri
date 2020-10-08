using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        int p1, p2, p3;

        private void button1_Click(object sender, EventArgs e)
        {
            
            pictureBox1.Left = 30;
            pictureBox2.Left = 30;
            pictureBox3.Left = 30;
            timer1.Enabled = true;
            button1.Enabled = false;
        }

        Random r1 = new Random();

        private void Form3_KeyPress(object sender, KeyPressEventArgs e)
        {
           //string x= e.KeyChar.ToString();
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Left = pictureBox1.Left + 10;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox2.Left = pictureBox2.Left + 10;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox3.Left = pictureBox3.Left + 10;
        }

        
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            p1 = r1.Next(1,50);
            p2 = r1.Next(1,50);
            p3 = r1.Next(1,50);
            pictureBox1.Left = pictureBox1.Left + p1;
            pictureBox2.Left = pictureBox2.Left + p2;
            pictureBox3.Left = pictureBox3.Left + p3;

            if (pictureBox1.Left > pictureBox2.Left && pictureBox1.Left > pictureBox3.Left)
            { 
                label3.Text = "Siyah araba önde";
                if (pictureBox1.Right >= pictureBox5.Left)
                {

                    timer1.Enabled = false;
                    MessageBox.Show("Siyah Araba Kazandı");
                    button1.Text = "Yeniden Başlat";
                    button1.Enabled = true;
                }
            }
            else if (pictureBox2.Left > pictureBox1.Left && pictureBox2.Left > pictureBox3.Left)
            { 
                label3.Text = "Turuncu araba önde";
                if (pictureBox2.Right >= pictureBox5.Left)
                {

                    timer1.Enabled = false;
                    MessageBox.Show("Turuncu Araba Kazandı!");
                    button1.Text = "Yeniden Başlat";
                    button1.Enabled = true;
                }
            }
            else if (pictureBox3.Left > pictureBox1.Left && pictureBox3.Left > pictureBox1.Left)
            { 
                label3.Text = "Kırmızı araba önde";
                if (pictureBox3.Right >= pictureBox5.Left)
                {

                    timer1.Enabled = false;
                    MessageBox.Show("Kırmızı Araba Kazandı!");
                    button1.Text = "Yeniden Başlat";
                    button1.Enabled = true;

                }
            }


               
            
            
        }
    }
}
