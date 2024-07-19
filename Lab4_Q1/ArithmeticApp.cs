using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Lab4_Q1
{
    internal class ArithmeticApp
    {
        public delegate double ArithmeticOperationDelegate(double num1, double num2);

        public void Run()
        {
            double num1, num2;
            int choice;

            Console.WriteLine("Enter first number: ");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nSelect operation:");
            Console.WriteLine("1. Add Numbers");
            Console.WriteLine("2. Multiply Numbers");
            Console.WriteLine("3. Divide Numbers");
            Console.WriteLine("4. Subtract Numbers");
            Console.WriteLine("5. Find Max Number");
            Console.WriteLine("Enter your choice: ");

            choice = int.Parse(Console.ReadLine());

            ArithmeticOperation operation = new ArithmeticOperation();
            ArithmeticOperationDelegate del;

            switch (choice)
            {
                case 1:
                    del = operation.AddNumbers;
                    break;
                case 2:
                    del = operation.MultiplyNumbers;
                    break;
                case 3:
                    del = operation.DivideNumbers;
                    break;
                case 4:
                    del = operation.SubtractNumbers;
                    break;
                case 5:
                    del = operation.FindMaxNumber;
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    return;
            }

            try
            {
                double result = del(num1, num2);
                Console.WriteLine("The result is: {0}", result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
            }
        }
    }
}
