using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubmissionOfInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which Question do you want to run, 1 to 11");
            int num = Convert.ToInt32(Console.ReadLine());

            ExecutionClass executionClass = new ExecutionClass();
            switch(num)
                {

                case 1:
                    executionClass.CallingAnimal();
                    break;

                case 2:
                    executionClass.CallingEmployee();
                    break;

                case 3:
                    executionClass.CallingVehicle();
                    break;

                case 4:
                    executionClass.CallingBook();
                    break;

                case 5:
                    executionClass.CallingDevice();
                    break;

                case 6:
                    //executionClass.CallingOrder();
                    break;

                case 7:
                    executionClass.CallingCourse();
                    break;
                case 8:
                    executionClass.CallingBankAccount();
                    break;

                case 9:
                    //executionClass.CallingBankAccount();
                    break;

                case 10:
                    executionClass.CallingRestaurantPerson();
                    break;

                case 11:
                    executionClass.CallingBaseVihicle();
                    break;

                    default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}
