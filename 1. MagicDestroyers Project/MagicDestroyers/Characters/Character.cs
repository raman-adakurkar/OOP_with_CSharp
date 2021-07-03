using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagicDestroyers.Characters.Interfaces;
using MagicDestroyers.Enums;
using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;

namespace MagicDestroyers.Characters
{
    public abstract class Character : IAttack, IDefend
    {
        // Fields
        private Faction faction;
        private string name;
        private int healthPoints;
        private int level;
        private Armor bodyArmor;
        private Weapon weapon;

        // Properties
        public int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                if (value >= 1)
                {
                    this.healthPoints = value;
                }

                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        public Faction Faction
        {
            get
            {
                return this.faction;
            }
            set
            {
                this.faction = value;
            }
        }
        public int Level
        {
            get
            {
                return this.level;
            }
            set
            {
                if (value >= 0)
                {
                    this.level = value;
                }

                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public Armor BodyArmor
        {
            get
            {
                return this.bodyArmor;
            }
            set
            {
                this.bodyArmor = value;
            }
        }
        public Weapon Weapon
        {
            get
            {
                return this.weapon;
            }
            set
            {
                this.weapon = value;
            }
        }

        public abstract void Attack();
        public abstract void Defend();
        public abstract void SpecialAttack();
    }
}
