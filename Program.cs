
using System;
using System.Collections;

namespace Day14_StackProgram
{
    internal class Program
    {
        static void Main(String[] args)
        {
            Queue q = new Queue();
            q.enqueue(56);
            q.enqueue(30);
            q.dequeue();
            q.dequeue();
            q.enqueue(70);
            q.enqueue(40);
            q.enqueue(50);
            q.dequeue();
            Console.WriteLine("Queue Front : " + q.front.key);
            Console.WriteLine("Queue Rear : " + q.rear.key);
        }
    }
}