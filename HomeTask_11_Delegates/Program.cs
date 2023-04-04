using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeTask_11_Delegates.Task_01;
using HomeTask_11_Delegates.Task_02;

namespace HomeTask_11_Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***TASK 1 - AVERAGE PRICE MONITORING***\n");
            ShowPrice.Task01_Monitoring();
            Console.WriteLine("\n***TASK 2 - SUBSCRIBER***\n");
            Execute.Task02_MonitoringSubscriber();
        }
    }
}