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

            List<string> favFooods = new List<string> { "Pizza", "Lo Mian", "Sushi Maki", "Unagi" };

            if(favFooods.Contains("fish"))
            {
                Console.WriteLine("I like fish too!");
            }
        }
    }
}
