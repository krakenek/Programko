using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPart2
{
    public class CarFactory
    {
        public string Znacka { get; set; }
        public string Velikost { get; set; }

        //Firma vyrabi auta nejake znacky a nejake velikosti pevne dane
        public CarFactory(string znacka, string velikost )
        {
            Znacka = znacka;
            Velikost = velikost;       
        }




    }
}
