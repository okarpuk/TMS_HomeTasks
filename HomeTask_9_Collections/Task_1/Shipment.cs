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
        public Product Brand { get; set; }
        public int ShipmentCost { get; set; }
        public int Quantity { get; set; }

        public Shipment(string shipmentname, Product brand, int shipmentcost, int quantity)
        {
            ShipmentName = shipmentname;
            Brand = brand;
            ShipmentCost = shipmentcost;
            Quantity = quantity;
        }

        public Shipment()
        {
        }

        public override void ProductInfo()
        {
            Console.WriteLine($"SHIPMENT INFO:\nShipment Name = {ShipmentName}, Shipment Cost = {ShipmentCost}, Quantity = {Quantity}. \nSHIPMENT PRODUCTS DETAILS:");
            base.ProductInfo();
        }
    }
}
