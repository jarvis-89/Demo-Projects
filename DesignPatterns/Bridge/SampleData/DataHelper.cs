namespace Bridge.SampleData
{
    using System;
    using Bridge.Model;
    using System.Collections.Generic;
    using System.IO;
    using Newtonsoft.Json;
    using System.Linq;

    public static class DataHelper
    {
        private static string ItemsJsonPath => @"SampleData\Items.json";
        private static string CategoriesJsonPath => @"SampleData\Categories.json";
        public static IEnumerable<T> GetCategories<T>() 
        {
            if (File.Exists(CategoriesJsonPath))
            {
                var Categories = JsonConvert.DeserializeObject<IEnumerable<T>>(File.ReadAllText(CategoriesJsonPath)); // as IEnumerable<Category>;
                return Categories.Count() > 0 ? Categories : throw new NotFoundException("Category list json file is empty!");
            }
            else
                throw new FileNotFoundException("Category json file not exist");
        }

        public static IEnumerable<Item> GetItems()
         {
             if (File.Exists(ItemsJsonPath))
             {
                var Items = JsonConvert.DeserializeObject<IEnumerable<Item>>(File.ReadAllText(ItemsJsonPath));
                return Items.Count() > 0 ? Items : throw new NotFoundException("Item list json file is empty!");
             }
             else
                throw new FileNotFoundException("Item json file not exist");
        }
    }
}