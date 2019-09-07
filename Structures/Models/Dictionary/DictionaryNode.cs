using System;

namespace Structures.Models.Dictionary
{
    public class DictionaryNode<T>
    {
        public int Key { get; set; }
        private T data { get; set; }

        public T Data
        {
            get => data;
            set
            {
                if (value is T)
                {
                    data = value;
                }
                else { throw new Exception("Invalid argument type!"); }
            }
        }

        public DictionaryNode(int key)
        {
            Key = key;
            Data = data;
        }
    }
}
