using Microsoft.Win32;
using OfficeOpenXml;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Transactions;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace Calculator.WPF.ViewModel
{
    public class MainWindowViewModel : BindableBase
    {
        public Unit unit { get; set; }
        public ObservableCollection<Unit> HistoryList { get; set; }

        private string _filePath;
        public string FilePath
        {
            get { return _filePath; }
            set 
            {
                SetProperty(ref _filePath, value);
                RaisePropertyChanged(nameof(FilePath));
                ImportCommand.RaiseCanExecuteChanged();
            }
        }

        private double _oldUnitValue;
        public double OldUnitValue
        {
            get { return _oldUnitValue; }
            set
            {
                SetProperty(ref _oldUnitValue, value);
                CalculateCommand.RaiseCanExecuteChanged();
            }
        }
        
        private ObservableCollection<string> _oldUnitList;

        public ObservableCollection<string> OldUnitList
        {
            get { return _oldUnitList; }
            set
            {
                _oldUnitList = value;
                CalculateCommand.RaiseCanExecuteChanged();

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

                CalculateCommand.RaiseCanExecuteChanged();
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
                CalculateCommand.RaiseCanExecuteChanged();
            }
        }

        private string _selectedNewUnit;
        public string SelectedNewUnit
        {
            get { return _selectedNewUnit; }
            set
            {
                SetProperty(ref _selectedNewUnit, value);
                CalculateCommand.RaiseCanExecuteChanged();
            }
        }
        public MainWindowViewModel()
        {
            HistoryList = new ObservableCollection<Unit>();
            ValueAnswer = "[]";
            UnitAnswer = "[]";

            CalculateCommand = new DelegateCommand(
                () =>
                {
                    CalculateAnswer();                  
                },
                () =>
                {
                return (/*OldUnitValue != null &&*/ SelectedNewUnit != null && SelectedOldUnit != null);
                });

            BrowseCommand = new DelegateCommand(
                ()=>
                {
                    GetFile();
                });

            ImportCommand = new DelegateCommand(
                ()=>
                {
                    ImportFromExcel();
                    OldUnitValue= HistoryList.Last().GetOldValue();
                    SelectedOldUnit = HistoryList.Last().GetThisUnit();
                    SelectedNewUnit = HistoryList.Last().GetNewUnit().Remove(0, 3);

                    ValueAnswer = HistoryList.Last().GetNewValue().ToString();
                    UnitAnswer = HistoryList.Last().GetNewUnit().ToString().Remove(0, 3);

                    RaisePropertyChanged(nameof(ValueAnswer));
                    RaisePropertyChanged(nameof(UnitAnswer));
                },
                ()=>
                {
                    return (FilePath != null);
                });
            

            //OldUnitValue = 0;
            OldUnitList = new ObservableCollection<string>()
            {
                "cm", "ft", "in", "km", "m", "mile"
            };

            NewUnitList = new ObservableCollection<string>()
            {
                "cm", "ft", "in", "km", "m", "mile"
            };
        }

        private void ImportFromExcel()
        {
            Unit _unit;
            var rows = new List<Unit>();

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage excelPackage = new ExcelPackage(new FileInfo(FilePath));

            var sheet = excelPackage.Workbook.Worksheets.First();

            for(int row=2; row <= sheet.Dimension.End.Row; row++)
            {
                _unit = createUnit((string)sheet.Cells[row, 2].Value);
                _unit.Calculate((double)sheet.Cells[row, 1].Value,"to " +  (string)sheet.Cells[row, 3].Value);

                HistoryList.Add(_unit);
            }
        }

        private void CalculateAnswer()
        {
            unit = createUnit(SelectedOldUnit);
            unit.Calculate(OldUnitValue, "to " + SelectedNewUnit);

            ValueAnswer = unit.GetNewValue().ToString();
            UnitAnswer = unit.GetNewUnit().ToString();
            UnitAnswer = UnitAnswer.Remove(0, 3);

            HistoryList.Add(unit);

            RaisePropertyChanged(nameof(ValueAnswer));
            RaisePropertyChanged(nameof(UnitAnswer));
        }

        private void GetFile()
        {
            var dialog = new OpenFileDialog();
            dialog.Title = "Find Excel file to import";
            dialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            dialog.Multiselect = false;

            if(dialog.ShowDialog() ?? false)
            {
                FilePath = dialog.FileName;
            }
        }

        public DelegateCommand CalculateCommand { get; private set; }

        public DelegateCommand BrowseCommand { get; private set; }
        
        public DelegateCommand ImportCommand { get; private set; }

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
                case "mile":
                    unit = new Mile();
                    break;
                default: throw new InvalidEnumArgumentException();
            }

            return unit;
        }
    }
}
