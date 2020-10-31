using System.Collections.Generic;

namespace FlyInn.Checkout.Shared
{
    public class MenuItem
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public List<Ingredient> Ingredients { get; set; }

        public List<Ingredient> AdditionalIngredients { get; set; }

        public List<Ingredient> ExcludedIngredients { get; set; }

        public MenuItem(string name, double price, List<Ingredient> ingredients,
            List<Ingredient> additionalIngredients, List<Ingredient> excludedIngredients)
        {
            this.Name = name;
            this.Price = price;
            this.Ingredients = ingredients;
            this.AdditionalIngredients = additionalIngredients;
            this.ExcludedIngredients = excludedIngredients;
        }
    }
}
