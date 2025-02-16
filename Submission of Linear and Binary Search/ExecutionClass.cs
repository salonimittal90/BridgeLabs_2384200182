using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submission_of_Linear_and_Binary_Search
{
    internal class ExecutionClass
    {
        public void CallingReverseString()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            string reversedString = ReverseString.Reverse(input);

            Console.WriteLine("Reversed String: " + reversedString);
        }

        public void CallingRemoveDuplicates()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            string result = RemoveDuplicates.RemoveDuplicateCharacters(input);

            Console.WriteLine("String after removing duplicates: " + result);

        }
        public void CallingConcatenateString()
        {
            string[] words = { "Hello", "this", "is", "a", "test" };

            string result = ConcatenateString.Concatenate(words);

            Console.WriteLine("Concatenated String: " + result);
        }

        public void Compare()
        {
            Console.Write("Enter number of iterations: ");
            int iterations = int.Parse(Console.ReadLine());

            ComparePerformance.Compare(iterations);
        }
        public void File()
        {
            Console.Write("Enter file path: ");
            string filePath = Console.ReadLine();

            ReadFile.ReadLineByLine(filePath);
        }
        public void Word()
        {

            Console.Write("Enter file path: ");
            string filePath = Console.ReadLine();

            Console.Write("Enter word to count: ");
            string wordToFind = Console.ReadLine();

            int result = WordCounter.CountWordOccurrences(filePath, wordToFind);

            if (result != -1)
            {
                Console.WriteLine($"The word '{wordToFind}' appears {result} times in the file.");
            }
        }

        public void Convertor()
        {
            Console.Write("Enter file path: ");
            string filePath = Console.ReadLine();

            CharConvertor.ConvertByteStreamToCharStream(filePath);
        }
        public void UserInput()
        {
            Console.Write("Enter file path to save input: ");
            string filePath = Console.ReadLine();

            ReadInput.WriteUserInputToFile(filePath);
        }

        public void LinearSearchProgram()
        {
            Console.Write("Enter array elements separated by space: ");
            string input = Console.ReadLine();
            int[] arr = Array.ConvertAll(input.Split(), int.Parse);  // Convert input to int array

            int firstNegative = LinearSearch.FindFirstNegative(arr);

            if (firstNegative != -1)
                Console.WriteLine($"First negative number: {firstNegative}");
            else
                Console.WriteLine("No negative number found in the array.");
        }

        public void FindWord()
        {
            Console.Write("Enter the number of sentences: ");
            int n = int.Parse(Console.ReadLine());

            string[] sentences = new string[n];
            Console.WriteLine("Enter the sentences:");
            for (int i = 0; i < n; i++)
            {
                sentences[i] = Console.ReadLine();
            }

            Console.Write("Enter the word to search: ");
            string word = Console.ReadLine();

            string result = SpecificWord.FindSentenceWithWord(sentences, word);

            if (result != "Not Found")
                Console.WriteLine($"First sentence containing '{word}': {result}");
            else
                Console.WriteLine("No sentence contains the given word.");
        }

        public void FindRotationPoint()
        {
            Console.Write("Enter array elements (space-separated): ");
            string input = Console.ReadLine();
            int[] arr = Array.ConvertAll(input.Split(), int.Parse);

            int rotationIndex = RotationPoint.FindRotationPoint(arr);
            Console.WriteLine($"Rotation Point (Index of Smallest Element): {rotationIndex}");

        }

        public void CallingPeakElement()
        {
            Console.Write("Enter array elements (space-separated): ");
            string input = Console.ReadLine();
            int[] arr = Array.ConvertAll(input.Split(), int.Parse);

            int peakIndex = PeakElement.FindPeakElement(arr);
            Console.WriteLine($"Index of Peak Element: {peakIndex}");
            Console.WriteLine($"Peak Element: {arr[peakIndex]}");
        }

        public void CallingSortedMatrix()
        {
            int[,] matrix = {
            { 1, 3, 5, 7 },
            { 10, 11, 16, 20 },
            { 23, 30, 34, 60 }
        };

            Console.Write("Enter target value to search: ");
            int target = int.Parse(Console.ReadLine());

            if (SortedMatrix.SearchMatrix(matrix, target, out int row, out int col))
            {
                Console.WriteLine($"Target found at position: ({row}, {col})");
            }
            else
            {
                Console.WriteLine("Target not found in the matrix.");
            }
        }

        public void CallingOccurance()
        {
            Console.Write("Enter sorted array elements (space-separated): ");
            string input = Console.ReadLine();
            int[] arr = Array.ConvertAll(input.Split(), int.Parse);

            Console.Write("Enter target element: ");
            int target = int.Parse(Console.ReadLine());

            int firstIndex = Occurance.FindFirstOccurrence(arr, target);
            int lastIndex = Occurance.FindLastOccurrence(arr, target);

            if (firstIndex == -1)
            {
                Console.WriteLine("Element not found in the array.");
            }
            else
            {
                Console.WriteLine($"First occurrence index: {firstIndex}");
                Console.WriteLine($"Last occurrence index: {lastIndex}");
            }
        }
        public void CallingSearchOperations()
        {
            int[] arr = { 3, 4, -1, 1, 2, 6 }; // Unsorted array
            Console.WriteLine("First Missing Positive: " + SearchOperations.FindFirstMissingPositive(arr));

            // Sorting the array for Binary Search
            Array.Sort(arr);
            Console.WriteLine("Sorted Array: " + string.Join(", ", arr));

            int target = 4;
            int index = SearchOperations.BinarySearch(arr, target);
            Console.WriteLine("Index of " + target + ": " + index);
        }
    }
}