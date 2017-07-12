using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> fayNumbers = new List<int>();
            //fayNumbers.Add(7);
            //fayNumbers.Add(25);
            //fayNumbers.Add(30);

            //foreach(int number in fayNumbers)
            //{
            //    Console.WriteLine(number);


            //}
            // .Count for Lists = .Length for Arrays
            // Console.WriteLine(fayNumbers.Count);
            //List<string> books = new List<string>{"Cat in the Hat" ,"Toad and Frog" ,"Grren eggs and Ham" };
            //Console.WriteLine(books[0]);
            //books.Insert(0, "Horton hears a Who");
            //Console.WriteLine(books[0]);


            //List<string> animals = new List<string>();
            //animals.Add("Duck");
            //animals.Add("Tiger");
            //animals.Add("Human");
            //animals.Add("Rockapotamus");
            //foreach (string animal in animals)
            //{
            //    Console.WriteLine(animal);
            //}

            //List<bool> rain = new List<bool> { true, false, false, true, false };

            //foreach (bool forcast in rain)
            //{
            //    if (forcast == true)
            //    {
            //        Console.WriteLine("Better bring an umbrella.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No rain today, enjoy the sun!");
            //    }

            //}

            //    List<string> favFooods = new List<string> { "Pizza", "Lo Mian", "fish", "Sushi Maki", "Unagi" };

            //    if(favFooods.Contains("fish"))
            //    {
            //        Console.WriteLine("I like fish too!");
            //    }

            //List<int> numbersList = new List<int>{ 1, 23, 9, 77, 922, 6, 32, 63, 14, 5 };
            //if(numbersList.Contains (23))
            //{
            //    numbersList.Remove (23);
            //    Console.WriteLine("removeing 23");
            //}
            //if (numbersList.Contains(77))
            //{
            //    numbersList.Remove(77);
            //    Console.WriteLine("removeing 77");
            //}
            //if (numbersList.Contains(15))
            //{
            //    numbersList.Remove(15);
            //    Console.WriteLine("removeing 15");
            //}
            //Console.WriteLine("Also remoeing 6 and 32");
            //numbersList.Remove(6);
            //numbersList.Remove(32);
            //foreach (int number in numbersList)
            //{
            //    Console.WriteLine(number);
            //}
            List<string> movies = new List<string> {"jay and silent bob", "mr. bill" };
            bool quite = false;
            do
            {
                Console.WriteLine("Please enter a movie so we can look thourgh our stock.\n type esc to quite.");
                string responseMovie = Console.ReadLine().ToLower();

                if (movies.Contains(responseMovie))
                {
                    Console.WriteLine("We got it!");
                }
                if (responseMovie == "esc")
                {
                    quite = true;
                    Console.WriteLine("Movies being ordered and Movies we have:");
                    foreach(string movie in movies)
                    {
                        Console.WriteLine(movie);
                    }
                }
                else
                {
                    Console.WriteLine("We are going to order that for you, hold tight.");
                    movies.Add(responseMovie);
                }
                
            }
            while (quite == false);
        }
    }
}
