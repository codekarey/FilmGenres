using System;
using System.Collections.Generic;
using System.Text;

namespace FilmGenres
{
    public class Film
    {
        //data required to create film
        private string title;
        private string category;

        public string Title { get => title; set => title = value; }
        public string Category{ get => category; set => category = value; }

        public Film()
        {

        }
        public Film(string title, string category)
        {
            Title = title;
            Category = category;
        }

        //orders how info is printed
        public override string ToString()
        {
            return $"|\t{Category}\t|\t{Title}\t";
        }
    }
}
