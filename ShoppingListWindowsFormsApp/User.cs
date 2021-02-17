using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingListWindowsFormsApp
{
    public class User
    {
        public string Name;
        public List<Product> ListProducts;
        public User(string name)
        {
            Name = name;
            ListProducts = new List<Product>();
        }
    }
}
