using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace Logic
{
     public class PodcastSerializer
    {
        public void Serialize(object o)
        {
            string path = Environment.CurrentDirectory + "Podcast.xml";
            if (File.Exists(path))
            {
                using (FileStream file = File.Create(path))
                {
                    XmlSerializer createXML = new XmlSerializer(o.GetType());
                    createXML.Serialize(file, o);
                }
            }
            else
            {
                using (FileStream file = File.Create(path))
                {
                    XmlSerializer createXML = new XmlSerializer(o.GetType());
                    
                    createXML.Serialize(file, o);
                }
            }
        }
        public List<Podcast> Deserialize(string path)
        {
            XmlSerializer loadXML = new XmlSerializer(typeof(List<Podcast>));
            if(File.Exists(path))
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                var obj = loadXML.Deserialize(fs);
                var lista = (List<Podcast>)obj;
                return lista;
            }
            else
            {
                return null;

            }
            

           

        }
    }
    }

