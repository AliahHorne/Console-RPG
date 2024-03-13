using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{
    class Battle : Event
    {
        
        public List<Enemy> enemies;

        public Battle(List<Enemy> enemies) : base(false)
        {
            this.enemies = enemies;
        }

        public override void Resolve(List<Player> players, List<Ally> allies)
        {
            // loop of turn system
            while (true)
            {
                // loop through all players
                foreach (var player in players)
                {
                    if (player.currentHP > 0)
                    {
                        Console.WriteLine("It is " + player.name + "'s turn.");
                        player.DoTurn(players, enemies, allies);
                    }
                        
                }

                // loop through all enemies
                foreach (var enemy in enemies)
                {
                    if (enemy.currentHP >0)
                    {
                        Console.WriteLine("It is " + enemy.name + "'s turn.");
                        enemy.DoTurn(players, enemies, allies);
                    }
                    
                }

                // loop through all enemies
                foreach (var ally in allies)
                {
                    if (ally.currentHP > 0)
                    {
                        Console.WriteLine("It is " + ally.name + "'s turn.");
                        ally.DoTurn(players, enemies, allies);
                    }
                        
                }

                // If players lose...
                if (players.TrueForAll(player => player.currentHP <= 0))
                {
                    Console.WriteLine("You lose. :(((((");
                    break;
                }

                // If players win
                if (enemies.TrueForAll(enemy => enemy.currentHP <= 0))
                {
                    Console.WriteLine("You won. :)))))");
                    break;
                }

                // put any code that should happen regardless of who win.
            }
        }
    }
}
