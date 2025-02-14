using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubmissionOfStacksQueues
{
    class TwoSumSolution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>(); // Store value → index

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i]; // Required number to reach target

                // If complement is found, return indices
                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i };
                }

                // Store current number with its index
                if (!map.ContainsKey(nums[i]))
                {
                    map[nums[i]] = i;
                }
            }

            return new int[] { -1, -1 }; // No valid pair found (edge case)
        }
    }
}
