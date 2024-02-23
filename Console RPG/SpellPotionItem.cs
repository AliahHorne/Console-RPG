namespace Console_RPG
{
    class SpellPotionItem : Item
    {
        public static SpellPotionItem potionII = new SpellPotionItem("Spell Slot Potion I", "It'll quench ya'.", 10, 20, 15);

        public int spellSlotAmount;

        public SpellPotionItem(string name, string description, int shopPrice, int maxAmount, int spellSlotAmount) : base(name, description, shopPrice, maxAmount)
        {
            this.spellSlotAmount = spellSlotAmount;
        }

        public override void Use(Entity user, Entity target)
        {
            user.currentHP += this.spellSlotAmount;
        }


    }
}
