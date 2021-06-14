using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects
{
    public class Ninja
    {
        // Initializing Fields for class
        public int height;
        public int weight;
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Creating object for Ninja class
            Ninja raman = new Ninja();

            // Accessing Fields of object raman from Ninja Class
            raman.height = 174;
            raman.weight = 74;

            // Displaying raman on console with properties
            Console.WriteLine("Raman's Height = " + raman.height + "\nRaman's Weight = " + raman.weight);
            Console.WriteLine();
        }
    }
}
