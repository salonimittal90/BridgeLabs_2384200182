using System;
namespace SubmissionOfSortingAlgorithms
{
    class SelectionSort
    {
        // Function to perform Selection Sort
        public void SortExamScores(int[] scores)
        {
            int n = scores.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i; // Assume the first unsorted element is the minimum

                // Find the minimum element in the remaining unsorted part
                for (int j = i + 1; j < n; j++)
                {
                    if (scores[j] < scores[minIndex])
                        minIndex = j; // Update minIndex if a smaller element is found
                }

                // Swap the found minimum element with the first unsorted element
                Swap(scores, i, minIndex);
            }
        }

        // Function to swap two elements in the array
        public void Swap(int[] arr, int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }

        // Function to print the array
        public void PrintArray(int[] scores)
        {
            foreach (int score in scores)
                Console.Write(score + " ");
            Console.WriteLine();
        }

    }
}
