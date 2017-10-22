using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB3
{
    public partial class Form1 : Form
    {
       
        int getNumInAlphabet(char c)
        {
            
            c = Char.ToLower(c);


            if (c >= 'a' && c <= 'е')
            {
                return (int)c - 1071;
            }
            else if (c >= 'ж' && c <= 'я')
            {

                return (int)c - 1070;
            }
            else if (c == 'ё')
            {
                return 7;
            }

            return 0;


        }

        char getSymByNumber(int num) {

            if (num >= 1 && num <= 6)
            {
                return (char)(num+1071);
            }
            else if (num >= 8 && num <= 33)
            {

                return (char)(num + 1070);
            }
            else if (num == 7)
            {
                return 'ё';
            }

            return ' ';
        
        
            
        }

        string cryptToVernam(string input,string key){

            string output = "";
            int i = 0;

            foreach (char c in input) {
                output +=getSymByNumber((getNumInAlphabet(c) ^ getNumInAlphabet((char)key[i])));

                i++;

                if (i >= key.Length)
                {
                    i = 0;
                }
            
            
            
            }
            




            return output;

        }

        public Form1()
        {
            
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox3.Text = cryptToVernam(richTextBox1.Text, richTextBox2.Text);
        }


       

    }
}
