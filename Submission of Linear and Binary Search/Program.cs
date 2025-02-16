using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submission_of_Linear_and_Binary_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExecutionClass executionClass = new ExecutionClass();
            Console.WriteLine("Which Question do you want to run 1 to 15");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    executionClass.CallingReverseString();
                    break;
                case 2:
                    executionClass.CallingRemoveDuplicates();
                    break;
                case 3:
                    executionClass.CallingConcatenateString();
                    break;
                case 4:
                    executionClass.Compare();
                    break;
                case 5:
                    executionClass.File();
                    break;
                case 6:
                    executionClass.Word();
                    break;
                case 7:
                    executionClass.Convertor();
                    break;
                case 8:
                    executionClass.UserInput();
                    break;
                case 9:
                    executionClass.LinearSearchProgram();
                    break;
                case 10:
                    executionClass.FindWord();
                    break;
                case 11:
                    executionClass.FindRotationPoint();
                    break;  
                case 12:
                    executionClass.CallingPeakElement();
                    break;
                case 13:
                    executionClass.CallingSortedMatrix();
                    break;
                case 14:
                    executionClass.CallingOccurance();
                    break;
                case 15:
                    executionClass.CallingSearchOperations();
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
            
        }
    }
}
