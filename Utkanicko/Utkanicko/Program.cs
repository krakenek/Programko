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
            int tmp = 1;
            List<Team> listik = new List<Team>();
            for (int i = 0; i < pocet; i++)
            {
                Console.WriteLine("Nyni pojmenujte " + tmp + ". tym");
                listik.Add(new Team(Console.ReadLine()));
                tmp++;
            }
            tmp = 1;
            foreach (Team nazev in listik)
            {
                Console.WriteLine("Jmeno " + tmp + ". tymu je: " + nazev.Nazev);
                tmp++;
            }
            List<Zapas> zapas = new List<Zapas>();
            for (int i = 0; i < pocet; i++)
            {
                tmp = 1;
                while (true)
                {
                    if (tmp == pocet - i)
                    {
                        break;
                    }
                    Team team1 = listik[i];
                    Team team2 = listik[i + tmp];
                    Zapas match = new Zapas(team1,team2 );
                    zapas.Add(match);
                    tmp++;
                    
                }
            }
            foreach(Zapas match in zapas)
            {
                Console.WriteLine("Zapas probehne mezi:" + match.Team1.Nazev + " a " + match.Team2.Nazev);
            }
            Console.ReadKey();



        }
    }
}
