using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Classes
{
    public class StorageList<T> : List<T>
    {
        ~StorageList()
        {
            Base.SaveObj(this);
        }
    }
}
