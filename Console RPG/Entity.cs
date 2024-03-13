using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{
    // Classes are useful for storing complex objects
    abstract class Entity
    {
        public string name;

        public int currentHP, maxHP;
        

        // This is called compostion. Composition is cool
        public Stats stats;
        public Entity(string name, int hp, Stats stats)
        {
            this.name = name;
            currentHP = hp;
            maxHP = hp;
            this.stats = stats; 
        }
        // allys in battle?
        public abstract void DoTurn(List<Player> players, List<Enemy> enemies, List<Ally> allies);
        public abstract Entity ChooseTarget(List<Entity> targets);
        public abstract void Attack(Entity target);

    } 
}
