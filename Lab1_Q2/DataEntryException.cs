using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Lab1_Q2
{
    internal class DataEntryException : Exception
    {
        public DataEntryException(string message) : base(message) { }
    }
}
