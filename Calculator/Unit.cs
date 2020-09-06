using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public abstract class Unit
    {
        //private string ToUnit = null;
        //private string ThisUnit = null;

        private double ToInch = 0;
        private double ToFeet = 0;
        private double ToMile = 0;
        private double ToCm = 0;
        private double ToM = 0;
        private double ToKm = 0;

        private string _thisUnit;
        public string ThisUnit
        {
            get { return _thisUnit; }
            set { _thisUnit =  value; }
        }

        private string _toUnit;
        public string ToUnit
        {
            get { return _toUnit; }
            set { _toUnit = value; }
        }

        private double _newValue;
        public double NewValue
        {
            get { return _newValue; }
            set { _newValue = value; }
        }
        private double _oldValue;
        public double OldValue
        {
            get { return _oldValue; }
            set { _oldValue = value; }
        }
        

        //Constructor
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
            OldValue = quantity;

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

                case "to mile":
                    Console.WriteLine($"Converting from {ThisUnit} to miles");
                    toReturn = quantity * ToMile;
                    break;

                case "to cm":
                    Console.WriteLine($"Converting from {ThisUnit} to cm");
                    toReturn = quantity * ToCm;
                    break;

                case "to m":
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

            NewValue = toReturn;
            return toReturn;
        }       

        public string GetNewUnit()
        {
            return ToUnit;
        }

        public double GetOldValue()
        {
            return OldValue;
        }

        public string GetThisUnit()
        {
            return ThisUnit;
        }

        public double GetNewValue()
        {
            return NewValue;
        }
    }
}
