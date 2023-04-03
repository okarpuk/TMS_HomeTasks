using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_11_Delegates.Task_01
{
    public class ShowPrice
    {
        public static void Task01_Monitoring()
        {
            Monitoring monitoring = new Monitoring(MonitoringDisplay);
            Monitoring.PriceDisplay();
        }

        public static void MonitoringDisplay(int result)
        {
            Console.WriteLine($"\nAVERAGE PRICE IS: {result}");
        }
    }
}
