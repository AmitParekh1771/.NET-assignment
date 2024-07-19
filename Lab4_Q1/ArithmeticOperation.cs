using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Lab4_Q1
{
    internal class ArithmeticOperation
    {
        public double AddNumbers(double num1, double num2)
        {
            return num1 + num2;
        }

        public double MultiplyNumbers(double num1, double num2)
        {
            return num1 * num2;
        }

        public double DivideNumbers(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            return num1 / num2;
        }

        public double SubtractNumbers(double num1, double num2)
        {
            return num1 - num2;
        }

        public double FindMaxNumber(double num1, double num2)
        {
            return Math.Max(num1, num2);
        }
    }
}
