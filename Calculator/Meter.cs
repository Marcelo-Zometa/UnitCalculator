using System;

namespace Calculator
{
    public class Meter : Unit
    {
        private string ToUnit = null;
        private string ThisUnit = "meters";

        //Conversion values
        private double ToInch = 39.3700787;
        private double ToFeet = 3.2808;
        private double ToMile = 0.000621;
        private double ToCm = 100;
        private double ToM = 1;
        private double ToKm = 0.001;

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
