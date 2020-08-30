using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.WinForms._2
{
    public partial class MainForm : Form
    {
        List<Unit> history = new List<Unit>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void CalculateBtnClicked(object sender, EventArgs e)
        {
            //Get data
            double originalNum = (double)numToConvert.Value;
            string originalUnit = comboOriginalUnit.Text;
            string newUnit = "to " + comboConvertTo.Text;

            Unit unit = null;
            double newNum = 0;

            try
            {
                //Create Unit object
                unit = createUnit(originalUnit);
                
                //Calculate converted unit
                newNum = unit.Calculate(originalNum, newUnit);
            
                //Display answer
                textAnswer.Text = newNum.ToString() + " " + (unit.GetNewUnit().ToLower().Remove(0,3));

                history.Add(unit);
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
                
                MessageBox.Show("Invalid units. Please enter the information again", "Error");

                numToConvert.Value = 0;
                comboOriginalUnit.Text = "";
                comboConvertTo.Text = "";
                textAnswer.Text = "";
            }           
        }

        //Return reference to unit to use.
        private Unit createUnit(string originalUnit)
        {
            Unit unit;

            switch (originalUnit)
            {
                case "cm": unit = new Centimeter();
                    break;
                case "ft": unit = new Foot();
                    break;
                case "in": unit = new Inch();
                    break;
                case "km": unit = new Kilometer();
                    break;
                case "m": unit = new Meter();
                    break;
                case "miles": unit = new Mile();
                    break;
                default: throw new InvalidEnumArgumentException();                   
            }

            return unit;
        }

        public void gridHistoryTabIndexChanged(object sender, EventArgs e)
        {
            if(tabControl.SelectedTab == tabHistory)
            {
                gridHistory.Rows.Clear();
                
                foreach(Unit i in history)
                {
                    gridHistory.Rows.Add(i.GetOldValue(), i.GetThisUnit(), i.GetNewValue(), i.GetNewUnit().ToLower().Remove(0, 3));
                }
            }
        }
    }
}
