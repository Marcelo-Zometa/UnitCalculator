using System;

namespace Calculator
{
    public class Foot : Unit
    {
        public Foot() : base(null, "ft", 12, 1, 0.0000189,
           30.48, 0.3048, 0.0003048)
        {
            Console.WriteLine("Class initiated with values");
        }
    }
}
