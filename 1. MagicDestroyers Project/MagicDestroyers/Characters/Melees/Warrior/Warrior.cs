using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagicDestroyers.Enums;
using MagicDestroyers.Equipment.Armors.Chainlink;
using MagicDestroyers.Equipment.Weapons.Axe;
using MagicDestroyers.Equipment.Weapons.Hammer;

namespace MagicDestroyers.Characters.Melee.Warrior
{
    public class Warrior : Melee
    {
        // Constants
        private const string DEFAULT_NAME = "Warrior";
        private const Faction DEFAULT_FACTION = Faction.Meele;

        private const int DEFAULT_ABILITY_POINTS = 0;
        private const int DEFAULT_HEALTH_POINTS = 100;
        private const int DEFAULT_LEVEL = 0;

        private readonly Chainlink DEFAULT_BODY_ARMOR = new Chainlink();
        private readonly Axe DEFAULT_WEAPON = new Axe();

        // Constructors
        public Warrior()
            : this (DEFAULT_NAME, DEFAULT_LEVEL)
        {

        }

        public Warrior(string Name, int Level)
            : this (Name, Level, DEFAULT_HEALTH_POINTS)
        {

        }

        public Warrior(string Name, int Level, int HealthPoints)
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
        public void Strike()
        {
            
        }

        public void Execute()
        {

        }

        public void SkinHarden()
        {

        }

        public override void Attack()
        {
            this.Strike();
        }

        public override void Defend()
        {
            this.SkinHarden();
        }

        public override void SpecialAttack()
        {
            this.Execute();
        }
    }
}
