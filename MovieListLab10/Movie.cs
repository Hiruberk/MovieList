using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MovieListLab10
{
    class Movie
    {
        public string Title { get; set; }
        public string Category { get; set; }



        public Movie(string Title, string Category)
        {
            this.Title = Title;
            this.Category = Category;

        }



        public void PrintMovie()
        {
            Console.WriteLine("----------------Movie List-------------");
            Console.WriteLine($"Title: {Title}    Genre: {Category}");
            Console.WriteLine("---------------------------------------");
        }

       //public List<movies> FindCategory(string Category)
       // {

       // } 

    }
}
