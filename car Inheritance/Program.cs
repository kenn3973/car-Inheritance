using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------Diesel Biler---------------------------");
            /*Diesel Bil*/
            List<DieselBil> dieselBilListe = new List<DieselBil>();
            DieselBil d1 = new DieselBil("ford", 100000, 2014, "dad12", 11, 40);
            DieselBil d2 = new DieselBil("Toyota", 100000, 2014, "dad13", 26, 50);
            DieselBil d3 = new DieselBil("Ferrari", 100000, 2014, "dad14", 11, 40);
            DieselBil d4 = new DieselBil("Volvo", 100000, 2014, "dad15", 11, false, 40);
            DieselBil d5 = new DieselBil("Smart Car", 100000, 2014, "dad16", 11, false, 40);
            dieselBilListe.Add(d1);
            dieselBilListe.Add(d2);
            dieselBilListe.Add(d3);
            dieselBilListe.Add(d4);
            dieselBilListe.Add(d5);

            foreach (var DieselCar in dieselBilListe)
            {
                Console.WriteLine(DieselCar.RegistreringsNr);
                Console.WriteLine(DieselCar.HalvÅrligEjerafgift());
                Console.WriteLine(DieselCar.RækkeVidde());
            }


            Console.WriteLine("------------------------Benzin Biler---------------------------");
            /*Benzin Bil*/
            List<BenzinBil> benzinBilListe = new List<BenzinBil>();
            BenzinBil b1 = new BenzinBil("ford", 100000, 2014, "dad13", 11, 40);
            BenzinBil b2 = new BenzinBil("Toyota", 100000, 2014, "dad14", 20, 50);
            BenzinBil b3 = new BenzinBil("Ferrari", 100000, 2014, "dad5532", 28, 40);
            BenzinBil b4 = new BenzinBil("Volvo", 100000, 2014, "dad1243", 11, 30);
            BenzinBil b5 = new BenzinBil("Smart Car", 100000, 2014, "dad1412", 29, 40);

            benzinBilListe.Add(b1);
            benzinBilListe.Add(b2);
            benzinBilListe.Add(b3);
            benzinBilListe.Add(b4);
            benzinBilListe.Add(b5);

            foreach (var BenzinBIl in benzinBilListe)
            {
                Console.WriteLine(BenzinBIl.RegistreringsNr);
                Console.WriteLine(BenzinBIl.HalvÅrligEjerafgift());
                Console.WriteLine(BenzinBIl.RækkeVidde());
            }


            Console.WriteLine("------------------------El Biler---------------------------");
            /*EL Bil*/
            List<ElBil> ElBilLister = new List<ElBil>();
            ElBil e1 = new ElBil("Tesla", 100000, 2015, "Elon123", 200, 100);
            ElBil e2 = new ElBil("Tesla", 100000, 2015, "Elon2", 200, 100);
            ElBil e3 = new ElBil("Tesla", 100000, 2015, "Elon3", 200, 100);
            ElBil e4 = new ElBil("Tesla", 100000, 2015, "Elon4", 200, 100);
            ElBil e5 = new ElBil("Tesla", 10000, 2015, "Elon5", 100, 100);

            ElBilLister.Add(e1);
            ElBilLister.Add(e2);
            ElBilLister.Add(e3);
            ElBilLister.Add(e4);
            ElBilLister.Add(e5);

            foreach (var ElCar in ElBilLister)
            {
                Console.WriteLine(ElCar.RegistreringsNr);
                Console.WriteLine(ElCar.HalvÅrligEjerafgift());
                Console.WriteLine(ElCar.RækkeVidde());
                Console.WriteLine("REgAfgift" +  " " +ElCar.RegistreringsAfgift());
            }
        }
    }
}
