using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_Methods
{
    public class Program
    {
        public static long CalculateFactorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            else
            {
                return number * CalculateFactorial(number - 1);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive integer");
            int input = int.Parse(Console.ReadLine());

            if (input < 0)
            {
                Console.WriteLine("Please enter a positive integer");

            }
            else
            {
                long result = CalculateFactorial(input);
                Console.WriteLine($"Factorial of {input} is: {result}");
            }
            Console.ReadKey();
        }
    }
}

   
