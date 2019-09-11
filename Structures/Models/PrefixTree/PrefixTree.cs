using System;
using System.Collections.Generic;
using System.Text;

namespace Structures.Models.PrefixTree
{
    public class PrefixTree<T>
    {
        public Node<T> Root { get; set; }

        public PrefixTree()
        {
            Root = new Node<T>('\0', default(T));
        }

        public void AddData(string data, T key)
        {
            AddData(data, key, Root);
        }

        private void AddData(string data, T key, Node<T> node)
        {
            if (string.IsNullOrEmpty(data))
            {
                if (!node.IsWord)
                {
                    node.Data = key;
                    node.IsWord = true;
                }
            }
            else
            {
                var subnode = node.TryFind(data[0]);
                if (subnode != null)
                {
                    AddData(data.Substring(1), key, subnode);
                }
                else
                {
                    var newNode = new Node<T>(data[0], key);
                    node.SubNode.Add(data[0], newNode);
                    AddData(data.Substring(1), key, newNode);
                }
            }
        }

        public bool Remove(string data)
        {
            return Remove(data, Root);
        }

        private bool Remove(string data, Node<T> node)
        {
            var result = false;
            if(string.IsNullOrEmpty(data))
            {
                if (node.IsWord)
                {
                    node.IsWord = false;
                    node.Data = default(T);
                    result = true;
                }
            }
            else
            {
                var subnode = node.TryFind(data[0]);
                if (subnode != null)
                {
                    result = Remove(data.Substring(1), subnode);
                }
                else
                {
                    result = false;
                }
            }
            return result;
        }

        public bool Search(string data)
        {
            return Search(data, Root);
        }

        private bool Search(string data, Node<T> node)
        {
            var result = false;
            if(string.IsNullOrEmpty(data))
            {
                if (node.IsWord)
                    result = true;
            }
            else
            {
                var subnode = node.TryFind(data[0]);
                if(subnode!=null)
                {
                    result = Search(data.Substring(1), subnode);
                }
                else
                {
                    result = false;
                }
            }
            return result;
        }
    }
}
