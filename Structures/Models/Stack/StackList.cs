using System;

namespace Structures.Models.Stack
{
    public class StackList<T>
    {
        public StackListItem<T> Head { get; private set; }
        public int Count { get; private set; }

        public StackList()
        {
            SetDefaultData();
        }

        public StackList(T data)
        {
            SetHead(data);
        }

        private void SetDefaultData()
        {
            Head = null;
            Count = 0;
        }

        private void SetHead(T data)
        {
            Head = new StackListItem<T>(data);
            Count = 1;
        }

        public void Push(T data)
        {
            if(Head != null)
            {
                var item = new StackListItem<T>(data);
                item.Previous = Head;
                Head = item;
                Count++;
            }
            else { SetHead(data); }
        }

        public T Pop()
        {
            if (Head != null)
            {
                var item = Head;
                Head = Head.Previous;
                Count--;
                return item.Data;
            }
            else { throw new ArgumentNullException("Stack is empty!"); }
        }

        public T Peek()
        {
            if (Head != null)
                return Head.Data;
            else throw new ArgumentNullException("Stack is empty!");
        }
    }
}