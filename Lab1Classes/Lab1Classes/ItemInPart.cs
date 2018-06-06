using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Lab1Classes
{
    [DataContract]
    public class ItemInPart : Base
    {
        static public StorageList<ItemInPart> ItemInParts = new StorageList<ItemInPart>();

        private Guid _partId;
        private Guid _itemId;

        [DataMember]
        public Item Item
        {
            get { return (Item)Item.Elements[_itemId]; }
            set { _itemId = value.Id; }
        }

        public ItemInPart(Guid partId, Guid itemId)
        {
            _partId = partId;
            _itemId = itemId;
        }

        [DataMember]
        public Part Part
        {
            get
            {
                foreach (Part part in Part.Elements.Values)
                {
                    if (part.Id == _partId)
                        return part;
                }

                return null;
            }
            set { _partId = value.Id; }
        }

    }
}
