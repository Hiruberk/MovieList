using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MovieListLab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Movie List Application!\n");
            Console.WriteLine("There are 20 movies in this list.");

            List<Movie> movies = new List<Movie>();

            //Animated Movies
            movies.Add(new Movie("Toy Story 4", "Animated"));
            movies.Add(new Movie("Inside Out", "Animated"));
            movies.Add(new Movie("Coco", "Animated"));
            movies.Add(new Movie("Zootopia", "Animated"));
            movies.Add(new Movie("Incredibles 2", "Animated"));

            //Drama Movies
            movies.Add(new Movie("Black Panther", "Drama"));
            movies.Add(new Movie("Parasite", "Drama"));
            movies.Add(new Movie("Knives Out", "Drama"));
            movies.Add(new Movie("Lady Bird", "Drama"));
            movies.Add(new Movie("Citizen Kane", "Drama"));

            //Horror Movies
            movies.Add(new Movie("The Exorcist", "Horror"));
            movies.Add(new Movie("Hereditary", "Horror"));
            movies.Add(new Movie("The Conjuring", "Horror"));
            movies.Add(new Movie("The Shining", "Horror"));
            movies.Add(new Movie("The Ring", "Horror"));

            //Sci-Fi Movies
            movies.Add(new Movie("2001: A Space Odyssey", "Sci-Fi"));
            movies.Add(new Movie("Aliens", "Sci-Fi"));
            movies.Add(new Movie("Blade Runner", "Sci-Fi"));
            movies.Add(new Movie("Interstellar", "Sci-Fi"));
            movies.Add(new Movie("Back to the Future", "Sci-Fi"));

            
            while (true)
            {
                Console.WriteLine("What category are your interested in? (Animated, Drama, Horror, Sci-Fi");



                //for (int i = 0; i < movies.Count; i++)
                //{
                //    Movie cinema = movies[i];
                //    Console.WriteLine($"Index: {i} | Title: {cinema.Title} | Genre: {cinema.Category}");
                //}

                Console.WriteLine("\nWould you like to look at another genre? (y/n)");
                if(Console.ReadLine().ToLower() == "n")
                {
                    break;
                }
            }
        }
    }
}
