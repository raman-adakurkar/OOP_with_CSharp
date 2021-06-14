using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        public class Ninja
        {
            // Fields
            private int height;
            private int weight;

            // Properties
            public int Height { get; set; }
            public int Weight { get; set; }
            public string Name { get; set; }

            // Methods
            public void Welcome(Ninja ninja)
            {
                Console.WriteLine("Welcome, " + ninja.Name);
            }

        }
        static void Main(string[] args)
        {
            Ninja goodNinja = new Ninja();
            goodNinja.Height = 174;
            goodNinja.Weight = 74;
            goodNinja.Name = "Raman";

            Ninja badNinja = new Ninja();
            badNinja.Height = 160;
            badNinja.Weight = 55;
            badNinja.Name = "Navjyot";

            goodNinja.Welcome(goodNinja);
            Console.WriteLine("Height : " + goodNinja.Height);
            Console.WriteLine("Weight : " + goodNinja.Weight);

            Console.WriteLine();

            badNinja.Welcome(badNinja);
            Console.WriteLine("Height : " + badNinja.Height);
            Console.WriteLine("Weight : " + badNinja.Weight);
        }
    }
}
