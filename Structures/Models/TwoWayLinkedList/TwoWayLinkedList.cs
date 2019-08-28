using System;
using System.Collections;

namespace Structures.Models.TwoWayLinkedList
{
    class TwoWayLinkedList<T> : IEnumerable
    {
        public TwoWayLinkedListItem<T> Head { get; private set; }

        public TwoWayLinkedListItem<T> Tail { get; private set; }

        public int Count { get; private set; }

        public TwoWayLinkedList()
        {
            SetDefaultData();
        }

        public TwoWayLinkedList(T data)
        {
            SetHeadAndTail(data);
        }

        private void SetHeadAndTail(T data)
        {
            var item = new TwoWayLinkedListItem<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }

        private void SetDefaultData()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public void AddData(T data)
        {
            if (Head != null)
            {
                var item = new TwoWayLinkedListItem<T>(data);
                item.Previous = Tail;
                Tail.Next = item;
                Tail = item;
                Count++;
            }
            else { SetHeadAndTail(data); }
        }

        public void Delete(T data)
        {
            if (Head != null)
            {
                var item = new TwoWayLinkedListItem<T>(data);
                if (Head.Data.Equals(item.Data))
                {
                    Head = Head.Next;
                    Count--;
                    return;
                }
                var current = Head.Next;
                var previous = Head;
                while (current != null)
                {
                    if (current.Data.Equals(item.Data))
                    {
                        if (current.Next != null)
                        {
                            previous.Next = current.Next;
                            current.Next.Previous = previous;
                            Count--;
                            return;
                        }
                        else
                        {
                            current.Previous = null;
                            previous.Next = null;
                            Count--;
                            return;
                        }
                    }
                    previous = current;
                    current = current.Next;
                }
            }
            else { throw new ArgumentNullException("Two way linked list is empty!"); }
        }

        public void AlterHead(T data)
        {
            if (Head != null)
            {
                var item = new TwoWayLinkedListItem<T>(data);
                Head.Previous = item;
                item.Next = Head;
                Head = item;
                Count++;
            }
            else { SetHeadAndTail(data); }
        }

        public void SetAfter(T after, T data)
        {
            if (Head != null)
            {
                var current = Head.Next;
                while (current != null)
                {
                    if (current.Data.Equals(after))
                    {
                        if (current.Next != null)
                        {
                            var item = new TwoWayLinkedListItem<T>(data);
                            current.Next.Previous = item;
                            item.Next = current.Next;
                            current.Next = item;
                            item.Previous = current;
                            Count++;
                            return;
                        }
                        else
                        {
                            AddData(data);
                            return;
                        }
                    }
                    current = current.Next;
                }
            }
            else { SetHeadAndTail(data); }
        }

        public IEnumerator GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}