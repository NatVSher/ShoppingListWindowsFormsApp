using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingListWindowsFormsApp
{
    public class Product
    {
        public string Name;
        public decimal Price;
        public TypeProduct Type;

        public Product(string name, decimal price, TypeProduct type)
        {
            Name = name;
            Price = price;
            Type = type;
        }

    }
}
