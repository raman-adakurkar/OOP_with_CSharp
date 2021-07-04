using System;
using MagicDestroyers.Equipment.Interfaces;

namespace MagicDestroyers.Equipment.Weapons.Blunt
{
    public class Staff : Blunt, IBuff
    {
        // Fields
        private const int DEFAULT_DAMAGE_POINTS = 10;

        // Constructors
        public Staff()
            : this(DEFAULT_DAMAGE_POINTS)
        {
        }

        public Staff(int armorPoints)
        {
            this.DamagePoints = armorPoints;
        }

        // Methods
        public override void SpecialAbility()
        {
            this.Buff();
        }

        public void Buff()
        {
            this.Empower();
            // More buff abilities...
            // ...
        }

        public void Empower()
        {
            throw new NotImplementedException();
        }
    }
}
