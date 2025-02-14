using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubmissionOfStacksQueues
{
    internal class QueueUsingStack
    {
        int[] stack1;
        int[] stack2;
        int size;
        int top1;
        int top2;
            public QueueUsingStack(int size)
            {
            stack1 = new int[size];
            stack2 = new int[size];
            this.size = size;
            this.top1 = -1;
            this.top2 = -1;
            
            }
        public void Push(int item)
        {
            if(top1==size-1)
            {
                Console.WriteLine("stack is full");
                return;
            }
            stack1[++top1] = item;
            Console.WriteLine(item+" item added in the stack1");
        }

        public void Pop()
        {
            if (top2 == size - 1)
            {
                if (top1 == -1)
                {
                    Console.WriteLine("stack is empty");
                    return;
                }
            }
            while(top1>=0)
            {  
                stack2[++top2] = stack1[top1--];
            }

            Console.WriteLine(stack2[top2--]+" deleted");

        }

        public void Display()
        {
            if (top2 == -1)
            {
                if (top1 == -1)
                {
                    Console.WriteLine("stack is empty");
                    return;
                }
            }
            while (top1 >= 0)
            {
                stack2[++top2] = stack1[top1--];
            }
             
            for(int i = top2;i>=0;i--)
            {
                Console.WriteLine("item are ");
                Console.WriteLine(stack2[i]+" ");
            }
        }


    }

}
