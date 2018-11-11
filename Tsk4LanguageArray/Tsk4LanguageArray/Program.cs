using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsk4LanguageArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******************************************************");
            Console.WriteLine("********************Task 4 Lauguages*******************");
            Console.WriteLine("*******************************************************");

            string[] greetings = { "Hello", "KiaOra", "Kon Nichiwa", "Namaste", "Bonjour", "Talofa", };
            Console.WriteLine("Please select a language.....");
            Console.WriteLine("Press 1 for English.....");
            Console.WriteLine("Press 2 for Moari.....");
            Console.WriteLine("Press 3 for Japanese.....");
            Console.WriteLine("Press 4 for Hindi.....");
            Console.WriteLine("Press 5 for French.....");
            Console.WriteLine("Press 6 for Samoan.....");
            int selection = int.Parse(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    Console.WriteLine(greetings[selection - 1]);
                    break;
                case 2:
                    Console.WriteLine(greetings[selection - 2]);
                    break;
                case 3:
                    Console.WriteLine(greetings[selection - 3]);
                    break;
                case 4:
                    Console.WriteLine(greetings[selection - 4]);
                    break;
                case 5:
                    Console.WriteLine(greetings[selection - 5]);
                    break;
                case 6:
                    Console.WriteLine(greetings[selection - 6]);
                    break;
                default:
                    Console.WriteLine("Oops, something went wrong...");
                    break;
            }
            Console.ReadLine();
        }
    }
}
