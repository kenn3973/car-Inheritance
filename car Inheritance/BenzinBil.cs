using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_Inheritance
{
    sealed class BenzinBil : Bil
    {

        /*Properties*/
        public int Tank { get; set; }
        public int KmPrLiter { get; private set; }

        /*Constructor*/
        public BenzinBil(string mærke, int prisExAfgift, int KøbsÅr, string registreringsNr, int KmPrLiter, int Tank) 
            : base(mærke, prisExAfgift, KøbsÅr, registreringsNr)
        {
            this.Tank = Tank;
            this.KmPrLiter = KmPrLiter;
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

        public override int RækkeVidde()
        {
            return Tank * KmPrLiter;
        }
    }
}
