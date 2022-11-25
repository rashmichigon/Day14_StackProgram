namespace Day14_StackProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StackUsingLinkedlist obj = new StackUsingLinkedlist();

            // insert Stack value
            obj.push(56);
            obj.push(30);
            obj.push(70);
            
            // print Stack elements
            obj.display();

            // print Top element of Stack
            Console.Write("\nTop element is {0}\n", obj.peek());

            // Delete top element of Stack
            obj.pop();
            obj.pop();

            // print Stack elements
            obj.display();

            // print Top element of Stack
            Console.Write("\nTop element is {0}\n", obj.peek());
        }
    }
    }
