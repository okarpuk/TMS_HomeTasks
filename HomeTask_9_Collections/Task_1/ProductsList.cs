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
                new Chocolate("Toblerone",20, new DateTime(2013, 8, 19), new DateTime(2021, 8, 20)),
                new Chocolate("Kommunarka",30, new DateTime(2017, 9, 19), new DateTime(2023, 9, 20)),
                new Tea("Greengield",40, new DateTime(2016, 7, 20), new DateTime(2022, 7, 21)),
                new Tea("Lipton",50, new DateTime(2014, 8, 20), new DateTime(2021, 8, 21)),
                new Tea("Tess",60, new DateTime(2018, 9, 20), new DateTime(2023, 9, 21)),
            };

            Console.WriteLine("\nLIST OF PRODUCTS:");
            foreach (var unit in productsList)
            {
                unit.ProductInfo();
            }


            Console.WriteLine($"\nATTENTION!!!\nThese products have expired:");
            var productExpired = from unit in productsList where unit.BestBeforeDate < DateTime.Now select unit;
            foreach (var unit in productExpired)
            {
                unit.ProductInfo();
            }


            Shipment batch = new Shipment("batch #1", productsList.First(), 100, 10);
            Console.WriteLine();
            batch.ProductInfo();


            ProductSet set = new ProductSet("set #1", 50, productsList.GetRange(2, 2));
            Console.WriteLine();
            set.ProductInfo();


            productsList[2].Cost += 100;

            productsList.Remove(productsList.Last());

            foreach (var item in productsList)
            {
                item.ProductInfo();
            }

            productsList.Clear();

        }



        //
        static public void Task_1_2()
        {
            Console.WriteLine($"Product list:");

            List<Product> productBase = new List<Product>()
            {
                new Coffee("Dallmayr",100, new DateTime(2015, 7, 19), new DateTime(2022, 7, 20)),
                new Coffee("Lavazza",200, new DateTime(2013, 8, 19), new DateTime(2021, 8, 20)),
                new Coffee("Jacobs",300, new DateTime(2017, 9, 19), new DateTime(2023, 9, 20)),
                new Soda("CocaCola",400, new DateTime(2016, 7, 20), new DateTime(2022, 7, 21)),
                new Soda("Pepsi",500, new DateTime(2014, 8, 20), new DateTime(2021, 8, 21)),
                new Soda("Fanta",600, new DateTime(2018, 9, 20), new DateTime(2023, 9, 21)),
            };

            foreach (var item in productBase)
            {
                item.ProductInfo();
            }

            var newCollection = from product in productBase where product.Cost > 300 select product;

            var minValue = (from product in newCollection select product.Cost).Min();

            Console.WriteLine($"Min value: {minValue}");


        }


        //
        static public void Task_1_3()
        {
            var people = new Dictionary<string, int>()
            {
                { "snickers",5},
                { "mars",6},
                { "dove",3},
                { "bounty",8},
                { "twix",1},
                { "picnic",9}
            };
            ShowNameAndCounts(people);
            ShowName(people);
            ShowCounts(people);

            var list = DictionaryToList(people);
            ListToDictiobary(list);

        }


        static void ShowNameAndCounts(Dictionary<string, int> people)
        {
            foreach (var person in people)
            {
                Console.WriteLine($"Name: {person.Key}  Value: {person.Value}");
            }
        }

        private static void ShowName(Dictionary<string, int> people)
        {
            List<string> keys = people.Keys.ToList();
            foreach (var key in keys)
            {
                Console.WriteLine($"Name: {key}");
            }
        }

        private static void ShowCounts(Dictionary<string, int> people)
        {
            List<int> values = people.Values.ToList();
            foreach (var value in values)
            {
                Console.WriteLine($"Count: {value}");
            }
        }

        private static List<KeyValuePair<string, int>> DictionaryToList(Dictionary<string, int> people)
        {
            List<KeyValuePair<string, int>> persons = people.ToList();
            return persons;
        }

        private static void ListToDictiobary(List<KeyValuePair<string, int>> persons)
        {
            Dictionary<string, int> people = new Dictionary<string, int>(persons);
        }














    }
}
