using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SRP6;
using System.Numerics;

namespace LAB6BezopSRP6
{
    public partial class Form1 : Form
    {
        private static String modulus = "20E176988FD33DE7AE0D296BF805A49F3F45B92FB59036DCC9F0624B89B2DB67";
        private string identificator;
        private BigInteger salt;
        private string verificator;
        private const int Generator = 0x0A;
        private const int SafePrimeLength = 256;
        private const int SaltBitLength = 512;
        private const int ScramblerBitLength = 256;
        private bool isRigistred = false;
        private Srp6 srpServer;
        private Srp6 srpClient;
        private byte[] identityHash;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text != null && PasswordTextBox.Text != null)
            {
                


                identityHash = Encoding.Unicode.GetBytes((UsernameTextBox.Text + ":" + PasswordTextBox.Text)).Sha1Hash();
                identificator = byteToString(identityHash);
                verificatorTextBox.Text=identificator;
                verificator = UsernameTextBox.Text;
                identificatorTextBox.Text = UsernameTextBox.Text;

                salt = Srp6.generateSalt(512);
                saltTextBox.Text = salt.ToHexString();
                isRigistred = true;
            }

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (isRigistred)
            {
                srpServer = new Srp6(identityHash, modulus, Generator, salt.ToHexString(), ScramblerBitLength);
                saltTextBox.Text = srpServer.Salt.ToHexString();
                saltTextBox2.Text = srpServer.Salt.ToHexString();
                byte[] identityHashLogin = Encoding.Unicode.GetBytes((LoginUsernameTextBox.Text + ":" + LoginPasswordTextBox.Text)).Sha1Hash();
                srpClient = new Srp6(identityHashLogin, modulus, Generator, srpServer.Salt.ToHexString());
                srpClient.SetSessionKey(srpServer.PublicKey.ToHexString(), srpServer.Scrambler.ToHexString());
                srpServer.SetSessionKey(srpClient.PublicKey.ToHexString());

                secretATextBox.Text = srpClient.PrivateKey.ToHexString();
                openATextBox.Text =srpClient.PublicKey.ToHexString();
                saltTextBox2.Text = srpServer.Salt.ToHexString();
                clientScramberTextBox.Text = srpClient.Scrambler.ToHexString();
                KeyOfSessionClientTextBox.Text = srpClient.SessionKey.ToHexString();

                secretBTextBox.Text = srpServer.PrivateKey.ToHexString();
                openBTextBox.Text = srpServer.PublicKey.ToHexString();

                serverScramberTextBox.Text = srpServer.Scrambler.ToHexString();
                KeyOfSessionServerTextBox.Text = srpServer.SessionKey.ToHexString();

            }
            
        }


        private static string GenerateRandomString(int length = 128)
        {

            byte[] bytes = new byte[length];
            Random rand = new Random();
            for (int i = 0; i < length; i++)
            {
                byte b = (byte)rand.Next(32, 126);
                if (b == 58)
                    i--;
                else
                    bytes[i] = b;
            }
            return Encoding.ASCII.GetString(bytes);
        }


        private static string GenerateSafePrime()
        {
            var random = new Random();
            var bitInt = BigIntegerExtensions.GenerateSafePrime(SafePrimeLength, 1, random);

            while (!bitInt.IsSafePrime(100))
            {
                bitInt = BigIntegerExtensions.GenerateSafePrime(SafePrimeLength, 1, random);
            }
            return bitInt.ToString("X2");
        }

        private string byteToString(byte[] mas)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in mas)
                sb.Append(b.ToString("X2"));

            string hexString = sb.ToString();
            return sb.ToString();
        }
    }
}
