using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submission_of_Linear_and_Binary_Search
{
    class ComparePerformance
    {
        public static void Compare(int iterations)
        {
            Stopwatch sw = new Stopwatch();

            //  Using Normal String Concatenation
            sw.Start();
            string normalString = "";
            for (int i = 0; i < iterations; i++)
            {
                normalString += "Test"; // Inefficient (Creates new string every time)
            }
            sw.Stop();
            Console.WriteLine("Time taken using String (+): " + sw.ElapsedMilliseconds + " ms");

            //  Using StringBuilder
            sw.Reset();
            sw.Start();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < iterations; i++)
            {
                sb.Append("Test"); // Efficient
            }
            sw.Stop();
            Console.WriteLine("Time taken using StringBuilder: " + sw.ElapsedMilliseconds + " ms");
        }
    }
}