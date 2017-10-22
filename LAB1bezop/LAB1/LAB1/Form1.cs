using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            string begin = textBox1.Text[0].ToString();
            string t = textBox1.Text.Remove(0, 1);
            textBox1.Text = t.Insert(t.Length, begin);
           
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string end = textBox1.Text[textBox1.Text.Length-1].ToString();
            string t = textBox1.Text.Remove(textBox1.Text.Length-1, 1);
            textBox1.Text = t.Insert(0, end);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string output = "";
            string table = textBox1.Text;
            richTextBox1.Text=richTextBox1.Text.ToLower();

            foreach (char sym in richTextBox1.Text) {

                if (sym == ' ') { output = output.Insert(output.Length, " "); }
                else
                {
                    try
                    {
                        if (sym == 'ё') { output = output.Insert(output.Length, table[6].ToString()); }
                        else if (sym > 'е') { output = output.Insert(output.Length, table[(int)sym - 1071].ToString()); }
                        else output = output.Insert(output.Length, table[(int)sym - 1072].ToString());
                    }
                    catch (IndexOutOfRangeException) { output = output.Insert(output.Length, "-"); }
                }
            }
            richTextBox2.Text = output;

        }

        
    }
}
