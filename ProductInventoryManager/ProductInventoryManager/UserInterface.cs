using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventoryManager
{
    internal class UserInterfaceOutput
    {
        public static string[] MainMenu()
        {
            string[] mainMenuText =
                {
                    "***************************",
                    "*********MAIN MENU*********",
                    "***************************",
                    "1. Create new product",
                    "2. Edit product",
                    "3. Get product details",
                    "4. Get inventory details",
                    "0. Exit"
                };

            return mainMenuText;
        }


    }
}
