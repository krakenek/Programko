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
            Car auticko = new Car("zelena","oppel",2004);
            Car auticko2 = new Car("modra", "oppel", 2004);
            Car auticko3 = new Car("zluta", "oppel", 2004);
            Console.WriteLine(auticko.Barva + ", " + auticko2.Barva + ", " + auticko3.Barva);


            Console.ReadKey();
        }
    }

}
