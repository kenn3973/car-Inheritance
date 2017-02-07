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

            if (PartikelFilter == true)
            {
                return base.HalvÅrligEjerafgift() + 500;
            }
            else
            {
                return base.HalvÅrligEjerafgift();
            }
           
        }
    }
}
