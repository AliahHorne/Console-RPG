using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{
    class Location
    {
        public static Location playersHome = new Location("Your home", "Very Safe");
        public static Location allysPlace = new Location("Ally's house", "Safe?", new Battle(new List<Enemy>() { Enemy.enemy1 }));
        public static Location evilPlace = new Location("Evil Lair", "Not Safe??");
        public static Location safePlace = new Location("A Safe Place", "WARNING-", new Battle(new List<Enemy>() { Enemy.enemy2 }));
        public static Location townEast = new Location("Eastern Town Plaza", "A peaceful shopping district.", new Shop("Lu", "Tricks and Trinkets", new List<Item>() { Item.potionI, Item.potionII, Item.wandI }));

        public string name;
        public string description;
        public Event feature;

        public Location north, east, south, west;

        public Location(string name, string description, Event feature = null)
        {
            this.name = name;
            this.description = description;
            this.feature = feature;
        }

        public void SetNearbyLocations(Location north = null, Location east = null, Location south = null, Location west = null)
        {
            if (!(north is null))
            {
                north.south = null;
                this.north = north;
            }


            if (!(east is null))
            {
                east.west = this;
                this.east = east;
            }

            if (!(south is null))
            {
                south.north = this;
                this.south = south;
            }
                

            if (!(west is null))
            {
                west.east = this;
                this.west = west;
            }
                
        }

        public void Resolve(List<Player> players, List<Ally> allies)
        {
            Console.WriteLine("You find yourself in " + this.name + ".");
            Console.WriteLine(this.description);

            Console.WriteLine("Where would you like to go?");

            //only reslove a battle if there is a battle to resolve. Null checking
            feature?.Resolve(players, allies);

            if (!(north is null))
                Console.WriteLine("North: " + this.north.name);

            if (!(east is null))
                Console.WriteLine("East: " + this.east.name);

            if (!(south is null))
                Console.WriteLine("South: " + this.south.name);

            if (!(west is null))
                Console.WriteLine("West: " + this.west.name);

            string direction = Console.ReadLine();
            Location nextLocation = null;

            if (direction == "north")
                nextLocation = this.north;

            if (direction == "east")
                nextLocation = this.east;

            if (direction == "south")
                nextLocation = this.south;

            if (direction == "west")
                nextLocation = this.west;

            nextLocation.Resolve(players, allies);
        }
    }
}
