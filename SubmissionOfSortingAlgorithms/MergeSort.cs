using System;
namespace SubmissionOfSortingAlgorithms
{
    public class MergeSort
    {
        // Function to perform Merge Sort
      public  static void SortBookPrices(int[] prices, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2; // Find the middle index

                // Recursively sort first and second halves
                SortBookPrices(prices, left, mid);
                SortBookPrices(prices, mid + 1, right);

                // Merge the sorted halves
                Merge(prices, left, mid, right);
            }
        }

        // Function to merge two sorted halves
       public static void Merge(int[] prices, int left, int mid, int right)
        {
            int n1 = mid - left + 1; // Size of left subarray
            int n2 = right - mid;    // Size of right subarray

            // Create temporary arrays
            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            // Copy data to temporary arrays
            for (int i = 0; i < n1; i++)
                leftArray[i] = prices[left + i];

            for (int j = 0; j < n2; j++)
                rightArray[j] = prices[mid + 1 + j];

            // Merge the two sorted arrays
            int iIndex = 0, jIndex = 0, kIndex = left;

            while (iIndex < n1 && jIndex < n2)
            {
                if (leftArray[iIndex] <= rightArray[jIndex])
                    prices[kIndex++] = leftArray[iIndex++];
                else
                    prices[kIndex++] = rightArray[jIndex++];
            }

            // Copy remaining elements of leftArray (if any)
            while (iIndex < n1)
                prices[kIndex++] = leftArray[iIndex++];

            // Copy remaining elements of rightArray (if any)
            while (jIndex < n2)
                prices[kIndex++] = rightArray[jIndex++];
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
