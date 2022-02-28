// Grading ID: S1918
// Program 2
// Due Date: 3/5/20
// CIS-199-75
// Calculates income tax based off income and a specific plan
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace Program_2
{
    public partial class programTwoForm : Form
    {
        public programTwoForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int income;
            double tax;

            // BASELINE CONSTANTS
            const int BASELINE_INCOME_1 = 9700;
            const int BASELINE_INCOME_2 = 39475;
            const int BASELINE_INCOME_3 = 84200;
            const int BASELINE_INCOME_4 = 160725;
            const int BASELINE_INCOME_5 = 204100;
            const int BASELINE_INCOME_6 = 510300;

            const double BASELINE_TAX_RATE_1 = .1;
            const double BASELINE_TAX_RATE_2 = .12;
            const double BASELINE_TAX_RATE_3 = .22;
            const double BASELINE_TAX_RATE_4 = .24;
            const double BASELINE_TAX_RATE_5 = .32;
            const double BASELINE_TAX_RATE_6 = .35;
            const double BASELINE_TAX_RATE_7 = .37;

            const double MAX_BASELINE_INCOME_1_TAX = 970;
            const double MAX_BASELINE_INCOME_2_TAX = 3573;
            const double MAX_BASELINE_INCOME_3_TAX = 9839.5;
            const double MAX_BASELINE_INCOME_4_TAX = 18366;
            const double MAX_BASELINE_INCOME_5_TAX = 13880;
            const double MAX_BASELINE_INCOME_6_TAX = 107170;


            //CANDIDATE ONE CONSTANTS
            const int C_1_INCOME_1 = 9525;
            const int C_1_INCOME_2 = 38700;
            const int C_1_INCOME_3 = 82500;
            const int C_1_INCOME_4 = 157500;
            const int C_1_INCOME_5 = 200000;
            const int C_1_INCOME_6 = 500000;

            const double C_1_TAX_RATE_1 = .1;
            const double C_1_TAX_RATE_2 = .15;
            const double C_1_TAX_RATE_3 = .25;
            const double C_1_TAX_RATE_4 = .28;
            const double C_1_TAX_RATE_5 = .33;
            const double C_1_TAX_RATE_6 = .35;
            const double C_1_TAX_RATE_7 = .396;

            const double MAX_C_1_INCOME_1_TAX = 952.5;
            const double MAX_C_1_INCOME_2_TAX = 4376.25;
            const double MAX_C_1_INCOME_3_TAX = 10950;
            const double MAX_C_1_INCOME_4_TAX = 21000;
            const double MAX_C_1_INCOME_5_TAX = 14025;
            const double MAX_C_1_INCOME_6_TAX = 105000;


            //CANDIDATE TWO CONSTANTS
            const int C_2_INCOME_1 = 9525;
            const int C_2_INCOME_2_ADDITIONAL_LIMIT = 29000;
            const int C_2_INCOME_2 = 38700;
            const int C_2_INCOME_3 = 82500;
            const int C_2_INCOME_4 = 157500;
            const int C_2_INCOME_5 = 200000;
            const int C_2_INCOME_6 = 250000;
            const int C_2_INCOME_7 = 500000;
            const int C_2_INCOME_8 = 2000000;
            const int C_2_INCOME_9 = 10000000;

            const double C_2_TAX_RATE_1 = .1;
            const double C_2_TAX_RATE_2 = .12;
            const double C_2_TAX_RATE_3 = .22;
            const double C_2_TAX_RATE_4 = .24;
            const double C_2_TAX_RATE_5 = .32;
            const double C_2_TAX_RATE_6 = .35;
            const double C_2_TAX_RATE_7 = .4;
            const double C_2_TAX_RATE_8 = .45;
            const double C_2_TAX_RATE_9 = .5;
            const double C_2_TAX_RATE_10 = .52;

            const double MAX_C_2_INCOME_1_TAX = 952.5;
            const double MAX_C_2_INCOME_2_TAX_ADDITION = 2337;
            const double MAX_C_2_INCOME_2_TAX = 3889;
            const double MAX_C_2_INCOME_3_TAX = 11388;
            const double MAX_C_2_INCOME_4_TAX = 21000;
            const double MAX_C_2_INCOME_5_TAX = 15300;
            const double MAX_C_2_INCOME_6_TAX = 19500;
            const double MAX_C_2_INCOME_7_TAX = 110000;
            const double MAX_C_2_INCOME_8_TAX = 735000;
            const double MAX_C_2_INCOME_9_TAX = 4320000;

            const double ADDITIONAL_TAX = .04;

            //CANDIDATE THREE CONSTANTS
            // some constants from candidate one apply to candidate three
            const double REDUCTION_DIFF = .1;

            const double MAX_TAX_AFTER_REDUCTION_1 = 857.25;
            const double MAX_TAX_AFTER_REDUCTION_2 = 3938.625;
            const double MAX_TAX_AFTER_REDUCTION_3 = 9855;
            const double MAX_TAX_AFTER_REDUCTION_4 = 18900;
            const double MAX_TAX_AFTER_REDUCTION_5 = 12622.5;


            int.TryParse(incomeTxt.Text, out income);

            //baseline
            if (baselineButton.Checked)
            {
                if (income <= BASELINE_INCOME_1)
                {
                    tax = income * BASELINE_TAX_RATE_1; // calculates tax owed
                    taxRateResultLbl.Text = ($"{BASELINE_TAX_RATE_1:P}"); // displays marginal tax rate
                    taxOwedResultLbl.Text = ($"{tax:C}"); // displays tax owed
                }
                else if (income <= BASELINE_INCOME_2)
                {
                    tax = (MAX_BASELINE_INCOME_1_TAX) + ((income - BASELINE_INCOME_1) * BASELINE_TAX_RATE_2); // calculates tax owed
                    taxRateResultLbl.Text = ($"{BASELINE_TAX_RATE_2:P}"); // displays marginal tax rate
                    taxOwedResultLbl.Text = ($"{tax:C}"); // displays tax owed
                }
                else if (income <= BASELINE_INCOME_3)
                {
                    tax = (MAX_BASELINE_INCOME_1_TAX) + (MAX_BASELINE_INCOME_2_TAX) + ((income - BASELINE_INCOME_2) * BASELINE_TAX_RATE_3); // calculates tax owed
                    taxRateResultLbl.Text = ($"{BASELINE_TAX_RATE_3:P}"); // displays marginal tax rate
                    taxOwedResultLbl.Text = ($"{tax:C}"); // displays tax owed
                }
                else if (income <= BASELINE_INCOME_4)
                {
                    tax = (MAX_BASELINE_INCOME_1_TAX) + (MAX_BASELINE_INCOME_2_TAX) + (MAX_BASELINE_INCOME_3_TAX) + ((income - BASELINE_INCOME_3) * BASELINE_TAX_RATE_4); // calculates tax owed
                    taxRateResultLbl.Text = ($"{BASELINE_TAX_RATE_4:P}"); // displays marginal tax rate
                    taxOwedResultLbl.Text = ($"{tax:C}"); // displays tax owed
                }
                else if (income <= BASELINE_INCOME_5)
                {
                    tax = (MAX_BASELINE_INCOME_1_TAX) + (MAX_BASELINE_INCOME_2_TAX) + (MAX_BASELINE_INCOME_3_TAX) + (MAX_BASELINE_INCOME_4_TAX) + ((income - BASELINE_INCOME_4) * BASELINE_TAX_RATE_5); // calculates tax owed
                    taxRateResultLbl.Text = ($"{BASELINE_TAX_RATE_5:P}"); // displays marginal tax rate
                    taxOwedResultLbl.Text = ($"{tax:C}"); // displays tax owed
                }
                else if (income <= BASELINE_INCOME_6)
                {
                    tax = (MAX_BASELINE_INCOME_1_TAX) + (MAX_BASELINE_INCOME_2_TAX) + (MAX_BASELINE_INCOME_3_TAX) + (MAX_BASELINE_INCOME_4_TAX) + (MAX_BASELINE_INCOME_5_TAX) + ((income - BASELINE_INCOME_5) * BASELINE_TAX_RATE_6); // calculates tax owed
                    taxRateResultLbl.Text = ($"{BASELINE_TAX_RATE_6:P}"); // displays marginal tax rate
                    taxOwedResultLbl.Text = ($"{tax:C}"); // displays tax owed
                }
                else
                {
                    tax = (MAX_BASELINE_INCOME_1_TAX) + (MAX_BASELINE_INCOME_2_TAX) + (MAX_BASELINE_INCOME_3_TAX) + (MAX_BASELINE_INCOME_4_TAX) + (MAX_BASELINE_INCOME_5_TAX) + (MAX_BASELINE_INCOME_6_TAX) + ((income - BASELINE_INCOME_6) * BASELINE_TAX_RATE_7); // calculates tax owed
                    taxRateResultLbl.Text = ($"{BASELINE_TAX_RATE_7:P}"); // displays marginal tax rate
                    taxOwedResultLbl.Text = ($"{tax:C}"); // displays tax owed
                }
            }

            //candidate one
            else if (candidateOneButton.Checked)
            {
                if (income <= C_1_INCOME_1)
                {
                    tax = income * C_1_TAX_RATE_1; // calculates tax owed
                    taxRateResultLbl.Text = ($"{C_1_TAX_RATE_1:P}"); // displays marginal tax rate
                    taxOwedResultLbl.Text = ($"{tax:C}"); // displays tax owed
                }
                else if (income <= C_1_INCOME_2)
                {
                    tax = (MAX_C_1_INCOME_1_TAX) + ((income - C_1_INCOME_1) * C_1_TAX_RATE_2); // calculates tax owed
                    taxRateResultLbl.Text = ($"{C_1_TAX_RATE_2:P}"); // displays marginal tax rate
                    taxOwedResultLbl.Text = ($"{tax:C}"); // displays tax owed
                }
                else if (income <= C_1_INCOME_3)
                {
                    tax = (MAX_C_1_INCOME_1_TAX) + (MAX_C_1_INCOME_2_TAX) + ((income - C_1_INCOME_2) * C_1_TAX_RATE_3); // calculates tax owed
                    taxRateResultLbl.Text = ($"{C_1_TAX_RATE_3:P}"); // displays marginal tax rate
                    taxOwedResultLbl.Text = ($"{tax:C}"); // displays tax owed
                }
                else if (income <= C_1_INCOME_4)
                {
                    tax = (MAX_C_1_INCOME_1_TAX) + (MAX_C_1_INCOME_2_TAX) + (MAX_C_1_INCOME_3_TAX) + ((income - C_1_INCOME_3) * C_1_TAX_RATE_4); // calculates tax owed
                    taxRateResultLbl.Text = ($"{C_1_TAX_RATE_4:P}"); // displays marginal tax rate
                    taxOwedResultLbl.Text = ($"{tax:C}"); // displays tax owed
                }
                else if (income <= C_1_INCOME_5)
                {
                    tax = (MAX_C_1_INCOME_1_TAX) + (MAX_C_1_INCOME_2_TAX) + (MAX_C_1_INCOME_3_TAX) + (MAX_C_1_INCOME_4_TAX) + ((income - C_1_INCOME_4) * C_1_TAX_RATE_5); // calculates tax owed
                    taxRateResultLbl.Text = ($"{C_1_TAX_RATE_5:P}"); // displays marginal tax rate
                    taxOwedResultLbl.Text = ($"{tax:C}"); // displays tax owed
                }
                else if (income <= C_1_INCOME_6)
                {
                    tax = (MAX_C_1_INCOME_1_TAX) + (MAX_C_1_INCOME_2_TAX) + (MAX_C_1_INCOME_3_TAX) + (MAX_C_1_INCOME_4_TAX) + (MAX_C_1_INCOME_5_TAX) + ((income - C_1_INCOME_5) * C_1_TAX_RATE_6); // calculates tax owed
                    taxRateResultLbl.Text = ($"{C_1_TAX_RATE_6:P}"); // displays marginal tax rate
                    taxOwedResultLbl.Text = ($"{tax:C}"); // displays tax owed
                }
                else
                {
                    tax = (MAX_C_1_INCOME_1_TAX) + (MAX_C_1_INCOME_2_TAX) + (MAX_C_1_INCOME_3_TAX) + (MAX_C_1_INCOME_4_TAX) + (MAX_C_1_INCOME_5_TAX) + (MAX_C_1_INCOME_6_TAX) + ((income - C_1_INCOME_6) * C_1_TAX_RATE_7); // calculates tax owed
                    taxRateResultLbl.Text = ($"{C_1_TAX_RATE_7:P}"); // displays marginal tax rate
                    taxOwedResultLbl.Text = ($"{tax:C}"); // displays tax owed
                }
            }

            // candidate two
            else if (candidateTwoButton.Checked)
            {
                if (income <= C_2_INCOME_1)
                {
                    tax = income * C_2_TAX_RATE_1; // calculates tax owed
                    taxRateResultLbl.Text = ($"{C_2_TAX_RATE_1:P}"); // displays marginal tax rate
                    taxOwedResultLbl.Text = ($"{tax:C}"); // displays tax owed
                }
                else if (income <= C_2_INCOME_2_ADDITIONAL_LIMIT)
                {
                    tax = (MAX_C_2_INCOME_1_TAX) + ((income - C_2_INCOME_1) * C_2_TAX_RATE_2); // calculates tax owed
                    taxRateResultLbl.Text = ($"{C_2_TAX_RATE_2:P}"); // displays marginal tax rate
                    taxOwedResultLbl.Text = ($"{tax:C}"); // displays tax owed
                }
                else if (income <= C_2_INCOME_2)
                {
                    tax = (MAX_C_2_INCOME_1_TAX) + (MAX_C_2_INCOME_2_TAX_ADDITION) + ((income - C_2_INCOME_2_ADDITIONAL_LIMIT) * (C_2_TAX_RATE_2 + ADDITIONAL_TAX)); // calculates tax owed
                    taxRateResultLbl.Text = ($"{C_2_TAX_RATE_2 + ADDITIONAL_TAX:P}"); // displays marginal tax rate
                    taxOwedResultLbl.Text = ($"{tax:C}"); // displays tax owed
                }
                else if (income <= C_2_INCOME_3)
                {
                    tax = (MAX_C_2_INCOME_1_TAX) + (MAX_C_2_INCOME_2_TAX) + ((income - C_2_INCOME_2) * (C_2_TAX_RATE_3 + ADDITIONAL_TAX)); // calculates tax owed
                    taxRateResultLbl.Text = ($"{C_2_TAX_RATE_3 + ADDITIONAL_TAX:P}"); // displays marginal tax rate
                    taxOwedResultLbl.Text = ($"{tax:C}"); // displays tax owed
                }
                else if (income <= C_2_INCOME_4)
                {
                    tax = (MAX_C_2_INCOME_1_TAX) + (MAX_C_2_INCOME_2_TAX) + (MAX_C_2_INCOME_3_TAX) + ((income - C_2_INCOME_3) * (C_2_TAX_RATE_4 + ADDITIONAL_TAX)); // calculates tax owed
                    taxRateResultLbl.Text = ($"{C_2_TAX_RATE_4 + ADDITIONAL_TAX:P}"); // displays marginal tax rate
                    taxOwedResultLbl.Text = ($"{tax:C}"); // displays tax owed
                }
                else if (income <= C_2_INCOME_5)
                {
                    tax = (MAX_C_2_INCOME_1_TAX) + (MAX_C_2_INCOME_2_TAX) + (MAX_C_2_INCOME_3_TAX) + (MAX_C_2_INCOME_4_TAX) + ((income - C_2_INCOME_4) * (C_2_TAX_RATE_5 + ADDITIONAL_TAX)); // calculates tax owed
                    taxRateResultLbl.Text = ($"{C_2_TAX_RATE_5 + ADDITIONAL_TAX:P}"); // displays marginal tax rate
                    taxOwedResultLbl.Text = ($"{tax:C}"); // displays tax owed
                }
                else if (income <= C_2_INCOME_6)
                {
                    tax = (MAX_C_2_INCOME_1_TAX) + (MAX_C_2_INCOME_2_TAX) + (MAX_C_2_INCOME_3_TAX) + (MAX_C_2_INCOME_4_TAX) + (MAX_C_2_INCOME_5_TAX) + ((income - C_2_INCOME_5) * (C_2_TAX_RATE_6 + ADDITIONAL_TAX)); // calculates tax owed
                    taxRateResultLbl.Text = ($"{C_2_TAX_RATE_6 + ADDITIONAL_TAX:P}"); // displays marginal tax rate
                    taxOwedResultLbl.Text = ($"{tax:C}"); // displays tax owed
                }
                else if (income <= C_2_INCOME_7)
                {
                    tax = (MAX_C_2_INCOME_1_TAX) + (MAX_C_2_INCOME_2_TAX) + (MAX_C_2_INCOME_3_TAX) + (MAX_C_2_INCOME_4_TAX) + (MAX_C_2_INCOME_5_TAX) + (MAX_C_2_INCOME_6_TAX) + ((income - C_2_INCOME_6) * (C_2_TAX_RATE_7 + ADDITIONAL_TAX)); // calculates tax owed
                    taxRateResultLbl.Text = ($"{C_2_TAX_RATE_7 + ADDITIONAL_TAX:P}"); // displays marginal tax rate
                    taxOwedResultLbl.Text = ($"{tax:C}"); // displays tax owed
                }
                else if (income <= C_2_INCOME_8)
                {
                    tax = (MAX_C_2_INCOME_1_TAX) + (MAX_C_2_INCOME_2_TAX) + (MAX_C_2_INCOME_3_TAX) + (MAX_C_2_INCOME_4_TAX) + (MAX_C_2_INCOME_5_TAX) + (MAX_C_2_INCOME_6_TAX) + (MAX_C_2_INCOME_7_TAX) + ((income - C_2_INCOME_7) * (C_2_TAX_RATE_8 + ADDITIONAL_TAX)); // calculates tax owed
                    taxRateResultLbl.Text = ($"{C_2_TAX_RATE_8 + ADDITIONAL_TAX:P}"); // displays marginal tax rate
                    taxOwedResultLbl.Text = ($"{tax:C}"); // displays tax owed
                }
                else if (income <= C_2_INCOME_9)
                {
                    tax = (MAX_C_2_INCOME_1_TAX) + (MAX_C_2_INCOME_2_TAX) + (MAX_C_2_INCOME_3_TAX) + (MAX_C_2_INCOME_4_TAX) + (MAX_C_2_INCOME_5_TAX) + (MAX_C_2_INCOME_6_TAX) + (MAX_C_2_INCOME_7_TAX) + (MAX_C_2_INCOME_8_TAX) + ((income - C_2_INCOME_8) * (C_2_TAX_RATE_9 + ADDITIONAL_TAX)); // calculates tax owed
                    taxRateResultLbl.Text = ($"{C_2_TAX_RATE_9 + ADDITIONAL_TAX:P}"); // displays marginal tax rate
                    taxOwedResultLbl.Text = ($"{tax:C}"); // displays tax owed
                }
                else
                {
                    tax = (MAX_C_2_INCOME_1_TAX) + (MAX_C_2_INCOME_2_TAX) + (MAX_C_2_INCOME_3_TAX) + (MAX_C_2_INCOME_4_TAX) + (MAX_C_2_INCOME_5_TAX) + (MAX_C_2_INCOME_6_TAX) + (MAX_C_2_INCOME_7_TAX) + (MAX_C_2_INCOME_8_TAX) + (MAX_C_2_INCOME_9_TAX) + ((income - C_2_INCOME_9) * (C_2_TAX_RATE_10 + ADDITIONAL_TAX)); // calculates tax owed
                    taxRateResultLbl.Text = ($"{C_2_TAX_RATE_10 + ADDITIONAL_TAX:P}"); // displays marginal tax rate
                    taxOwedResultLbl.Text = ($"{tax:C}"); // displays tax owed
                }
            }

            // candidate three
            else if(candidateThreeButton.Checked) // used another if statement to idicate button checked. without if statement, the results for candidate 3 would display if no button was checked.
            {
                if (income <= C_1_INCOME_1)
                {
                    tax = income * (C_1_TAX_RATE_1 - (C_1_TAX_RATE_1 * REDUCTION_DIFF)); // calculates tax owed
                    taxRateResultLbl.Text = ($"{C_1_TAX_RATE_1:P}"); // displays marginal tax rate
                    taxOwedResultLbl.Text = ($"{tax:C}"); // displays tax owed
                }
                else if (income <= C_1_INCOME_2)
                {
                    tax = (MAX_TAX_AFTER_REDUCTION_1) + ((income - C_1_INCOME_1) * (C_1_TAX_RATE_2 - (C_1_TAX_RATE_2 * REDUCTION_DIFF))); // calculates tax owed
                    taxRateResultLbl.Text = ($"{C_1_TAX_RATE_2:P}"); // displays marginal tax rate
                    taxOwedResultLbl.Text = ($"{tax:C}"); // displays tax owed
                }
                else if (income <= C_1_INCOME_3)
                {
                    tax = (MAX_TAX_AFTER_REDUCTION_1) + (MAX_TAX_AFTER_REDUCTION_2) + ((income - C_1_INCOME_2) * (C_1_TAX_RATE_3 - (C_1_TAX_RATE_3 * REDUCTION_DIFF))); // calculates tax owed
                    taxRateResultLbl.Text = ($"{C_1_TAX_RATE_3:P}"); // displays marginal tax rate
                    taxOwedResultLbl.Text = ($"{tax:C}"); // displays tax owed
                }
                else if (income <= C_1_INCOME_4)
                {
                    tax = (MAX_TAX_AFTER_REDUCTION_1) + (MAX_TAX_AFTER_REDUCTION_2) + (MAX_TAX_AFTER_REDUCTION_3) + ((income - C_1_INCOME_3) * (C_1_TAX_RATE_4 - (C_1_TAX_RATE_4 * REDUCTION_DIFF))); // calculates tax owed
                    taxRateResultLbl.Text = ($"{C_1_TAX_RATE_4:P}"); // displays marginal tax rate
                    taxOwedResultLbl.Text = ($"{tax:C}"); // displays tax owed
                }
                else if (income <= C_1_INCOME_5)
                {
                    tax = (MAX_TAX_AFTER_REDUCTION_1) + (MAX_TAX_AFTER_REDUCTION_2) + (MAX_TAX_AFTER_REDUCTION_3) + (MAX_TAX_AFTER_REDUCTION_4) + ((income - C_1_INCOME_4) * (C_1_TAX_RATE_5 - (C_1_TAX_RATE_5 * REDUCTION_DIFF))); // calculates tax owed
                    taxRateResultLbl.Text = ($"{C_1_TAX_RATE_5:P}"); // displays marginal tax rate
                    taxOwedResultLbl.Text = ($"{tax:C}"); // displays tax owed
                }
                else if (income <= C_1_INCOME_6)
                {
                    tax = (MAX_TAX_AFTER_REDUCTION_1) + (MAX_TAX_AFTER_REDUCTION_2) + (MAX_TAX_AFTER_REDUCTION_3) + (MAX_TAX_AFTER_REDUCTION_4) + (MAX_TAX_AFTER_REDUCTION_5) + ((income - C_1_INCOME_5) * C_1_TAX_RATE_6); // calculates tax owed
                    taxRateResultLbl.Text = ($"{C_1_TAX_RATE_6:P}"); // displays marginal tax rate
                    taxOwedResultLbl.Text = ($"{tax:C}"); // displays tax owed
                }
                else
                {
                    tax = (MAX_TAX_AFTER_REDUCTION_1) + (MAX_TAX_AFTER_REDUCTION_2) + (MAX_TAX_AFTER_REDUCTION_3) + (MAX_TAX_AFTER_REDUCTION_4) + (MAX_TAX_AFTER_REDUCTION_5) + (MAX_C_1_INCOME_6_TAX) + ((income - C_1_INCOME_6) * C_1_TAX_RATE_7); // calculates tax owed
                    taxRateResultLbl.Text = ($"{C_1_TAX_RATE_7:P}"); // displays marginal tax rate
                    taxOwedResultLbl.Text = ($"{tax:C}"); // displays tax owed
                }
            }
        }
    }
}
