using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpAssignmentTask_7
{
    internal class Program
    {
        static int CalculateFactorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return n * CalculateFactorial(n - 1);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Task 7: Methods");
            Console.WriteLine("Enter a positive integer to calculate it's factorial: ");
            int userInput = int.Parse(Console.ReadLine());

            if(userInput >= 0)
            {
                int factorialResult = CalculateFactorial(userInput);

                Console.WriteLine($"Factorial of {userInput} is: {factorialResult}"); ;
            }
            else
            {
                Console.WriteLine("Please enter a non-negative integer.");
            }

            Console.ReadKey();

        }
    }
}
