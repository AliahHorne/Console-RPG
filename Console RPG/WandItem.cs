namespace Console_RPG
{
    class WandItem : Item
    {
        public static WandItem wandI = new WandItem("Wand", "It'll quench ya'.", 10, 20, 15, 2);

        public int damage;
        public int spellSlotsSpent;

        public WandItem(string name, string description, int shopPrice, int maxAmount, int damage, int spellSlotsSpent) : base(name, description, shopPrice, maxAmount)
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
