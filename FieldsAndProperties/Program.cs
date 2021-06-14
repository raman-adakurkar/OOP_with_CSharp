using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects
{
    public class Ninja
    {
        // These are fields and these are for internal use of class are must be private
        private int height;
        private int weight;

        // These are Properties and these are for external use and can be public
        public int Height { get; set; }
        public int Weight { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ninja raman = new Ninja();

            raman.Height = 174;
            raman.Weight = 74;

            Console.WriteLine("Raman's Height : " + raman.Height + "\nRaman's Weight : " + raman.Weight);
            Console.WriteLine();
        }
    }
}
