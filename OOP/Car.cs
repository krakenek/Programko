using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Car
    {
        public string Motor { get; set; }
        public string Barva { get; set; }
        public string Znacka { get; set; }
        public int Rok { get; set; }

        public Car(string motor, string barva, string znacka, int rok)
        {
            Motor = motor;
            this.Barva = barva;
            Znacka = znacka;
            Rok = rok;
        }



    }
}
