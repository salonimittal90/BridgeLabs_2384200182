using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_s_Runtime_Analysis___Big_O_Notation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExecutionClass obj = new ExecutionClass();
            Console.WriteLine("Which Question do you want to run 1 to 5");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    obj.CallingTargetSearch();
                    break;
                case 2:
                    obj.CallingSortingComparison();
                    break;
                case 3:
                    obj.CallingStringConcatenation();
                    break;
                case 4:
                    obj.CallingFileReading();
                    break;
                case 5:
                    obj.CallingFibbonacciComparison();
                    break;
                case 0:
                    Console.WriteLine("Exiting program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice! Please select a valid option.");
                    break;
            }
        }


    }


}
   

