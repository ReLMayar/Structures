using System;
using System.Collections.Generic;
using System.Text;

namespace Structures.Models.BinaryHeap
{
    public class BinaryHeap<T> where T : IComparable
    {
        private List<T> items = new List<T>();

        public T GetMax()
        {
            if (items.Count > 0)
            {
                return items[0];
            }
            else
                return default(T);
        }

        public void AddData(T data)
        {
            items.Add(data);

            var current = items.Count - 1;
            var parent = GetParent(current);

            while(current > 0 && items[parent].CompareTo(items[current]) < 0)
            {
                Swap(current, parent);
                current = parent;
                parent = GetParent(current);
            }
        }

        public T Sort()
        {
            var result = items[0];
            items[0] = items[items.Count - 1];
            items.RemoveAt(items.Count - 1);
            for (int i = items.Count; i >= 0 ; i--)
            {
                Sort(i);
            }
            return result;
        }

        private void Sort(int current)
        {
            int max = current;
            int left;
            int right;

            while (current < items.Count)
            {
                left = 2 * current + 1;
                right = 2 * current + 2;

                if(left < items.Count && items[max].CompareTo(items[left]) < 0)
                {
                    max = left;
                }

                if (right < items.Count && items[max].CompareTo(items[right]) < 0)
                {
                    max = right;
                }

                if(max.CompareTo(current) == 0)
                {
                    break;
                }

                Swap(current, max);
                current = max;
            }
        }

        private void Swap(int current, int parrent)
        {
            var temp = items[parrent];
            items[parrent] = items[current];
            items[current] = temp;
        }

        private int GetParent(int current)
        {
            return (current - 1) / 2;
        }
    }
}
