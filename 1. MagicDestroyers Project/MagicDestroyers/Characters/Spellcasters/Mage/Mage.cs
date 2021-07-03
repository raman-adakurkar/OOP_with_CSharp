using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagicDestroyers.Enums;
using MagicDestroyers.Equipment.Armors.ClothRobe;
using MagicDestroyers.Equipment.Weapons.Staff;

namespace MagicDestroyers.Characters.Spellcasters.Mage
{
    public class Mage : Spellcaster
    {
        // Constants
        private const string DEFAULT_NAME = "Mage";
        private const Faction DEFAULT_FACTION = Faction.Spellcaster;

        private const int DEFAULT_MANA_POINTS = 0;
        private const int DEFAULT_HEALTH_POINTS = 100;
        private const int DEFAULT_LEVEL = 0;

        private readonly ClothRobe DEFAULT_BODY_ARMOR = new ClothRobe();
        private readonly Staff DEFAULT_WEAPON = new Staff();

        // Constructors
        public Mage()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {

        }

        public Mage(string Name, int Level)
            : this(Name, Level, DEFAULT_HEALTH_POINTS)
        {

        }

        public Mage(string Name, int Level, int HealthPoints)
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
        public void ArcaneWrath()
        {

        }

        public void Firewall()
        {

        }

        public void Meditation()
        {

        }

        public override void Attack()
        {
            this.ArcaneWrath();
        }

        public override void Defend()
        {
            this.Meditation();
        }

        public override void SpecialAttack()
        {
            this.Firewall();
        }
    }
}
