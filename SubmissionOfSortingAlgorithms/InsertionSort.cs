using System;
namespace SubmissionOfSortingAlgorithms
{
    public class InsertionSort
    {
        // Function to perform Insertion Sort
       public static void SortEmployeeIDs(int[] empIDs)
        {
            int n = empIDs.Length;

            for (int i = 1; i < n; i++)
            {
                int key = empIDs[i]; // Pick the current element
                int j = i - 1;

                // Shift elements of sorted part to find the correct position for key
                while (j >= 0 && empIDs[j] > key)
                {
                    empIDs[j + 1] = empIDs[j]; // Move element one step ahead
                    j--; // Move to the previous element
                }

                empIDs[j + 1] = key; // Insert key at the correct position
            }
        }

        // Function to print the array
      public  static void PrintArray(int[] empIDs)
        {
            foreach (int id in empIDs)
            {
                Console.Write(id + " ");
            }
            Console.WriteLine();
        }
    }

    }
