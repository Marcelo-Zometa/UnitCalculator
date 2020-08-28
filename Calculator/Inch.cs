using System;

namespace Calculator
{
    public class Inch : Unit
    {
        public Inch() : base(null, "inches", 1, 0.0833, 0.00001578,
           2.54, 0.0254, 0.0000254)
        {
            Console.WriteLine("Class initiated with values");
        }      
    }
}
