using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster_Lab
{
    class Blockbuster
    {

        public static void CheckOut()
        {
            Console.WriteLine("Welcome to the GC Blockbuster!");
            PrintMovies();
            Console.WriteLine($"Please select a movie you want to watch: (1 - {ListMovies().Count})");
            int input = int.Parse(Console.ReadLine());
            int i = 0;
            foreach  (Movie movie in ListMovies())
            {
                i++;
                if (input == i)
                {
                    movie.PrintInfo();
                    Console.WriteLine("\n Do you want to watch the movie? y/n");
                    string confirm = Console.ReadLine().ToLower().Trim();
                    if (confirm == "y")
                    {
                        movie.PrintScenes();
                        Console.WriteLine("Select a scene to watch: ");
                        int choice = int.Parse(Console.ReadLine());
                        //Needs to take in a choice from the user and display their selection of scenes
                    }
                }
            }
        }

        public static void PrintMovies()
        {
            List<Movie> movies = ListMovies();
            int i = 0;
            foreach (Movie a in movies)
            {
                i++;
                Console.WriteLine($"{i}. {a.Title}");

            }
        }

        public static List<Movie> ListMovies()
        {
            return new List<Movie> {
            new DVD("Home Alone", "Drama", 90, new List<string>() { "Keep the change you filthy animal", "Family reunited", "Fights off sticky bandits" }),
            new DVD("The Big Lebowski", "Drama", 110, new List<string>() { "Purchases milk with a check", "Mark it zero", "Burgular pees on rug" }),
            new DVD("The Sandlot", "Drama", 115, new List<string>() { "First encounter with the sandlot", "Squints kisses the lifeguard", "Goes to the fair" }),
            new VHS("Little Rascals", "Comedy", 75, new List<string>() { "Board meeting", "She loves me/she loves me not", "Baseball game" }),
            new VHS("Lion King", "Drama", 90, new List<string>() { "Mufasa dies", "Simba makes new friends in the jungle", "Becomes king" }),
            new VHS("Little Mermaid", "Romance", 85, new List<string>() { "Finds a Dinglehopper", "Speaks with Ursula", "Lives happily ever after" }),
            };
        }
        

    } 
}