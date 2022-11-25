
using System;
using System.Collections;

namespace Day14_StackProgram
{
    internal class program
    {
        static void Main(String[] args)
        {
            Queue queue = new Queue();

            // Adding elements in Queue
            queue.Enqueue(2);
            queue.Enqueue(4);

            Console.WriteLine("Number of elements in the Queue: {0}", queue.Count);

            // Retrieveing top element of queue
            Console.WriteLine("Top element of queue is:");
            Console.WriteLine(queue.Dequeue());

            // printing the no. of queue element
            // after dequeue operation
            Console.WriteLine("Number of elements in the Queue: {0}",  queue.Count);
        }
    }
}