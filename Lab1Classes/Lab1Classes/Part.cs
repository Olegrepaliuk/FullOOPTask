using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Lab1Classes
{
    [DataContract]
    public class Part : GlobalElement<Part>
    {


        public List<PartInDocument> PartInDocuments
        {
            get
            {
                List<PartInDocument> res = new List<PartInDocument>();
                foreach (PartInDocument pid in PartInDocument.PartInDocuments)
                    if (pid.Part == this)
                        res.Add(pid);
                return res;
            }
        }
        public List<Document> Documents
        {
            get
            {
                List<Document> res = new List<Document>();
                foreach (PartInDocument pid in PartInDocument.PartInDocuments)
                    if (pid.Part == this)
                        res.Add(pid.Document);
                return res;
            }
        }


        public List<ItemInPart> ItemInParts
        {
            get
            {
                List<ItemInPart> res = new List<ItemInPart>();
                foreach (ItemInPart iip in ItemInPart.ItemInParts)
                    if (iip.Part == this)
                        res.Add(iip);
                return res;
            }
        }
        public List<Item> Items
        {
            get
            {
                List<Item> res = new List<Item>();
                foreach (ItemInPart iip in ItemInPart.ItemInParts)
                    if (iip.Part == this)
                        res.Add(iip.Item);
                return res;
            }
        }



        public Part()
        {
            int i = Elements.Count();
            Name = "Part" + Convert.ToString(i + 1);
            Number = i + 1;
        }

        public Part (int number, string name)
        {
            Number = number;
            Name = name;
        }

        ~Part()
        {
            string info = "Part " + Name + " was removed at " + DateTime.Now + "\n";
            string[] infArr = new string[1];
            infArr[0] = info;
            File.AppendAllLines("D:\\WorkControl.txt", infArr);
        }


        public static string Options;

        //methods
        public static int CountParts(Dictionary<Guid, Part> dict)
        {
            if (dict == null)
            {
                return 0;
            }
            else
            {
                return dict.Count;
            }
        }

        public static bool TwoOrMoreParts(Guid ID)
        {

            int count = 0;
            foreach (var pid in ItemInPart.ItemInParts)
            {
                if (pid.Part.Id == ID)
                {
                    count++;
                }
            }
            if (count < 2) return false;
            return true;
        }
        public static List<Part> PartsWithTwoOrMoreItems(Dictionary<Guid, Part> dict)
        {
            List<Part> iTwoMore = new List<Part>();
            foreach (var prt in dict.Values)
            {
                if (TwoOrMoreParts(prt.Id))
                {
                    iTwoMore.Add(prt);
                }

            }
            return iTwoMore;

        }


        public static List<Part> TheLongestNameDocs(Dictionary<Guid, Part> Parts)
        {
            List<Part> theLongestList = new List<Part>();
            string theLongest = "";
            foreach (var prt in Parts.Values)
            {
                if (prt.Name.Length > theLongest.Length)
                {
                    theLongestList.Clear();
                    theLongest = prt.Name;
                    theLongestList.Add(prt);
                    continue;
                }
                if (prt.Name.Length == theLongest.Length)
                {
                    theLongestList.Add(prt);
                }
            }

            return theLongestList;
        }

    }
}
