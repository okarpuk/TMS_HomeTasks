using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_11_Delegates.Task_02
{
    public interface ISubscribe
    {
        void SubscriberAdding(ISubscriber s);
        void SubscriberDeleting(ISubscriber s);
        void InformSubscribers();
    }
}
