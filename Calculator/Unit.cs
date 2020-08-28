using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public abstract class Unit
    {
        private string ToUnit = null;
        private string ThisUnit = null;

        private double ToInch = 0;
        private double ToFeet = 0;
        private double ToMile = 0;
        private double ToCm = 0;
        private double ToM = 0;
        private double ToKm = 0;

        public Unit(string toUnit, string thisUnit, double toInch,
            double toFeet, double toMile, double toCm, double toM,
            double toKm)
        {
            this.ToUnit = toUnit;
            this.ThisUnit = thisUnit;
            this.ToInch = toInch;
            this.ToFeet = toFeet;
            this.ToMile = toMile;
            this.ToCm = toCm;
            this.ToM = toM;
            this.ToKm = toKm;
        }

        public double Calculate(double quantity, string toUnit)
        {
            double toReturn = 0;

            ToUnit = toUnit.ToLower();

            switch (ToUnit)
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

        
    }
}
