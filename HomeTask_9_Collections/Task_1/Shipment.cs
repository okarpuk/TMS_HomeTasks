using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Xml.Linq;

namespace HomeTask_9_Collections.Task_1
{
    internal class Shipment : Product
    {
        public string ShipmentName { get; set; }
        public Product Product { get; set; }
        public int ShipmentCost { get; set; }
        public int Quantity { get; set; }
        
        public Shipment(string shipmentname, Product product, int shipmentcost, int quantity)
        {
            ShipmentName = shipmentname;
            Product = product;
            ShipmentCost = shipmentcost;
            Quantity = quantity;
        }
        
        public override void ProductInfo()
        {
            Console.WriteLine($"SHIPMENT INFO:\nShipment Name = {ShipmentName}, Shipment Cost = {ShipmentCost}, Quantity = {Quantity}. \n\nSHIPMENT PRODUCTS DETAILS:");
            Product.ProductInfo();
        }
    }
}
