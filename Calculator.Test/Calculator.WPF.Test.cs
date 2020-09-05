using Calculator.WPF.ViewModel;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Calculator.Test
{
    public class WPF_Test
    {
        ObservableCollection<string> UnitList { get; set; }
        MainWindowViewModel vm;

        [SetUp]
        public void setup()
        {
            UnitList = new ObservableCollection<string>()
            {
                "cm", "ft", "in", "km", "m", "mile"
            };

            vm = new MainWindowViewModel();
        }

        [Test]
        public void constructorViewModelWorking()
        {
            Assert.AreEqual(UnitList, vm.NewUnitList);
            Assert.AreEqual(UnitList, vm.OldUnitList);
        }

        [Test]
        public void calculateButtonWorking()
        {
            /*If oldvalue and newvalue are not empty
             * create a unit with oldvalue.
             * call unit.calculate
             * Set answer textbox to value
             * 
             * Else
             * throw exception
            */
            vm.OldUnitValue = 1;
            vm.SelectedOldUnit = "m";
            vm.SelectedNewUnit = "cm";

            var expected = 100.00;
            vm.Calculate.Execute();

            Assert.AreEqual(expected, vm.unit.GetNewValue());
        }
    }
}
