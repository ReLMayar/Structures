using System;

namespace Structures.Models.LinkedList
{
    public class LinkedListItem<T>
    {
        private T data { get; set; }
        private LinkedListItem<T> next { get; set; }

        public T Data
        {
            get => data;
            set
            {
                if (value != null)
                {
                    data = value;
                }
                else { throw new ArgumentNullException(nameof(value), "Cannot be null!"); }
            }
        }

        public LinkedListItem<T> Next
        {
            get => next;
            set
            {
                if (value is LinkedListItem<T>)
                {
                    next = value;
                }
                else { throw new Exception("Invalid argument type!"); }
            }
        }

        public LinkedListItem(T data)
        {
            Data = data;
        }
    }
}