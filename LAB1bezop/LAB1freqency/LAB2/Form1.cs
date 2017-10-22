using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;

using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace LAB2
{
    

   

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class SymFr
        {
            public string sym;
            public double fr;
            public SymFr(string s, double f)
            {
                sym = s;
                f = fr;
            }

        }


        public List<SymFr> getFreqencyTable(string inputText)
        {
                List<SymFr> Table = new List<SymFr>();
                Table.Add(new SymFr("а", 0));
                Table.Add(new SymFr("б", 0));
                Table.Add(new SymFr("в", 0));
                Table.Add(new SymFr("г", 0));
                Table.Add(new SymFr("д", 0));

                Table.Add(new SymFr("е", 0));
                Table.Add(new SymFr("ё", 0));
                Table.Add(new SymFr("ж", 0));
                Table.Add(new SymFr("з", 0));
                Table.Add(new SymFr("и", 0));

                Table.Add(new SymFr("й", 0));
                Table.Add(new SymFr("к", 0));
                Table.Add(new SymFr("л", 0));
                Table.Add(new SymFr("м", 0));
                Table.Add(new SymFr("н", 0));

                Table.Add(new SymFr("о", 0));
                Table.Add(new SymFr("п", 0));
                Table.Add(new SymFr("р", 0));
                Table.Add(new SymFr("с", 0));
                Table.Add(new SymFr("т", 0));

                Table.Add(new SymFr("у", 0));
                Table.Add(new SymFr("ф", 0));
                Table.Add(new SymFr("х", 0));
                Table.Add(new SymFr("ц", 0));
                Table.Add(new SymFr("ч", 0));

                Table.Add(new SymFr("ш", 0));
                Table.Add(new SymFr("щ", 0));
                Table.Add(new SymFr("ъ", 0));
                Table.Add(new SymFr("ы", 0));
                Table.Add(new SymFr("ь", 0));

                Table.Add(new SymFr("э", 0));
                Table.Add(new SymFr("ю", 0));
                Table.Add(new SymFr("я", 0));


                foreach (char a in inputText)
                {
                    if ((int)a > 1071 && (int)a < 1106)
                    {
                        if (a == 'ё')
                        {
                            Table[6].fr++;

                        }
                        else if ((int)a <= 1077)
                        {
                            Table[(int)a - 1072].fr++;
                        }
                        else if (((int)a >= 1078))
                        {
                            Table[(int)a - 1071].fr++;
                        }
                    }
                }
                Table.Sort(new frComparer());

                if (inputText.Length != 0)
                {
                    foreach (SymFr s in Table)
                    {
                        s.fr /= inputText.Length;
                        s.fr = Math.Round(s.fr, 2);
                    }
                }

                
                return Table;

        }


        class frComparer : IComparer<SymFr>
        {
            public int Compare(SymFr a, SymFr b)
            {
                if (a.fr < b.fr)
                {
                    return 1;
                }
                else if (a.fr > b.fr)
                {
                    return -1;
                }

                return 0;
            }
        }

        List<SymFr> table1 = new List<SymFr>();
        List<SymFr> table2 = new List<SymFr>();


        private void button1_Click(object sender, EventArgs e)
        {

            textBox2.Text = "";
            table2 = getFreqencyTable(richTextBox1.Text);
            foreach (SymFr s in table2)
            {
                textBox2.Text += s.sym;

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.Text = "";
            table1 = getFreqencyTable(richTextBox1.Text);
            foreach (SymFr s in table1)
            {
                textBox1.Text += s.sym;

            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.InitialDirectory = "c:\\";
            fd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (fd.ShowDialog() == DialogResult.OK)
            {
                
                    richTextBox1.Text = File.ReadAllText(fd.FileName);
            }

            
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            char[] t1 = textBox1.Text.ToCharArray();
            char[] t2 = textBox2.Text.ToCharArray();
            string s="";
            richTextBox1.Text =richTextBox1.Text.ToLower();
            foreach (char c in richTextBox1.Text)
            {

                if (c == ' ')
                {
                    s += ' ';
                }
                else if ((int)c > 1071 && (int)c < 1106)
                {
                    for (int i = 0; i <= t2.Length - 1; i++)
                    {
                        if (t2[i] == c)
                        {
                            s += t1[i];
                            break;
                        }
                    }
                }
            }

            richTextBox2.Text = s;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            
        }
    }
}
