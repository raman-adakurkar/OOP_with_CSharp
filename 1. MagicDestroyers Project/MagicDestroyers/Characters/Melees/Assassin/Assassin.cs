using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagicDestroyers.Enums;
using MagicDestroyers.Equipment.Armors.Chainlink;
using MagicDestroyers.Equipment.Armors.LightLeatherVest;
using MagicDestroyers.Equipment.Weapons.Sword;

namespace MagicDestroyers.Characters.Melee.Assassin
{
    class Assassin : Melee
    {
        // Constants
        private const string DEFAULT_NAME = "Assassin";
        private const Faction DEFAULT_FACTION = Faction.Meele;

        private const int DEFAULT_ABILITY_POINTS = 0;
        private const int DEFAULT_HEALTH_POINTS = 100;
        private const int DEFAULT_LEVEL = 0;

        private readonly LightLeatherVest DEFAULT_BODY_ARMOR = new LightLeatherVest();
        private readonly Sword DEFAULT_WEAPON = new Sword();

        // Constructors
        public Assassin()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {

        }

        public Assassin(string Name, int Level)
            : this(Name, Level, DEFAULT_HEALTH_POINTS)
        {

        }

        public Assassin(string Name, int Level, int HealthPoints)
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
        public void Raze()
        {
            
        }

        public void BleedToDeath()
        {

        }

        public void Survival()
        {

        }

        public override void Attack()
        {
            this.Raze();
        }

        public override void Defend()
        {
            this.Survival();
        }

        public override void SpecialAttack()
        {
            this.BleedToDeath();
        }
    }
}
