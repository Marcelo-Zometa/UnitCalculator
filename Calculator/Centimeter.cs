using System;

namespace Calculator
{
    public class Centimeter : Unit
    {
        private string ToUnit = null;
        private string ThisUnit = "centimeters";

        //Conversion values
        private double ToInch = 0.39370079;
        private double ToFeet = 0.0328;
        private double ToMile = 0.00000621;
        private double ToCm = 1;
        private double ToM = 0.01;
        private double ToKm = 0.00001;

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
