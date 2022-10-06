using System;
using System.Collections.Generic;
using System.Text;

namespace PrakTask07._10._2022.Models
{
    class Car:Vehicle
    {
        public double FuelCapaciy;
        public double CurrentFuel;
        public double FuelFor1km;
        public Car(string color, string brand, double millage) : base(color, brand, millage)
        {
            Color = color;
            Brand = brand;
            Millage = millage;
        }

        public override void Drive(double amount)
        {
            if (amount*FuelFor1km<=CurrentFuel)
            {
                CurrentFuel -= (amount * FuelFor1km);
                Millage += amount;
            }
            else
            {
                Console.WriteLine("Gedilecek mesafe ucun benzin catmir, ya elave edin, yada vazgecin :D");
            }
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Color:{Color}; Brand:{Brand}; Millage:{Millage}; Fuel Capacity:{FuelCapaciy}; Current Fuel:{CurrentFuel}; Fuel for 1km:{FuelFor1km}");
        }

    }
}
