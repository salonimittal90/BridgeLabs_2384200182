using System;


namespace SubmissionOfStacksQueues
{
    using System;
    using System.Collections.Generic;

    class ZeroSumSubarrays
    {
        public static void FindZeroSumSubarrays(int[] arr)
        {
            Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
            int sum = 0;

            // Store initial sum = 0 at index -1 (for cases where subarray starts from 0)
            if (!map.ContainsKey(0))
                map[0] = new List<int>();
            map[0].Add(-1);

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i]; // Calculate cumulative sum

                // If sum exists in map, it means subarrays exist
                if (map.ContainsKey(sum))
                {
                    foreach (int start in map[sum])
                    {
                        Console.WriteLine($"Subarray found from index {start + 1} to {i}");
                    }
                }

                // Store current sum in map
                if (!map.ContainsKey(sum))
                    map[sum] = new List<int>();
                map[sum].Add(i);
            }
        }

    }
}
