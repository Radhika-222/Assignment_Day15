using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {  //Task 1:Hello World
            Console.WriteLine("Hello, World");
            Console.ReadKey();


            //Task 2:Variable and user input

            Console.WriteLine("Enter your Name");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
            Console.ReadKey();

            //Task 3:Basic Arithmetic

            Console.WriteLine("Enter first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = int.Parse(Console.ReadLine());
            //Addition
            int add = num1 + num2;
            Console.WriteLine("Addition is:" + add);

            //Subtraction
            int sub = num1 - num2;
            Console.WriteLine("Subtraction is:" + sub);

            //Multiplication
            int mul = num1 * num2;
            Console.WriteLine("Multiplication is:" + mul);

            //Division

            if (num2 != 0)
            {
                double quotient = (double)num1 / num2;
                Console.WriteLine("Quotient is:" + quotient);
            }
            else
            {
                Console.WriteLine("Cannot divide by zero");
            }

            //Modulus
            if (num2 != 0)
            {
                int remainder = num1 % num2;
                Console.WriteLine("Remainder is:" + remainder);
            }
            Console.ReadKey();

            //Task 4:Control Structure
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Given Number is Even");
            }
            else
            {
                Console.WriteLine("Given number is odd");
            }
            Console.ReadKey();

            //Task 5:Loops

            int i = 1;
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();

            //Task 6:Array
            int[] array = { 5, 10, 15, 20, 25 };

            int sum = 0;
            foreach (int number in array)
            {
                sum += number;
            }
            double average = (double)sum / array.Length;
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average}");

            Console.ReadLine();

            
        }
    }
}
  






   
