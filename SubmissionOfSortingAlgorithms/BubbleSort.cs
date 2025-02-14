using System;

namespace SubmissionOfSortingAlgorithms
{
    public class BubbleSort
    {
        // Function to perform Bubble Sort on student marks
       public static void SortMarks(int[] marks)
        {
            int n = marks.Length;
            bool swapped; // Flag to check if any swapping happened

            // Outer loop runs for (n-1) passes
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false; // Reset swapped flag at the start of each pass

                // Inner loop for comparing adjacent elements
                for (int j = 0; j < n - i - 1; j++)
                {
                    // Swap if the current element is greater than the next element
                    if (marks[j] > marks[j + 1])
                    {
                        int temp = marks[j];
                        marks[j] = marks[j + 1];
                        marks[j + 1] = temp;

                        swapped = true; // Mark swapped as true if any swapping occurs
                    }
                }

                // If no elements were swapped, the array is already sorted
                if (!swapped)
                    break;
            }
        }

        // Function to print the array elements
       public  static void PrintArray(int[] marks)
        {
            foreach (int mark in marks)
            {
                Console.Write(mark + " ");
            }
            Console.WriteLine();
        }
    }
}   
