using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Algorithm_s_Runtime_Analysis___Big_O_Notation

    {
        class FibonacciComparison
        {

            public static void ComparePerformance(int n)
            {
                // 1️⃣ Recursive Fibonacci (O(2^N))
                Stopwatch sw1 = Stopwatch.StartNew();
                int recResult = FibonacciRecursive(n);
                sw1.Stop();
                Console.WriteLine($"Recursive Fibonacci({n}) = {recResult}, Time: {sw1.ElapsedMilliseconds} ms");

                // 2️⃣ Iterative Fibonacci (O(N))
                Stopwatch sw2 = Stopwatch.StartNew();
                int iterResult = FibonacciIterative(n);
                sw2.Stop();
                Console.WriteLine($"Iterative Fibonacci({n}) = {iterResult}, Time: {sw2.ElapsedMilliseconds} ms");
            }

            public static int FibonacciRecursive(int n)
            {
                if (n <= 1) return n;
                return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
            }

            public static int FibonacciIterative(int n)
            {
                if (n <= 1) return n;

                int a = 0, b = 1, sum;
                for (int i = 2; i <= n; i++)
                {
                    sum = a + b;
                    a = b;
                    b = sum;
                }
                return b;
            }
        }

    }
