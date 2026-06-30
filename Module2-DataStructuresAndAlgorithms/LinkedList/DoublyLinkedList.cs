using System;

namespace DataStructuresAndAlgorithms.LinkedListImpl
{
    class DNode
    {
        public int Data;
        public DNode Prev;
        public DNode Next;
        public DNode(int data) { Data = data; Prev = null; Next = null; }
    }

    /// <summary>
    /// Doubly Linked List - allows traversal in both directions.
    /// </summary>
    class DoublyLinkedList
    {
        private DNode head;

        public void InsertAtEnd(int data)
        {
            DNode newNode = new DNode(data);
            if (head == null)
            {
                head = newNode;
                return;
            }
            DNode temp = head;
            while (temp.Next != null)
                temp = temp.Next;

            temp.Next = newNode;
            newNode.Prev = temp;
        }

        public void Delete(int key)
        {
            DNode current = head;
            while (current != null && current.Data != key)
                current = current.Next;

            if (current == null) return; // not found

            if (current.Prev != null)
                current.Prev.Next = current.Next;
            else
                head = current.Next; // deleting head

            if (current.Next != null)
                current.Next.Prev = current.Prev;
        }

        public void TraverseForward()
        {
            DNode temp = head;
            Console.Write("Forward: ");
            while (temp != null)
            {
                Console.Write(temp.Data + " <-> ");
                temp = temp.Next;
            }
            Console.WriteLine("null");
        }

        public void TraverseBackward()
        {
            if (head == null) return;
            DNode temp = head;
            while (temp.Next != null)
                temp = temp.Next;

            Console.Write("Backward: ");
            while (temp != null)
            {
                Console.Write(temp.Data + " <-> ");
                temp = temp.Prev;
            }
            Console.WriteLine("null");
        }

        static void Main(string[] args)
        {
            DoublyLinkedList list = new DoublyLinkedList();
            list.InsertAtEnd(10);
            list.InsertAtEnd(20);
            list.InsertAtEnd(30);

            list.TraverseForward();
            list.TraverseBackward();

            list.Delete(20);
            Console.WriteLine("After deleting 20:");
            list.TraverseForward();
        }
    }
}
