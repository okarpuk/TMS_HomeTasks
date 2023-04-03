using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_11_Delegates.Task_02
{
    class Subscriber_2 : ISubscriber
    {
        ISubscribe tracking;

        public Subscriber_2(ISubscribe sub)
        {
            tracking = sub;
            tracking.SubscriberAdding(this);
        }

        public void Refresh(int price)
        {
            Console.WriteLine($"SUBSCRIBER #2 NOTIFIED THAT AVERAGE PRICE IS LOWER THAN 20000 AND IS {price}");
        }

        public void Notify()
        {
            tracking.SubscriberAdding(this);
        }

        public void NoNotify()
        {
            tracking.SubscriberDeleting(this);
            tracking = null;
            Console.WriteLine($"ATTENTION! SUBSCRIBER #2 UNNOTIFIED!\n");
        }
    }
}
