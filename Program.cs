using Assignments.Lab1_Q1;
using Assignments.Lab1_Q2;
using Assignments.Lab2_Q1;
using Assignments.Lab2_Q2;
using Assignments.Lab2_Q3;
using Assignments.Lab3_Q1;
using Assignments.Lab4_Q1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lab1_Q1
            try
            {
                Customer customer = new Customer(1, "John Doe", "123 Main St", "Anytown", "555-1234", 60000);
            }
            catch (InvalidCreditLimitException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            // Lab1_Q2
            try
            {
                ProductMock product = new ProductMock(1, "Samsung Earbuds", 9999);
            }
            catch (DataEntryException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (Exception ex)  // Catch any other unexpected exceptions
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }

            // Lab2_Q1
            ContactListManager contactListManager = new ContactListManager();
            contactListManager.Run();

            // Lab2_Q2
            ProductManager productManager = new ProductManager();
            productManager.Run();

            // Lab2_Q3
            EmployeeManagement employeeManagement = new EmployeeManagement();
            employeeManagement.Run();

            // Lab3_Q1
            FileExtensionManager fileExtensionManager = new FileExtensionManager();
            fileExtensionManager.Run();

            // Lab4_Q1
            ArithmeticApp arithmeticApp = new ArithmeticApp();
            arithmeticApp.Run();

            Console.ReadLine();
        }
    }
}
