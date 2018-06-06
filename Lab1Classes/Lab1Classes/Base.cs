using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;
using System.Xml;

namespace Lab1Classes
{
    [Serializable]
    [DataContract]
    public class Base
    {
        [DataMember]
        public Guid Id { get; set; }

        public Base()
        {
            Id = Guid.NewGuid();
        }

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
            for (int i = 0; i < classNames.Length; i++)
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
