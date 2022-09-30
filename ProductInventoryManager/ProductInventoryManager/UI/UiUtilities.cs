using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventoryManager.UI
{
    internal class UiUtilities
    {
        public static void WriteToConsole(string[] textToOutput)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            foreach (var line in textToOutput)
                Console.WriteLine(line);

            Console.ForegroundColor = ConsoleColor.White;
        }

        public static string[] WriteAndReadConsole(string[] textToOutput)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string[] productDetails = new string[textToOutput.Length];

            var i = 0;
            foreach (var line in textToOutput)
            {
                Console.Write(line);
                productDetails[i] = Console.ReadLine();
                i++;
            }

            Console.ForegroundColor = ConsoleColor.White;
            return productDetails;
        }
    }
}
