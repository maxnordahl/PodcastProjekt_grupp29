using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Logic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Logic
{
    public class Category
    {
        public string CateName { get; set; }

        public Category(string CateName)
        {
            this.CateName = CateName;
        }

        public string getCateName()
        {
            return CateName;
        }

        //List<Category> Cates { get; set; } = new List<Category>();

        //public List<Category> CateLista()
        //{
        //    Cates.Add(new Category() { CateName="Favoriter"});
        //    Cates.Add(new Category() { CateName = "Hälsa" });
        //    return Cates;
        //}
    }
}
