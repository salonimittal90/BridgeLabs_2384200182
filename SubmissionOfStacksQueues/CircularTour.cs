using System;

namespace SubmissionOfStacksQueues
{
    class CircularTour
    {
        public static int FindStartingPoint(int[] petrol, int[] distance, int n)
        {
            int start = 0;        // Possible starting index
            int deficit = 0;      // Track negative balance
            int surplus = 0;      // Track current fuel balance

            for (int i = 0; i < n; i++)
            {
                surplus += petrol[i] - distance[i];

                // If surplus becomes negative, reset starting point
                if (surplus < 0)
                {
                    start = i + 1;  // Move to next pump
                    deficit += surplus; // Store deficit
                    surplus = 0;    // Reset surplus
                }
            }

            // If total fuel (surplus + deficit) is negative, no solution exists
            return (surplus + deficit >= 0) ? start : -1;
        }
    }
}
