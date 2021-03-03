using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingListWindowsFormsApp
{
    public class User
    {
        public string Name;
        public List<string> ListProducts;
        public decimal PriceSelectedProducts = 0;
        //public string Name
        //{
        //    get
        //    {
        //        return name;
        //    }
        //    set
        //    {
        //        if (name.Length > 30 || name.Length == 0)
        //        {
        //            throw new Exception("Имя не должно быть пустым  и привышать 30 знаков.");
        //        }

        //        for (int i = 0; i < name.Length; i++)
        //        {
        //            if ((name[i] < 'А' && name[i] != 'Ё') || name[i] > 'Я')
        //            {
        //                throw new Exception("Имя должно состоять только из букв русского алфавита!");                        
        //            }
        //        }
        //        Name = value;
        //    }
        //}
        public User(string name)
        {
            Name = name;
            ListProducts = new List<string>();
        }
    }
}
