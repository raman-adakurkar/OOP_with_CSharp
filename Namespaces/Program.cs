using System;
using Warrior;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Ninja goodNinja = new Ninja(174, 74, "Raman");
            Console.WriteLine
                (
                "Name : " + goodNinja.Name + "\n" +
                "Height : " + goodNinja.Height + "\n" +
                "Weight : " + goodNinja.Weight + "\n"
                );

            Ninja badNinja = new Ninja(160, 55, "Najyot");
            Console.WriteLine
                (
                "Name : " + badNinja.Name + "\n" +
                "Height : " + badNinja.Height + "\n" +
                "Weight : " + badNinja.Weight + "\n"
                );


        }
    }
}
