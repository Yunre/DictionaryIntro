using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryIntro
{
    class MyDictionary<T,X>
    {

        T[] items;
        X[] items2;
        public MyDictionary()
        {
            items = new T[0];
            items2 = new X[0];

        }

        public void Add(T item , X item2)
        {
            T[] tempList = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempList.Length; i++)
            {
                items[i] = tempList[i];
            }
            items[items.Length - 1] = item;

            X[] tempList2 = items2;
            items2 = new X[items2.Length + 1];
            for (int i = 0; i < tempList2.Length; i++)
            {
                items2[i] = tempList2[i];
            }
            items2[items2.Length - 1] = item2;
        }
        public int Lenght { get { return items.Length; } }

        public T[] Key { get { return items; } }
        public X[] Name { get { return items2; } }
    }
}
