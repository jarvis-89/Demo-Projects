namespace Bridge.Categories
{
    using System;
    using System.Linq;
    
    public abstract class Category
    {
        public Category() {}
        public Category(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        
        public int Id { get; set; }
        public string Name {get;set;}
        public abstract void Load(int id);
    }
}