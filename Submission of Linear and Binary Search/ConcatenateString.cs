using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submission_of_Linear_and_Binary_Search
{
    public class ConcatenateString
    {
        public static string Concatenate(string[] words)
        {
            if (words == null || words.Length == 0)
                return string.Empty;

            StringBuilder sb = new StringBuilder();

            foreach (string word in words)
            {
                sb.Append(word).Append(" ");
            }

            return sb.ToString().Trim();
        }
    }
}