using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Lab1Classes
{
    [DataContract]
    public class Item : TextDependElement<Item>
    {
        
        
        public List<ItemInPart> ItemInParts
        {
            get
            {
                List<ItemInPart> res = new List<ItemInPart>();
                foreach (ItemInPart iip in ItemInPart.ItemInParts)
                    if (iip.Item == this)
                        res.Add(iip);
                return res;
            }
        }
        public List<Part> Parts
        {
            get
            {
                List<Part> res = new List<Part>();
                foreach (ItemInPart iip in ItemInPart.ItemInParts)
                    if (iip.Item == this)
                        res.Add(iip.Part);
                return res;
            }
        }

        //public List<ItemInPart> ItemInParts
        //{
        //    get
        //    {
        //        List<ItemInPart> res = new List<ItemInPart>();
        //        foreach (ItemInPart iip in ItemInPart.ItemInParts)
        //            if (iip.Part == this)
        //                res.Add(iip);
        //        return res;
        //    }
        //}
        //public List<Item> Items
        //{
        //    get
        //    {
        //        List<Item> res = new List<Item>();
        //        foreach (ItemInPart iip in ItemInPart.ItemInParts)
        //            if (iip.Part == this)
        //                res.Add(iip.Item);
        //        return res;
        //    }
        //}

        public List<ParagraphInItem> ParagraphInItems
        {
            get
            {
                List<ParagraphInItem> res = new List<ParagraphInItem>();
                foreach (ParagraphInItem pii in ParagraphInItem.ParagraphInItems)
                    if (pii.Item == this)
                        res.Add(pii);
                return res;
            }
        }

        public List<Paragraph> Paragraphs
        {
            get
            {
                List<Paragraph> res = new List<Paragraph>();
                foreach (ParagraphInItem pii in ParagraphInItem.ParagraphInItems)
                    if (pii.Item == this)
                        res.Add(pii.Paragraph);
                return res;
            }
        }




        public Item (int number, int fontSize)
        {
            Number = number;
            FontSize = fontSize;
        }

        //public List<Paragraph> Paragraphs { get; set; } = new List<Paragraph>();





        public override string ToString()
        {
            return Convert.ToString(Number);
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


        public static List<Item> ItemsWithTwoOrMoreParagraphs(Dictionary<Guid, Item> dict)
        {
            List<Item> parTwoMore = new List<Item>();
            foreach (var elem in dict.Values)
            {
                if (elem.Paragraphs.Count >= 2)
                {
                    parTwoMore.Add(elem);
                }

            }
            return parTwoMore;

        }


    }
}
