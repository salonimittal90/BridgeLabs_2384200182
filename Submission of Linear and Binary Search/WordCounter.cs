using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submission_of_Linear_and_Binary_Search
{
    class WordCounter
    {
        public static int CountWordOccurrences(string filePath, string wordToFind)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Error: File not found.");
                return -1;
            }

            int count = 0;
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] words = line.Split(new char[] { ' ', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string word in words)
                        {
                            if (word.Equals(wordToFind, StringComparison.OrdinalIgnoreCase))
                            {
                                count++;
                            }
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                return -1;
            }

            return count;
        }
    }
}