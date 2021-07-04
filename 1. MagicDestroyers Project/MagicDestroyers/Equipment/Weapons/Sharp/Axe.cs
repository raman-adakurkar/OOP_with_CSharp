using System;

namespace MagicDestroyers.Equipment.Weapons.Sharp
{
    public class Axe : Sharp
    {
        // Fields
        private const int DEFAULT_DAMAGE_POINTS = 10;

        // Constructors
        public Axe()
            : this(DEFAULT_DAMAGE_POINTS)
        {
        }

        public Axe(int armorPoints)
        {
            this.DamagePoints = armorPoints;
        }

        // Methods
        public override void SpecialAbility()
        {
            this.HackNSlash();
        }

        public void HackNSlash()
        {
            throw new NotImplementedException();
        }
    }
}
