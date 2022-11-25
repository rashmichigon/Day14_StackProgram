using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_StackProgram
{
    public class StackUsingLinkedlist
    {
        private class Node
        {
            public int data;
            public Node link;
        }

        // create global top reference variable
        Node top;

        // Constructor
        public StackUsingLinkedlist() 
        {
            this.top = null;
        }

        public void push(int x)
        {
            // create new node temp and allocate memory
            Node temp = new Node();
            if (temp == null)
            {
                Console.Write("\nHeap Overflow");
                return;
            }

            // initialize data into temp data field
            temp.data = x;

            // put top reference into temp link
            temp.link = top;

            // update top reference
            top = temp;
        }
        public bool isEmpty()
        {
            return top == null; 
        }
        public int peek()
        {
            // check for empty stack
            if (!isEmpty())
            {
                return top.data;
            }
            else
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
        }

        // Utility function to pop top element from the stack
        public void pop() // remove at the beginning
        {
            if (top == null)
            {
                Console.Write("\nStack Underflow");
                return;
            }

            // update the top pointer to
            // point to the next node
            top = (top).link;
        }

        public void display()
        {
            // check for stack underflow
            if (top == null)
            {
                Console.Write("\nStack Underflow");
                return;
            }
            else
            {
                Node temp = top;
                while (temp != null)
                {

                    // print node data
                    Console.Write(temp.data);

                    // assign temp link to temp
                    temp = temp.link;
                    if (temp != null)
                        Console.Write(" -> ");
                }
            }
        }
    }
}
