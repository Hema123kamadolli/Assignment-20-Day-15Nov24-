using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpAssignmentTask_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 4: Control Structures");
            Console.Write("Enter an integer to check whether it is even or odd: ");
            int userInput = int.Parse(Console.ReadLine());

             //check if the number is even or odd
             if (userInput % 2 == 0)
             {
                Console.WriteLine($"{userInput} is an even number.");
             }
             else
             {
                Console.WriteLine($"{userInput} is an odd number. ");
             }

                Console.ReadKey();
            
        }
    }

}
    

