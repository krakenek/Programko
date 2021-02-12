using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPPart2.TEst;

namespace OOPPart2
{
    class Program
    {
        static void Main(string[] args)
        {/*
            Car auticko = new Car("zelena", "maly", 2004);
            //Car autobezroku = new Car("zluty","nissan");
            Car auticko2 = new Car("modra", "velky", 2004);
            Car auticko3 = new Car("zluta", "mini", 2004);
            //Console.WriteLine(auticko.Barva + ", " + auticko.Znacka + ", " + auticko3.Barva);

            Car autobezroku = new Car("zluty", "maxi");
            autobezroku.Year = 2020;
            //Console.WriteLine(autobezroku.Year);            
            Console.WriteLine(auticko.Barva);

            autobezroku.BarvaAuta();
            int rok = autobezroku.VratRok() * 5;
            Console.WriteLine(rok);*/

            CarFactory poldovka = new CarFactory("audi", "peknemaly");
            List<Auto> listaut = new List<Auto>();
            /*
            Auto auticko = new Auto(poldovka,2020,"zluty");
            Auto auticko2 = new Auto(poldovka, 2014, "cerveny");
            Auto auticko3 = new Auto(poldovka, 2020, "modry");*/
            /*
            listaut.Add(auticko);
            listaut.Add(auticko2);
            listaut.Add(auticko3);*/
            int pocet = 0;
            List<Car> listicek = new List<Car>();
            while (pocet < 2)
            {
                pocet++;
                Console.WriteLine("Napis Barvu auta");
                string barvicka = Console.ReadLine();
                Console.WriteLine("Napis Velikost auta");
                string velikost = Console.ReadLine();
                Console.WriteLine("Napis Rok auta");
                int rok = Int32.Parse(Console.ReadLine());
                listicek.Add(new Car(barvicka, velikost, rok));

            }

            foreach (Car auto in listicek)
            {
                    Console.WriteLine(auto.Year + " " + auto.Velikost + " " + auto.Barva);
            }

            // Console.WriteLine(auticko.Znacka + " " + auticko.Year + " " + auticko.Velikost + " " + auticko.Barva);
            //Console.WriteLine(listaut[0].Znacka + " " + listaut[0].Year + " " + listaut[0].Velikost + " " + listaut[1].Barva);
            /*
            pocet = 0;
            foreach (Auto auto in listaut)
            {
                pocet++;
                if (auto.Year==2020)
                {
                    Console.WriteLine(auto.Znacka + " " + auto.Year + " " + auto.Velikost + " " + auto.Barva);
                }
            }*/

            Console.ReadKey();
        }
    }

}
