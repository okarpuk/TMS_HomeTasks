using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_9_Collections.Task_1
{
    public class ProductsList
    {
        public static void Task_1_1()
        {
            List<Product> productsList = new List<Product>()
            {
                new Chocolate("Milka",11, new DateTime(2022, 6, 15), new DateTime(2024, 6, 14)),
                new Chocolate("Lindt",10, new DateTime(2020, 11, 20), new DateTime(2021, 11, 19)),
                new Chocolate("Kommunarka",5, new DateTime(2022, 12, 11), new DateTime(2024, 12, 10)),
                new Tea("Greengield",10, new DateTime(2019, 12, 31), new DateTime(2022, 12, 30)),
                new Tea("Lipton",12, new DateTime(2017, 1, 1), new DateTime(2020, 1, 1)),
                new Tea("Tess",8, new DateTime(2023, 1, 1), new DateTime(2026, 1, 1)),
            };
            //ALL List
            Console.WriteLine("\nLIST OF PRODUCTS #1:");
            foreach (var unit in productsList)
            {
                unit.ProductInfo();
            }
            //EXPIRED PRODUCTS
            Console.WriteLine($"\nATTENTION!!!\nThese products have expired:");
            var productExpired = from unit in productsList where unit.BestBeforeDate < DateTime.Now select unit;
            foreach (var unit in productExpired)
            {
                unit.ProductInfo();
            }
            //SHIPMENT
            Shipment lot = new Shipment("LOT 1", productsList.First(), 500, 32);
            Console.WriteLine();
            lot.ProductInfo();
            //SET
            ProductSet set = new ProductSet("SET 1", 20, productsList.GetRange(3, 3));
            Console.WriteLine();
            set.ProductInfo();
            //CHANGE PRICE
            productsList[3].Cost += 100;
            Console.WriteLine($"\nCHANGE PRICE:");
            foreach (var unit in productsList)
            {
                unit.ProductInfo();
            }
            //REMOVE LAST PRODUCT
            productsList.Remove(productsList.Last());
            Console.WriteLine($"\nDELETE LAST:");
            foreach (var unit in productsList)
            {
                unit.ProductInfo();
            }
            //CLEAR LIST
            productsList.Clear();
            Console.WriteLine($"\nCLEAR LIST:");
            foreach (var unit in productsList)
            {
                unit.ProductInfo();
            }
        }
        //TASK 1_2
        static public void Task_1_2()
        {
            Console.WriteLine($"\nLIST OF PRODUCTS #2:");
            List<Product> productList = new List<Product>()
            {
                new Coffee("Dallmayr",400, new DateTime(2020, 6, 11), new DateTime(2024, 1, 11)),
                new Coffee("Lavazza",100, new DateTime(2020, 4, 22), new DateTime(2023, 7, 5)),
                new Coffee("Jacobs",200, new DateTime(2021, 2, 23), new DateTime(2025, 12, 12)),
                new Soda("CocaCola",500, new DateTime(2019, 1, 12), new DateTime(2024, 4, 4)),
                new Soda("Pepsi",800, new DateTime(2020, 12, 12), new DateTime(2022, 12, 11)),
                new Soda("Fanta",900, new DateTime(2021, 3, 2), new DateTime(2023, 3, 3)),
            };
            foreach (var unit in productList)
            {
                unit.ProductInfo();
            }
            var newList = from item in productList where item.Cost > 300 select item;
            var minCost = (from item in newList select item.Cost).Min();
            Console.WriteLine($"\nMINIMUM COST: {minCost}");
        }
        //TASK 1_3
        static public void Task_1_3()
        {
            var delights = new Dictionary<string, int>()
            {
                { "Milka", 23 },
                { "Lindt", 61 },
                { "Lipton", 32 },
                { "Lavazza", 48 },
                { "Pepsi", 101 },
                { "Fanta", 95 }
            };
            NameCountInfo(delights);
            NameInfo(delights);
            CountInfo(delights);
            var list = DictionaryToList(delights);
            ListToDictiobary(list);
        }
        static void NameCountInfo(Dictionary<string, int> delights)
        {
            Console.WriteLine("\nNAME AND COUNT LIST:");
            foreach (var unit in delights)
            {
                Console.WriteLine($"NAME: {unit.Key} \tCOUNT: {unit.Value}");
            }
        }
        private static void NameInfo(Dictionary<string, int> delights)
        {
            List<string> keys = delights.Keys.ToList();
            Console.WriteLine("\nNAMES LIST:");
            foreach (var key in keys)
            {
                Console.WriteLine($"NAME: {key}");
            }
        }
        private static void CountInfo(Dictionary<string, int> delights)
        {
            List<int> values = delights.Values.ToList();
            Console.WriteLine("\nCOUNTS LIST:");
            foreach (var value in values)
            {
                Console.WriteLine($"COUNT: {value}");
            }
        }
        private static List<KeyValuePair<string, int>> DictionaryToList(Dictionary<string, int> delights)
        {
            List<KeyValuePair<string, int>> units = delights.ToList();
            return units;
        }
        private static void ListToDictiobary(List<KeyValuePair<string, int>> delights)
        {
            Dictionary<string, int> myDict = new Dictionary<string, int>(delights);
        }
    }
}
