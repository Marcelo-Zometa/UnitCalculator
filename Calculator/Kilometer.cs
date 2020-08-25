using System;

namespace Calculator
{
    public class Kilometer: Unit
    {
        private string ToUnit = null;
        private string ThisUnit = "kilometers";

        //Conversion values
        private double ToInch = 39370.0787;
        private double ToFeet = 32808;
        private double ToMile = 0.621;
        private double ToCm = 100_000;
        private double ToM = 1000;
        private double ToKm = 1;

        //Method to transform values
        public double Calculate(double quantity)
        {
            double toReturn = 0;

            switch (ToUnit.ToLower())
            {
                case "to in":
                    Console.WriteLine($"Converting from {ThisUnit} to inch");
                    toReturn = quantity * ToInch;
                    break;

                case "to ft":
                    Console.WriteLine($"Converting from {ThisUnit} to ft");
                    toReturn = quantity * ToFeet;
                    break;

                case "to miles":
                    Console.WriteLine($"Converting from {ThisUnit} to miles");
                    toReturn = quantity * ToMile;
                    break;

                case "to cm":
                    Console.WriteLine($"Converting from {ThisUnit} to cm");
                    toReturn = quantity * ToCm;
                    break;

                case "to meters":
                    Console.WriteLine($"Converting from {ThisUnit} to meters");
                    toReturn = quantity * ToM;
                    break;

                case "to km":
                    Console.WriteLine($"Converting from {ThisUnit} to km");
                    toReturn = quantity * ToKm;
                    break;

                default:
                    Console.WriteLine("Invalid option. Falling back");
                    throw new InvalidOperationException();
                    //break;

            }

            return toReturn;
        }

        public void setToUnit(string unit)
        {
            ToUnit = unit;
        }
    }
}
