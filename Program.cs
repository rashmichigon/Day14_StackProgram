
using System;
using System.Collections;

namespace Day14_StackProgram
{
     static void Main(String[] args)
    {
        StackUsingLinkedlist myStack = new StackUsingLinkedlist();

        // Inserting the elements into the Stack
        myStack.push(56);
        myStack.push(30);
        myStack.push(70);
       

        // Displaying the count of elements
        // contained in the Stack before
        // removing all the elements
        Console.Write("Total number of elements in the Stack are : ");

        bool Count = false;
        Console.WriteLine(Count);

        // Removing all elements from Stack
        myStack.Clear();

        // Displaying the count of elements
        // contained in the Stack after
        // removing all the elements
        Console.Write("Total number of elements in the Stack are : ");

        Console.WriteLine(Count);
    }
}