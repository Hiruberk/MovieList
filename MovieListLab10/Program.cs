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

            List<string> genres = new List<string>();

            foreach  (Movie c in movies)
            {
                if (!genres.Contains(c.Category))
                {
                    genres.Add(c.Category);
                }
            }

                        
            while (true)
            {
                Console.WriteLine("What category are your interested in?");
                Console.WriteLine("Please enter the corresponding number for your category");

                for (int i = 0; i < genres.Count; i++)
                {
                    Console.WriteLine($"{i+1}) {genres[i]}");
                }

                int option = VoidCheck(Console.ReadLine()) - 1;

                string searchGenre = string.Empty;
                searchGenre = genres[option];
                List<Movie> returnList = new List<Movie>();

                Console.WriteLine($"Here are your {searchGenre} movies");
                foreach (Movie m in movies)
                {
                    if (m.Category == searchGenre)
                    {
                        returnList.Add(m);
                    }
                }

                IEnumerable<Movie> sortedReturnList = returnList.OrderBy(o => o.Title);

                foreach (Movie m in sortedReturnList)
                {
                    Console.WriteLine($"Title: {m.Title}\nGenre: {m.Category}");
                    Console.WriteLine("*******************************");
                }


                Console.WriteLine("\nWould you like to look at another genre? (y/n)");
                if(Console.ReadLine().ToLower() == "n")
                {
                    break;
                }
            }
        }

        public static int VoidCheck(string input)
        {
            int integer;
            while (true)    
            {
                if (Int32.TryParse(input, out integer))
                {
                    return integer;
                }
                else
                {
                    Console.WriteLine("Please enter the corresponding number for your category");
                    input = Console.ReadLine();
                }
            }
        }


    }
}
