using System;

namespace Stack_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListStack list = new LinkedListStack();
            list.push(70);
            list.push(30);
            list.push(56);
            list.display();
           


            LinkedListQueue linkedListQueue = new LinkedListQueue();
            linkedListQueue.Enqueue(56);
            linkedListQueue.Enqueue(30);
            linkedListQueue.Enqueue(70);
            
        }
    }
}
