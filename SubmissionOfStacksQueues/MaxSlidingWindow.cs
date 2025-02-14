using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubmissionOfStacksQueues
{
    class SlidingWindowMaximum
    {
        public static void MaxSlidingWindow(int[] nums, int n, int k)
        {
            int[] result = new int[n - k + 1]; // Store the max values
            int ri = 0; // Result index
            int[] deque = new int[n]; // Implementing deque using array
            int front = 0, rear = -1; // Pointers for deque

            for (int i = 0; i < n; i++)
            {
                // Remove elements which are out of this window
                if (front <= rear && deque[front] < i - k + 1)
                    front++;

                // Remove all elements smaller than the current element from the back
                while (front <= rear && nums[deque[rear]] <= nums[i])
                    rear--;

                // Push current index at rear
                deque[++rear] = i;

                // Store the maximum value for the current window
                if (i >= k - 1)
                    result[ri++] = nums[deque[front]];
            }

            // Print the result
            Console.WriteLine("Sliding Window Maximum:");
            Console.WriteLine(string.Join(" ", result));
        }
    }
}