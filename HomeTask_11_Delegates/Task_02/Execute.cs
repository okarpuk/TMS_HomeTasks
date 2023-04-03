using HomeTask_11_Delegates.Task_01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_11_Delegates.Task_02
{
    public class Execute
    {
        public static void Task02_MonitoringSubscriber()
        {
            Monitoring tracking = new Monitoring();
            Subscriber_1 subscriber1 = new Subscriber_1(tracking);
            Subscriber_2 subscriber2 = new Subscriber_2(tracking);
            tracking.PriceToGet();
            tracking.PriceToGet();
            subscriber2.NoNotify();
            tracking.PriceToGet();
            tracking.PriceToGet();
        }
    }
}
