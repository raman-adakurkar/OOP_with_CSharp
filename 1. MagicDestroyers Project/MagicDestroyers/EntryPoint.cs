using MagicDestroyers.Characters.Melee.Knight;
using MagicDestroyers.Characters.Melee.Warrior;
using MagicDestroyers.Characters;
using MagicDestroyers.Characters.Melee.Assassin;
using MagicDestroyers.Characters.Spellcasters.Druid;
using MagicDestroyers.Characters.Spellcasters.Mage;
using MagicDestroyers.Characters.Spellcasters.Necromancer;
using System.Collections.Generic;

namespace MagicDestroyers
{
    class EntryPoint
    {
        static void Main()
        {
            Character warrior = new Warrior();
            Character knight = new Knight();
            Character assassin = new Assassin();
            Character druid = new Druid();
            Character mage = new Mage();
            Character necromancer = new Necromancer();

            List<Character> meleeTeam = new List<Character>();
            List<Character> spellTeam = new List<Character>();

            meleeTeam.Add(assassin);
            meleeTeam.Add(knight);
            meleeTeam.Add(warrior);

            spellTeam.Add(druid);
            spellTeam.Add(mage);
            spellTeam.Add(necromancer);

            foreach(var melee in meleeTeam)
            {
                System.Console.WriteLine("Name    : " + melee.Name);
                System.Console.WriteLine("Faction : " + melee.Faction);
                System.Console.WriteLine("----------------------");
            }

            foreach (var spell in spellTeam)
            {
                System.Console.WriteLine("Name    : " + spell.Name);
                System.Console.WriteLine("Faction : " + spell.Faction);
                System.Console.WriteLine("----------------------");
            }

        }
    }
}
