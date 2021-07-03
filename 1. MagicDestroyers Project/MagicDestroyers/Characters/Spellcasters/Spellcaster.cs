using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Characters.Spellcasters
{
    public abstract class Spellcaster : Character
    {
        // Fields
        private int manaPoints;

        // Properties
        public int ManaPoints
        {
            get
            {
                return manaPoints;
            }
            set
            {
                if (value >= 0)
                {
                    manaPoints = value;
                }

                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }


    }
}
