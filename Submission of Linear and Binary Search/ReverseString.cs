using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submission_of_Linear_and_Binary_Search
{
    public class ReverseString
    {
        public static string Reverse(string input)
        {
            StringBuilder sb = new StringBuilder(input);
            int n = sb.Length;

            for (int i = 0, j = n - 1; i < j; i++, j--)
            {
                char temp = sb[i];
                sb[i] = sb[j];
                sb[j] = temp;
            }

            return sb.ToString();
        }
    }
}
