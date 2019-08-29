using System;

namespace Structures.Models.Stack
{
    public class StackListItem<T>
    {
        private T data { get; set; }
        private StackListItem<T> previous { get; set; }

        public T Data
        {
            get => data;
            set
            {
                if(data != null)
                {
                    data = value;
                }
                else { throw new ArgumentNullException(nameof(value), "Cannot be null!"); }
            }
        }

        public StackListItem<T> Previous
        {
            get => previous;
            set
            {
                if(value is StackListItem<T>)
                {
                    previous = value;
                }
                else { throw new Exception("Invalid argument type!"); }
            }
        }

        public StackListItem(T data)
        {
            Data = data;
        }
    }
}