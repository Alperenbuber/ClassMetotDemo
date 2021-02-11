using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class Dictionary<K,T>
    {
        T[] items;
        K[] keys;
        public Dictionary()
        {
            items = new T[0];
            keys = new K[0];
        }
        
    }
}
