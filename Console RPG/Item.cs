using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{
    abstract class Item
    {
        public static HealthPotionItem potionI = new HealthPotionItem("Health Potion I", "It'll quench ya'.", 10, 10, 10);
        public static SpellPotionItem potionII = new SpellPotionItem("Spell Slot Potion I", "It'll quench ya'.", 10, 10, 15);
        public static WandItem wandI = new WandItem("Wand", "It'll quench ya'.", 10, 10, 15, 2);

        public string name;
        public string description;

        public int shopPrice;
        public int sellPrice;
        

        public Item(string name, string description, int shopPrice, int sellPrice)
        {
            this.name = name;
            this.description = description;
            this.shopPrice = shopPrice;
            this.sellPrice = sellPrice;
        }

        public abstract void Use(Entity user, Entity target);
    }
}
