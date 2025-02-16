using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submission_of_Linear_and_Binary_Search
{
    class RotationPoint
    {
        public static int FindRotationPoint(int[] arr)
        {
            int left = 0, right = arr.Length - 1;

            while (left < right)
            {
                int mid = left + (right - left) / 2;

                // Check if mid element is greater than last element
                if (arr[mid] > arr[right])
                {
                    left = mid + 1; // Smallest element lies in right half
                }
                else
                {
                    right = mid; // Smallest element lies in left half (including mid)
                }
            }
            return left;  // Left index is now pointing to the smallest element
        }
    }

}