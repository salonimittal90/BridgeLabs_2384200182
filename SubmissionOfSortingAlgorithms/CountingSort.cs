using System;

namespace SubmissionOfSortingAlgorithms
{
    class CountingSort
    {
        // Function to perform Counting Sort
        public void SortStudentAges(int[] ages, int minAge, int maxAge)
        {
            int range = maxAge - minAge + 1; // Age range (10 to 18)
            int[] count = new int[range]; // Count array
            int[] output = new int[ages.Length]; // Output sorted array

            // Step 1: Count the occurrences of each age
            for (int i = 0; i < ages.Length; i++)
                count[ages[i] - minAge]++;

            // Step 2: Compute cumulative frequencies
            for (int i = 1; i < range; i++)
                count[i] += count[i - 1];

            // Step 3: Place elements in their correct positions
            for (int i = ages.Length - 1; i >= 0; i--)
            {
                output[count[ages[i] - minAge] - 1] = ages[i];
                count[ages[i] - minAge]--; // Decrease count
            }

            // Copy sorted array back to original array
            for (int i = 0; i < ages.Length; i++)
                ages[i] = output[i];
        }

        // Function to print the array
        public void PrintArray(int[] ages)
        {
            foreach (int age in ages)
                Console.Write(age + " ");
            Console.WriteLine();
        }
    }
}