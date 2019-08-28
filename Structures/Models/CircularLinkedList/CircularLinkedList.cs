using System;
using System.Collections;

namespace Structures.Models.CircularLinkedList
{
    public class CircularLinkedList<T> : IEnumerable
    {
        public CircularLinkedListItem<T> Head { get; private set; }
        public int Count { get; private set; }
        public CircularLinkedList()
        {
            SetDefaultData();
        }
        public CircularLinkedList(T data)
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
            var item = new CircularLinkedListItem<T>(data);
            Head = item;
            Head.Next = item;
            Head.Previous = item;
            Count = 1;
        }

        public void AddData(T data)
        {
            if (Head != null)
            {
                var item = new CircularLinkedListItem<T>(data);
                var last = Head.Previous;
                last.Next = item;
                Head.Previous = item;
                item.Next = Head;
                item.Previous = last;
                Count++;
                return;
            }
            else { SetHead(data); }
        }

        public void Delete(T data)
        {
            if (Head != null)
            {
                var item = new CircularLinkedListItem<T>(data);
                if (Head.Data.Equals(item.Data))
                {
                    Head.Previous.Next = Head.Next;
                    Head.Next.Previous = Head.Previous;
                    Head = Head.Next;
                    Count--;
                    return;
                }
                var current = Head.Next;
                var previous = Head;
                while (current != null)
                {
                    if(current.Data.Equals(item.Data))
                    {
                        previous.Next = current.Next;
                        current.Next.Previous = previous;
                        Count--;
                        return;
                    }
                    previous = current;
                    current = current.Next;
                }
            }
            else { throw new ArgumentNullException("Linked list is empty!"); }
        }

        public void AlterHead(T data)
        {
        }

        public void Setafter(T after, T data)
        {
            if (Head != null)
            {
                var current = Head.Next;
                while (current != null)
                {
                    if (current.Data.Equals(after))
                    {
                        var item = new CircularLinkedListItem<T>(data);
                        current.Next.Previous = item;
                        item.Next = current.Next;
                        current.Next = item;
                        item.Previous = current;
                        Count++;
                        return;
                    }
                    current = current.Next;
                }
            }
            else { SetHead(data); }
        }

        public IEnumerator GetEnumerator()
        {
            var current = Head;
            for (int i = 0; i < Count; i++)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}