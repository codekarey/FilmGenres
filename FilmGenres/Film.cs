using System;
using System.Collections.Generic;
using System.Text;

namespace FilmGenres
{
    class Film
    {
        //data required to create film
        private string title;
        private string category;

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public string Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }
        //film item
        public Film(string _title, string _category)
        {
            Title = _title;
            Category = _category;
        }
        //list of flims with genres
        public static void All()
        {
            List<Film> listAll = new List<Film>
            {
            new Film("Spirited Away", "Animated"),
            new Film("Waking Life", "Animated"),
            new Film("Eternal Sunshine of the Spotless Mind", "Drama"),
            new Film("Pay It Forward", "Drama"),
            new Film("IT", "Horror"),
            new Film("Chucky", "Horror"),
            new Film("The Gremlins", "Horror"),
            new Film("The Matrix", "Scifi"),
            new Film("Back To The Future", "Scifi"),
            new Film("Shawn Of The Dead", "Scifi"),
            };
            //list all films a -> z
            //  (listAll.OrderBy(x=>x)).ToList();
            foreach (Film azList in listAll)
            {
                Console.WriteLine(azList);
            }
        }

    }
}
