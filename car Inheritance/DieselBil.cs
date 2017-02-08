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


        /*Constructor*/
        public DieselBil(string mærke, int prisExAfgift, int KøbsÅr, string registreringsNr, int KmPrLiter, bool PartikelFilter) 
            : base(mærke, prisExAfgift, KøbsÅr, registreringsNr, KmPrLiter)
        {
            this.PartikelFilter = PartikelFilter;
        }

        public DieselBil(string mærke, int prisExAfgift, int KøbsÅr, string registreringsNr, int KmPrLiter) 
            :this(mærke, prisExAfgift, KøbsÅr, registreringsNr, KmPrLiter, true)
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





            //if (PartikelFilter == true)
            //{
            //    return 1000;
            //}
            //else
            //{
            //    return 1500;
            //}

        }


    }
}
