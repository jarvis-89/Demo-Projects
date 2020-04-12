namespace Bridge
{
    using Bridge.Model;
    using Bridge.SampleData;
    using System.Collections.Generic;
    using System.Linq;
    using Bridge.Categories;

    public interface IItemListProvider
    {
         IEnumerable<Item> GetItems(int categoryId)
         {
             return DataHelper.GetItems().Where(x=>x.CategoryId == categoryId);
         }
         IEnumerable<Item> GetItems(Category category)
         {
             return DataHelper.GetItems().Where(x=>x.CategoryId == category.Id);
         }
    }
}