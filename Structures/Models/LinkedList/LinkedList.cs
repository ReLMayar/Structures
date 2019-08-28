using System;
using System.Collections;

namespace Structures.Models.LinkedList
{
    class LinkedList<T> : IEnumerable
    {
        public LinkedListItem<T> Head { get; private set; }
        public LinkedListItem<T> Tail { get; private set; }
        public int Count { get; private set; }

        public LinkedList()
        {
            SetDefaultData();
        }

        public LinkedList(T data)
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
            var item = new LinkedListItem<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }

        public void AddData(T data)
        {
            if (Tail != null)
            {
                var item = new LinkedListItem<T>(data);
                Tail.Next = item;
                Tail = item;
                Count++;
            }
            else{ SetHeadAndTail(data); }
        }

        public void Delete(T data)
        {
            if (Head != null)
            {
                var item = new LinkedListItem<T>(data);
                if (Head.Data.Equals(item.Data))
                {
                    Head = Head.Next;
                    Count--;
                    return;
                }
                var current = Head.Next;
                var previous = Head;
                while (current.Next != null)
                {
                    if (current.Data.Equals(item.Data))
                    {
                        if (current.Next != null)
                        {
                            previous.Next = current.Next;
                            Count--;
                            return;
                        }
                        else
                        {
                            previous.Next = null;
                            Count--;
                            return;
                        }
                    }
                    previous = current;
                    current = current.Next;
                }
            }
            else { throw new ArgumentNullException("Linked list is empty!"); }
        }

        public void AlterHead(T data)
        {
            if(Head != null)
            {
                var item = new LinkedListItem<T>(data);
                item.Next = Head;
                Head = item;
                Count++;
            }
            else{ SetHeadAndTail(data); }
        }

        public void SetAfter(T after, T data)
        {
            if (Head != null)
            {
                var current = Head;
                while (current != null)
                {
                    if (current.Data.Equals(after))
                    {
                        var item = new LinkedListItem<T>(data);
                        item.Next = current.Next;
                        current.Next = item;
                        Count++;
                        return;
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