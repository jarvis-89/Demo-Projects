namespace Bridge.Categories
{
    using System;
    using System.Linq;

    public class Pantry : Category, IItemListProvider
    {
        public Pantry() {}
        public Pantry(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public string Notes { get; set; }

        public override void Load(int id)
        {
            var category = SampleData.DataHelper.GetCategories<Pantry>().Where(x=>x.Id == id).FirstOrDefault();
            if (category != null)
            {
            this.Id = category.Id;
            this.Name = category.Name;
            }
            else
                throw new NullReferenceException($"No category found for specified Id : {id}");
        }
    }
}