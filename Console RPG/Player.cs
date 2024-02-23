using System;
using System.Collections.Generic;

namespace Console_RPG
{
    class Player : Entity
    {
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
            // i figure out
            return targets[0];
        }

        public override void Attack(Entity target)
        {
            // figure out how to calculate the damage and subtract from the target's hp
            Console.WriteLine(this.name + " attacked " + target.name);
        }

        public void UseItem(Item item, Entity target)
        {
            item.Use(this, target);
        }
    }
}
