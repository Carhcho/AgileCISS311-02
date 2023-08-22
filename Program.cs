using System;
using System.Collections.Generic;

namespace dropbox02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> allMovies = new List<Movie>();

            allMovies.Add(new NewRelease("Terminator 10", "Cesar Roncancio", 0));
            allMovies.Add(new NewRelease("WandaVision", "Michael Scott", 3));

            allMovies.Add(new Classic("Titanic", "Dicaprios Director", 1995, 95));
            allMovies.Add(new Classic("Terminator 1", "Cesar Roncancio", 1990, 100));
            allMovies.Add(new Classic("War", "USA President", 1940, 105));

            foreach(Movie m in allMovies)
            {
                Console.WriteLine("Tomorrow's price for new release:");
            }
            foreach(Movie m in allMovies)
            {
                if(m is NewRelease)
                {
                    NewRelease nm = (NewRelease)m;
                    nm.DaysInTheatre = nm.DaysInTheatre + 1;
                    Console.WriteLine($"{nm.Title} price will be {nm.DisplayPrice():C}");
                }
            }
            Console.ReadKey();
        }
    }
}
