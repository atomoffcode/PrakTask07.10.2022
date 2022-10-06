using System;
using System.Collections.Generic;
using System.Text;

namespace PrakTask07._10._2022.Models
{
    abstract class Vehicle
    {
        public string Color;
        public string Brand;
        public double Millage;

        public Vehicle(string color,string brand, double millage)
        {
            Color = color;
            Brand = brand;
            Millage = millage;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Color:{Color}; Brand:{Brand}; Millage:{Millage}");
        }


        public abstract void Drive(double amount);
        
    }
}
