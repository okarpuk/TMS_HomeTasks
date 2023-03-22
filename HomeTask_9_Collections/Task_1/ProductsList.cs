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
            List<Product> productBase = new List<Product>()
            {
                    new Fruit("apple",10, new DateTime(2015, 7, 19), new DateTime(2022, 7, 20)),
                    new Fruit("lemon",20, new DateTime(2013, 8, 19), new DateTime(2021, 8, 20)),
                    new Fruit("pear",30, new DateTime(2017, 9, 19), new DateTime(2023, 9, 20)),
                    new Vegetable("tomato",40, new DateTime(2016, 7, 20), new DateTime(2022, 7, 21)),
                    new Vegetable("cucumber",50, new DateTime(2014, 8, 20), new DateTime(2021, 8, 21)),
                    new Vegetable("pepper",60, new DateTime(2018, 9, 20), new DateTime(2023, 9, 21)),
            };

            foreach (var item in productBase)
            {
                item.ProductInfo();
            }


            Console.WriteLine($"\nThese products are expired:");
            var expiredItems = from item in productBase where item.BestBeforeDate < DateTime.Now select item;
            foreach (var item in expiredItems)
            {
                item.ProductInfo();
            }


            Сonsignment batch = new Сonsignment("batch #1", productBase.First(), 100, 10);
            Console.WriteLine();
            batch.ShowInfo();


            ProductKit kit = new ProductKit("kit #1", 50, productBase.GetRange(2, 2));
            Console.WriteLine();
            kit.ShowInfo();


            productBase[2].Cost += 100;

            productBase.Remove(productBase.Last());

            foreach (var item in productBase)
            {
                item.ProductInfo();
            }

            productBase.Clear();

        }



        //
        static public void Task_1_2()
        {
            Console.WriteLine($"Product list:");

            List<Product> productBase = new List<Product>()
            {
                new Fruit("snickers",100, new DateTime(2015, 7, 19), new DateTime(2022, 7, 20)),
                new Fruit("mars",200, new DateTime(2013, 8, 19), new DateTime(2021, 8, 20)),
                new Fruit("dove",300, new DateTime(2017, 9, 19), new DateTime(2023, 9, 20)),
                new Vegetable("bounty",400, new DateTime(2016, 7, 20), new DateTime(2022, 7, 21)),
                new Vegetable("twix",500, new DateTime(2014, 8, 20), new DateTime(2021, 8, 21)),
                new Vegetable("picnic",600, new DateTime(2018, 9, 20), new DateTime(2023, 9, 21)),
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
