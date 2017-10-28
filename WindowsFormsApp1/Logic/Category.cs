using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class Category
    {
        public string CateName { get; set; }

        public Category()
        {
            this.CateName = CateName;
        }

        public string getCateName()
        {
            return CateName;
        }

        List<Category> Cates { get; set; } = new List<Category>();

        public List<Category> CateLista()
        {
            Cates.Add(new Category() { CateName="Favoriter"});
            Cates.Add(new Category() { CateName = "Hälsa" });
            return Cates;
        }

        public void RemoveCateFromList(Category cate)
        {
            Cates.Remove(cate);
        }
    }
}
