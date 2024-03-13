namespace Console_RPG
{
    class SpellPotionItem : Item
    {
        

        public int spellSlotAmount;

        public SpellPotionItem(string name, string description, int shopPrice, int sellPrice, int spellSlotAmount) : base(name, description, shopPrice, sellPrice)
        {
            this.spellSlotAmount = spellSlotAmount;
        }

        public override void Use(Entity user, Entity target)
        {
            user.currentHP += this.spellSlotAmount;
        }


    }
}
