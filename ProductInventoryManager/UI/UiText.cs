using InventoryDomain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UI
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

        public static string[] ProductInfo(Product product)
        {
            string[] productInfo =
            {
                "---Product Info---",
                $"ID: {product.Id}",
                $"Name: {product.Name}",
                $"Price(kr): {Math.Round(product.Price, MidpointRounding.AwayFromZero)}",
                $"Quantity in stock: {product.Quantity}",
                "---------------------"
            };

            return productInfo;
        }
    }
}
