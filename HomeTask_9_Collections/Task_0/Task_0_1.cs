using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_9_Collections.Task_0
{
    internal class Task_0_1
    {
        public static void arrayException()
        {
            try
            {
                ArrayList list = new ArrayList();
                object s = list[18];
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error! Exception: {ex.Message}");
            }
        }
    }
}
