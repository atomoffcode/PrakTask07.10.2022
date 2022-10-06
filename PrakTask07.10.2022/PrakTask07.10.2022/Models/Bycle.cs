using System;
using System.Collections.Generic;
using System.Text;

namespace PrakTask07._10._2022.Models
{
    class Bycle: Vehicle
    {
        public Bycle(string color, string brand, double millage) : base(color, brand, millage)
        {
            Color = color;
            Brand = brand;
            Millage = millage;
        }

        public override void Drive(double amount)
        {
            Millage += amount;
        }

    }
}
