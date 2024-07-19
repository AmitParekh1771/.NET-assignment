using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Lab2_Q3
{
    internal class Employee
    {
        public Employee() { }  // Default constructor

        public Employee(int employeeNumber, string name, decimal basicSalary)
        {
            if (employeeNumber <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(employeeNumber),
                    "Employee number must be a positive integer.");
            }

            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name), "Name cannot be null or empty.");
            }

            if (basicSalary < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(basicSalary),
                    "Basic salary must be a non-negative value.");
            }

            this.EmployeeNumber = employeeNumber;
            this.Name = name;
            this.BasicSalary = basicSalary;
        }

        public int EmployeeNumber { get; set; }

        public string Name { get; set; }

        public decimal BasicSalary { get; set; }

        public decimal PF  // Consider readonly property for calculated values
        {
            get { return CalculatePF(BasicSalary); }
        }

        private decimal CalculatePF(decimal basicSalary)
        {
            return basicSalary * 0.12m;  // Example calculation (replace with actual formula)
        }
    }
}
