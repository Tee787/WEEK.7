using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsk1MedalsArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******************************************************");
            Console.WriteLine("*******************Task 1 Medals***********************");
            Console.WriteLine("*******************************************************");

            string[] names = new String[3];
            Console.WriteLine("Enter the name of the gold medal winner: ");
            names[0] = Console.ReadLine();
            Console.WriteLine("Enter the name of the silver medal winner: ");
            names[1] = Console.ReadLine();
            Console.WriteLine("Enter the name of the bronze medal winner: ");
            names[2] = Console.ReadLine();

            Console.WriteLine("\nWhich medal winner would you like to know: ");
            Console.WriteLine("Press 1 for the gold winner: ");
            Console.WriteLine("Press 2 for the silver winner: ");
            Console.WriteLine("Press 3 for the bronze winner: ");
            int input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                Console.WriteLine($"Gold medal went to: {names[input - 1]}");
            }
            else if (input == 2)
            {
                Console.WriteLine($"Silver medal went to: {names[input - 2]}");
            }
            else if (input == 3)
            {
                Console.WriteLine($"Bronze medal went to: {names[input - 3]}");
            }

            Console.ReadLine();
        }
       
    }
}
