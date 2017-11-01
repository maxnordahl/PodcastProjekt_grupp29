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
using System.Xml.Serialization;

namespace Logic
{
    [Serializable]
    public class Category
    {
        [XmlElement("Genre")]
        public string CateName { get; set; }

        public Category(string CateName)
        {
            this.CateName = CateName;
        }

        public string getCateName()
        {
            return CateName;
        }

    }
}
