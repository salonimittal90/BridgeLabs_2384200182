using System;
namespace SubmissionOfSortingAlgorithms
{
    class QuickSort
    {
        // Function to perform Quick Sort
        public static void SortProductPrices(int[] prices, int low, int high)
        {
            if (low < high)
            {
                // Partitioning index
                int pivotIndex = Partition(prices, low, high);

                // Recursively sort elements before and after partition
                SortProductPrices(prices, low, pivotIndex - 1);
                SortProductPrices(prices, pivotIndex + 1, high);
            }
        }

        // Function to partition the array
        public static int Partition(int[] prices, int low, int high)
        {
            int pivot = prices[high]; // Choosing last element as pivot
            int i = low - 1; // Index for smaller elements

            for (int j = low; j < high; j++)
            {
                if (prices[j] < pivot)
                {
                    i++;
                    Swap(prices, i, j);
                }
            }

            // Swap pivot element with the element at (i + 1)
            Swap(prices, i + 1, high);

            return i + 1; // Return partition index
        }

        // Function to swap two elements in the array
        public static void Swap(int[] arr, int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }

        // Function to print the array
       public static void PrintArray(int[] prices)
        {
            foreach (int price in prices)
                Console.Write(price + " ");
            Console.WriteLine();
        }

    }
}
