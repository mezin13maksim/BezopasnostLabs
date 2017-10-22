using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSALAB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        RSAClient rsaClient = new RSAClient();

        private void button1_Click(object sender, EventArgs e)
        {

            EasyNumberGenerator e1 = new EasyNumberGenerator();
            textBox1.Text = e1.generateEasyNumber()[0].ToString();
            textBox2.Text = e1.generateEasyNumber()[1].ToString();
 
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                if (rsaClient.setRSA(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox4.Text)))
                {
                    textBox3.Text = rsaClient.getN().ToString();
                    textBox5.Text = rsaClient.getD().ToString();
                    LogTextBox.Text += "Ключи дешифрования успешно установлены\n";
                }
                else
                    LogTextBox.Text += "Неверое число е, попробуйте другое \n";
            }
            catch (Exception)
            {
                LogTextBox.Text += "Ошибка не введены q p или e\n";
                
            }


           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LogTextBox.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                
                    int temp = rsaClient.powm(Convert.ToInt32(textBox11.Text), Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox9.Text));
                    textBox10.Text = temp.ToString();
                    LogTextBox.Text += "Сообщение зашифровано m=" + textBox11.Text + " e=" + textBox8.Text + " n=" + textBox9.Text + "\n";
                
            }
            catch (Exception)
            {
                LogTextBox.Text += "Ошибка не введены n,e или сообщение \n";

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            


            try
            {

                textBox7.Text = rsaClient.powm(Convert.ToInt32(textBox6.Text), rsaClient.getD(), rsaClient.getN()).ToString();
                LogTextBox.Text += "Сообщение разшифровано m=" + textBox6.Text + " d=" + rsaClient.getD() + " n=" + rsaClient.getN() + "\n";
                
            }
            catch (Exception)
            {
                LogTextBox.Text += "Ошибка не введены q,p,e или сообщение \n";

            }



        }
    }
}
