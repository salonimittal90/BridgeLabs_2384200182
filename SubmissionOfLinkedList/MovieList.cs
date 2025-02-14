using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListAssignment
{

    public class Movie
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public int Year { get; set; }
        public double Rating { get; set; }
        public Movie Next { get; set; }
        public Movie Prev { get; set; }

        public Movie(string title, string director, int year, double rating)
        {
            Title = title;
            Director = director;
            Year = year;
            Rating = rating;
            Next = null;
            Prev = null;
        }
    }

    public class MovieList
    {
        private Movie head;
        private Movie tail;

        public void AddMovieAtBeginning(string title, string director, int year, double rating)
        {
            Movie newMovie = new Movie(title, director, year, rating);
            if (head == null)
            {
                head = tail = newMovie;
            }
            else
            {
                newMovie.Next = head;
                head.Prev = newMovie;
                head = newMovie;
            }
        }

        public void AddMovieAtEnd(string title, string director, int year, double rating)
        {
            Movie newMovie = new Movie(title, director, year, rating);
            if (tail == null)
            {
                head = tail = newMovie;
            }
            else
            {
                tail.Next = newMovie;
                newMovie.Prev = tail;
                tail = newMovie;
            }
        }

        public void AddMovieAtPosition(string title, string director, int year, double rating, int position)
        {
            if (position <= 0)
            {
                AddMovieAtBeginning(title, director, year, rating);
                return;
            }
            Movie newMovie = new Movie(title, director, year, rating);
            Movie current = head;
            for (int i = 0; current != null && i < position - 1; i++)
            {
                current = current.Next;
            }
            if (current == null)
            {
                AddMovieAtEnd(title, director, year, rating);
                return;
            }
            newMovie.Next = current.Next;
            if (current.Next != null)
                current.Next.Prev = newMovie;
            current.Next = newMovie;
            newMovie.Prev = current;
        }

        public void RemoveMovie(string title)
        {
            Movie current = head;
            while (current != null)
            {
                if (current.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    if (current.Prev != null)
                        current.Prev.Next = current.Next;
                    else
                        head = current.Next;

                    if (current.Next != null)
                        current.Next.Prev = current.Prev;
                    else
                        tail = current.Prev;
                    return;
                }
                current = current.Next;
            }
        }

        public void SearchByDirectorOrRating(string director, double rating)
        {
            Movie current = head;
            while (current != null)
            {
                if (current.Director.Equals(director, StringComparison.OrdinalIgnoreCase) || current.Rating == rating)
                {
                    Console.WriteLine($"Title: {current.Title}, Director: {current.Director}, Year: {current.Year}, Rating: {current.Rating}");
                }
                current = current.Next;
            }
        }

        public void UpdateRating(string title, double newRating)
        {
            Movie current = head;
            while (current != null)
            {
                if (current.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    current.Rating = newRating;
                    return;
                }
                current = current.Next;
            }
        }

        public void DisplayMoviesForward()
        {
            Movie current = head;
            while (current != null)
            {
                Console.WriteLine($"Title: {current.Title}, Director: {current.Director}, Year: {current.Year}, Rating: {current.Rating}");
                current = current.Next;
            }
        }

        public void DisplayMoviesReverse()
        {
            Movie current = tail;
            while (current != null)
            {
                Console.WriteLine($"Title: {current.Title}, Director: {current.Director}, Year: {current.Year}, Rating: {current.Rating}");
                current = current.Prev;
            }
        }
    }

}
