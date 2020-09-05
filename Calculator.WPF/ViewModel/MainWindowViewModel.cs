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
            _oldValue = 0;

            Calculate = new DelegateCommand(
                () =>
                {

                    unit = createUnit(OldUnitList.ToString());
                    unit.Calculate(_oldValue, NewUnitList.ToString());

                    ValueAnswer = unit.GetNewValue().ToString();
                    UnitAnswer = unit.GetNewUnit().ToString();
                },
                () =>
                {
                    return (SelectedNewUnit != null && SelectedOldUnit != null);
                });

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

        public double _oldValue { get; set; }

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

        //public string SelectedOldUnit { get; set; }
        //public string SelectedNewUnit { get; set; }


        //private DelegateCommand calculate;
        //public DelegateCommand Calculate => calculate ?? new DelegateCommand(
        //    ()=> 
        //    {
        //        unit = createUnit(SelectedOldUnit);
        //        unit.Calculate(_oldValue, SelectedNewUnit);

        //        ValueAnswer = unit.GetNewValue().ToString();
        //        UnitAnswer = unit.GetNewUnit().ToString();
                
        //        RaisePropertyChanged(nameof(ValueAnswer));
        //        RaisePropertyChanged(nameof(UnitAnswer));
        //    }, 
        //    ()=> 
        //    {
        //        return SelectedNewUnit != null && SelectedOldUnit != null;

        //    });



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
