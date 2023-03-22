using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_9_Collections.Task_1
{
    public class Product
    {
        public string Brand { get; set; }
        public int Cost { get; set; }
        public DateTime DateOfManufacture { get; set; }
        public DateTime BestBeforeDate { get; set; }

        public Product(string name, int price, DateTime dateOfManufacture, DateTime bestBeforeDate)
        {
            Brand = name;
            Cost = price;
            DateOfManufacture = dateOfManufacture;
            BestBeforeDate = bestBeforeDate;
        }

        public Product()
        {
        }

        public virtual void ProductInfo()
        {
            Console.WriteLine($"Brand = {Brand}, Cost = {Cost}, Date Of Manufacture = {DateOfManufacture.ToString("dd/MM/yyyy")}, Best before date = {BestBeforeDate.ToString("dd/MM/yyyy")}, Profuct Expired ={ProductExpired()}");
        }

        public bool ProductExpired()
        {
            return this.BestBeforeDate < DateTime.Today;
        }

    }
}
