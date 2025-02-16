using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submission_of_Linear_and_Binary_Search
{
    public class RemoveDuplicates
    {
        public static string RemoveDuplicateCharacters(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            HashSet<char> seen = new HashSet<char>();
            StringBuilder sb = new StringBuilder();

            foreach (char c in input)
            {
                if (!seen.Contains(c))
                {
                    seen.Add(c);
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }
    }
}
