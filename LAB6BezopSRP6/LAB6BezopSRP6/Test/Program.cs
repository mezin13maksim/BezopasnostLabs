using System;
using System.Text;
using SRP6;

namespace Program
{
    class Program
    {
        
        private static string Username = "TEST";
        private static string Password = "test";
     

        
        private const int Generator = 0x0A;
        private const int SafePrimeLength = 256;
        private const int SaltBitLength = 512;
        private const int ScramblerBitLength = 256;
       

        /*static void Main(string[] args)
        {
            

           
			String modulus = "20E176988FD33DE7AE0D296BF805A49F3F45B92FB59036DCC9F0624B89B2DB67";

            
			
			{
				RunTest(modulus);
			}

            Console.ReadLine();
        

		private static ConsoleKey GetKey()
		{
			ConsoleKeyInfo result = Console.ReadKey(true);
			if (result.Key != ConsoleKey.Enter)
				Console.Write(result.KeyChar);
			return result.Key;
		}

   
        

		private static bool RunTest(String modulus, bool silent = false)
		{
           
            byte[] identityHash = Encoding.Unicode.GetBytes((Username + ":" + Password)).Sha1Hash();

		
			var srpServer = new Srp6(identityHash, modulus, Generator, SaltBitLength, ScramblerBitLength);

		
			var srpClient = new Srp6(identityHash, modulus, Generator, srpServer.Salt.ToHexString());

		
			srpClient.SetSessionKey(srpServer.PublicKey.ToHexString(), srpServer.Scrambler.ToHexString());

			
			srpServer.SetSessionKey(srpClient.PublicKey.ToHexString());

            
            const string startingText = "Hello";
            string encryptedText = srpServer.Encrypt(startingText);
            string decryptedText = srpClient.Decrypt(encryptedText);

			
			if (!silent)
            {

                
				Console.WriteLine(Environment.NewLine);
				Console.WriteLine("Modulus = " + srpServer.Modulus.ToHexString());
				Console.WriteLine("Multiplier = " + srpServer.Multiplier.ToHexString());
				Console.WriteLine("Generator = " + srpServer.Generator.ToHexString());
				Console.WriteLine("Salt = " + srpServer.Salt.ToHexString());
				Console.WriteLine("IdentityHash = " + srpServer.IdentityHash.ToHexString());
				Console.WriteLine("Verifier = " + srpServer.Verifier.ToHexString());
				Console.WriteLine();
				Console.WriteLine("ServerPrivateKey(b)= " + srpServer.PrivateKey.ToHexString());
				Console.WriteLine("ServerPublicKey(B)= " + srpServer.PublicKey.ToHexString());
				Console.WriteLine("Scramber(u)= " + srpServer.Scrambler.ToHexString());
				Console.WriteLine();
				Console.WriteLine("ClientPrivateKey(a) = " + srpClient.PrivateKey.ToHexString());
				Console.WriteLine("ClientPublicKey(A)= " + srpClient.PublicKey.ToHexString());
				Console.WriteLine("ClientIdentityHash(x) = " + srpClient.IdentityHash.ToHexString());
				Console.WriteLine();
				Console.WriteLine("ServerSessionKey = " + srpServer.SessionKey.ToHexString());
				Console.WriteLine("ClientSessionKey = " + srpClient.SessionKey.ToHexString());
                Console.WriteLine();
                Console.WriteLine("Starting Text = " + startingText);
                Console.WriteLine("Encrypted Text = " + encryptedText);
                Console.WriteLine("Decrypted Text = " + decryptedText);
			}

            
			return srpServer.SessionKey.Equals(srpClient.SessionKey);
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
		}*/

    }
}
