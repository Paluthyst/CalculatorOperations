using System;
using System.Net.Http.Headers;

namespace CalculatorOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            //indetify num1
            int num1;
            //user input
            Console.WriteLine("Can I have a number?");
            num1 = int.Parse(Console.ReadLine());
            //operations
            if (num1 % 2 == 0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }
            Console.WriteLine(num1 + " plus 1 is: " + (num1 + 1));
            Console.WriteLine(num1 + " subtracted by 1 is: " + (num1 - 1));
            Console.WriteLine(num1 + " divided by 1 is: "+ (num1 % 1));
            Console.WriteLine(num1 + " multiplyed by 1 is: " + (num1*1));
            Console.WriteLine(num1 + " ++ is: "+ (num1 + 1));
            Console.WriteLine(num1 + " -- is: "+ (num1 - 1));

        }
    }
}
