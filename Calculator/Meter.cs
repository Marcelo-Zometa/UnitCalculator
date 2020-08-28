using System;

namespace Calculator
{
    public class Meter : Unit
    {
        public Meter() : base(null, "meters", 39.3700787, 3.2808, 0.000621,
           100, 1, 0.001)
        {
            Console.WriteLine("Class initiated with values");            
        }        
    }
}
