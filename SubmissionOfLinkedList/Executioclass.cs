using LinkedListAssignment;
using System;
using static SubmissionOfLinkedList.StudentNode;

namespace SubmissionOfLinkedList
{
    internal class Executioclass
    {
        public void CallingSampleStudent()

        {
            Student obj = new Student();
            obj.AddFirst(1, "saloni", 22, 'A');
            obj.AddLast(3, "Jyoti", 12, 'A');
            obj.AddAtSpecific(2, "Tanya", 14, 'A', 2);
            obj.DisplayStudent();
            obj.DeleteRollno(2);
            obj.DisplayStudent();
            obj.DeleteRollno(2);
           obj.SearchByRollno(4);
            obj.UpdateGrade(1, 'B');
        }
        public void CallingMovieManagement()
        {
            MovieList movieList = new MovieList();
         movieList.AddMovieAtEnd("Inception", "Christopher Nolan", 2010, 8.8);
         movieList.AddMovieAtBeginning("Interstellar", "Christopher Nolan", 2014, 8.6);
         movieList.AddMovieAtPosition("The Matrix", "Lana Wachowski", 1999, 8.7, 1);

         Console.WriteLine("Movies in Forward Order:");
         movieList.DisplayMoviesForward();

         Console.WriteLine("\nMovies in Reverse Order:");
         movieList.DisplayMoviesReverse();

         Console.WriteLine("\nUpdating rating of Inception to 9.0");
         movieList.UpdateRating("Inception", 9.0);

         Console.WriteLine("\nSearching for movies directed by Christopher Nolan:");
         movieList.SearchByDirectorOrRating("Christopher Nolan", 0);

         Console.WriteLine("\nRemoving 'The Matrix' from the list");
         movieList.RemoveMovie("The Matrix");

         Console.WriteLine("\nFinal Movie List:");
         movieList.DisplayMoviesForward();
        }

        public void CallingTaskScheduler()
        {
            TaskScheduler scheduler = new TaskScheduler();
            scheduler.AddAtEnd(1, "Task A", 2, DateTime.Now.AddDays(1));
            scheduler.AddAtBeginning(2, "Task B", 1, DateTime.Now.AddDays(2));
            scheduler.AddAtEnd(3, "Task C", 3, DateTime.Now.AddDays(3));

            Console.WriteLine("All Tasks:");
            scheduler.DisplayTasks();

            Console.WriteLine("\nViewing Current Task:");
            scheduler.ViewCurrentTask();

            Console.WriteLine("\nSearching for tasks with Priority 2:");
            scheduler.SearchByPriority(2);

            Console.WriteLine("\nRemoving Task with ID 2");
            scheduler.RemoveTask(2);
            scheduler.DisplayTasks();
        }

        public void CallingInventoryManagement()
        {
            InventoryManagementSystem obj = new InventoryManagementSystem();
             obj.AddFirst("Daal", 101, 1, 100.0);
             obj.AddAtSpecific("Chips", 103, 2, 20.0, 2);
             obj.AddLast("Rice", 102, 1, 50.0);
           obj.Displayitem();
             obj.RemoveId(103);
           obj.Displayitem();
           obj.SearchItem(102, "Rice");
            obj.SortInventory("Rice", true);
        }

        public void CallingLibraryManagement()
        {
              LibraryManagementSystem library = new LibraryManagementSystem();
              library.AddAtEnd(1, "Book A", "Author X", "Fiction", true);
              library.AddAtBeginning(2, "Book B", "Author Y", "Sci-Fi", false);
              library.AddAtEnd(3, "Book C", "Author Z", "History", true);

              Console.WriteLine("All Books (Forward Order):");
              library.DisplayBooksForward();

              Console.WriteLine("\nUpdating Availability of Book ID 2 to Available");
              library.UpdateAvailability(2, true);
              library.DisplayBooksForward();

              Console.WriteLine("\nSearching for Book 'Book C':");
              library.SearchBook("Book C");

              Console.WriteLine("\nTotal Number of Books: " + library.CountBooks());

              Console.WriteLine("\nRemoving Book ID 1");
              library.RemoveBook(1);
              library.DisplayBooksForward();
        }

        public void CallingRoundRobinSchedulingAlgorithm()
        {
            RoundRobinSchedulingAlgorithm scheduler2 = new RoundRobinSchedulingAlgorithm();
             scheduler2.AddProcess(1, 10, 1);
             scheduler2.AddProcess(2, 5, 2);
             scheduler2.AddProcess(3, 8, 1);
             scheduler2.AddProcess(4, 12, 3);

             Console.WriteLine("Initial Process Queue:");
             scheduler2.DisplayProcesses();

             Console.WriteLine("\nStarting Round Robin Scheduling with Time Quantum = 4");
             scheduler2.RoundRobinScheduling(4);
        }

        public void CallingSocialMediaFriendConnections()
        {
            SocialMediaFriendConnections smfc = new SocialMediaFriendConnections();

            // Adding Users
            smfc.AddUser(1, "Alice", 25);
            smfc.AddUser(2, "Bob", 28);
            smfc.AddUser(3, "Charlie", 22);
            smfc.AddUser(4, "David", 30);

            // Adding Friend Connections
            smfc.AddFriend(1, 2);
            smfc.AddFriend(1, 3);
            smfc.AddFriend(2, 4);

            // Display Friends
            smfc.DisplayFriends(1);
            smfc.DisplayFriends(2);

            // Find Mutual Friends
            smfc.FindMutualFriends(1, 4);
            smfc.FindMutualFriends(1, 3);

            // Remove Friend Connection
            Console.WriteLine("\nRemoving Bob from Alice's friends...");
            smfc.RemoveFriend(1, 2);
            smfc.DisplayFriends(1);
            smfc.DisplayFriends(2);

            // Count Friends of Each User
            Console.WriteLine("\nFriend Counts:");
            smfc.CountFriends();

            Console.ReadLine();
        
    }
        public void CallingUndo_RedoFunctionalityforTextEditor()
        {
            Undo_RedoFunctionalityforTextEditor textEditor = new Undo_RedoFunctionalityforTextEditor();
            textEditor.AddState("Hello");
            textEditor.AddState("Hello, World");
            textEditor.AddState("Hello, World!");

            textEditor.DisplayCurrentState();
            textEditor.Undo();
            textEditor.Undo();
            textEditor.Redo();
        }

        public void CallingOnlineTicketReservationSystem()
        {
            OnlineTicketReservationSystem ticketSystem = new OnlineTicketReservationSystem();
            ticketSystem.AddTicket(1, "Alice", "Inception", "A1");
            ticketSystem.AddTicket(2, "Bob", "Interstellar", "B2");
            ticketSystem.AddTicket(3, "Charlie", "Dunkirk", "C3");

            Console.WriteLine("\nAll Booked Tickets:");
            ticketSystem.DisplayTickets();

            Console.WriteLine("\nSearch for tickets by movie name 'Interstellar':");
            ticketSystem.SearchTicket("Interstellar");

            Console.WriteLine("\nTotal Tickets: " + ticketSystem.TotalTickets());

            Console.WriteLine("\nRemoving Ticket ID 2:");
            ticketSystem.RemoveTicket(2);

            Console.WriteLine("\nUpdated Ticket List:");
            ticketSystem.DisplayTickets();
        }
    }

}
