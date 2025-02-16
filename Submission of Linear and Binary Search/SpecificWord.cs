using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submission_of_Linear_and_Binary_Search
{
    class SpecificWord
    {
        public static string FindSentenceWithWord(string[] sentences, string word)
        {
            word = word.ToLower();  // Convert word to lowercase for case-insensitive search

            foreach (string sentence in sentences)  // Linear Search
            {
                if (sentence.ToLower().Contains(word))
                {
                    return sentence;  // First sentence containing the word found
                }
            }
            return "Not Found";  // No sentence contains the word
        }

    }

}