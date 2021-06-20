using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Ninja
    {
        // Fields
        private int height;
        private int weight;

        private string name;

        // Properties
        public int Height 
        { 
            get
            {
                return height;
            }
            set
            {
                if (value < 170)
                {
                    height = value;
                }

                else
                    throw new ArgumentOutOfRangeException(string.Empty, "Height must be less than 170");
            }
        }

        public int Weight 
        { 
            get
            {
                return weight;
            }

            set
            {
                weight = value;
            }
        }

        public string Name 
        { 
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        // Constructor
        public Ninja(int height, int weight, string name)
        {
            Height = height;
            Weight = weight;
            Name = name;
        }

        // Methods
        public void DisplayNinja(int height, int weight, string name)
        {
            // use of this keyword. Check output to see the result using this keyword and without using this keyword
            Console.WriteLine($@"DisplayNinja Method - Name : {this.name}, Height : {this.height}, Weight : {this.weight}");
            Console.WriteLine($@"DisplayNinja Method - Name : {name}, Height : {height}, Weight : {weight}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ninja goodNinja = new Ninja(169, 74, "Raman");
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

            goodNinja.DisplayNinja(1, 2, "three");
            badNinja.DisplayNinja(2, 3, "four");

        }
    }
}
