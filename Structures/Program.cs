using System;

namespace Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            #region LinkedList
            Console.WriteLine("Linked List" + '\n');
            var item = new Models.LinkedList.LinkedList<int>();

            Console.WriteLine("Add data in Linked List:");
            item.AddData(1);
            item.AddData(2);
            item.AddData(3);
            item.AddData(4);
            item.AddData(5);
            item.AddData(6);

            foreach (var items in item)
            {
                Console.Write(items + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Delete data from Linked List:");
            item.Delete(2);
            item.Delete(5);
            foreach (var items in item)
            {
                Console.Write(items + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Alter Head in Linked List:");
            item.AlterHead(9);
            foreach (var items in item)
            {
                Console.Write(items + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Linked List set after:");
            item.SetAfter(3, 8);
            foreach (var items in item)
            {
                Console.Write(items + " ");
            }
            Console.WriteLine('\n');
            #endregion

            #region TwoWayLinkedList
            Console.WriteLine("Two Way Linked List" + '\n');
            var twoWayLinkedList = new Models.TwoWayLinkedList.TwoWayLinkedList<int>();

            Console.WriteLine("Add data in Two Way Linked List:");
            twoWayLinkedList.AddData(1);
            twoWayLinkedList.AddData(2);
            twoWayLinkedList.AddData(3);
            twoWayLinkedList.AddData(4);
            twoWayLinkedList.AddData(5);
            foreach (var items in twoWayLinkedList)
            {
                Console.Write(items + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Delete data from Two Way Linked List:");
            twoWayLinkedList.Delete(2);
            twoWayLinkedList.Delete(4);
            foreach (var items in twoWayLinkedList)
            {
                Console.Write(items + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Alter head in Two Way Linked List:");
            twoWayLinkedList.AlterHead(4);
            foreach (var items in twoWayLinkedList)
            {
                Console.Write(items + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Two Way Linked List set after:");
            twoWayLinkedList.SetAfter(3, 8);
            twoWayLinkedList.SetAfter(5, 9);
            foreach (var items in twoWayLinkedList)
            {
                Console.Write(items + " ");
            }
            Console.WriteLine('\n');
            #endregion

            #region CircularLinkedList
            var circularLinkedList = new Models.CircularLinkedList.CircularLinkedList<int>();
            Console.WriteLine("Circular Linked List" + '\n');
            Console.WriteLine("Add data in Circular Linked List:");
            circularLinkedList.AddData(1);
            circularLinkedList.AddData(2);
            circularLinkedList.AddData(3);
            circularLinkedList.AddData(4);
            circularLinkedList.AddData(5);
            foreach (var items in circularLinkedList)
            {
                Console.Write(items + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Delete data from Circular Linked List:");
            circularLinkedList.Delete(1);
            circularLinkedList.Delete(4);
            foreach (var items in circularLinkedList)
            {
                Console.Write(items + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Circular Linked List set after:");
            circularLinkedList.Setafter(3, 8);
            foreach (var items in circularLinkedList)
            {
                Console.Write(items + " ");
            }
            Console.WriteLine('\n');
            #endregion

            #region Stack
            Console.WriteLine("Stack" + '\n');
            var stack = new Models.Stack.StackList<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine("Stack Peek:");
            Console.WriteLine(stack.Peek());
            Console.WriteLine("Stack Pop:");
            Console.Write(stack.Pop() + " ");
            Console.WriteLine(stack.Pop());
            Console.WriteLine("Stack Peek:");
            Console.WriteLine(stack.Peek());
            Console.WriteLine();
            #endregion

            #region Queue
            Console.WriteLine("Queue" + '\n');
            var queue = new Models.Queue.QueueList<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            Console.WriteLine("Queue Top:");
            Console.WriteLine(queue.Top());
            Console.WriteLine("Queue Dequeue:");
            Console.Write(queue.Dequeue() + " ");
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine("Queue Top:");
            Console.WriteLine(queue.Top());
            #endregion
        }
    }
}