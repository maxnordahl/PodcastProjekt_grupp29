using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    class Category
    {
        public string CateName { get; set; }

        private Category()
        {
            this.CateName = CateName;
        }

        public string getCateName()
        {
            return CateName;
        }
    }
}
