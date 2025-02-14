using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubmissionOfStacksQueues
{
    public class ExecutionClass
    {
        public void CallingQueueUsingStacks()
        {
            QueueUsingStack obj = new QueueUsingStack(5);
            obj.Push(5);
            obj.Push(6);
            obj.Push(7);
            obj.Push(8);
            obj.Push(9);
            obj.Pop();
            obj.Pop();
            obj.Pop();
            obj.Pop();
            obj.Pop();
            obj.Display();
        }

        public void CallingStackSorter()
        {
            StackSorter stack = new StackSorter(5);

            stack.Push(3);
            stack.Push(1);
            stack.Push(4);
            stack.Push(2);
            stack.Push(5);

            Console.WriteLine("Original Stack:");
            stack.Display();

            stack.SortStack();

            Console.WriteLine("\nSorted Stack:");
            stack.Display();

        }
        public void CallingstockSpan()
        {

            int[] prices = { 100, 80, 60, 70, 60, 75, 85 };
            int n = prices.Length;
            int[] span = new int[n];

            // Function call with the correct syntax
            StockSpan.CalculateSpan(prices, n, span);

            Console.WriteLine("Stock Span:");
            Console.WriteLine(string.Join(" ", span));
        }


        public void CallingMaxSlidingWindow()
        {
            int[] nums = { 1, 3, -1, -3, 5, 3, 6, 7 };
            int k = 3;
            int n = nums.Length;

            SlidingWindowMaximum.MaxSlidingWindow(nums, n, k);
        }

        public void CallingCircularTour()
        {
            int[] petrol = { 4, 6, 7, 4 };
            int[] distance = { 6, 5, 3, 5 };
            int n = petrol.Length;

            int startIndex = CircularTour.FindStartingPoint(petrol, distance, n);
            Console.WriteLine(startIndex != -1 ? "Start at pump: " + startIndex : "No solution possible");
        }

        public void CallingZeroSumSubarrays()
        {
            int[] arr = { 3, 4, -7, 1, 2, -6, 1, 6 };
            ZeroSumSubarrays.FindZeroSumSubarrays(arr); 

            
        }

        public void CallingPairWithGivenSum()
        {
            int[] arr = { 2, 7, 11, 15, 4, 8 };
            int target = 9;

            PairWithGivenSum.HasPairWithSum(arr, target);

        }

        public void CallingLongestConsecutiveSequence()
        {
            int[] nums = { 100, 4, 200, 1, 3, 2 };
            Console.WriteLine("Longest Consecutive Sequence Length: " + LongestConsecutiveSequence.FindLongestConsecutive(nums)); 

        }

        public void CallingCustomHashMap()
        {
            CustomHashMap<string, int> hashMap = new CustomHashMap<string, int>();

            hashMap.Put("Apple", 10);
            hashMap.Put("Banana", 20);
            hashMap.Put("Mango", 30);
            hashMap.Put("Orange", 40);
            hashMap.Put("Apple", 50); // Updating Apple

            Console.WriteLine("Value for 'Apple': " + hashMap.Get("Apple"));
            hashMap.Remove("Banana");

            Console.WriteLine("\nAfter Removing 'Banana':");
            hashMap.Display();
        }

        public void CallingTwoSumSolution()
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            int[] result = TwoSumSolution.TwoSum(nums, target);
            Console.WriteLine($"Indices: [{result[0]}, {result[1]}]");
        }





    }
}
