using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{

    class DHUser
    {
        private int secret = 0;
        private int openKey = 0;
        private int closeKey = 0;
        private int g = 0;
        private int p = 0;



        private int dhFunc(int a, int b,int c)
        {
            long p = a;

            for (int i = 0; i <= b -2 ; i++) {
                p = p*a;
            
            }
            return (int)(p % c);

        }

        public int getOpenKey(){
            return this.openKey;
        }

        public int getCloseKey(int forgeinKey)
        {
            this.closeKey = dhFunc(forgeinKey,secret,p);
            return this.closeKey;
        }

        public DHUser(int g, int p , int secret)
        {
            this.p = p;
            this.g = g;
            this.secret = secret;
            if (dhFunc(g, p - 1, p) == 1)
                this.openKey = dhFunc(g, secret, p);
            
        }


    }

}
