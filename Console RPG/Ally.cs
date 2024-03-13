using System;
using System.Collections.Generic;
using System.Linq;

namespace Console_RPG
{
    class Ally : Entity
    {
        public static Ally saph = new Ally("Saph", 50, new Stats(10, 8, 7), 5);
        public int level2;

        public Ally(string name, int hp, Stats stats, int level2) : base(name, hp, stats)
        {
            this.level2 = level2;
        }

        public override Entity ChooseTarget(List<Entity> targets)
        {
            Random random = new Random();
            return targets[random.Next(targets.Count)];
        }

        public override void DoTurn(List<Player> players, List<Enemy> enemies, List<Ally> allies)
        {
            Entity target = ChooseTarget(enemies.Cast<Entity>().ToList());
            Attack(target);
        }

        public override void Attack(Entity target)
        {
            // figure out how to calculate the damage and subtract from the target's hp
            Console.WriteLine(this.name + " attacked " + target.name);
        }
    }
}
