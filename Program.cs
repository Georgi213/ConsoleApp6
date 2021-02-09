using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string dannie;
            string hg;
            int m = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("m={0},b={1}", m, b);
            double c = (m + b) / (6 * m - 4 * b);
            Console.WriteLine("c={0}", c.ToString());
            string daniie = Console.ReadLine();
            hg = Console.ReadLine();
            Random rnd = new Random();
            int hinne = rnd.Next(1, 5);
            Console.WriteLine("Hinne:{0}", hinne);
            string tekst = "???";
            switch (hinne)
            {
                case 1: tekst = "Õpi veel!"; break;
                case 2: tekst = "Õpi natuke veel!"; break;
                case 3: tekst = "Rahuldav!"; break;
                case 4: tekst = "Hea!"; break;
                case 5: tekst = "Väga hea!"; break;
                default:
                    tekst = "Viga!";
                    break;
            }
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.WriteLine(tekst);
            ConsoleKeyInfo nupp = new ConsoleKeyInfo();

            do
            {
                Console.WriteLine("Kostja petuh");
                nupp = Console.ReadKey();


            } while (nupp.Key != ConsoleKey.Backspace);
            Console.ReadLine();
            Console.WriteLine("Töö failidega:");
            string a;
            Console.WriteLine("Q-on vaja salvestada failisse");
            Console.WriteLine("N-on vaja lugeda failist");
            nupp = Console.ReadKey();
            if (nupp.Key == ConsoleKey.Q)
            {
                StreamWriter file = new StreamWriter(@"..\..\texsts.txt", true);
                file.WriteLine(hinne + "" + tekst);
                file.Close();
                a = hinne + "" + tekst;
                Console.WriteLine("Failisse oli salvestatud:{0}", a);
            }
            else if (nupp.Key == ConsoleKey.N)
            {
                Console.WriteLine("Failis on järgmine informatsion:{0}");
                StreamReader fillist = new StreamReader(@"..\..\texsts.txt");
                a = fillist.ReadToEnd();
                Console.WriteLine(a);
            }
            else if (nupp.Key == ConsoleKey.E)
            {

            }
            else
            {
                Console.WriteLine("Puhkame");
            }
            Console.ReadLine();
        }
    }
}
