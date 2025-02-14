using System;
namespace SubmissionOfStacksQueues
{
    public class StackUsingArray
    {
        int[] stack;
        int top;
        int size;

        public StackUsingArray(int size)
        {
            this.size = size;
            stack = new int[size];
            top = -1;
        }
        public void push(int item)
        {
            if(top == size-1)
            {
                Console.WriteLine("stack is fulll");
                return;
            }
            stack[++top] = item;
            //Console.WriteLine(item+" added");
        }

        public void Display()
        {
            Console.WriteLine("items are: ");
            for (int i=top;i>-1;i--)
            {
               
                Console.WriteLine(stack[i]+" ");
            }
        }
        public void pop()
        {
            if(top ==-1)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            stack[top]= top--;
        }

        public void Peek()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("peek element is " + stack[top]);
        }

    }
}
