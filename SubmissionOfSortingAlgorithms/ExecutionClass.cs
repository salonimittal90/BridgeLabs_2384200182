using System;

namespace SubmissionOfSortingAlgorithms
{
    public class ExecutionClass
    {
        public void CallingBubbleSort()
        {
            int[] studentMarks = { 85, 60, 75, 95, 70, 80 };

            Console.WriteLine("Original Marks:");
            BubbleSort.PrintArray(studentMarks); // Print original array

            BubbleSort.SortMarks(studentMarks);  // Call sorting function

            Console.WriteLine("Sorted Marks:");
            BubbleSort.PrintArray(studentMarks); // Print sorted array
        }

        public void CallingInsertionSort()
        {

            int[] employeeIDs = { 102, 100, 105, 101, 103, 104 };

            Console.WriteLine("Original Employee IDs:");
            InsertionSort.PrintArray(employeeIDs); // Print original array

            InsertionSort.SortEmployeeIDs(employeeIDs); // Sort the IDs using Insertion Sort

            Console.WriteLine("Sorted Employee IDs:");
            InsertionSort.PrintArray(employeeIDs); // Print sorted array
        }

        public void CallingMergeSort()
        {
            // Sample Book Prices
            int[] bookPrices = { 500, 150, 700, 200, 450, 300 };

            Console.WriteLine("Original Book Prices:");
            MergeSort.PrintArray(bookPrices); // Print original array

            MergeSort.SortBookPrices(bookPrices, 0, bookPrices.Length - 1); // Call Merge Sort

            Console.WriteLine("Sorted Book Prices:");
            MergeSort.PrintArray(bookPrices); // Print sorted array
        }

        public void CallingQuickSort()
        {
            // Sample Product Prices
            int[] productPrices = { 999, 500, 1200, 750, 650, 300 };

            Console.WriteLine("Original Product Prices:");
            QuickSort.PrintArray(productPrices); // Print original array

            QuickSort.SortProductPrices(productPrices, 0, productPrices.Length - 1); // Call Quick Sort

            Console.WriteLine("Sorted Product Prices:");
            QuickSort.PrintArray(productPrices); // Print sorted array
        }

        public void CallingSelectionSort()
        {
            SelectionSort sorter = new SelectionSort();

            // Sample Exam Scores
            int[] examScores = { 85, 60, 75, 95, 70, 80 };

            Console.WriteLine("Original Exam Scores:");
            sorter.PrintArray(examScores); // Print original array

            sorter.SortExamScores(examScores); // Call Selection Sort

            Console.WriteLine("Sorted Exam Scores:");
            sorter.PrintArray(examScores); // Print sorted array
        }

        public void CallingHeapSort()
        {
            HeapSort sorter = new HeapSort();

            // Sample Salary Demands
            int[] salaryDemands = { 60000, 45000, 75000, 50000, 70000, 55000 };

            Console.WriteLine("Original Salary Demands:");
            sorter.PrintArray(salaryDemands); // Print original array

            sorter.SortSalaries(salaryDemands); // Call Heap Sort

            Console.WriteLine("Sorted Salary Demands:");
            sorter.PrintArray(salaryDemands); // Print sorted array
        }

        public void CallingCountingSort()
        {
            CountingSort sorter = new CountingSort();

            // Sample Student Ages
            int[] studentAges = { 15, 12, 17, 10, 14, 16, 18, 11, 13, 12 };

            Console.WriteLine("Original Student Ages:");
            sorter.PrintArray(studentAges); // Print original array

            sorter.SortStudentAges(studentAges, 10, 18); // Call Counting Sort

            Console.WriteLine("Sorted Student Ages:");
            sorter.PrintArray(studentAges); // Print sorted array
        }
    }
}




    
