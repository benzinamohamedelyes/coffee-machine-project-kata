using System;
using System.Collections.Generic;
using System.Text;

namespace coffee_machine_project_kata.Domain
{
    public class Product: BaseProduct
    {
        public static readonly Product COFFEE = new Product(ProductType.Coffee, 1);
        public static readonly Product SUGAR = new Product(ProductType.Sugar, 0.1);
        public static readonly Product CREAM = new Product(ProductType.Cream, 0.5);
        public static readonly Product TEA = new Product(ProductType.Tea, 2);
        public static readonly Product WATER = new Product(ProductType.Water, 0.2);
        public static readonly Product CHOCOLAT = new Product(ProductType.Chocolat, 1);
        public static readonly Product MILK = new Product(ProductType.Milk, 0.4);
        public Product(ProductType product, double price):base(product, price)
        {
        }
    }
}
