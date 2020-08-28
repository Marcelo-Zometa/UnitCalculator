using System;

namespace Calculator
{
    public class Mile : Unit
    {
        public Mile() : base(null, "miles", 63360, 5280, 1,
           160934.4, 1609.34, 1.609344)
        {
            Console.WriteLine("Class initiated with values");
        }      
    }
}
