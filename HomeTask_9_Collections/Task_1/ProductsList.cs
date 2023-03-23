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
                new Chocolate("Milka",10, new DateTime(2015, 7, 19), new DateTime(2022, 7, 20)),
                new Chocolate("Lindt",20, new DateTime(2013, 8, 19), new DateTime(2021, 8, 20)),
                new Chocolate("Kommunarka",30, new DateTime(2017, 9, 19), new DateTime(2023, 9, 20)),
                new Tea("Greengield",40, new DateTime(2016, 7, 20), new DateTime(2022, 7, 21)),
                new Tea("Lipton",50, new DateTime(2014, 8, 20), new DateTime(2021, 8, 21)),
                new Tea("Tess",60, new DateTime(2018, 9, 20), new DateTime(2023, 9, 21)),
            };
            //ALL List
            Console.WriteLine("\nLIST OF PRODUCTS 1:");
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
            Shipment lot = new Shipment("LOT 1", productsList.First(), 100, 10);
            Console.WriteLine();
            lot.ProductInfo();
            //SET
            ProductSet set = new ProductSet("SET 1", 50, productsList.GetRange(2, 2));
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
            Console.WriteLine($"\nLIST OF PRODUCTS 2:");
            List<Product> productList = new List<Product>()
            {
                new Coffee("Dallmayr",100, new DateTime(2015, 7, 19), new DateTime(2022, 7, 20)),
                new Coffee("Lavazza",200, new DateTime(2013, 8, 19), new DateTime(2021, 8, 20)),
                new Coffee("Jacobs",300, new DateTime(2017, 9, 19), new DateTime(2023, 9, 20)),
                new Soda("CocaCola",400, new DateTime(2016, 7, 20), new DateTime(2022, 7, 21)),
                new Soda("Pepsi",500, new DateTime(2014, 8, 20), new DateTime(2021, 8, 21)),
                new Soda("Fanta",600, new DateTime(2018, 9, 20), new DateTime(2023, 9, 21)),
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
                { "Milka", 5 },
                { "Lindt", 6 },
                { "Lipton", 3 },
                { "Lavazza", 8 },
                { "Pepsi", 1 },
                { "Fanta", 9 }
            };
            NameCountInfo(delights);
            NameInfo(delights);
            CountInfo(delights);
            var list = DictionaryToList(delights);
            ListToDictiobary(list);
        }
        static void NameCountInfo(Dictionary<string, int> delights)
        {
            Console.WriteLine("\nPAIR VALUE LIST:");
            foreach (var unit in delights)
            {
                Console.WriteLine($"NAME: {unit.Key} \tCOUNT: {unit.Value}");
            }
        }
        private static void NameInfo(Dictionary<string, int> delights)
        {
            List<string> keys = delights.Keys.ToList();
            Console.WriteLine();
            foreach (var key in keys)
            {
                Console.WriteLine($"NAME: {key}");
            }
        }
        private static void CountInfo(Dictionary<string, int> delights)
        {
            List<int> values = delights.Values.ToList();
            Console.WriteLine();
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
            Dictionary<string, int> people = new Dictionary<string, int>(delights);
        }
    }
}
