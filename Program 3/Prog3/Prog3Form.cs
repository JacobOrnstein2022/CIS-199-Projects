// Grading ID: S1918
// Program 3
// Due Date: 4/2/2020
// Section: CIS-199-75
// This application calculates the marginal tax rate for various candidates' tax plans.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog3
{
    public partial class Prog3Form : Form
    {
        public Prog3Form()
        {
            InitializeComponent();
        }

        private void calcTaxBtn_Click(object sender, EventArgs e)
        {
            double[] baseRates = { .1, .12, .22, .24, .32, .35, .37 }; //Baseline tax rates
            int[] baseThreshLowerLimit = { 1, 9700, 39475, 84200, 160725, 204100, 510300 }; // Baseline income thresholds

            double[] C2Rates = { .1, .12, .22, .24, .32, .35, .4, .45, .5, .52 }; // Candidate 2 tax rates
            int[] C2ThreshLowerLimit = { 1, 9525, 38700, 82500, 157500, 200000, 250000, 500000, 2000000, 10000000 }; // Candidate 2 income thresholds

            bool validInput = false; // checks if the input can be used for a range check
            int income; // Filer's taxable income (input)
            int baseIndex = baseThreshLowerLimit.Length - 1; // Baseline range check starting position 
            int C2Index = C2ThreshLowerLimit.Length - 1; // candidate 2 range check starting position

            if (int.TryParse(incomeTxt.Text, out income) && income >= 0)
            {
                if (baselineRdoBtn.Checked) // Baseline button
                {
                  while(baseIndex >= 0 && !validInput)
                    {
                        if (income >= baseThreshLowerLimit[baseIndex])
                            validInput = true; // shows input is valid
                        else
                            --baseIndex; // decrements through array
                    }

                  if(validInput)
                        marginalRateOutLbl.Text = $"{baseRates[baseIndex]:P}"; // displays tax rate
                    else
                        MessageBox.Show("Enter valid income!"); // displays message prompting for valid income

                }
                else // Candidate 2 button
                {
                    while (C2Index >= 0 && !validInput)
                    {
                        if (income >= C2ThreshLowerLimit[C2Index])
                            validInput = true; // shows input is valid
                        else
                            --C2Index; // decrements through array
                    }

                    if (validInput)
                        marginalRateOutLbl.Text = $"{C2Rates[C2Index]:P}"; // displays tax rate
                    else
                        MessageBox.Show("Enter valid income!"); // displays message prompting for valid income
                }
            }
        }

        private void candidate2RdoBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void candidate1RdoBtn_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
