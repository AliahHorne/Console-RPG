using System;
using System.Collections.Generic;
using System.Linq;

namespace Console_RPG
{
    class Player : Entity
    {
        public static List<Item> Inventory = new List<Item>() { Item.potionI, Item.potionII, Item.wandI };
        public static int CoinCount = 0;

        public static Player alulu = new Player("Alulu", 70, 7, 12, new Stats(10, 8, 7), 9);

        public int level;
        public int currentSpellSlots, maxSpellSlots;

        public Player(string name, int hp, int currentSpellSlots, int maxSpellSlots, Stats stats, int level) : base(name, hp, stats)
        {
            this.level = level;
            this.currentSpellSlots = currentSpellSlots;
            this.maxSpellSlots = maxSpellSlots;
        }

        public override Entity ChooseTarget(List<Entity> targets)
        {
            Console.WriteLine("Please pick an enemy to target:");
            
            // print out names of ppl we can choose from
            for (int i = 0; i < targets.Count; i++) 
            {
                Console.WriteLine($"{i + 1}: {targets[i].name}");
            }

            int index = Convert.ToInt32(Console.ReadLine());
            return targets[index - 1];
        }

        public Item ChooseItem(List<Item> items)
        {
            Console.WriteLine("Please pick an item to use:");

            // print out names of ppl we can choose from
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {items[i].name}");
            }

            int index = Convert.ToInt32(Console.ReadLine());
            return items[index - 1];
        }

        public override void Attack(Entity target)
        {
            // figure out how to calculate the damage and subtract from the target's hp
            Console.WriteLine(this.name + " attacked " + target.name);
        }

        public override void DoTurn(List<Player> players, List<Enemy> enemies, List<Ally> allies)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("Attack | Item");
            string choice = Console.ReadLine();

            if (choice == "Attack")
            {
                Entity target = ChooseTarget(enemies.Cast<Entity>().ToList());
                Attack(target); 
            }

            else if (choice == "Item")
            {
                Item item = ChooseItem(Inventory);
                Entity target = ChooseTarget(enemies.Cast<Entity>().ToList());
                
                item.Use(this, target);
                Inventory.Remove(item);
            }
        }

        public void UseItem(Item item, Entity target)
        {
            item.Use(this, target);
        }
    }
}
