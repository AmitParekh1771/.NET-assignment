using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Lab2_Q2
{
    internal class ProductManager
    {
        private ArrayList productList = new ArrayList();

        public void AddProduct()
        {
            Console.WriteLine("Enter Product Number: ");
            int productNo = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Product Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Rate: ");
            decimal rate = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter Stock: ");
            int stock = int.Parse(Console.ReadLine());

            productList.Add(new Product { ProductNo = productNo, Name = name, Rate = rate, Stock = stock });
            Console.WriteLine("Product added successfully!");
            //SortProducts();
        }

        public void SearchProduct()
        {
            Console.WriteLine("Enter Product Number to search: ");
            int productNo = int.Parse(Console.ReadLine());

            bool found = false;
            foreach (Product product in productList)
            {
                if (product.ProductNo == productNo)
                {
                    Console.WriteLine($"Product No: {product.ProductNo}");
                    Console.WriteLine($"Product Name: {product.Name}");
                    Console.WriteLine($"Rate: {product.Rate}");
                    Console.WriteLine($"Stock: {product.Stock}");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Product not found!");
            }
        }

        public void DeleteProduct()
        {
            Console.WriteLine("Enter Product Number to delete: ");
            int productNo = int.Parse(Console.ReadLine());

            int indexToDelete = -1;
            for (int i = 0; i < productList.Count; i++)
            {
                Product product = (Product)productList[i];
                if (product.ProductNo == productNo)
                {
                    indexToDelete = i;
                    break;
                }
            }

            if (indexToDelete != -1)
            {
                productList.RemoveAt(indexToDelete);
                Console.WriteLine("Product deleted successfully!");
            }
            else
            {
                Console.WriteLine("Product not found!");
            }
        }

        //private void SortProducts()
        //{
        //    productList.Sort((p1, p2) => ((Product)p1).ProductNo.CompareTo(((Product)p2).ProductNo));
        //}

        public void Run()
        {
            int choice;

            do
            {
                Console.WriteLine("\nProduct Management Menu");
                Console.WriteLine("1. Add New Product");
                Console.WriteLine("2. Search Product");
                Console.WriteLine("3. Delete Currently Searched Product");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddProduct();
                        break;
                    case 2:
                        SearchProduct();
                        break;
                    case 3:
                        DeleteProduct();
                        break;
                    case 4:
                        Console.WriteLine("Exiting Product Management application...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            } while (choice != 4);
        }
    }
}
