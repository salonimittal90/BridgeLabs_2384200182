
using System;

class StackSorter
{
    private int[] stack; // Stack array
    private int top; // Top of the stack
    private int size; // Stack size

    // Constructor
    public StackSorter(int size)
    {
        this.size = size;
        this.stack = new int[size];
        this.top = -1;
    }

    // Push operation
    public void Push(int value)
    {
        if (top == size - 1)
        {
            Console.WriteLine("Stack Overflow! Cannot push more elements.");
            return;
        }
        stack[++top] = value;
    }

    // Pop operation
    public int Pop()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack Underflow! No elements to pop.");
            return -1;
        }
        return stack[top--];
    }

    // Check if stack is empty
    public bool IsEmpty()
    {
        return top == -1;
    }

    // Sort the stack using recursion
    public void SortStack()
    {
        if (!IsEmpty()) // Base condition: If stack is not empty
        {
            int temp = Pop(); // Remove the top element
            SortStack(); // Recursively sort the remaining stack
            InsertInSortedOrder(temp); // Insert the popped element at the correct position
        }
    }

    // Insert element in sorted order
    private void InsertInSortedOrder(int value)
    {
        if (IsEmpty() || stack[top] <= value) // Base case: If stack is empty or last element is smaller
        {
            stack[++top] = value; // Insert the element
            return;
        }

        int temp = Pop(); // Remove the top element
        InsertInSortedOrder(value); // Recursively insert value
        stack[++top] = temp; // Push back the removed element
    }

    // Display the stack
    public void Display()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack is empty.");
            return;
        }

        Console.WriteLine("Stack elements:");
        for (int i = top; i >= 0; i--)
        {
            Console.WriteLine(stack[i]);
        }
    }

}

