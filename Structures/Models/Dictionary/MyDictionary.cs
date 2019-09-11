using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Structures.Models.HashTable;

namespace Structures.Models.Dictionary
{
    public class MyDictionary<T> : IEnumerable<T>
    {
        private DictionaryNode<T>[] items;

        public MyDictionary(int size)
        {
            items = new DictionaryNode<T>[size];

            for (int i = 0; i < items.Length; i++)
            {
                items[i] = new DictionaryNode<T>(i);
            }
        }

        public void AddData(T data)
        {
            var key = GetHash(data);
            if (!items[key].Data.Equals(default(T)))
            {
                for (int i = key; i < items.Length; i++)
                {
                    if (items[i].Data.Equals(default(T)))
                    {
                        items[i].Key = key;
                        items[i].Data = data;
                        return;
                    }
                }
                for (int i = 0; i < key; i++)
                {
                    if (items[i].Data.Equals(default(T)))
                    {
                        items[i].Key = key;
                        items[i].Data = data;
                        return;
                    }
                }
            }
            else
            {
                items[key].Key = key;
                items[key].Data = data;
            }
        }

        public bool Search(T data)
        {
            var key = GetHash(data);
            for (int i = 0; i < items.Length; i++)
            {
                if(items[i].Key.Equals(key) && items[i].Data.Equals(data))
                {
                    return true;
                }
            }
            return false;
        }

        public void Remove(T data)
        {
            var key = GetHash(data);
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Key.Equals(key) && items[i].Data.Equals(data))
                {
                    items[i].Data = default(T);
                    items[i].Key = 0;
                }
            }
        }

        private int GetHash(T data)
        {
            return data.GetHashCode() % items.Length;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < items.Length; i++)
            {
                yield return items[i].Data;
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            for (int i = 0; i < items.Length; i++)
            {
                yield return items[i].Data;
            }
        }
    }
}
