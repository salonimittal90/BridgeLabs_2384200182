using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_s_Runtime_Analysis___Big_O_Notation
{
    class StringConcatenation
    {
        public static void ComparePerformance(int N)
        {
            //  Using String (Very Slow)
            Stopwatch sw1 = Stopwatch.StartNew();
            string str = "";
            for (int i = 0; i < N; i++)
            {
                str += "A";
            }
            sw1.Stop();
            Console.WriteLine("String Concatenation Time: " + sw1.ElapsedMilliseconds + " ms");

            //  Using StringBuilder (Fast)
            Stopwatch sw2 = Stopwatch.StartNew();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < N; i++)
            {
                sb.Append("A");
            }
            sw2.Stop();
            Console.WriteLine("StringBuilder Concatenation Time: " + sw2.ElapsedMilliseconds + " ms");
        }
    }
}


