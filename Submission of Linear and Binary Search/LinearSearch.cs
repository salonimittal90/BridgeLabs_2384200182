using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submission_of_Linear_and_Binary_Search
{
    class LinearSearch
    {

        public static int FindFirstNegative(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)  // Linear Search
            {
                if (arr[i] < 0)
                {
                    return arr[i];  // First negative number found
                }
            }
            return -1;  // No negative number found
        }
    }

}