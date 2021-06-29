using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChaining
{
    public class Mobile
    {
        private int a;
        private int b;

        private string d;
        private string e;
        private string name;

        public int A 
        { 
            get
            {
                return this.a;
            }

            set
            {
                this.a = value;
            }
        }
        public int B
        {
            get
            {
                return this.b;
            }

            set
            {
                this.b = value;
            }
        }
        public string D
        {
            get
            {
                return this.d;
            }

            set
            {
                this.d = value;
            }
        }
        public string E
        {
            get
            {
                return this.e;
            }

            set
            {
                this.e = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        public Mobile()
            : this (10,20)
        {

        }

        public Mobile(int a, int b)
            : this(10, 20, "D", "E")
        {

        }

        public Mobile(int a, int b, string d, string e)
        {
            this.A = a;
            this.B = b;
            this.D = "D changed";
            this.E = e;
            this.Name = "Raman";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var a = new Mobile();
            Console.WriteLine(a.A);
            Console.WriteLine(a.B);
            Console.WriteLine(a.D);
            Console.WriteLine(a.E);
            Console.WriteLine(a.Name);
        }
    }
}
