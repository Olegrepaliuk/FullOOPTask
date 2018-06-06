using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;
using System.Xml;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace Lab1Classes
{

    public enum StorageFormat { sfXml, sfText, sfMemory }

    interface IDataStorage
    {
        void LoadObj(StorageFormat sf);
        void SaveObj(StorageFormat sf);
    }

    public class BaseStorageXml
    {
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



    public class BaseStorageMemory
    {
        public static T Load<T>(Stream s)
        {
            using (Stream memoryStream = s)
            {
                s.Position = 0;
                XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(memoryStream, Encoding.UTF8, new XmlDictionaryReaderQuotas(), null);
                DataContractSerializer serializer = new DataContractSerializer(typeof(T));
                return (T)serializer.ReadObject(reader);
            }
            //s.Position = 0;
            //var formatter = new BinaryFormatter();
            //var tm = (T)formatter.Deserialize(s);
            //return tm;
        }

        public static Stream Save<T>(T tm)
        {
            Stream memoryStream = new MemoryStream();
            DataContractSerializer serializer = new DataContractSerializer(tm.GetType());
            serializer.WriteObject(memoryStream, tm);
            string s = Encoding.UTF8.GetString(((MemoryStream)memoryStream).ToArray());
            return memoryStream;

                //var formatter = new BinaryFormatter();
                //var stream = new MemoryStream();
                //formatter.Serialize(stream, tm);
                //return stream;
        }
    }




    public class BaseStorageText
    {
        public static StorageDictionary<Document> LoadObj(StorageDictionary<Document> obj)
        {
            if (File.Exists(GetNameFromObject(obj) + ".txt"))
            {

                StorageDictionary<Document> res = new StorageDictionary<Document>();

                StreamReader sr = new StreamReader(GetNameFromObject(obj) + ".txt");

                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Document d = new Document();

                    string[] arr;

                    arr = line.Split('#');

                    d.Id = Guid.Parse(arr[0]);
                    d.Number = Convert.ToInt32(arr[1]);
                    d.Name = arr[2];
                    d.IsEditable = Convert.ToBoolean(arr[3]);

                    res.Add(d.Id, d);
                }
                sr.Close();
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

        public static void SaveObj(StorageDictionary<Document> collection)
        {
            //DataContractSerializer dcs = new DataContractSerializer(obj.GetType());
            //XmlWriter xmlw = XmlWriter.Create(GetNameFromObject(obj) + ".xml");

            //dcs.WriteObject(xmlw, obj);
            //xmlw.Close();

            StreamWriter sw = new StreamWriter(GetNameFromObject(collection) + ".txt");
            foreach (Document doc in collection.Values)
            {
                sw.WriteLine(Convert.ToString(doc.Id) + "#" + Convert.ToString(doc.Number)
                            + "#" + doc.Name + "#" + Convert.ToBoolean(doc.IsEditable));
            }
        }

        public static void SaveObj2<T>(T obj)
        {
            using (StreamWriter file = File.CreateText(GetNameFromObject(obj) + ".txt"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, obj);
            }


        }

        public static T LoadObj2<T>(T obj)
        {
            using (StreamReader file = File.OpenText(GetNameFromObject(obj) + ".txt"))
            {
                JsonSerializer serializer = new JsonSerializer();
                T obj2 = (T)serializer.Deserialize(file, typeof(T));
                return obj2;
            }
        }

    }



    [Serializable]
    public class StorageDictionary<T> : Dictionary<Guid, T>, IDataStorage
    {

        private Stream mem;

        ~StorageDictionary()
        {
            Base.SaveObj(this);
        }

        public void LoadObj(StorageFormat sf)
        {
            StorageDictionary<T> dic = new StorageDictionary<T>();

            switch (sf)
            {
                case StorageFormat.sfMemory:
                    if (mem != null)
                    {
                        dic = BaseStorageMemory.Load<StorageDictionary<T>>(mem);
                    }
                    break;

                case StorageFormat.sfText:
                    //if (T is Document)
                    dic = BaseStorageText.LoadObj2(this);
                    break;

                //XML
                default:
                    dic = BaseStorageXml.LoadObj(this);
                    break;

            }

            this.Clear();
            foreach (var elem in dic)
            {
                Add(elem.Key, elem.Value);
            }
        }

        public void SaveObj(StorageFormat sf)
        {
            switch (sf)
            {
                case StorageFormat.sfMemory:
                    mem = BaseStorageMemory.Save(this);
                    break;

                case StorageFormat.sfText:
                    //if (T is Document)
                    //BaseStorageDocumentText.SaveObj(this);
                    //break;
                    BaseStorageText.SaveObj2(this);
                    break;
                //XML
                default:
                    BaseStorageXml.SaveObj(this);
                    break;

            }





        }



        public static explicit operator StorageDictionary<T>(StorageDictionary<Document> v)
        {
            throw new NotImplementedException();
        }
    }


 



}