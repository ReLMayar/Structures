using System;
using System.Collections.Generic;
using System.Text;

namespace Structures.Models.PrefixTree
{
    public class Node<T>
    {
        public char Symbol { get; set; }
        public bool IsWord { get; set; }
        private T data { get; set; }
        private Dictionary<char, Node<T>> subNode { get; set; }

        public T Data
        {
            get => data;
            set
            {
                if(value != null)
                {
                    data = value;
                }
                else { throw new ArgumentNullException(nameof(value), "Cannot be null"); }
            }
        }

        public Dictionary<char, Node<T>> SubNode
        {
            get => subNode;
            set
            {
                if(value != null)
                {
                    subNode = value;
                }
                else { throw new ArgumentNullException(nameof(value), "Cannot be null!"); }
            }
        }

        public Node(char symbol, T data)
        {
            Symbol = symbol;
            Data = data;
            SubNode = new Dictionary<char, Node<T>>();
        }

        public Node<T> TryFind(char symbol)
        {
            if (SubNode.TryGetValue(symbol, out Node<T> value))
            {
                return value;
            }
            else
                return null;
        }
    }
}
