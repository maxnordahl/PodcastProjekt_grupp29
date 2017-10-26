using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class Category
    {
        public string CateName { get; set; }
        public List<Category> Cates { get; set; }

        public Category()
        {
            this.CateName = CateName;
        }

        public string getCateName()
        {
            return CateName;
        }

        public List<Category> CateLista()
        {
            var Cates = new List<Category>();
            Cates.Add(new Category() { CateName="Favoriter"});
            Cates.Add(new Category() { CateName = "Hälsa" });
            return Cates;
  
        }
    }
}
