using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Lab1Classes
{

        [Serializable]
        [DataContract]
    public class GlobalElement<T> : Element<T>
        where T: GlobalElement<T>

    {
        
        private string name;
        [DataMember]
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (Char.IsLower(value[0]))
                {

                    for (int i = 0; i < value.Length; i++)
                    {
                        if (i == 0) name += Char.ToUpper(value[0]);
                        else
                        {
                            name += value[i];
                        }
                    }
                }
                else
                {
                    name = value;
                }
            }
        }

        public void EditGlobal(string name, int number)
        {
            Name = name;
            Number = number;
        }

        public bool CheckNameForNoLetterSymbols()
        {
            for(int i = 0; i<Name.Length; i++)
            {
                if(((Name[i]>64)&(Name[i] < 90))| ((Name[i] > 96) & (Name[i] < 123))| ((Name[i] >= 192) & (Name[i] <= 255)))
                {
                    continue;
                }
                else
                {
                    return true;
                }
                
            }
            return false;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
