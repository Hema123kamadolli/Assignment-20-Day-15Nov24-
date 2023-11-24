using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpAssignmentTask_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task-8 Exception Handling");

            int age;

            while (true)
            {
                Console.WriteLine("Enter your Age: ");
                string userInput = Console.ReadLine();

                if(int.TryParse(userInput, out age))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input.Please enter a valid integer for age.");
                }

            }

            if(age < 18)
            {
                Console.WriteLine("You are a minor (under 18)");
            }
            else if(age >= 18 && age <= 65)
            {
                Console.WriteLine("You are an adult (between 18 and 65)");
            }
            else 
            {
                Console.WriteLine("You are a senior (65 and older)");
            }
            Console.ReadKey();
        }
    }
}
