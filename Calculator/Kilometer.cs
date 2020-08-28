using System;

namespace Calculator
{
    public class Kilometer: Unit
    {
        public Kilometer() : base(null, "kilometers", 39370.0787, 32808, 0.621,
           100_000, 1000, 1)
        {
            Console.WriteLine("Class initiated with values");
        }
    }
}
