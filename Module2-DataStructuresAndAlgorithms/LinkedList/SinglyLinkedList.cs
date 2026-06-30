using System;

namespace DataStructuresAndAlgorithms.LinkedListImpl
{
    class Node
    {
        public int Data;
        public Node Next;

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }

    /// <summary>
    /// Singly Linked List with Insert, Delete, Search, and Traverse operations.
    /// Time Complexity: Insert at head O(1), Insert at end O(n),
    /// Search O(n), Delete O(n)
    /// </summary>
    class SinglyLinkedList
    {
        private Node head;

        public void InsertAtBeginning(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = head;
            head = newNode;
        }

        public void InsertAtEnd(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                return;
            }
            Node current = head;
            while (current.Next != null)
                current = current.Next;
            current.Next = newNode;
        }

        public void Delete(int key)
        {
            Node current = head, prev = null;

            if (current != null && current.Data == key)
            {
                head = current.Next;
                return;
            }

            while (current != null && current.Data != key)
            {
                prev = current;
                current = current.Next;
            }

            if (current == null) return; // not found

            prev.Next = current.Next;
        }

        public bool Search(int key)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Data == key)
                    return true;
                current = current.Next;
            }
            return false;
        }

        public void Traverse()
        {
            Node current = head;
            Console.Write("List: ");
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }

        public void Reverse()
        {
            Node prev = null, current = head, next = null;
            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            head = prev;
        }

        static void Main(string[] args)
        {
            SinglyLinkedList list = new SinglyLinkedList();
            list.InsertAtEnd(10);
            list.InsertAtEnd(20);
            list.InsertAtEnd(30);
            list.InsertAtBeginning(5);

            list.Traverse(); // 5 -> 10 -> 20 -> 30 -> null

            Console.WriteLine("Search 20: " + list.Search(20));
            Console.WriteLine("Search 99: " + list.Search(99));

            list.Delete(10);
            Console.WriteLine("After deleting 10:");
            list.Traverse();

            list.Reverse();
            Console.WriteLine("After reversing:");
            list.Traverse();
        }
    }
}
