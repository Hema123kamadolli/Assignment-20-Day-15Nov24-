using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpAssignmentTask_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Task 2: Variable and user input");
            Console.WriteLine("Enter Your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}!");

            Console.ReadKey();
        }
    }
}
