using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<string> planetList = new List<string>(){"Mercury", "Venus", "Mars"};
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            List<string> lastPlanetList = new List<string>(){"Uranus", "Neptune"};

            foreach(string planet in planetList) {
                Console.WriteLine(planet);
            }
            planetList.Insert(2, "Earth");
            Console.WriteLine();

            planetList.AddRange(lastPlanetList);
            planetList.Add("Pluto");
            
            Console.WriteLine();

            List<string> rockyPlanets = planetList.GetRange(0,3);

            foreach(string planet in rockyPlanets) 
            {Console.WriteLine(planet);}

            Console.WriteLine();


            foreach(string planet in planetList) 
            {Console.WriteLine(planet);}

            Console.WriteLine();

            planetList.Remove("Pluto");

            planetList.ForEach(planet => {
                Console.WriteLine(planet);
            });

            Console.WriteLine();

            lastPlanetList.ForEach(planet => {
                Console.WriteLine(planet);
            });
        }
    }
}
