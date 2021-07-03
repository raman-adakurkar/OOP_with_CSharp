using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagicDestroyers.Enums;
using MagicDestroyers.Equipment.Armors.LightLeatherVest;
using MagicDestroyers.Equipment.Weapons.Staff;

namespace MagicDestroyers.Characters.Spellcasters.Druid
{
    public class Druid : Spellcaster
    {
        // Constants
        private const string DEFAULT_NAME = "Druid";
        private const Faction DEFAULT_FACTION = Faction.Spellcaster;

        private const int DEFAULT_MANA_POINTS = 0;
        private const int DEFAULT_HEALTH_POINTS = 100;
        private const int DEFAULT_LEVEL = 0;

        private readonly LightLeatherVest DEFAULT_BODY_ARMOR = new LightLeatherVest();
        private readonly Staff DEFAULT_WEAPON = new Staff();

        // Constructors
        public Druid()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {

        }

        public Druid(string Name, int Level)
            : this(Name, Level, DEFAULT_HEALTH_POINTS)
        {

        }

        public Druid(string Name, int Level, int HealthPoints)
        {
            base.Name = Name;
            base.Level = Level;
            base.HealthPoints = HealthPoints;
            base.Faction = DEFAULT_FACTION;
            base.ManaPoints = DEFAULT_MANA_POINTS;
            this.Weapon = DEFAULT_WEAPON;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
        }

        // Methods
        public void Moonfire()
        {

        }

        public void Starburst()
        {

        }

        public void OneWithTheNature()
        {

        }

        public override void Attack()
        {
            this.Moonfire();
        }

        public override void Defend()
        {
            this.OneWithTheNature();
        }

        public override void SpecialAttack()
        {
            this.Starburst();
        }
    }
}
