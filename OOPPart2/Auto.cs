using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOPPart2
{
    class Auto
    {
        public int Year { get; set; }

        public string Barva { get; set; }

        public string Znacka { get; set; }
        public string Velikost { get; set; }

        public Auto( CarFactory cf, int year, string barva)
        {
            Year = year;
            Barva = barva;
            Znacka = cf.Znacka;
            Velikost = cf.Velikost;       
        }


    }
}
