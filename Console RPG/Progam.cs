using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{
    class Progam
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What’s your name?");
            Player.alulu.name = Console.ReadLine();
            
            Console.WriteLine("What’s your ally's name?");
            Ally.saph.name = Console.ReadLine();

            Console.WriteLine("What’s your enemy's name?");
            Enemy.enemy1.name = Console.ReadLine();

            Console.WriteLine("What’s your other enemy's name?");
            Enemy.enemy2.name = Console.ReadLine();

            //Console.WriteLine(enemy1.stats.strength);

            Location.playersHome.SetNearbyLocations(north: Location.evilPlace, west: Location.allysPlace);
            Location.evilPlace.SetNearbyLocations(east: Location.safePlace, south: Location.playersHome);
            Location.allysPlace.SetNearbyLocations(north: Location.evilPlace, east: Location.playersHome);
            Location.safePlace.SetNearbyLocations(west: Location.evilPlace);

            Location.safePlace.Resolve(new List<Player>() { Player.alulu });
        }
    }
}
