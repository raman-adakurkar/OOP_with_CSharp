namespace MagicDestroyers.Equipment.Armors.Light
{
    public class ClothRobe : Light
    {
        // Fields
        private const int DEFAULT_ARMOR_POINTS = 10;

        // Constructors
        public ClothRobe()
            : this(DEFAULT_ARMOR_POINTS)
        {
        }

        public ClothRobe(int armorPoints)
        {
            this.ArmorPoints = armorPoints;
        }
    }
}
