using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpAssignmentTask_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task-5 Loops");
            Console.WriteLine("Numbers from 1 to 10:");

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.ReadKey();



        }
    }
}
