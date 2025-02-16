using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submission_of_Linear_and_Binary_Search
{
    class PeakElement
    {

        public static int FindPeakElement(int[] arr)
        {
            int left = 0, right = arr.Length - 1;

            while (left < right)
            {
                int mid = left + (right - left) / 2;

                // If mid element is greater than next element, peak lies in left half
                if (arr[mid] > arr[mid + 1])
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;  // Move right if mid+1 is greater
                }
            }
            return left;  // Left index is the peak element index
        }
    }

}