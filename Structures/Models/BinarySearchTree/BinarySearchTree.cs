using System;
using System.Collections.Generic;

namespace Structures.Models.BinarySearchTree
{
    public class BinarySearchTree<T> where T : IComparable
    {
        public Node<T> Root { get; private set; }
        public int Count { get; private set; }

        public BinarySearchTree()
        {
            SetDefaultData();
        }

        public BinarySearchTree(T data)
        {
            SetRoot(data);
        }

        private void SetDefaultData()
        {
            Root = null;
            Count = 0;
        }

        private void SetRoot(T data)
        {
            var item = new Node<T>(data);
            Root = item;
            Count = 1;
        }

        public void AddData(T data)
        {
            if (Root != null)
            {
                Root.AddData(data);
                Count++;
            }
            else
            {
                SetRoot(data);
            }
        }

        public List<T> PreOrder()
        {
            if (Root == null)
            {
                return new List<T>();
            }
            else
                return PreOrder(Root);
        }

        public List<T> PostOrder()
        {
            if (Root == null)
            {
                return new List<T>();
            }
            else
                return PostOrder(Root);
        }

        public List<T> InOrder()
        {
            if (Root == null)
            {
                return new List<T>();
            }
            else
                return InOrder(Root);
        }

        public List<T> PreOrder(Node<T> data)
        {
            var list = new List<T>();
            if (data != null)
            {
                list.Add(data.Data);

                if(data.Left != null)
                {
                    list.AddRange(PreOrder(data.Left));
                }

                if (data.Right != null)
                {
                    list.AddRange(PreOrder(data.Right));
                }
            }
            return list;
        }

        public List<T> PostOrder(Node<T> data)
        {
            var list = new List<T>();
            if (data != null)
            {
                if (data.Left != null)
                {
                    list.AddRange(PostOrder(data.Left));
                }

                if (data.Right != null)
                {
                    list.AddRange(PostOrder(data.Right));
                }

                list.Add(data.Data);
            }
            return list;
        }

        public List<T> InOrder(Node<T> data)
        {
            var list = new List<T>();
            if (data != null)
            {
                if (data.Left != null)
                {
                    list.AddRange(InOrder(data.Left));
                }

                list.Add(data.Data);

                if (data.Right != null)
                {
                    list.AddRange(InOrder(data.Right));
                }
            }
            return list;
        }
    }
}
