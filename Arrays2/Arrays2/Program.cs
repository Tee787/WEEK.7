using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************************************************************************************");
            Console.WriteLine("*************************************Reverse Array**********************************");
            Console.WriteLine("************************************************************************************");

            string[] number = new String[5];
            Console.WriteLine("\nEnter 5 numbers....");
            Console.WriteLine("Enter number 1....");
            number[0] = Console.ReadLine();
            Console.WriteLine("Enter number 2....");
            number[1] = Console.ReadLine();
            Console.WriteLine("Enter number 3....");
            number[2] = Console.ReadLine();
            Console.WriteLine("Enter number 4....");
            number[3] = Console.ReadLine();
            Console.WriteLine("Enter number 5....");
            number[4] = Console.ReadLine();

            for  (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(number[0] [1],[2],);
            }
            for(int i = 5; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("This is my reverse array.");

            /*********************************************************************************************/

            /*Console.WriteLine("********************************************************************");
            Console.WriteLine("********************************************************************");
            Console.WriteLine("********************************************************************");

            Console.WriteLine("Please enter how big an array you would like: ");    //Console display output
            int input = int.Parse(Console.ReadLine());                              //input variable used plus integer convert statement
            int total = 0;                                                          //total variable used
            int[] array1 = new int[input];                                          //array integer input

            Option1(input, total, array1);                                          //Option1 Method
            Console.Clear();
            Option2(input, total, array1);                                          //Option2 Method
        }
        public static void Option1(int input, int total, int[] array1)              //Calling Method for Option1
        {
            for (int i = 0; i < input; i++)                                         //for loop statement used in Option1
            {
                Console.Write($"Please enter number {i + 1}: ");                    //Write method used for user input of integer
                array1[i] = int.Parse(Console.ReadLine());                          //output of array1 loop. Converted to an integer
            }

            for (int i = 0; i < input; i++)                                          //second for loop statement used
            {
                Console.Write($"Number {i + 1}: array1[i]\n");                      //user input of integer
                total += array1[i];
            }
            Console.WriteLine($"total = {total}");
        }

        public static void Option2(int input, int total, int[] array1)              //Calling Method for Option2
        {
            for (int i = 0; i < input; i++)                                         //for loop statement usage in Option2
            {
                Console.Write($"Number {i + 1}: array1[i]\n");
                total += array1[i];
            }
            
            foreach(int x in array1)                                                //foreach statement used
            {
                Console.WriteLine(x);
                total += x;
            }
            Console.WriteLine($"total = {total}");
            Console.ReadLine();*/
        }

    }
}
