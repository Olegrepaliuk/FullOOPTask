using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Lab1Classes
{

    //public class DocumentList : StorageDictionary<Document>
    //{
    //    protected DocumentList(SerializationInfo info, StreamingContext context)
    //    {
    //        info.AddValue("key", elem.Key);
    //        info.AddValue("doc_id", elem.Value.Id);
    //        info.AddValue("doc_name", elem.Value.Name);
    //        info.AddValue("doc_is", elem.Value.IsEditable);
    //        info.AddValue("doc_number", elem.Value.Number);

    //        string key = "";
    //        Document elem = new Document();
    //        elem.Id = 

    //        //n1 = info.GetInt32("i");
    //        //n2 = info.GetInt32("j");
    //        //str = info.GetString("k");
    //    }


    //    public override virtual void GetObjectData(SerializationInfo info, StreamingContext context)
    //    {
    //        foreach(var elem in this)
    //        {
    //            info.AddValue("key", elem.Key);
    //            info.AddValue("doc_id", elem.Value.Id);
    //            info.AddValue("doc_name", elem.Value.Name);
    //            info.AddValue("doc_is", elem.Value.IsEditable);
    //            info.AddValue("doc_number", elem.Value.Number);
            
    //        }
    //    }
    //}


    [DataContract]
    [Serializable]
    public class Document : GlobalElement<Document>
    {
        
        [DataMember]
        public bool IsEditable { get; set;}

        private string password;
        public string Password
        {
            set
            {
                password = Convert.ToString(value.GetHashCode());
                
            }
        }

        public List<PartInDocument> PartInDocuments
        {
            get
            {
                List<PartInDocument> res = new List<PartInDocument>();
                foreach (PartInDocument pid in PartInDocument.PartInDocuments)
                    if (pid.Document == this)
                        res.Add(pid);
                return res;
            }
        }
        public List<Part> Parts
        {
            get
            {
                List<Part> res = new List<Part>();
                foreach (PartInDocument pid in PartInDocument.PartInDocuments)
                    if (pid.Document == this)
                        res.Add(pid.Part);
                return res;
            }
        }

        public Part this[int index]
        {
            get
            {
                if(index < Parts.Count)
                {
                    return Parts[index];
                }
                else
                {
                    return null;
                }
                
            }
        }

        //Constructors&Destructor


        public Document()
        {


            //int i = Elements.Count();
            //Name = "Document" + Convert.ToString(i + 1);
            //IsEditable = true;
            //Number = i + 1;

            //bool uni;
            //do
            //{
            //    uni = true;
            //    var sameName = Elements
            //        .Where(z => ((Document)z.Value).Name == Name)
            //        .ToList();
            //    if (sameName.Count != 0) uni = false;
            //    if (!uni) Name += Convert.ToString(i + 1);
            //} while (!uni);
            //Password = "Name:" + Name + ",Number:" + Number;
        }

        public Document(string pass)
        {
            Password = pass;
        }

        public Document(int objAmount)
        {
            if (objAmount < 1) objAmount = 1;
            for (int i = 0; i < objAmount; i++)
            {
                var localDoc = new Document();
                Elements.Add(localDoc.Id, localDoc);
            }
        }

        public Document(string name, int number, bool isEdit)
        {
            Name = name;
            IsEditable = isEdit;
            Number = number;
            Password = "Name:" + Name + ", Number:" + Number;
        }

        ~Document()
        {
            
            string info = "Document " + Name + " was removed at " + DateTime.Now;
            string[] infArr = new string[1];
            infArr[0] = info;
            File.AppendAllLines("D:\\WorkControl.txt", infArr);
        }



        public static string Organisation;

        //methods

        public static int CountDocs(List<Document> list)
        {
            
            if (list == null) return 0;
            return list.Count();
        }

        public static bool TwoOrMoreDocuments(Guid ID)
        {
            
            int count = 0;
            foreach(var pid in PartInDocument.PartInDocuments)
            {
                if (pid.Document.Id == ID)
                {
                    count++;
                }
            }
            if (count < 2) return false;
            return true;
        }
        public static List<Document> DocsWithTwoOrMoreParts(Dictionary<Guid, Document> dict)
        {
            List<Document> pTwoMore = new List<Document>();
            foreach(var doc in dict.Values)
            {
                if (TwoOrMoreDocuments(doc.Id))
                {
                    pTwoMore.Add(doc);
                }

            }
            return pTwoMore;

        }

        
        public static List <Document> TheLongestNameDocs(Dictionary<Guid, Document> Docs)
        {
            List<Document> theLongestList = new List<Document>();
            string theLongest = "";
            foreach(var doc in Docs.Values)
            {
                if (doc.Name.Length > theLongest.Length)
                {
                    theLongestList.Clear();
                    theLongest = doc.Name;
                    theLongestList.Add(doc);
                    continue;
                }
                if(doc.Name.Length == theLongest.Length)
                {
                    theLongestList.Add(doc);
                }
            }

            return theLongestList;
        }

    }
}
