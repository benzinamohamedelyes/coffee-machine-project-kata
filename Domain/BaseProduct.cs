using System;
using System.Collections.Generic;
using System.Text;

namespace coffee_machine_project_kata.Domain
{
    abstract class BaseProduct
    {
        private ProductType _product;
        private double _price;
        public  ProductType GetProduct()
        {
            return _product;
        }
        public double GetPrice()
        {
            return _price;
        }
        public BaseProduct(ProductType product, double price)
        {
            _product = product;
            _price = price;
        }
    }
}
