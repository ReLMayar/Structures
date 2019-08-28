using System;

namespace Structures.Models.CircularLinkedList
{
    public class CircularLinkedListItem<T>
    {
        private T data { get; set; }
        private CircularLinkedListItem<T> next { get; set; }
        private CircularLinkedListItem<T> previous { get; set; }

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

        public CircularLinkedListItem<T> Next
        {
            get => next;
            set
            {
                if (value is CircularLinkedListItem<T>)
                {
                    next = value;
                }
                else { throw new Exception("Invalid argument type!"); }
            }
        }

        public CircularLinkedListItem<T> Previous
        {
            get => previous;
            set
            {
                if (value is CircularLinkedListItem<T>)
                {
                    previous = value;
                }
                else { throw new Exception("Invalid argument type!"); }
            }
        }

        public CircularLinkedListItem(T data)
        {
            Data = data;
        }
    }
}