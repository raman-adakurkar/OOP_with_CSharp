using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Weapons.Staff
{
    public class Staff : Weapon
    {
        // Fields
        private int damage;

        // Properties
        public int Damage
        {
            get
            {
                return damage;
            }

            set
            {
                if (value >= 1)
                {
                    damage = value;
                }

                else
                {
                    Console.WriteLine("Damage cannot be less than 1");
                }
            }
        }

        // Methods
        public void Empower()
        {

        }
    }
}
