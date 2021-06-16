using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_Queue
{
    public class LinkedListStack
    {
        private Node top;
        public LinkedListStack()
        {
            this.top = null;
        }
        internal void push(int value)
        {
            Node node = new Node(value);       //Object of NOde created and passing data into it as values
            if(this.top ==null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} pushed to stack", value);

        }
        internal void display()        //Method to display the whole thing 
        {
            Node temp = this.top;
            while(temp!=null)
            {
                Console.WriteLine(temp.data+" ");
                temp = temp.next;
            }
        }
        internal void Peek()     //Method to return top element of stack (LiFO) without deleting it  
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            Console.WriteLine("{0} is in top of Stack", this.top.data);
        }
        internal void Pop()   //Method to remove the top most element and return it 
        {
            if (this.top == null)
            {
                Console.WriteLine("Value popped is {0}", this.top.data);
                this.top = this.top.next;
            }
        }
        internal void IsEmpty()  //Method checking for empty spaces
        {
            while (this.top != null)
            {
                Peek();
                Pop();
                break;
            }
        }


    }
}
