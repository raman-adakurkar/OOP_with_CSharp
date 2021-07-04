namespace MagicDestroyers.Equipment.Armors.Leather
{
    public class LightLeatherVest : Leather
    {
        // Fields
        private const int DEFAULT_ARMOR_POINTS = 10;

        // Constructors
        public LightLeatherVest()
            : this(DEFAULT_ARMOR_POINTS)
        {
        }

        public LightLeatherVest(int armorPoints)
        {
            this.ArmorPoints = armorPoints;
        }
    }
}
