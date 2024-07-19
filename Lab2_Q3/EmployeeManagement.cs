using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Lab2_Q3
{
    internal class EmployeeManagement
    {
        private List<Employee> Employees = new List<Employee>();

        private void AddEmployee()
        {
            Console.WriteLine("Enter Employee Number: ");
            int employeeNumber = int.Parse(Console.ReadLine());

            Employee employee = Employees.FirstOrDefault(e => e.EmployeeNumber == employeeNumber);

            if (employee != null)
            {
                Console.WriteLine($"Employee already with number {employeeNumber} already exists.");
                return;
            }

            Console.WriteLine("Enter Employee Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Basic Salary: ");
            decimal basicSalary = decimal.Parse(Console.ReadLine());

            Employees.Add(new Employee(employeeNumber, name, basicSalary));
            
            Console.WriteLine("Employee added successfully.");
        }

        private void SearchEmployee()
        {
            Console.WriteLine("Enter Employee Number to Search For: ");
            int employeeNumber = int.Parse(Console.ReadLine());

            Employee employee = Employees.FirstOrDefault(e => e.EmployeeNumber == employeeNumber);

            if (employee != null)
            {
                Console.WriteLine($"Employee Found =>");
                Console.WriteLine($"Name: {employee.Name}");
                Console.WriteLine($"BasicSalary: {employee.BasicSalary}");
                Console.WriteLine($"PF: {employee.PF}");
            }
            else
            {
                Console.WriteLine($"No record found with employee number {employee.EmployeeNumber}");
            }
        }

        private void DeleteEmployee()
        {
            Console.WriteLine("Enter Employee Number to Delete: ");
            int employeeNumber = int.Parse(Console.ReadLine());

            Employee employee = Employees.FirstOrDefault(e => e.EmployeeNumber == employeeNumber);

            if (employee != null)
            {
                Employees.Remove(employee);
                Console.WriteLine($"Employee deleted successfully.");
            }
            else
            {
                Console.WriteLine($"No record found with employee number {employee.EmployeeNumber}");
            }
        }

        private void ViewAllEmployees()
        {
            Console.WriteLine("Employees List =>");

            foreach (Employee employee in Employees )
            {
                Console.WriteLine($"Number: {employee.EmployeeNumber}\tName: {employee.Name}\tBasic Salary: {employee.BasicSalary}\tPF: {employee.PF}");
            }
        }

        public void Run()
        {
            int choice;

            do
            {
                Console.WriteLine("\nEmployee Management System");
                Console.WriteLine("1. Add New Employee");
                Console.WriteLine("2. Search Employee");
                Console.WriteLine("3. Delete Employee");
                Console.WriteLine("4. View All Employees");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Enter your choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddEmployee();
                        break;
                    case 2:
                        SearchEmployee();
                        break;
                    case 3:
                        DeleteEmployee();
                        break;
                    case 4:
                        ViewAllEmployees();
                        break;
                    case 5:
                        Console.WriteLine("Exiting Employee Management System...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            } while (choice != 5);
        }
    }
}
