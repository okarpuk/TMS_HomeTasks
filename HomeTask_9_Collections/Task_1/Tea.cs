using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_9_Collections.Task_1
{
    public class Tea : Product
    {
        public Tea(string brand, int cost, DateTime dateOfManufacture, DateTime bestBeforeDate) : base(brand, cost, dateOfManufacture, bestBeforeDate)
        {
        }

        public virtual void ProductInfo()
        {
            Console.WriteLine($"Information about product: {base.ProductInfo}");
        }

    }
}
