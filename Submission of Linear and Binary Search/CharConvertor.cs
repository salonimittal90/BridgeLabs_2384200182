using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submission_of_Linear_and_Binary_Search
{
    class CharConvertor
    {

        public static void ConvertByteStreamToCharStream(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Error: File not found.");
                return;
            }

            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))  // UTF-8 Encoding
                {
                    string content = sr.ReadToEnd();  // Read entire file
                    Console.WriteLine("File Content (as Characters):");
                    Console.WriteLine(content);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}