using System;
using System.Collections.Generic;

namespace _1_06.Urban_Planner_II
{
    class City
    {
        public string Name {get;}
        public int EstablishedYear {get;}
        public string Mayor {get;}

        private List<Building> Buildings = new List<Building>();

        public City( string name, int year, string mayor )
        {
            Name = name;
            EstablishedYear = year;
            Mayor = mayor;
        }

        /*
            Name of the city.
            The mayor of the city.
            Year the city was established.
            A collection of all of the buildings in the city.
            A method to add a building to the city.
        */
        public void AddBuilding( Building building)
        {
            Buildings.Add(building);
        }

        public void PrintCityInfo()
        {
            Console.Write(
                $"City name: {Name}\n" +
                $"Year of establishment: {EstablishedYear}\n" +
                $"City mayor name: {Mayor}\n\n"
                );
        }

        public void GetBuildingsInfo()
        {
            Console.Write($"Buildings info of city {Name}:\n\n");

            foreach( Building building in Buildings )
            {
                building.PrintInfo();
            }
        }
    }
}
