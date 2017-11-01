using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Logic
{
    public class CategorySeriealizer
    { 

        public void Serialize(object o)
        {
            string path = Environment.CurrentDirectory + "Category.xml";
            if (File.Exists(path))
            {
                using (FileStream file = File.Create(path))
                {
                    XmlSerializer createXML = new XmlSerializer(o.GetType());
                    createXML.Serialize(file, o);
                }
            }
            else {
                using (FileStream file = File.Create(path))
                {
                    XmlSerializer createXML = new XmlSerializer(o.GetType());
                    createXML.Serialize(file, o);
                }
            }
        }
        public List<Category> Deserialize(string path)
        {
            XmlSerializer loadXML = new XmlSerializer(typeof(List<Category>));
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            var obj = loadXML.Deserialize(fs);
            var lista = (List<Category>)obj;

            return lista;

        }
    }
}

