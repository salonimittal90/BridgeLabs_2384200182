using LinkedListAssignment;
using System;
using static SubmissionOfLinkedList.StudentNode;

namespace SubmissionOfLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Executioclass executionClass = new Executioclass();
            Console.WriteLine("Which Question you want to run 1 to 9");
            int num = Convert.ToInt32(Console.ReadLine());
            switch(num)
            {
                case 1:
                    executionClass.CallingSampleStudent();
                    break;

                    case 2:
                    executionClass.CallingMovieManagement();
                    break;

                    case 3:
                    executionClass.CallingTaskScheduler();
                        break;
                case 4:
                    executionClass.CallingInventoryManagement();
                        break;

                    case 5:
                    executionClass.CallingLibraryManagement();
                    break;
                    case 6:
                    executionClass.CallingRoundRobinSchedulingAlgorithm();
                      break; ;
                    case 7:
                    executionClass.CallingSocialMediaFriendConnections();
                   break;

                    case 8:
                    executionClass.CallingUndo_RedoFunctionalityforTextEditor();
                    break;

                    case 9:
                    executionClass.CallingOnlineTicketReservationSystem();
                    break;

                    default:
                    {
                        Console.WriteLine("invalid choice");
                        break;
                    }

            }






        }
    }
}
