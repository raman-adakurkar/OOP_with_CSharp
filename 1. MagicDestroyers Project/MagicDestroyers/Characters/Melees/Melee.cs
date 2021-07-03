using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Characters.Melee
{
    public abstract class Melee : Character
    {
        // Fields
        private int abilityPoints;

        // Properties
        public int AbilityPoints
        {
            get
            {
                return this.abilityPoints;
            }
            set
            {
                if (value >= 0)
                {
                    this.abilityPoints = value;
                }

                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
}
