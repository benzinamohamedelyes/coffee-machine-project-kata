using System;
using System.Collections.Generic;
using System.Text;

namespace coffee_machine_project_kata.Domain
{
    public class Recipe
    {
        public static readonly Recipe EXPRESSO = new Recipe(new Product[] { Product.COFFEE, Product.WATER }, "Expresso");

        public static readonly Recipe LUNGO = new Recipe(new Product[] { Product.COFFEE, Product.WATER, Product.WATER }, "Allongé");

        public static readonly Recipe CAPUCCINO = new Recipe(new Product[] { Product.COFFEE, Product.CHOCOLAT, Product.WATER, Product.CREAM }, "Capuccino");

        public static readonly Recipe CHOCOLAT = new Recipe(new Product[] { Product.CHOCOLAT, Product.CHOCOLAT, Product.CHOCOLAT,
            Product.MILK, Product.MILK, Product.WATER, Product.SUGAR }, "Chocolat");

        public static readonly Recipe TEA = new Recipe(new Product[] { Product.TEA, Product.WATER, Product.WATER }, "The");

        Product[] _products;
        public string Name { get; }
        public Recipe(Product[] products, string name)
        {
            _products = products;
            Name = name;
        }
        public double GetPrice()
        {
            double price = 0;
            for (int i = 0; i < _products.Length; i++)
            {
                price += _products[i].GetPrice();
            }
            return price + (price * 0.3);
        }

    }
}
