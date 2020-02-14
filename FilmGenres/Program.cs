using System;
using System.Collections.Generic;
using System.Linq;

namespace FilmGenres
{
    class Program
    {
        static void Main(string[] args)
        {
            bool yes = true;
            while (yes)
            {
                Console.WriteLine("Enter the number below the film options to continue.");
                Console.WriteLine(" [   1   ]   [  2  ]   [  3  ]    [  4  ]    [  5   ]    [   6   ]");
                Console.WriteLine("  Animated    Drama     Horror     SciFi     List All     Add New");
                string input=Console.ReadLine();
                try
                {
                    //check for valid input and nav menu options
                    switch(input){
                        case "1":
                            //list all m in 1
                            List<Film> anim = new List<Film>
                            {
                              new Film("Spirited Away", "Animated"),
                              new Film("Waking Life", "Animated"),
                            };
                            View(anim);
                            break;
                        case "2":
                            foreach(Film drama in listAll)
                            {
                                if (drama.Category == "Drama")
                                {
                                Console.WriteLine(drama);
                                }
                                 
                            }
                           
                            break;
                        case "3":

                            break;
                        case "4":
                            break;
                        case "5":
                            //sends to view format in Film to print public list
                             View(listAll);
                            break;
                        case "6":
                            Console.WriteLine("Enter the Genre:");
                            string newG = Console.ReadLine();
                            Console.WriteLine("Enter the Title:");
                            string newT = Console.ReadLine();
                            Film userFilm = new Film{ Title = newT, Category = newG};
                            listAll.Add(userFilm);
                            View(listAll);
                    break;
                        default:
                            break;
                    };
                }
                catch
                {
                    //error message
                    Console.WriteLine("Sorry, please try a number 1-6");
                }
                //ask if user wants to return to menu or exit
            }
        }
        //display updated film options to console
        public static void View(List<Film> Genre)
        {
            Console.WriteLine("\t   Genre\t     Title\n*************************************************");
            foreach (Film m in Genre)
            {
                Console.WriteLine(m+"\n-\t-\t-\t-\t-\t-\t-");
            }
        }
        //sample film list
        public static List<Film> listAll = new List<Film>
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
    }
}
