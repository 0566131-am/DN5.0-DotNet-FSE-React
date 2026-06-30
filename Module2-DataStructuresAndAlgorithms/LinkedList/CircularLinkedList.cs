using System;

namespace DataStructuresAndAlgorithms.LinkedListImpl
{
    class CNode
    {
        public int Data;
        public CNode Next;
        public CNode(int data) { Data = data; Next = null; }
    }

    /// <summary>
    /// Circular Singly Linked List - last node points back to head.
    /// </summary>
    class CircularLinkedList
    {
        private CNode head;

        public void Insert(int data)
        {
            CNode newNode = new CNode(data);
            if (head == null)
            {
                head = newNode;
                newNode.Next = head;
                return;
            }
            CNode temp = head;
            while (temp.Next != head)
                temp = temp.Next;

            temp.Next = newNode;
            newNode.Next = head;
        }

        public void Delete(int key)
        {
            if (head == null) return;

            CNode current = head, prev = null;

            // If head itself holds the key
            if (head.Data == key)
            {
                if (head.Next == head) // single node
                {
                    head = null;
                    return;
                }
                CNode last = head;
                while (last.Next != head)
                    last = last.Next;

                head = head.Next;
                last.Next = head;
                return;
            }

            prev = head;
            current = head.Next;
            while (current != head)
            {
                if (current.Data == key)
                {
                    prev.Next = current.Next;
                    return;
                }
                prev = current;
                current = current.Next;
            }
        }

        public void Traverse()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            CNode temp = head;
            Console.Write("Circular List: ");
            do
            {
                Console.Write(temp.Data + " -> ");
                temp = temp.Next;
            } while (temp != head);
            Console.WriteLine("(back to head)");
        }

        static void Main(string[] args)
        {
            CircularLinkedList list = new CircularLinkedList();
            list.Insert(10);
            list.Insert(20);
            list.Insert(30);

            list.Traverse();

            list.Delete(20);
            Console.WriteLine("After deleting 20:");
            list.Traverse();
        }
    }
}
