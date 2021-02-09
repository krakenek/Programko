using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car auticko = new Car("zelena", "oppel", 2004);
            Car autobezroku = new Car("zluty","nissan");
            Car auticko2 = new Car("modra", "oppel", 2004);
            Car auticko3 = new Car("zluta", "oppel", 2004);
            //Console.WriteLine(auticko.Barva + ", " + auticko.Znacka + ", " + auticko3.Barva);
            autobezroku.Year = 2020;
            Console.WriteLine(autobezroku.Year);

            string auto1barva = "modra";
            string auto1znacka = "cervena";
            int auto1rok = 2004;



            Console.ReadKey();
        }
    }

}
