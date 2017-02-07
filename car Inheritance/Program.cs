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
            Bil b1 = new Bil("ford", 81701, 2015, 200);


            Console.WriteLine(b1.TotalPris()); 
        }
    }
}
