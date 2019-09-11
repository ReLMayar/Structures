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
            Console.WriteLine('\n');
            #endregion

            #region BinarySearchTree
            Console.WriteLine("Binary Search Tree" + '\n');
            var binarySearchTree = new Models.BinarySearchTree.BinarySearchTree<int>();
            binarySearchTree.AddData(7);
            binarySearchTree.AddData(5);
            binarySearchTree.AddData(4);
            binarySearchTree.AddData(6);
            binarySearchTree.AddData(8);
            binarySearchTree.AddData(9);

            Console.WriteLine("BinarySearchTree PreOrder:");
            var preOrder = binarySearchTree.PreOrder();
            foreach(var preOrders in preOrder)
            {
                Console.Write(preOrders + " ");
            }
            Console.WriteLine();

            Console.WriteLine("BinarySearchTree PostOrder:");
            var postOrder = binarySearchTree.PostOrder();
            foreach (var postOrders in postOrder)
            {
                Console.Write(postOrders + " ");
            }
            Console.WriteLine();

            Console.WriteLine("BinarySearchTree InOrder");
            var inOrder = binarySearchTree.InOrder();
            foreach (var inOrders in inOrder)
            {
                Console.Write(inOrders + " ");
            }
            Console.WriteLine('\n');
            #endregion

            #region HashTable
            Console.WriteLine("Hash Table" + '\n');
            var hashTable = new Models.HashTable.HashTable<int>(8);
            hashTable.AddData(1);
            hashTable.AddData(2);
            hashTable.AddData(1);
            hashTable.AddData(4);
            hashTable.AddData(5);
            hashTable.AddData(4);
            hashTable.AddData(9);
            hashTable.AddData(7);

            Console.WriteLine("Hash table search:");
            Console.WriteLine(hashTable.Search(1));
            Console.WriteLine(hashTable.Search(5));
            Console.WriteLine(hashTable.Search(10));

            Console.WriteLine('\n');
            #endregion

            #region Dictionary
            Console.WriteLine("Dictionary" + '\n');
            var myDictionary = new Models.Dictionary.MyDictionary<int>(5);
            myDictionary.AddData(1);
            myDictionary.AddData(3);
            myDictionary.AddData(5);
            myDictionary.AddData(5);
            myDictionary.AddData(10);

            foreach (var dict in myDictionary)
            {
                Console.Write(dict + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Dictionary Search 10, 15:");
            Console.WriteLine(myDictionary.Search(10));
            Console.WriteLine(myDictionary.Search(15));

            Console.WriteLine("Dictionary Remove 10, 1:");
            myDictionary.Remove(10);
            myDictionary.Remove(1);

            foreach (var dict in myDictionary)
            {
                Console.Write(dict + " ");
            }
            Console.WriteLine('\n');
            #endregion

            #region BinaryHeap
            Console.WriteLine("Binary Heap" + '\n');
            var binaryHeap = new Models.BinaryHeap.BinaryHeap<int>();

            binaryHeap.AddData(1);
            binaryHeap.AddData(3);
            binaryHeap.AddData(5);
            binaryHeap.AddData(4);
            binaryHeap.AddData(2);
            binaryHeap.AddData(9);
            binaryHeap.AddData(10);
            binaryHeap.AddData(7);
            binaryHeap.AddData(17);
            binaryHeap.AddData(72);

            foreach (var heap in binaryHeap)
            {
                Console.Write(heap + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Sorted BinaryHeap:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(binaryHeap.Sort() + " ");
            }

            Console.WriteLine('\n');
            #endregion

            #region PrefixTree
            Console.WriteLine("Prefix Tree" + '\n');
            var prefixtree = new Models.PrefixTree.PrefixTree<int>();
            prefixtree.AddData("привет", 100);
            prefixtree.AddData("пока", 50);
            prefixtree.AddData("кокос", 200);

            Console.WriteLine("PrefixTree Remove:");
            Console.WriteLine(prefixtree.Remove("покрытие"));
            Console.WriteLine(prefixtree.Remove("пока"));

            Console.WriteLine("PrefixTree Search:");
            Console.WriteLine(prefixtree.Search("покрытие"));
            Console.WriteLine(prefixtree.Search("привет"));
            Console.WriteLine(prefixtree.Search("пока"));
            #endregion
        }
    }
}