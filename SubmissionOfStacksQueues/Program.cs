using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubmissionOfStacksQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExecutionClass executionClass = new ExecutionClass();

            Console.WriteLine("which Question do you want to run 1 to 10");
            int num = Convert.ToInt32(Console.ReadLine());

            switch(num)
            {
               
            case 1:
                    executionClass.CallingQueueUsingStacks();
                    break;

            case 2:
                    executionClass.CallingStackSorter();
                    break;

                case 3:
                    executionClass.CallingstockSpan();
                    break;

                case 4:
                    executionClass.CallingMaxSlidingWindow();
                    break;
                case 5:
                    executionClass.CallingCircularTour();
                    break;

                case 6:
                    executionClass.CallingZeroSumSubarrays();
                     break;

                    case 7:
                    executionClass.CallingPairWithGivenSum();
                    break;

                case 8:
                    executionClass.CallingLongestConsecutiveSequence();
                    break;


                    case 9:
                    executionClass.CallingCustomHashMap();
                    break;

                    case 10:
                    executionClass.CallingTwoSumSolution();
                    break;

                default:
                    {
                        Console.WriteLine("Invalid choice");
                        break;
                    }

            }
        }
    }
}
   
    
       
   
        

   

    