using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Lab1_Q1
{
    internal class InvalidCreditLimitException : Exception
    {
        public InvalidCreditLimitException(string message) : base(message) { }
    }
}
