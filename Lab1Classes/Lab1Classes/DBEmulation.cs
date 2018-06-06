using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace Lab1Classes
{

    public class DBEmulation
    {
        //public Dictionary<Guid,Document> Documents = new Dictionary<Guid, Document>();
        //public Dictionary<Guid, Part> Parts = new Dictionary<Guid, Part>();
        //public Dictionary<Guid, Item> Items = new Dictionary<Guid, Item>();
        //public Dictionary<Guid, Paragraph> Paragraphs = new Dictionary<Guid, Paragraph>();

        //public List<PartInDocument> PartInDocuments = new List<PartInDocument>();
        //public List<ItemInPart> ItemInParts = new List<ItemInPart>();
        //public List<ParagraphInItem> ParagraphInItems = new List<ParagraphInItem>();


        //public static DBEmulation Load()
        //{
        //    DataContractSerializer dcs = new DataContractSerializer(typeof(DBEmulation));
        //    XmlReader xmlr = XmlReader.Create("DBEmulation.xml");
        //    DBEmulation res = (DBEmulation)dcs.ReadObject(xmlr);
        //    xmlr.Close();
        //    return res;
        //}

        //public void Save()
        //{
        //    DataContractSerializer dcs = new DataContractSerializer(typeof(DBEmulation));
        //    XmlWriter xmlw = XmlWriter.Create("DBEmulation.xml");
        //    dcs.WriteObject(xmlw, this);
        //    xmlw.Close();
        //}

        public static T LoadObj<T>(T obj)
        {
            if (File.Exists(GetNameFromObject(obj) + ".xml"))
            {
                DataContractSerializer dcs = new DataContractSerializer(obj.GetType());
                XmlReader xmlr = XmlReader.Create(GetNameFromObject(obj) + ".xml");
                T res = (T)dcs.ReadObject(xmlr);
                xmlr.Close();
                return res;
            }
            else
            {
                return obj;
            }
        }

        private static string GetNameFromObject(object obj)
        {
            string[] classNames = { "Document", "Part", "Item", "Paragraph", "ItemInPart", "PartInDocument", "ParagraphInItem" };
            for(int i = 0; i < classNames.Length; i++)
            {
                if (obj.ToString().EndsWith("." + classNames[i] + "]"))
                {
                    return classNames[i];
                }
                                  
            }
            
           
            return obj.ToString();
        }

        public static void SaveObj(object obj)
        {
            DataContractSerializer dcs = new DataContractSerializer(obj.GetType());
            XmlWriter xmlw = XmlWriter.Create(GetNameFromObject(obj) + ".xml"); //filename + 
            dcs.WriteObject(xmlw, obj);
            xmlw.Close();
        }
    }
}
