namespace Bridge
{
    using System.Collections.Generic;
    using Bridge.Categories;

    public interface IVendor
    {
         List<Category> Categories {get;set;}
         string Name {get;set;}
         void PrintItems(Category category);
    }
}