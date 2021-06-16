using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_Queue
{
    class Node
    {
        public int data;
        public Node next;        //Key and next which stores address Associated to another node key

        public Node(int data)
        {
            this.data = data;
        }
    }
}
