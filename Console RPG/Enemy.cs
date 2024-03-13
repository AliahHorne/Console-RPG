using System;
using System.Collections.Generic;
using System.Linq;

namespace Console_RPG
{
    class Enemy : Entity
    {

        public static Enemy enemy1 = new Enemy("TyFoon", 30, new Stats(5, 3, 6), 7);
        public static Enemy enemy2 = new Enemy("GranitV", 30, new Stats(6, 6, 3), 10);

        public int coinsDroppedOnDefeated;

        public Enemy(string name, int hp, Stats stats, int coinsDroppedOnDefeated) : base(name, hp, stats)
        {
            this.coinsDroppedOnDefeated = coinsDroppedOnDefeated;
        }

        public override Entity ChooseTarget(List<Entity> targets)
        {
            Random random = new Random();
            return targets[random.Next(targets.Count)];
        }

        public override void Attack(Entity target)
        {
            // figure out how to calculate the damage and subtract from the target's hp
            Console.WriteLine(this.name + " attacked " + target.name);
        }

        public override void DoTurn(List<Player> players, List<Enemy> enemies, List<Ally> allies)
        {
            Entity target = ChooseTarget(players.Cast<Entity>().ToList());
            Attack(target);
        }
    }
}
