using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string operation = GetOperation();
            double x, y;
            bool loops = true;


            if (operation.Equals("+"))
            {
                x = GetNumber("Number 1: ");
                y = GetNumber("Number 2: ");
                Console.WriteLine(AddNumbers(x, y));
            }
            else if (operation.Equals("-"))
            {
                x = GetNumber("Number 1: ");
                y = GetNumber("Number 2: ");
                Console.WriteLine(SubtractNumbers(x, y));
            }
            else if (operation.Equals("*"))
            {
                x = GetNumber("Number 1: ");
                y = GetNumber("Number 2: ");
                Console.WriteLine(MultiplyNumbers(x, y));
            }
            else if (operation.Equals("/"))
            {
                x = GetNumber("Number 1: ");
                y = -1;
                while (loops)
                {
                    y = GetNumber("Number 2: "); 
                    // if user tries to divide by zero, they'll be prompted again
                    if (!(y == 0)) 
                    {
                        loops = false;
                    }
                }
                Console.WriteLine(DivideNumbers(x, y));
            }

        }
        static double DivideNumbers(double num1, double num2) => num1 / num2;

        static double MultiplyNumbers(double num1, double num2) => num1 * num2;

        static double SubtractNumbers(double num1, double num2) => num1 - num2;

        static double AddNumbers(double num1, double num2) => num1 + num2;
        static string GetOperation()
        {
            bool haveOperation = false;
            string operation = "x";

            while (!haveOperation)
            {
                try
                {
                    Console.Write("Choose operation (+)(-)(*)(/): ");
                    operation = Console.ReadLine();

                    string[] operations = new string[4]
                    {
                        "+","-","*","/"
                    };

                    haveOperation = Array.Exists(operations, element => element == operation);
                    return operation;

                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid operation"); // Change this
                }

            }
            return operation;



        }

        static double GetNumber(string message)
        {
            bool looping = true;
            double result = -1;

            while (looping)
            {
                try
                {
                    Console.Write(message);
                    result = Convert.ToDouble(Console.ReadLine());
                    return result;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Only numbers are allowed");
                }

            }

            return result;
        }
    }
}

