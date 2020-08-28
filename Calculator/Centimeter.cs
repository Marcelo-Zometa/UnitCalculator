using System;

namespace Calculator
{
    public class Centimeter : Unit
    {
        public Centimeter() : base(null, "centimeters", 0.39370079, 0.0328, 0.00000621,
           1, 0.01, 0.00001)
        {
            Console.WriteLine("Class initiated with values");
        }
    }
}
