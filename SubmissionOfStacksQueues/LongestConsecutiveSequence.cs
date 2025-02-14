using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubmissionOfStacksQueues
{
    class LongestConsecutiveSequence
    {
        public static int FindLongestConsecutive(int[] nums)
        {
            HashSet<int> numSet = new HashSet<int>(nums); // Store unique elements
            int longest = 0;

            foreach (int num in numSet)
            {
                // Check only if 'num' is the starting point of a sequence
                if (!numSet.Contains(num - 1))
                {
                    int currentNum = num;
                    int currentStreak = 1;

                    // Count consecutive numbers
                    while (numSet.Contains(currentNum + 1))
                    {
                        currentNum++;
                        currentStreak++;
                    }

                    // Update longest sequence length
                    longest = Math.Max(longest, currentStreak);
                }
            }

            return longest;
        }
    }
}