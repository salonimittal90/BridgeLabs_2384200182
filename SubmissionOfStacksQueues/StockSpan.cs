using System;

namespace SubmissionOfStacksQueues
{
    internal class StockSpan
    {
        public static void CalculateSpan(int[] prices, int n, int[] span)
        {
            int[] stack = new int[n]; // Manually implemented stack (using array)
            int top = -1; // Stack top pointer

            stack[++top] = 0; // Push first index
            span[0] = 1; // First day's span is always 1

            for (int i = 1; i < n; i++)
            {
                // Pop elements while stack is not empty and top index price is <= current price
                while (top >= 0 && prices[stack[top]] <= prices[i])
                {
                    top--; // Pop operation
                }

                // If stack is empty, span = i + 1, else span = i - stack[top]
                span[i] = (top == -1) ? (i + 1) : (i - stack[top]);

                // Push current index onto stack
                stack[++top] = i;
            }
        }

    }
}
