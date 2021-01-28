using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MovieListLab10
{
    class Movie
    {
        public string Title { get; set; }//Declaring title property 
        public string Category { get; set; }//Declaring category or genre property



        public Movie(string Title, string Category)
        {
            this.Title = Title;
            this.Category = Category;
            //constructing the object, so it may be used in the list in the main method
        }
    }
}
