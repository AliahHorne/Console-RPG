using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{
    class Battle
    {
        public bool isResolved;
        public List<Enemy> enemies;

        public Battle(List<Enemy> enemies)
        {
            this.isResolved = false;
            this.enemies = enemies;
        }

        public void Resolve(List<Player> players)
        {
            Console.WriteLine(players[0].name);
        }
    }
}
