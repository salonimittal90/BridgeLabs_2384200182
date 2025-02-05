using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OopsKeywordLevel1
{
    internal class Program
    {
        static void Main()
        {

            Console.WriteLine("Enter the number ");
            Console.WriteLine("which Question do you wan to run from 1 to 7");
            int ques = Convert.ToInt32(Console.ReadLine());
            ExecutionClass executionClasses =  new ExecutionClass();

            switch (ques)
            {
                case 1:
                    executionClasses.CallingBankAccount();
                    break;


                case 2:
                    executionClasses.CallingLibraryManagement();
                    break;


                case 3:
                    executionClasses.CallingEmployeeManagement();
                    break;

                case 4:
                    executionClasses.CallingShoppingCart();
                    break;


                case 5:
                    executionClasses.CallingUniversityManagement(); 
                    break;  

                case 6:
                    executionClasses.CallingVehileRegistration();
                    break;

                case 7:
                    executionClasses.CallingHospitalManagement();
                    break;
                
                    default:
                    Console.WriteLine("Enter the valid no. ");
                    break;


            }
        }
    }
}
