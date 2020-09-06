using Microsoft.Win32;
using OfficeOpenXml;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Transactions;
using System.Windows;
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
                if(value < 0)
                {
                    MessageBox.Show("Invalid input. Value must be greater than 0", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                else
                {
                    SetProperty(ref _oldUnitValue, value);
                    CalculateCommand.RaiseCanExecuteChanged();
                }
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
                    GetFile("Find Excel file to import");
                });

            ImportCommand = new DelegateCommand(
                ()=>
                {
                    ImportFromExcel();
                    
                    //CalculateCommand.RaiseCanExecuteChanged();
                },
                ()=>
                {
                    return (FilePath != null);
                });

            ExportCommand = new DelegateCommand(
                ()=> 
                {
                    ExportToExcel();
                },
                ()=>
                {
                    return (HistoryList.Count() > 0);
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

        private void AssignAnswerValues()
        {
            ValueAnswer = HistoryList.Last().GetNewValue().ToString();
            UnitAnswer = HistoryList.Last().GetNewUnit().ToString().Remove(0, 3);

            RaisePropertyChanged(nameof(ValueAnswer));
            RaisePropertyChanged(nameof(UnitAnswer));
        }

        private void RaiseButtonCanExecute()
        {
            ImportCommand.RaiseCanExecuteChanged();
            CalculateCommand.RaiseCanExecuteChanged();
            ExportCommand.RaiseCanExecuteChanged();
        }

        public DelegateCommand CalculateCommand { get; private set; }

        private void CalculateAnswer()
        {
            unit = createUnit(SelectedOldUnit);
            unit.Calculate(OldUnitValue, "to " + SelectedNewUnit);

            HistoryList.Add(unit);

            AssignAnswerValues();
            RaiseButtonCanExecute();
        }

        public DelegateCommand BrowseCommand { get; private set; }
        private void GetFile(string message)
        {
            var dialog = new OpenFileDialog();
            dialog.Title = message;
            dialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            dialog.Multiselect = false;

            if (dialog.ShowDialog() ?? false)
            {
                FilePath = dialog.FileName;

            }
        }

        public DelegateCommand ImportCommand { get; private set; }
        private void ImportFromExcel()
        {
            Unit _unit;
            var rows = new List<Unit>();

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage excelPackage = new ExcelPackage(new FileInfo(FilePath));

            if(excelPackage.File.Exists == false)
            {
                MessageBox.Show("Invalid input. File does not exist", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var sheet = excelPackage.Workbook.Worksheets.First();

            for (int row = 2; row <= sheet.Dimension.End.Row; row++)
            {
                _unit = createUnit((string)sheet.Cells[row, 2].Value);
                _unit.Calculate((double)sheet.Cells[row, 1].Value, "to " + (string)sheet.Cells[row, 3].Value);

                HistoryList.Add(_unit);
            }
            OldUnitValue = HistoryList.Last().GetOldValue();
            SelectedOldUnit = HistoryList.Last().GetThisUnit();
            SelectedNewUnit = HistoryList.Last().GetNewUnit().Remove(0, 3);

            RaisePropertyChanged(nameof(OldUnitValue));
            RaisePropertyChanged(nameof(SelectedOldUnit));
            RaisePropertyChanged(nameof(SelectedNewUnit));

            AssignAnswerValues();

            RaiseButtonCanExecute();
        }

        public DelegateCommand ExportCommand { get; private set; }
        private void ExportToExcel()
        {
            GetFile("Locate file to export to");

            if (FilePath == null)
                return;

            if (File.Exists(FilePath))
            {
                var result = MessageBox.Show("There is another file named like that.", "Overwrite it?", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    File.Delete(FilePath);
                }
                else
                    return;
            }

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage package = new ExcelPackage(new FileInfo(FilePath));
            var sheet = package.Workbook.Worksheets.Add("Export");

            //Headers
            sheet.Cells[1, 1].Value = "Original Value";
            sheet.Cells[1, 2].Value = "Original Unit";
            sheet.Cells[1, 3].Value = "New Value";
            sheet.Cells[1, 4].Value = "New Unit";

            var row = 1;

            //Adding info to table
            foreach(Unit unit in HistoryList)
            {
                row++;
                sheet.Cells[row, 1].Value = unit.OldValue;
                sheet.Cells[row, 2].Value = unit.ThisUnit;
                sheet.Cells[row, 3].Value = unit.NewValue;
                sheet.Cells[row, 4].Value = unit.ToUnit.Remove(0,3);
            }

            sheet.Tables.Add(sheet.Cells[1, 1, row, 4], "ExportUnits");

            package.Save();

            new Process
            {
                StartInfo = new ProcessStartInfo(FilePath)
                {
                    UseShellExecute = true
                }
            }.Start();
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
                case "mile":
                    unit = new Mile();
                    break;
                default: throw new InvalidEnumArgumentException();
            }

            return unit;
        }
    }
}
