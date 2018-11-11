using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsk3RandomNameArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******************************************************");
            Console.WriteLine("*****************Task 3 Random Names*******************");
            Console.WriteLine("*******************************************************");

            string[] names = { "Jim", "John", "Max", "Tarnz" };
            Random rand = new Random();

            int winner = rand.Next(0, 4);
            Console.WriteLine($"{names[winner]}");

            Console.ReadLine();
        }
    }
}
