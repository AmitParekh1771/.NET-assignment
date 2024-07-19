using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Lab1_Q1
{
    internal class Customer
    {
        private decimal _CreditLimit;

        public Customer() { }

        public Customer(int customerId, string customerName, string address, string city, string phone, decimal creditLimit)
        {
            CustomerId = customerId;
            CustomerName = customerName;
            Address = address;
            City = city;
            Phone = phone;
            CreditLimit = creditLimit;  // Calls the property setter with validation
        }

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }

        // Property with validation for CreditLimit
        public decimal CreditLimit
        {
            get { return _CreditLimit; }
            set
            {
                if (value > 50000)
                {
                    throw new InvalidCreditLimitException("Credit Limit cannot exceed 50000");
                }
                _CreditLimit = value;
            }
        }
    }
}
