using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Lab1Classes
{
    [DataContract]
    public abstract class TextDependElement<T> : Element<T>
        where T:TextDependElement<T>
    {
        private int fontSize;
        [DataMember]
        public int FontSize
        {
            get
            {
                if (fontSize == 0) return 8;
                else return fontSize;
            }
            set
            {
                if ((value > 0) & (value < 100))
                {
                    fontSize = value;
                }
                else
                {
                    fontSize = 8;
                }

            }
        }
        [DataMember]
        public bool Bold { get; set; }

        public void EditTextDepend(int fontSize, bool isBold)
        {
            FontSize = fontSize;
            Bold = isBold;
        }
    }
}
