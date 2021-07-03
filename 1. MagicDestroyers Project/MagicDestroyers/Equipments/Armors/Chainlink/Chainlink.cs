using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Armors.Chainlink
{
    public class Chainlink : Armor
    {
        // Fields
        private int armorPoints;

        // Properties
        public int ArmorPoints 
        { 
            get
            {
                return armorPoints;
            }

            set
            {
                if(value > 1)
                {
                    armorPoints = value;
                }

                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        // Methods
    }
}
