using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubmissionOfStacksQueues
{
    class PairWithGivenSum
    {
        public static bool HasPairWithSum(int[] arr, int target)
        {
            HashSet<int> set = new HashSet<int>(); // HashSet to store visited numbers

            foreach (int num in arr)
            {
                int complement = target - num;

                // Check if complement is in the set
                if (set.Contains(complement))
                {
                    Console.WriteLine($"Pair found: ({complement}, {num})");
                    return true;
                }

                // Store the current number in the set
                set.Add(num);
            }

            Console.WriteLine("No pair found.");
            return false;
        }

       
    }
}
