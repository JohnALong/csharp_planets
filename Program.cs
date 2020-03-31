using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> rockyPlanets = new List<string>();
            List<string> planetList = new List<string>(){"Mercury", "Mars"};
            List<string> lastPlanets = new List<string>(){"Uranus", "Neptune"};
    
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            planetList.AddRange(lastPlanets);
            planetList.Insert(1,"Venus");
            planetList.Insert(2,"Earth");
            planetList.Add("Pluto");

            rockyPlanets = planetList.GetRange(0,4);

            planetList.Remove("Pluto");
            foreach (string planet in planetList) {
                Console.WriteLine(planet);
            }

            foreach (string lastPlanet in lastPlanets) {
                Console.WriteLine(lastPlanet);
            }

            Console.WriteLine(String.Join(", ", planetList));
            Console.WriteLine(String.Join(", ", rockyPlanets));
            foreach (string rockyplanet in rockyPlanets) {
                Console.WriteLine(rockyplanet);
            }
            Random random = new Random();
            List<int> numbers = new List<int> {
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
            };
            for (int i=0; i<numbers.Count; i++) 
            {
                // Determine if the current loop index is contained inside of the `numbers` list. Print a message to the console indicating whether the index is in the list.
                if (numbers.Contains(i))
                {
                    Console.WriteLine($"Numbers list contains {i}");
                }
                else
                {
                    Console.WriteLine($"Numbers list does not contain {i}");
                }
            }
         }   
    }
}
