using System;

namespace FilmGenres
{
    class Program
    {
        static void Main(string[] args)
        {
            bool yes = true;
            while (true)
            {
                Console.WriteLine("Enter the number below the film options to continue.");
                Console.WriteLine(" [   1   ]   [  2  ]   [  3  ]    [  4  ]    [  5   ]    [   6   ]");
                Console.WriteLine("  Animated    Drama     Horror     SciFi     List All     Add New");
                try
                {
                    //check for valid input
                    int userPicked = int.Parse(Console.ReadLine());
                    //menu options
                    switch{
                        case "1":
                            //list all m in 1
                            break;
                        case "2":
                            break;
                        case "3":
                            break;
                        case "4":
                            break;
                        case "5":
                            break;
                        case "6":
                            break;
                        default:
                            break;
                    }
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
            foreach (Film m in Genre)
            {
                Console.WriteLine(m);
            }
        }

    }
}
