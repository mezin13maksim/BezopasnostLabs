using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSALAB
{
    class RSAClient
    {
        private int n = 0;
        private int d = 0;
        private int e = 0;
        public int getN() { return n; }
        public int getE() { return e; }
        public int getD() { return d; }

        public bool setRSA(int qRSA, int pRSA,int eRSA){

            int nTemp = qRSA*pRSA;
            int ffunc = (qRSA - 1) * (pRSA - 1);

            if (eRSA % 2 == 0) { return false; }
            for (int i = 3; i <= eRSA; i++)
            {
                if (ffunc % i == 0 && eRSA % i==0)
                    return false;

            }

            float dTemp = 0;


            for (int i = 1; i <= 20; i++)
            {

                dTemp = (float)(i * ffunc +1) / (float)eRSA;
                if (dTemp % 1 == 0)
                {

                    this.e = eRSA;
                    this.n = nTemp;
                    this.d = (int)dTemp;
                    return true;
                }
            }
            return false;
        }

        public int decryptRSA(int closeMessage)
        {
            if (closeMessage < 1) return 0;

            return powm(closeMessage, d, n);
            
        }

        public int cryptRSA(int openMessage)
        {
            if (openMessage < 1) return 0;

            return powm(openMessage, e, n);

        }

        public int powm(long a, long b, long n)
        {
            long c = 1;
            while (b!=0) {
                if (b%2 == 0)
                {   
                    b/= 2; 
                    a=(a*a)%n;
                }
                else
                { b--; 
                c= (c*a)%n;
                }
            }
            return (int)c;
        }
	}

    class EasyNumberGenerator
    {
        public int[] generateEasyNumber()
        {
            int[] mas =   {2,3,5,7,11,13,17,19,23,29,31,37,41,43,47,53,59,61,67,71,73,
                           79,83,89,97,101,103,107,109,113,127,131,137,139,149,151,157,
                           163,167,173,179,181,191,193,197,199,211,223,227,229,233,239,
                           241,251,257,263,269,271,277,281,283,293,307,311,313,317,331,
                           337,347,349,353,359,367,373,379,383,389,397,401,409,419,421,
                           431,433,439,443,449,457,461,463,467,479,487,491,499,503,509,
                           521,523,541,547,557,563,569,571,577,587,593,599,601,607,613,
                           617,619,631,641,643,647,653,659,661,673,677,683,691,701,709,
                           719,727,733,739,743,751,757,761,769,773,787,797,809,811,821,
                           823,827,829,839,853,857,859,863,877,881,883,887,907,911,919,
                           929,937,941,947,953,967,971,977,983,991,997};
            Random r = new Random();

            int[] ret = { mas[r.Next(mas.Length - 1)], mas[r.Next(mas.Length - 2)] };
            return ret;
        }


    }

}



