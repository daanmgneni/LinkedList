﻿namespace LinkedListProgram
{
    public class LinkedList
    {
        public Node head;

        public void Add(int Data)
        {
            Node node = new Node(Data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = node;
            }
            Console.WriteLine("{0} inserted into Linked List", node.Data);
        }

        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.Data + " ");
                temp = temp.Next;
            }
        }

        /*
         //Insertion
        public Node Insertion(int position, int Data)
      {
        if (position < 1)
            Console.WriteLine("Invalid position");
        if (position == 1)
        {
            var newNode = new Node(Data);
            newNode.Next = this.head;
            head = newNode;
        }
        else
        {
            while (position-- != 0)
            {
                if (position == 1)
                {
                    Node node = new Node(Data);
                    node.Next = this.head.Next;
                    head.Next = node;
                    break;
                }
                head = head.Next;
            }
            if (position != 1)
                Console.WriteLine("Position out of range");
        }
        return head;
       }
        */

        /*
        //Delete First element
        public Node DeleteFirst()
        {
            if (this.head == null)
            {
                return null;
            }
            this.head = this.head.Next;
            return this.head;
        }
        */

        public Node DeleteLast()
        {
            if (this.head == null)
            {
                return null;
            }

            if (head.Next == null)
            {
                return null;
            }
            Node newNode = head;
            while (newNode.Next.Next != null)
            {
                newNode = newNode.Next;
            }

            newNode.Next = null;
            return head;
        }

    }

}
