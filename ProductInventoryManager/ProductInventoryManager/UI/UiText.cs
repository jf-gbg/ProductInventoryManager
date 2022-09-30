using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventoryManager.UI
{
    public class UiText
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
        
        public static string[] ProductCreation()
        {
            string[] productCreationText =
            {
                "Product name: ",
                "Product price: ",
                "Quantity in stock: ",
            };

            return productCreationText;
        }

        public static string[] EditProduct()
        {
            string[] editProductText =
            {
                "New Name: ",
                "New Price: ",
            };

            return editProductText;
        }
    }
}
