using System;
using System.Collections.Generic;
using System.Linq;

namespace Console_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What’s your name?");
            //Player.alulu.name = Console.ReadLine();
            //
            //Console.WriteLine("What’s your ally's name?");
            //Ally.saph.name = Console.ReadLine();
            //
            //Console.WriteLine("What’s your enemy's name?");
            //Enemy.enemy1.name = Console.ReadLine();
            //
            //Console.WriteLine("What’s your other enemy's name?");
            //Enemy.enemy2.name = Console.ReadLine();

            //Console.WriteLine(enemy1.stats.strength);

            Location.playersHome.SetNearbyLocations(north: Location.evilPlace, east: Location.townEast, west: Location.allysPlace);
            Location.evilPlace.SetNearbyLocations(east: Location.safePlace, south: Location.playersHome);
            Location.allysPlace.SetNearbyLocations(north: Location.evilPlace, east: Location.playersHome);
            Location.safePlace.SetNearbyLocations(west: Location.evilPlace, south: Location.townEast);
            Location.townEast.SetNearbyLocations(north: Location.safePlace, west: Location.playersHome);

            Location.playersHome.Resolve(new List<Player>() { Player.alulu }, new List<Ally>() { Ally.saph });

            //Console.WriteLine($"There are {numberOfEnemies} in battle.");
        }
    }
}
