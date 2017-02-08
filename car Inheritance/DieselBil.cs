using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_Inheritance
{
    class DieselBil : Bil
    {

        /*Properties*/
        public bool PartikelFilter { get;  private set; }
        public int Tank { get; private set; }
        public int KmPrLiter { get; private set; }

        /*Constructor*/
        public DieselBil(string mærke, int prisExAfgift, int KøbsÅr, string registreringsNr, int KmPrLiter, bool PartikelFilter, int Tank) 
            : base(mærke, prisExAfgift, KøbsÅr, registreringsNr)
        {
            this.PartikelFilter = PartikelFilter;
            this.Tank = Tank;
            this.KmPrLiter = KmPrLiter;
        }

        public DieselBil(string mærke, int prisExAfgift, int KøbsÅr, string registreringsNr, int KmPrLiter, int Tank) 
            :this(mærke, prisExAfgift, KøbsÅr, registreringsNr, KmPrLiter, true, Tank)
        {
           
        }


        /*Mehtoder*/
        public override int HalvÅrligEjerafgift()
        {
            int udgift = 0;
            int noPartikelfilter = 500;

            if (PartikelFilter == true)
            {
                if (KmPrLiter < 15)
                {
                    udgift = 2000;
                }
                else if (KmPrLiter >= 15 && KmPrLiter <= 25)
                {
                    udgift = 1000;
                }
                else if (KmPrLiter > 25)
                {
                    udgift = 300;
                }

                return udgift;
            }
            else
            {
                if (KmPrLiter < 15)
                {
                    udgift = 2000 + noPartikelfilter;
                }
                else if (KmPrLiter >= 15 && KmPrLiter <= 25)
                {
                    udgift = 1000 + noPartikelfilter;
                }
                else if (KmPrLiter > 25)
                {
                    udgift = 300 + noPartikelfilter;
                }

                return udgift;
            }

        }

        public override int RækkeVidde()
        {
            return Tank * KmPrLiter;
        }
    }
}
