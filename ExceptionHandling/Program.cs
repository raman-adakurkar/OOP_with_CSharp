using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class Mobile
    {
        private const int defaultScreenSize = 7;

        private double screenSize;

        private string modelNumber;
        private string brandName;

        public double ScreenSize 
        { 
            get
            {
                return this.screenSize;
            }

            set
            {
                if(value >= defaultScreenSize)
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Mobile ScreenSize cannot be greater than 7 inches");
                }

                else
                {
                    this.screenSize = value;
                }
            }
        }
        public string ModelNumber
        {
            get
            {
                return this.modelNumber;
            }

            set
            {
                this.modelNumber = value;
            }
        }
        public string BrandName
        {
            get
            {
                return this.brandName;
            }

            set
            {
                this.brandName = value;
            }
        }

        public Mobile(double screenSize, string modelNumber, string brandName)
        {
            this.ScreenSize = screenSize;
            this.ModelNumber = modelNumber;
            this.BrandName = brandName;
        }

        public void MobileInfo()
        {
            Console.WriteLine("BrandName : " + this.brandName);
            Console.WriteLine("ModelNumber : " + this.modelNumber);
            Console.WriteLine("ScreenSize : " + this.screenSize);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Mobile note = new Mobile(6.5, "Redmi Note 10 Pro Max", "Redmi");
                note.MobileInfo();

                Mobile eight = new Mobile(9, "Realme 8", "Realme");
                eight.MobileInfo();
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            
        }
    }
}