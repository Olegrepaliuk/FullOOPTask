using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Lab1Classes
{
    [DataContract]
    public class Paragraph : TextDependElement<Paragraph>
    {
        private string text;
        
        [DataMember]
        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                if (Char.IsLower(value[0]))
                {

                    for (int i = 0; i < value.Length; i++)
                    {
                        if (i == 0) text += Char.ToUpper(value[0]);
                        else
                        {
                            text += value[i];
                        }
                        if((i == value.Length - 1)&(value[value.Length-1]!='.'))
                        {
                            text += Convert.ToString('.');
                        }
                    }
                }
                else
                {
                    text = value;
                    if (text[text.Length - 1] != '.')
                    {
                        text += Convert.ToString('.');
                    }
                }
            }
        }



        public int SymbolsAmount
        {
            get
            {
               
                if(Text != null)
                {
                    return Text.Where(z => z != ' ').Count();
                    
                }
                else
                {
                    return 0;
                }


            }
        }

        //public List<ItemInPart> ItemInParts
        //{
        //    get
        //    {
        //        List<ItemInPart> res = new List<ItemInPart>();
        //        foreach (ItemInPart iip in ItemInPart.ItemInParts)
        //            if (iip.Item == this)
        //                res.Add(iip);
        //        return res;
        //    }
        //}
        //public List<Part> Parts
        //{
        //    get
        //    {
        //        List<Part> res = new List<Part>();
        //        foreach (ItemInPart iip in ItemInPart.ItemInParts)
        //            if (iip.Item == this)
        //                res.Add(iip.Part);
        //        return res;
        //    }
        //}

        public List<ParagraphInItem> ParagraphInItems
        {
            get
            {
                List<ParagraphInItem> res = new List<ParagraphInItem>();
                foreach (ParagraphInItem pii in ParagraphInItem.ParagraphInItems)
                    if (pii.Paragraph == this)
                        res.Add(pii);
                return res;
            }
        }

        public List<Item> Items
        {
            get
            {
                List<Item> res = new List<Item>();
                foreach (ParagraphInItem pii in ParagraphInItem.ParagraphInItems)
                    if (pii.Paragraph == this)
                        res.Add(pii.Item);
                return res;
            }
        }




        public Paragraph (string text, int font, bool bold, int num)
        {
            Text = text;
            FontSize = font;
            Bold = bold;
            Number = num;
        }

        public static string Options;

        public static int AllTextAmount(Dictionary<Guid, Paragraph> pars)
        {
            int res = 0;
            foreach(var elem in pars.Values)
            {
                res += elem.Text.Length;
            }
            return res;
        }
        public override string ToString()
        {
            return Text;
        }
    }
}
 