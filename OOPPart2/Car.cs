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
        public string Velikost { get; set; }
        public int Year { get; set; }

        // Konstruktor
        public Car(string barva, string velikost, int year)
        {
            Barva = barva;
            Velikost = velikost;
            Year = year;
        }

        // Konstruktor 2
        public Car(string barva, string velikost)
        {
            Barva = barva;
            Velikost = velikost;
        }

        //Konstruktor 3
        public Car()
        { 
        
        }

        public void BarvaAuta()
        {
            Console.WriteLine(Barva);
        }

        public void RokAuta()
        {
            Console.WriteLine(Year);
        }

        public int VratRok()
        {
            return Year;
        }

    }
}
