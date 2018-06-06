using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Lab1Classes
{


    [DataContract]
    [Serializable]
    public class Element<T> : Base
        where T:Element<T>
    {
        static public StorageDictionary<T> Elements = new StorageDictionary<T>();

        public Element()
        {
            Elements.Add(Id, (T)this);
        }

        private int number;
        [DataMember]
        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                if (value > 0)
                {
                    number = value;
                }

            }
        }
    }
}
