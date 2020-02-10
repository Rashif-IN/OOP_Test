using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace OOP_Test
{
    public interface IItems
    {
        int Item_id { get; set; }
        int Price { get; set; }
        int Quantity { get; set; }
    }

    public class Cart : IItems
    {
        
        public int Item_id { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        static List<IItems> itemCart = new List<IItems>();

        public Cart AddItem(int id, int price, int qty = 1)
        {
            Log_.PopulateLog($"item with ID:{id} with price:{price} has been added {qty}");
            var obj = new Cart();
            obj.Item_id = id;
            obj.Price = price;
            obj.Quantity = qty;
            itemCart.Add(obj);
            return this;
        }

        public Cart RemoveItem(int id)
        {
            Log_.PopulateLog($"item with ID:{id} has been removed");
            var obj = itemCart;
            var newObj = new List<IItems>();
            foreach (var x in obj)
            {
                if (x.Item_id != id)
                {
                    newObj.Add(x);
                }
            }
            itemCart = newObj;
            return this;
        }

        public Cart AddDiscount(int disc)
        {
            Log_.PopulateLog($"{disc} % discount has been added to this cart");
            var obj = itemCart;
            foreach (var x in obj)
            {
                x.Price = x.Price * disc / 100;
            }
            itemCart = obj;
            return this;
        }

        public static void TotalItems()
        {
            Log_.PopulateLog($"Total Item requested : {itemCart.Count()} item(s)");
            Console.WriteLine(itemCart.Count());
        }

        public static void TotalQuantity()
        {
            int totalQty = 0;
            foreach (var x in itemCart)
            {
                totalQty += x.Quantity;
            }
            Log_.PopulateLog($"Total quantity requested : {totalQty} quantity");
            Console.WriteLine(totalQty);
        }

        public static void TotalPrice()
        {
            int totalPrice = 0;
            foreach (var x in itemCart)
            {
                totalPrice += x.Price * x.Quantity;
            }
            Log_.PopulateLog($"Total price requested : {totalPrice}");
            Console.WriteLine(totalPrice);
        }

        public static void ShowAllItems()
        {
            var allItems = new List<string>();
            foreach (var x in itemCart)
            {
                allItems.Add(x.Item_id.ToString());
            }
            allItems.Distinct();
            Log_.PopulateLog($"All items added : {String.Join(", ",allItems)}");
            Console.WriteLine(String.Join(", ", allItems));
        }

        public static void Checkout()
        {
            List<string> lines = new List<string>();

            lines.Add("Item_id,Price,Qty");

            foreach (var x in itemCart)
            {
                lines.Add($"{x.Item_id},{x.Price},{x.Quantity}");
            }
            Log_.PopulateLog("purchase has been made");
            File.WriteAllLines(@"/Users/user/Projects/OOP_Test/OOP_Test/Checkout.txt", lines);
        }
    }

}
