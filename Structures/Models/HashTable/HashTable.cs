using System;

namespace Structures.Models.HashTable
{
    public class HashTable<T>
    {
        private HashTableNode<T>[] items;

        public HashTable(int size)
        {
            items = new HashTableNode<T>[size];

            for (int i = 0; i < items.Length; i++)
            {
                items[i] = new HashTableNode<T>(i);
            }
        }

        public void AddData(T item)
        {
            var key = GetHash(item);
            items[key].Data.Add(item);
        }

        public bool Search(T item)
        {
            var key = GetHash(item);
            return items[key].Data.Contains(item);
        }

        private int GetHash(T item)
        {
            return item.GetHashCode() % items.Length;
        }
    }
}
