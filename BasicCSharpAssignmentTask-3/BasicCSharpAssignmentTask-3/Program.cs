using ArithMeticLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpAssignmentTask_3
{
     internal class Program
        {
            static void Main(string[] args)
            {
                string choice;
                do
                {

                    Console.WriteLine("Task 3: Basic Arithmetic");
                    double number1, number2;
                    Console.WriteLine("Enter First Number");
                    number1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Second Number");
                    number2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Choose Operation 1. Add 2. Diff 3. Multiplay 4.Division 5.Modulus");
                    int op = int.Parse(Console.ReadLine());
                    Calculation cal = new Calculation();
                    switch (op)
                    {
                        case 1:
                            {
                                Console.WriteLine($"Result after adding {number1}and{number2} = \t {cal.Add(number1, number2)}");
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine($" Difference of {number1}and {number2} = \t {cal.Diff(number1, number2)}");
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine($"Multiplication of {number1}and{number2} = \t {cal.Multi(number1, number2)}");
                                break;
                            }
                        case 4:
                            {
                            if (number2 != 0)
                            {
                               // double quotient = (double)number1 / number2;
                                Console.WriteLine($"Result after dividing {number1}by{number2} = \t {cal.Div(number1, number2)}");
                            }
                            else
                            {
                                Console.WriteLine("Cannot divide by zero.");
                            }
                            break;
                        }
                        case 5:
                            {
                            if (number2 != 0)
                            {
                               // double reminder = number1 % number2;
                                Console.WriteLine($" Modulus of {number1}by{number2} = \t {cal.Module(number1, number2)}");
                            }
                            else
                            {
                                Console.WriteLine("Cannot calculatemodulus when the second number is zero.");
                            }
                            break;
                            }
                        default:
                            {
                                Console.WriteLine("Invalid Operation Choice!!!");
                                break;
                            }

                    }
                    Console.WriteLine("Do you wanna contineue... if yes press y");
                    choice = Console.ReadLine().ToLower();
                }
                while (choice == "y");


            }
        }
    }



