using System;
namespace SubmissionOfSortingAlgorithms
{
    class HeapSort
    {
        // Function to perform Heap Sort
        public void SortSalaries(int[] salaries)
        {
            int n = salaries.Length;

            // Step 1: Build Max Heap
            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(salaries, n, i);

            // Step 2: Extract elements from heap one by one
            for (int i = n - 1; i > 0; i--)
            {
                // Swap the root (largest) with the last element
                Swap(salaries, 0, i);

                // Reheapify the reduced heap
                Heapify(salaries, i, 0);
            }
        }

        // Function to heapify a subtree rooted at index `i`
        public void Heapify(int[] arr, int n, int i)
        {
            int largest = i; // Assume root is largest
            int left = 2 * i + 1; // Left child index
            int right = 2 * i + 2; // Right child index

            // If left child is larger than root
            if (left < n && arr[left] > arr[largest])
                largest = left;

            // If right child is larger than largest so far
            if (right < n && arr[right] > arr[largest])
                largest = right;

            // If largest is not root, swap and recursively heapify
            if (largest != i)
            {
                Swap(arr, i, largest);
                Heapify(arr, n, largest);
            }
        }

        // Function to swap two elements
        public void Swap(int[] arr, int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }

        // Function to print the array
        public void PrintArray(int[] salaries)
        {
            foreach (int salary in salaries)
                Console.Write(salary + " ");
            Console.WriteLine();
        }
    }
}
