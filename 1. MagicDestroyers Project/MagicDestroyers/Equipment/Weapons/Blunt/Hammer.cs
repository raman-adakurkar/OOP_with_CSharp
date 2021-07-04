using System;
using MagicDestroyers.Equipment.Interfaces;

namespace MagicDestroyers.Equipment.Weapons.Blunt
{
    public class Hammer : Blunt, ISpecialItemAbility
    {
        // Fields
        private const int DEFAULT_DAMAGE_POINTS = 10;

        // Constructors
        public Hammer()
            : this(DEFAULT_DAMAGE_POINTS)
        {
        }

        public Hammer(int armorPoints)
        {
            this.DamagePoints = armorPoints;
        }

        // Methods
        public override void SpecialAbility()
        {
            this.Stun();
        }

        public void Stun()
        {
            throw new NotImplementedException();
        }
    }
}
