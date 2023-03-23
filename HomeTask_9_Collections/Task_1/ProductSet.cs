using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_9_Collections.Task_1
{
    public class ProductSet : Product
    {
        public string ProductSetName { get; set; }
        public int ProductSetCost { get; set; }
        public List<Product> ProductsList { get; set; }

        public ProductSet(string productSetName, int productSetCost, List<Product> productsList)
        {
            ProductSetName = productSetName;
            ProductSetCost = productSetCost;
            ProductsList = productsList;
        }

        public override void ProductInfo()
        {
            Console.WriteLine($"PRODUCT SET DETAILS:\nProduct Set Name = {ProductSetName}, ProductSet Cost = {ProductSetCost}. \n\nSET CONTAINS:");
            foreach (var unit in ProductsList)
            {
                unit.ProductInfo();
            }
        }
    }
}
