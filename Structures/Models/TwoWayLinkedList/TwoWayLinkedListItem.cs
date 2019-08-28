using System;

namespace Structures.Models.TwoWayLinkedList
{
    public class TwoWayLinkedListItem<T>
    {
        private T data { get; set; }
        private TwoWayLinkedListItem<T> next { get; set; }
        private TwoWayLinkedListItem<T> previous { get; set; }

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

        public TwoWayLinkedListItem<T> Next
        {
            get => next;
            set
            {
                if (value is TwoWayLinkedListItem<T>)
                {
                    next = value;
                }
                else { throw new Exception("Invalid argument type!"); }
            }
        }

        public TwoWayLinkedListItem<T> Previous
        {
            get => previous;
            set
            {
                if(value is TwoWayLinkedListItem<T>)
                {
                    previous = value;
                }
                else { throw new Exception("Invalid argument type!"); }
            }
        }

        public TwoWayLinkedListItem(T data)
        {
            Data = data;
        }
    }
}