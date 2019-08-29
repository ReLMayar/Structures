using System;

namespace Structures.Models.Queue
{
    public class QueueListItem<T>
    {
        private T data { get; set; }
        private QueueListItem<T> previous { get; set; }

        public T Data
        {
            get => data;
            set
            {
                if(value != null)
                {
                    data = value;
                }
                else { throw new ArgumentNullException(nameof(value), "Cannot be null!"); }
            }
        }

        public QueueListItem<T> Previous
        {
            get => previous;
            set
            {
                if(value is QueueListItem<T>)
                {
                    previous = value;
                }
                else { throw new Exception("Invalid argument type!"); }
            }
        }

        public QueueListItem(T data)
        {
            Data = data;
        }
    }
}