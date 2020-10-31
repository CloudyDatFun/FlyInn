using System;
using System.Collections.Generic;
using System.Linq;

namespace FlyInn.Checkout.Shared
{
    public abstract class Order
    {
        public List<MenuItem> OrderItems { get; set; }

        public double OrderTotal
        {
            get
            {
                double total = 0;
                foreach (var item in OrderItems)
                {
                    total += item.Price;
                    total += item.AdditionalIngredients.Sum(additional => additional.Price);
                }

                return total;
            }
        }

        public double OrderTotalWithTip { get; set; }

        public double Tip => this.OrderTotalWithTip - OrderTotal;

        public DateTime OrderTime { get; set; }

        public DateTime PayTime { get; set; }
    }
}
