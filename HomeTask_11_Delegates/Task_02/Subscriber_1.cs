using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_11_Delegates.Task_02
{
    public class Subscriber_1 : ISubscriber
    {
        ISubscribe tracking;

        public Subscriber_1(ISubscribe sub)
        {
            tracking = sub;
            tracking.SubscriberAdding(this);
        }

        public void Refresh(int price) => Console.WriteLine($"SUBSCRIBER #1 NOTIFIED THAT PRICE IS LOWER THAN 20000 AND IS {price}");

        public void Notify() => tracking.SubscriberAdding(this);
    }
}
