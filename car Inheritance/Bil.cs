using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_Inheritance
{
     public class Bil
    {
        public int BilPrisExAfgift { get; private set; }
        public int KøbsÅr { get; private set; }
        public string Mærke { get; private set; }
        public string RegistreringsNr { get; set; }
        public int KmPrLiter { get; private set; }


        /*Methoder*/
        public virtual int RegistreringsAfgift()
        {
            int BilAfgift = 0;

            if (KøbsÅr <= 2014)
            {
                if (BilPrisExAfgift <= 80500)
                {
                  BilAfgift =  (BilPrisExAfgift * 105) / 100;
                }

                if (BilPrisExAfgift > 80500)
                {
                    int sum1 = (80500 * 105) / 100;
                    int sum2 = ((BilPrisExAfgift - 80500) * 180) / 100;
                    BilAfgift = sum1 + sum2;
                }

                
            }
                else if (KøbsÅr >= 2015)
            {
                if (BilPrisExAfgift <= 81700)
                {
                    BilAfgift = (BilPrisExAfgift * 105) / 100;
                }

                if (BilPrisExAfgift > 81700)
                {
                    int sum1 = (80500 * 105) / 100;
                    int sum2 = ((BilPrisExAfgift - 80500) * 180) / 100;
                    BilAfgift = sum1 + sum2;
                }

            }

            return BilAfgift;
        }

        public int TotalPris()
        {
            return BilPrisExAfgift + RegistreringsAfgift();
        } 

        public virtual int HalvÅrligEjerafgift()
        {
            return 1000;
        }


        public Bil(string mærke, int prisExAfgift, int købsÅr, int KmPrLiter)
        {
            this.Mærke = mærke;
            this.BilPrisExAfgift = prisExAfgift;
            this.KøbsÅr = købsÅr;
            this.KmPrLiter = KmPrLiter;
        }

    }
}
