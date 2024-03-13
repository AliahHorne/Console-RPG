namespace Console_RPG
{
    class WandItem : Item
    {
        

        public int damage;
        public int spellSlotsSpent;

        public WandItem(string name, string description, int shopPrice, int sellPrice, int damage, int spellSlotsSpent) : base(name, description, shopPrice, sellPrice)
        {
            this.damage = damage;
            this.spellSlotsSpent = spellSlotsSpent;
        }

        public override void Use(Entity target, Entity user)
        {
            if (spellSlotsSpent == 0)
                return;

            target.currentHP -= this.damage;
            --spellSlotsSpent;
        }
    }
}
