using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_Inheritance
{
    class ElBil : Bil
    {
        /*Properties*/
        public int BatteriKapacitet { get; private set; }
        public int KmPrKW { get; private set; }


        /*Constructor*/
        public ElBil(string mærke, int prisExAfgift, int KøbsÅr, string registreringsNr, int BatteriKapacitet, int KmPrKw) 
            : base(mærke, prisExAfgift, KøbsÅr, registreringsNr)
        {
            this.BatteriKapacitet = BatteriKapacitet;
            this.KmPrKW = KmPrKw;
        }



        /*Methoder*/

        public override int RegistreringsAfgift()
        {
            int BilAfgift = 0;

            if (KøbsÅr <= 2014)
            {
                if (BilPrisExAfgift <= 80500)
                {
                    BilAfgift = (BilPrisExAfgift * 105) / 100;
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

            return (BilAfgift * 20) / 100;
        }

        public override int HalvÅrligEjerafgift()
        {
            return 0;
        }

        public override int RækkeVidde()
        {
            return BatteriKapacitet * KmPrKW;
        }
    }
}
