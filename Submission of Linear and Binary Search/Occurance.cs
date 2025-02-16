using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submission_of_Linear_and_Binary_Search
{
    class Occurance
    {

        public static int FindFirstOccurrence(int[] arr, int target)
        {
            int left = 0, right = arr.Length - 1, result = -1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                {
                    result = mid;  // Possible first occurrence
                    right = mid - 1;  // Continue searching in left half
                }
                else if (arr[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return result;
        }

        public static int FindLastOccurrence(int[] arr, int target)
        {
            int left = 0, right = arr.Length - 1, result = -1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                {
                    result = mid;  // Possible last occurrence
                    left = mid + 1;  // Continue searching in right half
                }
                else if (arr[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return result;
        }
    }

}