using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_Queue
{
    class LinkedListQueue
    {
        Node head = null;

        internal void Enqueue(int data)
        {
            Node node = new Node(data);
            if(head==null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while(temp.next!=null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} is inserted into Queue", node.data);
        }
        internal void display()
        {
            Node temp = this.head;
            if(temp==null)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            while(temp!=null)
            {
                Console.WriteLine(temp.data+ " ");
                temp = temp.next;
            }
        }
    }
}
