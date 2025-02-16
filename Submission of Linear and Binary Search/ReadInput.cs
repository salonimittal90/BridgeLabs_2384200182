using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submission_of_Linear_and_Binary_Search
{
    class ReadInput
    {

        public static void WriteUserInputToFile(string filePath)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath, true))  // 'true' to append data
                {
                    Console.WriteLine("Enter text (type 'exit' to stop):");

                    while (true)
                    {
                        string input = Console.ReadLine();
                        if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                            break;

                        sw.WriteLine(input);  // Write input to file
                    }
                }

                Console.WriteLine($"User input has been saved to {filePath}");
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }

}