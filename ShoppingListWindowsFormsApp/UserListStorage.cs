using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ShoppingListWindowsFormsApp
{
    class UserListStorage
    {
        public static string Path = "UserLists.json";

        public static void Save(User user)
        {            
            var jsonData = JsonConvert.SerializeObject(user, Formatting.Indented);
            FileProvider.Replase(Path, jsonData);
        }

        public static User GetAll()
        {
            if (!File.Exists(Path))
            {
                throw new Exception("Пользователь еще не добавлен");
            }
            var fileData = FileProvider.Get(Path);
            var userLists = JsonConvert.DeserializeObject<User>(fileData);
            return userLists;
        }
    }
}
