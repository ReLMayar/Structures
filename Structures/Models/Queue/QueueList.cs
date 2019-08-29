using System;

namespace Structures.Models.Queue
{
    public class QueueList<T>
    {
        public QueueListItem<T> Head { get; private set; }
        public QueueListItem<T> Tail { get; private set; }
        public int Count { get; private set; }

        public QueueList()
        {
            SetDefaultData();
        }

        public QueueList(T data)
        {
            SetHeadAndTail(data);
        }

        private void SetDefaultData()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        private void SetHeadAndTail(T data)
        {
            var item = new QueueListItem<T>(data);
            Tail = item;
            Head = item;
            Count = 1;
        }

        public void Enqueue(T data)
        {
            if (Head != null)
            {
                var item = new QueueListItem<T>(data);
                Tail.Previous = item;
                Tail = item;
                Count++;
            }
            else { SetHeadAndTail(data); }
        }

        public T Dequeue()
        {
            if (Head != null)
            {
                var item = Head;
                Head = Head.Previous;
                Count--;
                return item.Data;
            }
            else { throw new ArgumentNullException("Queue is empty!"); }
        }

        public T Top()
        {
            if (Head != null)
            {
                return Head.Data;
            }
            else { throw new ArgumentNullException("Queue is empty!"); }
        }
    }
}