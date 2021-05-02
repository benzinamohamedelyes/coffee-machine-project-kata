using System;
using System.Collections.Generic;
using System.Text;

namespace coffee_machine_project_kata.Domain
{
    abstract class BaseProduct
    {
        private ProductType Product { get; }
        private double Price { get; }
    }
}
