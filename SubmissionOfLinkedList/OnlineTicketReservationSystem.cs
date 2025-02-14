using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListAssignment
{

    // Node representing a booked ticket in the reservation system
    class TicketNode
    {
        public int TicketID;
        public string CustomerName;
        public string MovieName;
        public string SeatNumber;
        public DateTime BookingTime;
        public TicketNode Next;

        public TicketNode(int ticketID, string customerName, string movieName, string seatNumber)
        {
            TicketID = ticketID;
            CustomerName = customerName;
            MovieName = movieName;
            SeatNumber = seatNumber;
            BookingTime = DateTime.Now;
            Next = null;
        }
    }

    class OnlineTicketReservationSystem
    {
        private TicketNode head = null;
        private TicketNode tail = null;
        private int count = 0;

        // Add a new ticket reservation at the end
        public void AddTicket(int ticketID, string customerName, string movieName, string seatNumber)
        {
            TicketNode newTicket = new TicketNode(ticketID, customerName, movieName, seatNumber);
            if (head == null)
            {
                head = newTicket;
                tail = newTicket;
                tail.Next = head;
            }
            else
            {
                tail.Next = newTicket;
                newTicket.Next = head;
                tail = newTicket;
            }
            count++;
        }

        // Remove a ticket by Ticket ID
        public void RemoveTicket(int ticketID)
        {
            if (head == null)
            {
                Console.WriteLine("No tickets to remove.");
                return;
            }

            TicketNode current = head, prev = null;
            do
            {
                if (current.TicketID == ticketID)
                {
                    if (current == head)
                    {
                        head = head.Next;
                        tail.Next = head;
                    }
                    else
                    {
                        prev.Next = current.Next;
                        if (current == tail)
                            tail = prev;
                    }
                    count--;
                    Console.WriteLine("Ticket removed successfully.");
                    return;
                }
                prev = current;
                current = current.Next;
            } while (current != head);

            Console.WriteLine("Ticket ID not found.");
        }

        // Display all current tickets
        public void DisplayTickets()
        {
            if (head == null)
            {
                Console.WriteLine("No tickets booked.");
                return;
            }

            TicketNode temp = head;
            do
            {
                Console.WriteLine($"Ticket ID: {temp.TicketID}, Customer: {temp.CustomerName}, Movie: {temp.MovieName}, Seat: {temp.SeatNumber}, Time: {temp.BookingTime}");
                temp = temp.Next;
            } while (temp != head);
        }

        // Search for a ticket by Customer Name or Movie Name
        public void SearchTicket(string keyword)
        {
            if (head == null)
            {
                Console.WriteLine("No tickets available.");
                return;
            }

            TicketNode temp = head;
            bool found = false;
            do
            {
                if (temp.CustomerName.Contains(keyword) || temp.MovieName.Contains(keyword))
                {
                    Console.WriteLine($"Ticket ID: {temp.TicketID}, Customer: {temp.CustomerName}, Movie: {temp.MovieName}, Seat: {temp.SeatNumber}, Time: {temp.BookingTime}");
                    found = true;
                }
                temp = temp.Next;
            } while (temp != head);

            if (!found)
                Console.WriteLine("No matching tickets found.");
        }

        // Calculate total number of booked tickets
        public int TotalTickets()
        {
            return count;
        }
    }
}
