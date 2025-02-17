using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Algorithm_s_Runtime_Analysis___Big_O_Notation
{
    public class ExecutionClass
    {
        public void CallingTargetSearch()
        {
            SearchTarget obj = new SearchTarget();
            // size of a variable
            int n = 10000;
            // declare and initialize the array of same size
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = i;
            }
            // take the target variable 
            int target = n - 10;

            //start timmer  
            Stopwatch sw = Stopwatch.StartNew();

            //call the function
            obj.LinearSearch(arr, target);

            //stop timmer
            sw.Stop();

            //convert the time into miliseconds
            Console.WriteLine($"Linear Search Time: {sw.Elapsed.TotalMilliseconds} ms");

            //Restart the watch
            sw.Restart();

            //call the method
            obj.BinarySearch(arr, target);

            //stop the watch
            sw.Stop();

            //convert the time into miliseconds
            Console.WriteLine($"Binary Search Time: {sw.Elapsed.TotalMilliseconds} ms");
        }

        public void CallingSortingComparison()
        {
            // Define dataset size
            int n = 10000;

            // Generate fixed dataset of size 10000
            int[] arr = new int[n];
            Random rand = new Random(42); // Fixed seed for consistency
            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(1, 1000000);
            }

            // Clone arrays for fair comparison
            int[] arr1 = (int[])arr.Clone();
            int[] arr2 = (int[])arr.Clone();
            int[] arr3 = (int[])arr.Clone();

            SortingComparision obj = new SortingComparision();

            // Start stopwatch for Bubble Sort
            Stopwatch sw = Stopwatch.StartNew();
            obj.BubbleSort(arr1);
            sw.Stop();
            Console.WriteLine($"Bubble Sort Time: {sw.Elapsed.TotalMilliseconds} ms");

            // Restart stopwatch for Merge Sort
            sw.Restart();
            obj.MergeSort(arr2, 0, arr2.Length - 1);
            sw.Stop();
            Console.WriteLine($"Merge Sort Time: {sw.Elapsed.TotalMilliseconds} ms");

            // Restart stopwatch for Quick Sort
            sw.Restart();
            obj.QuickSort(arr3, 0, arr3.Length - 1);
            sw.Stop();
            Console.WriteLine($"Quick Sort Time: {sw.Elapsed.TotalMilliseconds} ms");
        }

        public void CallingStringConcatenation()
        {
            int N = 100000;
            StringConcatenation.ComparePerformance(N);
        }

        public void CallingFileReading()
        {
            Console.Write("Enter File Path : ");
            string filePath = Console.ReadLine();
            FileReading.ComparePerformance(filePath);
        }

        public void CallingFibbonacciComparison()
        {
            int n = 30;
            FibonacciComparison.ComparePerformance(n);
        }
    }


}
    

