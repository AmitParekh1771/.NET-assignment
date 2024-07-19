using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignments.Lab1_Q2
{
    internal class ProductMock
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }

        public ProductMock(int productID, string productName, decimal price)
        {
            if (productID <= 0)
            {
                throw new DataEntryException("Product ID must be greater than zero");
            }

            if (string.IsNullOrEmpty(productName))
            {
                throw new DataEntryException("Product Name cannot be left blank");
            }

            if (price <= 0)
            {
                throw new DataEntryException("Price of product must be greater than zero");
            }

            if (!Regex.IsMatch(productName, @"^[a-zA-Z0-9]+$"))
            {
                throw new DataEntryException("Product Name should have alphabets and numbers only");
            }

            ProductID = productID;
            ProductName = productName;
            Price = price;
        }
    }
}
