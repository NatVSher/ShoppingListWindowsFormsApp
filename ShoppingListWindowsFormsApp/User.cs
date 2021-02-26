using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingListWindowsFormsApp
{
    public class User
    {
        public string Name;
        public List<string> ListProducts;
        public User(string name)
        {
            Name = name;
            ListProducts = new List<string>();
        }
    }
}
