using System;
using System.Collections.Generic;

namespace FlyInn.Checkout.Shared
{
    public class OutOfHouseOrder : Order
    {
        public string Name => this.DeliveryAddress.Name;

        public Address DeliveryAddress { get; set; }

        public string DeliveryNote { get; set; }

        public DateTime ShipTime { get; set; }

        public OutOfHouseOrder(List<MenuItem> orderItems, Address deliveryAddress, string deliveryNote)
        {
            this.OrderItems = orderItems;
            this.DeliveryAddress = deliveryAddress;
            this.DeliveryNote = deliveryNote;
            this.OrderTime = DateTime.Now;
        }
    }
}
