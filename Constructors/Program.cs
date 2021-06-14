using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Ninja
    {
        private int height;
        private int weight;
        private string name;

        public int Height { get; set; }
        public int Weight { get; set; }
        public string Name { get; set; }

        public Ninja(int height, int weight, string name)
        {
            Height = height;
            Weight = weight;
            Name = name;
        }
    }
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
