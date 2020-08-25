using System;

namespace Calculator
{
    public class Mile : Unit
    {
        private string ToUnit = null;
        private string ThisUnit = "miles";

        //Conversion values
        private double ToInch = 63360;
        private double ToFeet = 5280;
        private double ToMile = 1;
        private double ToCm = 160934.4;
        private double ToM = 1609.34;
        private double ToKm = 1.609344;

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
