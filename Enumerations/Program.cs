using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations
{
    public enum Brand
    {
        Xiaomi,
        Realme,
        Samsung,
        Nokia,
        Apple,
        Motorola,
        Oneplus,
        Oppo,
        Vivo,
        Infinix,
        Techno
    }

    public enum Model
    {
        NumberSeries,
        NoteSeries,
        CameraCentric,
        BudgetSeries,
        FlagshipSeries,
        FlagshipKiller
    }

    public enum Screen
    {
        five = (int)5.5,
        six = (int)6,
        sixFiveThree = (int)6.53,
        sixSixSeven = (int)6.67,
        sixEight = (int)6.8
    }

    public enum Battery
    {
        small = 4000,
        medium = 4500,
        large = 5000,
        huge = 6000,
        monster = 7000
    }


    public class Mobile
    {
        private Brand brandName;
        private Model modelSeries;
        private Screen screenSize;
        private Battery batteryCapacity;

        public Brand BrandName
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
        public Model ModelSeries
        {
            get
            {
                return this.modelSeries;
            }

            set
            {
                this.modelSeries = value;
            }
        }
        public Screen ScreenSize
        {
            get
            {
                return this.screenSize;
            }

            set
            {
                this.screenSize = value;
            }
        }
        public Battery BatteryCapacity
        {
            get
            {
                return this.batteryCapacity;
            }

            set
            {
                this.batteryCapacity = value;
            }
        }

        public void Info(Brand brandName, Model modelSeries)
        {
            if (brandName == Brand.Apple)
            {
                if (modelSeries == Model.FlagshipSeries)
                {
                    Console.WriteLine("Brand Name : " + brandName);
                    Console.WriteLine("Model : " + modelSeries);
                    Console.WriteLine("Screen Size : " + Screen.six + "Inch");
                    Console.WriteLine("Battery Capacity : " + Battery.small + "mAh");
                }
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                var Mobile = new Mobile();
                Mobile.Info(Brand.Apple, Model.FlagshipSeries);
            }
        }
    }
}
