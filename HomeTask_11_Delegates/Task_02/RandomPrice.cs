using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_11_Delegates.Task_02
{
    internal class RandomPrice
    {
        public RandomPrice() { }

        public List<int> CreatePrice(int pricesQTY)
        {
            Console.WriteLine("FOUND PRICES:");
            List<int> Generator = new List<int>();
            Random random = new Random();
            for (int i = 0; i < pricesQTY; i++)
            {
                var myPrice = random.Next(10000, 30000);
                Console.WriteLine($"{myPrice};");
                Generator.Add(myPrice);
            }
            return Generator;
        }
    }
}
