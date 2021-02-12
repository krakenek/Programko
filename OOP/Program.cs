using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> listik = new List<Car>();
            Car auto = new Car("velky","zluta","oppel",2001);
            Car auto2 = new Car("maly", "zeleny", "hyundai", 2008);
            listik.Add(auto);
            listik.Add(auto2);
            listik.Add(new Car("stredni", "oranzovy", "skodovka", 2006));
            
           // Console.WriteLine(auto2.Znacka + auto.Rok.ToString());
            int test = auto.Rok + 1000;
           // Console.WriteLine(test);

            Match zapas = new Match(auto, auto2);
            //zapas.VypisBarvyAut();
            // Console.WriteLine(zapas.Car1.Motor);
            List<Match> zapasy = new List<Match>();
            bool pravda = true;
            bool help;
            foreach (Car car1 in listik)
            {
                foreach (Car car2 in listik)
                {

                    if (car1 == car2)
                    {

                    }
                    else {
                        if (pravda == true)
                        {
                            Match zapasek = new Match(car1, car2);
                            zapasy.Add(zapasek);
                            pravda = false;
                        }
                        else
                        {
                            help = false;
                            Match zapasek = new Match(car1, car2);
                            foreach (Match hulahula in zapasy)
                            {
                                if (zapasek.Car1.Znacka == hulahula.Car2.Znacka || zapasek.Car2.Znacka == hulahula.Car1.Znacka)
                                {
                                    help = false;
                                }
                                else {
                                   // Console.WriteLine(zapasek.Car1.Znacka);
                                    help = true;                                    
                                }
                            }
                            if (help)
                            {
                                zapasy.Add(zapasek);
                            }
                        }


                    }                    
                
                }                                   
            }

            foreach (Match match in zapasy)
            {

                Console.WriteLine("Auto:" + match.Car1.Znacka + ", Proti autu:" + match.Car2.Znacka);
            }

                Console.ReadLine();


        }
    }

}
