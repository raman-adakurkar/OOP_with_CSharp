﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects
{
    public class Ninja
    {
        // Initializing properties for class
        private int height;
        private int weight;

        public int Height { get; set; }
        public int Weight { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Creating object for Ninja class
            Ninja raman = new Ninja();

            // Accessing properties of object raman from Ninja Class
            raman.Height = 174;
            raman.Weight = 74;

            // Displaying raman on console with properties
            Console.WriteLine("Raman's Height = " + raman.Height + "\nRaman's Weight = " + raman.Weight);
            Console.WriteLine();
        }
    }
}
