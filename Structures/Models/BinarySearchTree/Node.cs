using System;

namespace Structures.Models.BinarySearchTree
{
    public class Node<T> where T : IComparable
    {
        private T data { get; set; }
        private Node<T> left { get; set; }
        private Node<T> right { get; set; }

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

        public Node<T> Left
        {
            get => left;
            set
            {
                if(value is Node<T>)
                {
                    left = value;
                }
                else { throw new Exception("Invalid argument type!"); }
            }
        }

        public Node<T> Right
        {
            get => right;
            set
            {
                if(value is Node<T>)
                {
                    right = value;
                }
                else { throw new Exception("Invalid argument type!"); }
            }
        }

        public Node(T data)
        {
            Data = data;
        }

        public void AddData(T data)
        {
            var item = new Node<T>(data);

            if (item.Data.CompareTo(Data) < 0)
            {
                if (Left == null)
                {
                    Left = item;
                }
                else
                {
                    Left.AddData(data);
                }
            }
            else
            {
                if (Right == null)
                {
                    Right = item;
                }
                else
                {
                    Right.AddData(data);
                }
            }

        }
    }
}
