using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Transactions;

namespace Calculator.WPF.ViewModel
{
    public class MainWindowViewModel : BindableBase
    {
        public Unit calculator { get; set; }

        public MainWindowViewModel()
        {
            OldUnitList = new ObservableCollection<string>()
            {
                "cm", "ft", "in", "km", "m", "mile"
            };

            NewUnitList = new ObservableCollection<string>()
            {
                "cm", "ft", "in", "km", "m", "mile"
            };

        }

        private ObservableCollection<string> _oldUnitList;

        public ObservableCollection<string> OldUnitList
        {
            get { return _oldUnitList; }
            set { _oldUnitList = value; }
        }

        private ObservableCollection<string> _newUnitList;

        public ObservableCollection<string> NewUnitList
        {
            get { return _newUnitList; }
            set { _newUnitList = value; }
        }
    }
}
