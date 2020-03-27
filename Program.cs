using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){"Mercury", "Mars"};
            List<string> lastPlanets = new List<string>(){"Uranus", "Neptune"};

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            planetList.AddRange(lastPlanets);

            foreach (string planet in planetList) {
                Console.WriteLine(planet);
            }

            foreach (string lastPlanet in lastPlanets) {
                Console.WriteLine(lastPlanet);
            }

            Console.WriteLine(String.Join(", ", planetList));
        } 
    }
}
