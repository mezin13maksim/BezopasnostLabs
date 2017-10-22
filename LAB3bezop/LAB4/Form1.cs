using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB4
{

    



    public partial class Form1 : Form
    {
        private int dhFunc(int a, int b, int c)
        {
            long p = a;

            for (int i = 0; i <= b - 2; i++)
            {
                p = p * a;

            }
            return (int)(p % c);

        }

        public Form1()
        {
            InitializeComponent();
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxG1.Text = textBox1.Text;
                textBoxG2.Text = textBox1.Text;
                
            }
            catch (Exception) { }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxP1.Text = textBox2.Text;
                textBoxP2.Text = textBox2.Text;
            
            }
            catch (Exception) { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DHUser u1 = new DHUser(Convert.ToInt32(textBoxG1.Text), Convert.ToInt32(textBoxP1.Text), Convert.ToInt32(textBoxA1.Text));
                DHUser u2 = new DHUser(Convert.ToInt32(textBoxG2.Text), Convert.ToInt32(textBoxP2.Text), Convert.ToInt32(textBoxB2.Text));
                textBoxAo1.Text = u1.getOpenKey().ToString();
                textBoxBo2.Text = u2.getOpenKey().ToString();
                textBoxK1.Text = u1.getCloseKey(u2.getOpenKey()).ToString();
                textBoxK2.Text = u2.getCloseKey(u1.getOpenKey()).ToString();

            }
            catch (Exception) { }




        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dhFunc(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text) - 1, Convert.ToInt32(textBox2.Text)) == 1)
                button4.BackColor = Color.Green;
            else
                button4.BackColor = Color.Red;

        }

    }

    

    

    



}
