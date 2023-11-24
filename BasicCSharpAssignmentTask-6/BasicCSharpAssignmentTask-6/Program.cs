using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpAssignmentTask_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task-6 Array ");

            // Declare and initialize an integer array with five elements
            int[] numbers = { 10, 20, 30, 40, 50 };

            // Calculate the sum of the elements in the array
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }

            // Calculate the average of the elements in the array
            double average = (double)sum / numbers.Length;

            // Display the sum and average on the console
            Console.WriteLine($"Array Elements: {string.Join(", ", numbers)}");
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average}");

            
            Console.ReadKey();
        }
    }
}
