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

            List<Movie> movies = new List<Movie>();//Intializing my movie list full of my object Movie class

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

            List<string> genres = new List<string>();//Creating an empty string list of only the categories, allows the option to expand the genre selection indefinetly

            foreach  (Movie c in movies)
            {
                if (!genres.Contains(c.Category))//Insures that no duplicates are entered into the string list.
                {
                    genres.Add(c.Category);
                }
            }

                        
            while (true)//Break is down below this is to allow a continue y/n loop
            {
                Console.WriteLine("What category are your interested in?");
                Console.WriteLine("Please enter the corresponding number for your category");

                for (int i = 0; i < genres.Count; i++)
                {
                    Console.WriteLine($"{i+1}) {genres[i]}");//Prints out the list of generes with an associated number for them to select.
                }                       // The +1 is so the user doesn't wonder why 0 was an option on a list.

                int option = ValidCheck(Console.ReadLine(), 0, (genres.Count-1)) - 1;//insures that the user gives a number to the corresponding genre and it is in the range.

                string searchGenre = string.Empty;
                searchGenre = genres[option];//captures the genre they picked.
                List<Movie> returnList = new List<Movie>();//Declares the returnlist that we will put the specific movies with the matching user selected genre

                Console.WriteLine($"Here are your {searchGenre} movies");
                foreach (Movie m in movies)
                {
                    if (m.Category == searchGenre)
                    {
                        returnList.Add(m);//Creates the list of returned movies
                    }
                }

                IEnumerable<Movie> sortedReturnList = returnList.OrderBy(o => o.Title);//Sorts the objected oriented list alphabetically by the Title.

                foreach (Movie m in sortedReturnList)
                {
                    Console.WriteLine($"Title: {m.Title}\nGenre: {m.Category}");//Prints the sorted list of the user selected genre.
                    Console.WriteLine("*******************************");
                }


                Console.WriteLine("\nWould you like to look at another genre? (y/n)");//continue loop referenced above.
                if(Console.ReadLine().ToLower() == "n")
                {
                    break;
                }
            }
        }

        /// <summary>
        /// Checks that that the user enters a valid entry that will not throw an error.
        /// Enter a string to convert to int from Console.ReadLine() and a min and max inclusive range.
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Returns a valid integer that is inbetween the given min and max range.</returns>
        public static int ValidCheck(string input, int min, int max)
        {
            int integer;
            while (true)    
            {
                if (Int32.TryParse(input, out integer))//Checks if it can be converted to a number
                {
                    if (integer >= min && integer <= max)//Checks that it is within the given range
                    {
                        return integer;// returns a valid integer
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number that is on the list!\n");//requires them to keep trying until they give a valid entry
                        input = Console.ReadLine();
                    }

                }
                else
                {
                    Console.WriteLine("Please enter the corresponding number for your category.\n");//requires them to keep trying until they give a valid entry
                    input = Console.ReadLine();
                }
            }
        }


    }
}
