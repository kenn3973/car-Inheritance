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

            List<DieselBil> dieselBilListe = new List<DieselBil>();
            DieselBil d1 = new DieselBil("ford", 100000, 2014, "dad12", 11);
            DieselBil d2 = new DieselBil("Toyota", 100000, 2014, "dad13", 11);
            DieselBil d3 = new DieselBil("Ferrari", 100000, 2014, "dad14", 11);
            DieselBil d4 = new DieselBil("Volvo", 100000, 2014, "dad15", 11, false);
            DieselBil d5 = new DieselBil("Smart Car", 100000, 2014, "dad16", 11, false);


            dieselBilListe.Add(d1);
            dieselBilListe.Add(d2);
            dieselBilListe.Add(d3);
            dieselBilListe.Add(d4);
            dieselBilListe.Add(d5);


            foreach (var DieselCar in dieselBilListe)
            {
                Console.WriteLine(DieselCar.RegistreringsNr);
                Console.WriteLine(DieselCar.HalvÅrligEjerafgift());
            }

       
        }
    }
}
