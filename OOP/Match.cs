using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP
{
    public class Match
    {
        //Parametry
        public Car Car1 { get; set; }
        public Car Car2 { get; set; }
        //Constructor
        public Match(Car car1, Car car2)
        {
            Car1 = car1;
            Car2 = car2;
        }
        //Metody
        public void VypisBarvyAut()
        {
            Console.WriteLine("Barva prvniho auta je:" + Car1.Barva);
            Console.WriteLine("Barva druheho auta je:" + Car2.Barva);
        }



    }
}
