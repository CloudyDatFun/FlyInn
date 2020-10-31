using System.Collections.Generic;

namespace FlyInn.Checkout.Shared
{
    public class Ingredient
    {
        public string Name { get; set; }
        
        public double Price { get; set; }

        public Ingredient(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}