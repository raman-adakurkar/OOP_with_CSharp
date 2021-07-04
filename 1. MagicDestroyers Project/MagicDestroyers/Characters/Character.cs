using System;
using MagicDestroyers.Characters.Interfaces;
using MagicDestroyers.Enums;
using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;

namespace MagicDestroyers.Characters
{
    public abstract class Character : IAttack, IDefend
    {
        private Faction faction;

        private Weapon weapon;
        private Armor bodyArmor;

        private bool isAlive;

        private int healthPoints;
        private int level;
        private int scores;

        private string name;

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

        public bool IsAlive
        {
            get
            {
                return this.isAlive;
            }

            protected set
            {
                this.isAlive = value;
            }
        }

        public int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }

            set
            {
                if (value >= 0 && value <= 120)
                {
                    this.healthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, the value should be >= 0 and <= 100.");
                }
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
                    throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, level should always be positive.");
                }
            }
        }

        public int Scores
        {
            get
            {
                return this.scores;
            }

            set
            {
                this.scores = value;
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
                if (value.Length >= 3 && value.Length <= 12)
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException(string.Empty, "Inappropriate length of name, name should be between 3 and 12 characters.");
                }
            }
        }

        public abstract int Attack();

        public abstract int SpecialAttack();

        public abstract int Defend();

        public void TakeDamage(int damage, string attackerName, string type)
        {
            if (this.Defend() < damage)
            {
                this.healthPoints = this.healthPoints - damage + this.Defend();

                if (this.healthPoints <= 0)
                {
                    this.isAlive = false;
                }
            }
            else
            {
                Console.WriteLine("Haha! Your damage was not enough to harm me!");
            }

            if (!this.isAlive)
            {
                Tools.TypeSpecificColorfulCW($"{attackerName} attacked {this.name} with damage {damage},\n     ----------- {this.name} is DEAD!", type);
            }
            else
            {
                //Tools.TypeSpecificColorfulCW($"{this.name} received {damage} damage from {attackerName},\n and now has {this.healthPoints} healthpoints!", type);
                Tools.TypeSpecificColorfulCW($"{attackerName} attacks {this.name} and gives damage of {damage},\n     {this.name} now has {this.healthPoints} healthpoints!", type);
            }
        }

        public void WonBattle()
        {
            this.scores++;

            if (this.scores % 10 == 0)
            {
                this.level++;
            }
        }
    }
}
