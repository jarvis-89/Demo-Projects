namespace Bridge.Categories
{
    using System;
    using System.Linq;
    
    public class PersonalCare : Category
    {
        public PersonalCare() {}
        public PersonalCare(int id, string name) : base(id,name) {}

        public bool CanGiveSample { get; set; }

        public override void Load(int id)
        {
            var category = SampleData.DataHelper.GetCategories<PersonalCare>().Where(x=>x.Id == id).FirstOrDefault();
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