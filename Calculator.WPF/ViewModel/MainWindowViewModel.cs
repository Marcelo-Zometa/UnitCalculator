using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Transactions;

namespace Calculator.WPF.ViewModel
{
    public class MainWindowViewModel : BindableBase
    {
        public Unit unit { get; set; }

        public MainWindowViewModel()
        {
            ValueAnswer = "[]";
            UnitAnswer = "[]";

            Calculate = new DelegateCommand(
                () =>
                {

                    unit = createUnit(SelectedOldUnit);
                    unit.Calculate(OldValue, "to " + SelectedNewUnit);
                    
                    ValueAnswer = unit.GetNewValue().ToString();
                    UnitAnswer = unit.GetNewUnit().ToString();
                    UnitAnswer = UnitAnswer.Remove(0, 3);

                    RaisePropertyChanged(nameof(ValueAnswer));
                    RaisePropertyChanged(nameof(UnitAnswer));
                },
                () =>
                {
                return (/*OldValue != null &&*/ SelectedNewUnit != null && SelectedOldUnit != null);
                });

            //OldValue = 0;
            OldUnitList = new ObservableCollection<string>()
            {
                "cm", "ft", "in", "km", "m", "mile"
            };

            NewUnitList = new ObservableCollection<string>()
            {
                "cm", "ft", "in", "km", "m", "mile"
            };
        }
        public DelegateCommand Calculate { get; private set; }

        private double _oldValue;
        public double OldValue
        {
            get { return _oldValue; }
            set
            {
                SetProperty(ref _oldValue, value);
                Calculate.RaiseCanExecuteChanged();
            }
        }
        //public string OldValue { get; set; }

        private ObservableCollection<string> _oldUnitList;

        public ObservableCollection<string> OldUnitList
        {
            get { return _oldUnitList; }
            set 
            { 
                _oldUnitList = value;
                Calculate.RaiseCanExecuteChanged();
                
                RaisePropertyChanged(nameof(OldUnitList));
            }
        }

        private ObservableCollection<string> _newUnitList;

        public ObservableCollection<string> NewUnitList
        {
            get { return _newUnitList; }
            set 
            { 
                _newUnitList = value;
                
                Calculate.RaiseCanExecuteChanged();
                RaisePropertyChanged(nameof(NewUnitList));

            }

        }

        public string ValueAnswer { get; set; }
        public string UnitAnswer { get; set; }

        private string _selectedOldUnit;
        public string SelectedOldUnit
        {
            get { return _selectedOldUnit; }
            set 
            {
                SetProperty(ref _selectedOldUnit, value);
                Calculate.RaiseCanExecuteChanged();
            }
        }

        private string _selectedNewUnit;
        public string SelectedNewUnit
        {
            get { return _selectedNewUnit; }
            set
            {
                SetProperty(ref _selectedNewUnit, value);
                Calculate.RaiseCanExecuteChanged();
            }
        }



        //Returns reference to unit t be created
        private Unit createUnit(string originalUnit)
        {
            Unit unit;

            switch (originalUnit)
            {
                case "cm":
                    unit = new Centimeter();
                    break;
                case "ft":
                    unit = new Foot();
                    break;
                case "in":
                    unit = new Inch();
                    break;
                case "km":
                    unit = new Kilometer();
                    break;
                case "m":
                    unit = new Meter();
                    break;
                case "miles":
                    unit = new Mile();
                    break;
                default: throw new InvalidEnumArgumentException();
            }

            return unit;
        }
    }
}
