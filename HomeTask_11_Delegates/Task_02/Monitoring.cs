using HomeTask_11_Delegates.Task_01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_11_Delegates.Task_02
{
    public class Monitoring : ISubscribe
    {
        private int calculatedPrice;
        private int generatedPricesQTY = 5;
        private List<ISubscriber> subscribers;

        public Monitoring()
        {
            subscribers = new List<ISubscriber>();
        }

        public void PriceToGet()
        {
            calculatedPrice = (int)new RandomPrice().CreatePrice(generatedPricesQTY).Average();
            if (calculatedPrice < 20000)
            {
                Console.WriteLine("ATTENTION! AVERAGE PRICE IS LOWER THAN 20000!");
                InformSubscribers();
            }
            else
            {
                Console.WriteLine("AVERAGE PRICE IS HIGHER THAN 20000");
            }
            Console.WriteLine();
        }

        public void SubscriberAdding(ISubscriber subscriber)
        {
            subscribers.Add(subscriber);
        }

        public void SubscriberDeleting(ISubscriber subscriber)
        {
            subscribers.Remove(subscriber);
        }

        public void InformSubscribers()
        {
            foreach (ISubscriber subscriber in subscribers)
                subscriber.Refresh(calculatedPrice);
        }
    }
}
