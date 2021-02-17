using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ShoppingListWindowsFormsApp
{
    class ProductStorage
    {
        public static string Path = "products.json";

        public static void Append(Product products)
        {
            var allProducts = GetAll();
            allProducts.Add(products);
            Save(allProducts);
        }

        public static List<Product> GetAll()
        {
            if (!File.Exists(Path))
            {
                var products = new List<Product>
                {
                    new Product("Молоко 1л", 60, TypeProduct.FoodProduct),
                    new Product("Хлеб", 28, TypeProduct.FoodProduct),
                    new Product("Туалетная бумага", 140, TypeProduct.NonFoodProduct),
                    new Product("Зубная паста", 100, TypeProduct.NonFoodProduct),
                    new Product("Лоротодин", 60, TypeProduct.MedicalProduct),
                    new Product("Бинт", 60, TypeProduct.MedicalProduct)
                };
                Save(products);
                return products;
            }
            var fileData = FileProvider.Get(Path);
            var allProducts = JsonConvert.DeserializeObject<List<Product>>(fileData);
            return allProducts;
        }
        static void Save(List<Product> products)
        {
            var jsonData = JsonConvert.SerializeObject(products, Formatting.Indented);
            FileProvider.Replase(Path, jsonData);
        }
    }
}
