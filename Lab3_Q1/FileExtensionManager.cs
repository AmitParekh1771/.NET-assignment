using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Lab3_Q1
{
    internal class FileExtensionManager
    {
        private Dictionary<string, string> fileExtensions = new Dictionary<string, string>();

        public void Run()
        {
            // Add some elements (duplicate values allowed for file types)
            fileExtensions.Add(".txt", "Text File");
            fileExtensions.Add(".docx", "Microsoft Word Document");
            fileExtensions.Add(".pdf", "Portable Document Format");
            fileExtensions.Add(".jpg", "JPEG Image");
            fileExtensions.Add(".png", "Portable Network Graphic");
            fileExtensions.Add(".docx", "Microsoft Word Document"); // Duplicate value for ".docx"

            // Try adding a duplicate key (exception expected)
            try
            {
                fileExtensions.Add(".txt", "Another Text File"); // This will throw an exception
                Console.WriteLine("Duplicate key added successfully (unexpected behavior)"); // This won't be printed
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message); // Handle the exception for duplicate key
            }

            // Change the value for an existing key
            fileExtensions[".jpg"] = "JPEG Image File";
            Console.WriteLine("Updated value for '.jpg': {0}", fileExtensions[".jpg"]);

            // Add a new key-value pair using the indexer
            fileExtensions["gif"] = "Graphics Interchange Format";
            Console.WriteLine("New key-value pair added: '.gif' - {0}", fileExtensions["gif"]);

            // Try accessing a non-existent key (exception expected)
            try
            {
                string type = fileExtensions["unknown"];
                Console.WriteLine("File type for '.unknown': {0}", type); // This won't be printed
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine("Error: Key not found - '.unknown'"); // Handle the exception for missing key
            }

            // Print all key-value pairs using foreach loop
            Console.WriteLine("\nList of File Extensions and Types:");
            foreach (KeyValuePair<string, string> entry in fileExtensions)
            {
                Console.WriteLine($"Extension: {entry.Key}, Type: {entry.Value}");
            }

            // Remove a key-value pair
            if (fileExtensions.Remove(".pdf"))
            {
                Console.WriteLine("'.pdf' extension removed successfully.");
            }
            else
            {
                Console.WriteLine("'.pdf' extension not found for removal.");
            }
        }
    }
}
