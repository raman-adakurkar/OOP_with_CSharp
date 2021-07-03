using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagicDestroyers.Enums;
using MagicDestroyers.Equipment.Armors.Chainlink;
using MagicDestroyers.Equipment.Weapons.Hammer;

namespace MagicDestroyers.Characters.Melee.Knight
{
    public class Knight : Melee
    {
        // Constants
        private const string DEFAULT_NAME = "Knight";
        private const Faction DEFAULT_FACTION = Faction.Meele;

        private const int DEFAULT_ABILITY_POINTS = 0;
        private const int DEFAULT_HEALTH_POINTS = 100;
        private const int DEFAULT_LEVEL = 0;

        private readonly Chainlink DEFAULT_BODY_ARMOR = new Chainlink();
        private readonly Hammer DEFAULT_WEAPON = new Hammer();

        // Constructors
        public Knight()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {

        }

        public Knight(string Name, int Level)
            : this(Name, Level, DEFAULT_HEALTH_POINTS)
        {

        }

        public Knight(string Name, int Level, int HealthPoints)
        {
            base.Name = Name;
            base.Level = Level;
            base.HealthPoints = HealthPoints;
            base.Faction = DEFAULT_FACTION;
            base.AbilityPoints = DEFAULT_ABILITY_POINTS;
            this.Weapon = DEFAULT_WEAPON;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
        }

        // Methods
        public void HolyBlow()
        {

        }

        public void PurifySoul()
        {

        }

        public void RighteousWings()
        {

        }

        public override void Attack()
        {
            this.HolyBlow();
        }

        public override void Defend()
        {
            this.RighteousWings();
        }

        public override void SpecialAttack()
        {
            this.PurifySoul();
        }
    }
}
