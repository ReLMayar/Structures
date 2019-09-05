using System;

namespace Structures.Models.HashTable
{
    public class HashTable<T>
    {
        private Node<T>[] items;

        public HashTable(int size)
        {
            items = new Node<T>[size];
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
