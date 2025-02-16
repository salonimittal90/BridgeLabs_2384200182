using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submission_of_Linear_and_Binary_Search
{
    class SearchOperations
    {
        // Function to find the first missing positive integer using Linear Search
        public static int FindFirstMissingPositive(int[] arr)
        {
            int n = arr.Length;
            bool[] present = new bool[n + 1]; // To track numbers from 1 to n

            // Mark present numbers
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > 0 && arr[i] <= n)
                {
                    present[arr[i]] = true;
                }
            }

            // Find the first missing positive number
            for (int i = 1; i <= n; i++)
            {
                if (!present[i])
                    return i;
            }

            return n + 1; // If all numbers from 1 to n are present
        }

        // Binary Search to find index of target element
        public static int BinarySearch(int[] arr, int target)
        {
            int left = 0, right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                    return mid;
                else if (arr[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return -1; // Target not found
        }
    }
}