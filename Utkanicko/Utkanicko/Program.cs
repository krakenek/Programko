using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace Utkanicko
{
    class Program
    {
        static void Main(string[] args)
        {
            int pocet = 0;
            Console.WriteLine("Vitejte v simulatoru fotbalového utkani");
            Console.WriteLine("Kolik dnes bude hrát týmu?");
            pocet = Int32.Parse(Console.ReadLine());
            while (true)
            {
                if (pocet == 0)
                {
                    Console.WriteLine("Bez druzstev nemuze byt utkani");
                }
                else if (pocet == 1)
                {
                    Console.WriteLine("Na zapas jsou potreba aspon dva tymy");
                }
                else if (pocet < 0)
                {
                    Console.WriteLine("Tymy nemohou byt v zapornem cisle");
                }
                else
                {
                    Console.WriteLine("Dobra takze dnesni zapas bude mezi " + pocet + (" tymy"));
                    break;
                }
                Console.WriteLine("Takze kolik dnes bude hrát týmu?");
                pocet = Int32.Parse(Console.ReadLine());
            }
            int i = 0;
            string nazev_tymu;
            while (true)
            {
                i++;
                Console.WriteLine("Nyni pojdme pojmenovat " + i + ". tym");
                var nazev_tymu = new Team();
                if (i > 10)
                {
                    break;
                }
            }
            Console.ReadKey();



        }
        public List<string> Pridani(string str1)
        {
                var tym = new List<string>();
                tym.Add(str1);
        }
        class Team
        {

        }
        
    }
}
