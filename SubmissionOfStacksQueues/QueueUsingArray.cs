using System;

namespace SubmissionOfStacksQueues
{
    public class QueueUsingArray
    {
        int[] Queue;
        int size;
        int front;
        int rear;

        public QueueUsingArray(int size)
        {
            Queue = new int[size];
            this.size = size;
            this.front = -1;
            this.rear = -1;
        }

        public bool IsFull()
        {
            return rear == size - 1;
        }

        public void Enqueue(int item)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is full");
                return;
            }
            if (front == -1)
            {
                front = 0;
            }
            Queue[++rear] = item;
            Console.WriteLine(item + " added");
        }

        public void Display()
        {
            if(front ==-1|| front>rear)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            Console.WriteLine("Items are:");
            for(int i = front; i <=rear;i++)
            {
                Console.WriteLine(Queue[i]);
            }
        }
        public void Dequeue()
        {
            if(front==-1 ||front>rear)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            front++;
            Console.WriteLine("item deleted");
            if (front > rear)
            {
                front = rear = -1;
            }
        }


    }
}
