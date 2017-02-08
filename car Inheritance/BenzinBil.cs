using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_Inheritance
{
    sealed class BenzinBil : Bil
    {

        /*Constructor*/
        public BenzinBil(string mærke, int prisExAfgift, int KøbsÅr, string registreringsNr, int KmPrLiter) 
            : base(mærke, prisExAfgift, KøbsÅr, registreringsNr, KmPrLiter)
        {
           
        }


        /*Methods*/
        public override int HalvÅrligEjerafgift()
        {
            int udgift = 0;

            if (KmPrLiter < 20)
            {
                udgift = 1200;
            }
            else if (KmPrLiter >= 20 && KmPrLiter <= 28)
            {
                udgift = 600;
            }
            else if (KmPrLiter > 28)
            {
                udgift = 320;
            }

            return udgift;
        }
    }
}
