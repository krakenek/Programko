using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPart2
{
    // Trida
    public class Car
    {
        // Parametry
        public string Barva { get; set; }
        public string Znacka { get; set; }
        public int Year { get; set; }

        // Konstruktor
        public Car(string barva, string znacka, int year)
        {
            Barva = barva;
            Znacka = znacka;
            Year = year;
        }

        public Car(string barva, string znacka)
        {
            Barva = barva;
            Znacka = znacka;
        }

    }
}
