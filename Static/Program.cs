using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    public static class Practice
    {
        private static int number;
        private static string name;

        public static int Number
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
            }
        }
        public static string Name 
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

        static Practice()
        {
           Number = 10;
           Name = "Raman";
           Console.WriteLine(Number);
           Console.WriteLine(Name);
        }
    }

    public class Raman
    {
        private int a;

        public int A 
        {
            get
            {
                return this.a;
            }

            private set
            {
                this.a = value;
            }
        }

        public Raman(int a)
        {
            this.A = a;
            Console.WriteLine(A);
        }
    }

    enum E
    {
        one,
        two
    }

    class Program
    {
        static void Main(string[] args)
        {
            Practice.Number = 100;
            Practice.Name = "Raman Adakurkar";
            Console.WriteLine();

            Console.WriteLine(Practice.Name);
            Console.WriteLine(Practice.Number);
            Console.WriteLine();

            var r = new Raman(10);
            Console.WriteLine(r.A);

            Console.WriteLine();
            Console.WriteLine(E.two);



        }
    }
}
