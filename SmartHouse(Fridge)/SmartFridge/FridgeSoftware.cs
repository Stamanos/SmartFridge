using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFridge
{
    class FridgeSoftware
    {
        public class Note
        {
            public static string SMS(string text)
            {
                string message = "Your message is " + text;
                return message;
            }
            public static Dictionary<string, string> noteFile = new Dictionary<string, string>();

            public static void Create(string noteText, string creationDate)
            {
                noteFile.Add(creationDate, noteText);
            }

            public static void Erase(string creationDate)
            {
                noteFile.Remove(creationDate);
            }
        }
        public static int GetRowIndex(int h, int[] heights, Point point) //find the row of cell position by finding the pointer position
        {
            int i;
            for (i = heights.Length - 1; i >= 0 && point.Y < h; i--)
            {
                h -= heights[i];
            }
            return i + 1;
        }

        public class Shop
        {
            public static Dictionary<string, int> existingProducts = new Dictionary<string, int>();
            public static Dictionary<string, int> products = new Dictionary<string, int>();

            public static void startingProducts()
            {
                try
                {
                    existingProducts.Add("Coca Cola", 4);
                    existingProducts.Add("Κοτόπουλο", 2);
                    existingProducts.Add("Μοσχαράκι", 4);
                    existingProducts.Add("Κρεμμύδι", 3);
                    existingProducts.Add("Μήλο", 3);
                    existingProducts.Add("Μπανάνα", 2);
                    existingProducts.Add("Γάλα άσπρο", 3);
                    existingProducts.Add("Γραβιέρα", 1);
                    existingProducts.Add("Σπαγγέτι", 2);
                    existingProducts.Add("Ζαμπόν", 3);
                    existingProducts.Add("Αυγά", 6);
                    existingProducts.Add("Κέτσαπ", 1);
                }
                catch(ArgumentException exep)
                {

                }
            }
            /// <summary>
            /// This method store the products and the quantity of each product in a dictionary and returns the sum quantity of a product 
            /// </summary>
            /// <param name="product"></param>
            /// <param name="quantity"></param>
            /// <returns></returns>
            public static void Add(string product, int quantity)
            {
                if (products.ContainsKey(product))
                {
                    products[product] += quantity;
                }
                else
                {
                    products.Add(product, quantity);
                }
            }
            public static void Erase(string product)
            {
                products.Remove(product);
            }
        }

        public class Inside
        {
            /// <summary>
            /// The method Combine puts all the products together.
            /// </summary>
            public static void Combine()
            {
                foreach(var key in Shop.products.Keys)
                {
                    if (Shop.existingProducts.ContainsKey(key))
                    {
                        Shop.existingProducts[key] = Shop.existingProducts[key] + Shop.products[key];
                    }
                    else
                    {
                        Shop.existingProducts.Add(key, Shop.products[key]);
                    }
                }
            }
        }
        
        public class Settings
        {
            public static string fridgeDate = DateTime.Now.ToLongDateString() + System.Environment.NewLine +
                DateTime.Now.ToString("hh:mm:ss");
            public static string fridgeTemprature = "4 C";
            /// <summary>
            /// Set the date of the fridge
            /// </summary>
            /// <param name="date"></param>
            public static void SetDate(DateTime date)
            {
                fridgeDate = date.ToLongDateString() + System.Environment.NewLine +
                DateTime.Now.ToString("hh:mm:ss");
            }
            /// <summary>
            ///  Set the temrature of the fridge
            /// </summary>
            /// <param name="value"></param>
            public static void SetTemprature(int value)
            {
                fridgeTemprature = value.ToString() + " C";
            }
        }
        
        public class Help
        {
            public static string path;
            /// <summary>
            /// In this method you give the number of the form, and returns the path each PDF file
            /// </summary>
            /// <param name="form"></param>
            /// <returns></returns>
            public static void Show(int form)
            {
                if (form == 0) //help for the note function
                {
                    path = "https://www.dropbox.com/sh/7a39kwas1fe50it/AAD6UqsnFVr5io0pYl8IU_Y4a?dl=0";
                    //https://www.dropbox.com/s/qswrpq5hugg2h68/Notes.pdf?dl=0
                }
                else if(form == 1) //help for the shopping function
                {
                    path = "https://www.dropbox.com/s/lzz4710x0ywdpb5/Shopping.pdf?dl=0";
                }
                else if (form == 2) //help for the InsideTheFridge function
                {
                    path = "https://www.dropbox.com/s/o7jwgaw9wawe8jk/InsideTheFridge.pdf?dl=0";
                }
                else if (form == 3) //help for the recipes function
                {
                    path = "https://www.dropbox.com/s/9mivrymk3k51e5e/Recipes.pdf?dl=0";
                }
                else if (form == 4)  //help for the Settings
                {
                    path = "https://www.dropbox.com/s/3n16edlir9e1xld/Settings.pdf?dl=0";
                }
                else if (form == 5) //help for the tv
                {
                    path = "https://www.dropbox.com/s/048wm8yq606qy8k/tv.pdf?dl=0";
                }
            }
        }
    }
}
