using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsk2NamesArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******************************************************");
            Console.WriteLine("**************************Task 2***********************");
            Console.WriteLine("*******************************************************");

            string[] names = new string[5];

            //Console.WriteLine($"Please enter the first name:\n ");        //Using standard method to start our program
            //names[0] = Console.ReadLine();
            //Console.WriteLine($"\nPlease enter the second name:\n ");
            //names[1] = Console.ReadLine();
            //Console.WriteLine($"\nPlease enter the third name:\n ");
            //names[2] = Console.ReadLine();
            //Console.WriteLine($"\nPlease enter the forth name:\n ");
            //names[3] = Console.ReadLine();
            //Console.WriteLine($"\nPlease enter the fifth name:\n ");
            //names[4] = Console.ReadLine();

            for (int i = 0; i <= 4; i++)                                    //for loop used to shorten the standard method
            {
                Console.WriteLine($"\nPlease enter name {i + 1}:\n ");      //Here is where the input names are added to intiate the for loop
            }
            Console.WriteLine($"\nThe first name entered is {names[0]}");   //Output of the final result
            Console.WriteLine($"\nThe last name entered is {names[4]}");

            Console.ReadLine();
        }
    }
}
