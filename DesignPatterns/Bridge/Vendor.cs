namespace Bridge
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Bridge.Categories;

    public class Vendor : IVendor
    {
        public Vendor(params Category[] categories)
        {
            this.Categories = new List<Category>();
            foreach (var category in categories)
             this.Categories.Add(category);
        }
        public List<Category> Categories { get; set; }
        public string Name { get; set; }

        public void PrintItems(Category category)
        {
            if (category is IItemListProvider)
            {
                var ItemList = (category as IItemListProvider).GetItems(category);
                ItemList?.ToList().ForEach((item)=>{
                    Console.WriteLine($"{item.Id} --> {item.Name}");
                });
            }
            else
                Console.WriteLine("Can not print list of Item");
        }
    }
}