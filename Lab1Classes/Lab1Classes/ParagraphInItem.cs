using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Lab1Classes
{
    [DataContract]
    public class ParagraphInItem
    {

        static public StorageList<ParagraphInItem> ParagraphInItems = new StorageList<ParagraphInItem>();

        private Guid _itemId;
        private Guid _paragraphId;

        [DataMember]
        public Paragraph Paragraph
        {
            get { return (Paragraph)Paragraph.Elements[_paragraphId]; }
            set { _paragraphId = value.Id; }
        }

        public ParagraphInItem(Guid itemId, Guid paragraphId)
        {
            _itemId = itemId;
            _paragraphId = paragraphId;
        }

        [DataMember]
        public Item Item
        {
            get
            {
                foreach (Item item in Item.Elements.Values)
                {
                    if (item.Id == _itemId)
                        return item;
                }

                return null;
            }
            set { _itemId = value.Id; }
        }
    }
}
