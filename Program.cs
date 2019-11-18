using System;
using System.Collections.Generic;

namespace _1_06.Urban_Planner_II
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Building> buildings = new List<Building>();

            buildings.Add( newBuilding("512 8th Avenue", 10_0, 10_0, 1, "First Owner") );
            buildings.Add( newBuilding("101 6th Avenue", 11_0, 11_0, 2, "Second Owner") );
            buildings.Add( newBuilding("305 9th Avenue", 12_0, 12_0, 3, "Third Owner") );

            foreach( Building building in buildings )
            {
                building.PrintInfo();
            }
        }

        static Building newBuilding( string address, double width, double depth, int stories, string owner )
        {
            Building building = new Building(address);

            building.Width = width;
            building.Depth = depth;
            building.Stories = stories;
            building.Construct();
            building.Purchase(owner);

            return building;
        }
    }
}
