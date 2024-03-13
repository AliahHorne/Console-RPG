using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{
    class Shop : Event
    {
        public string shopKeeperName;
        public string shopName;
        public List<Item> items;

        public Shop(string shopKeeperName, string shopName, List<Item> items) : base(false)
        {
            this.shopKeeperName = shopKeeperName;
            this.shopName = shopName;
            this.items = items;
        }

        public override void Resolve(List<Player> players, List<Ally> allies)
        {
            Console.WriteLine($"Welcome to {shopKeeperName}'s {shopName}! What ya lookin' for?");

            // TODO: Desplay price
            Item item = ChooseItem(this.items);
            Player.CoinCount -= item.shopPrice;
            Player.Inventory.Add(item);

            Console.WriteLine($"You got {item.name}!");
        }

        public Item ChooseItem(List<Item> items)
        {
            Console.WriteLine("Please pick an item to use:");

            // print out names of ppl we can choose from
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {items[i].name} ({items[i].shopPrice})");
            }

            int index = Convert.ToInt32(Console.ReadLine());
            return items[index - 1];
        }
    }
}
