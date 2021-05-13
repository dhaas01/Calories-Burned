using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calories_Burned__Number_7_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            const double CALORIES_PER_MINUTE = 3.9;         // The number of calories burned per minute.
            int counterMinutes = 10;                        // The number of minutes; needs to start at 10.
            double caloriesBurnedAfterXMinutes = 0;         // Holds the calculated number of calories burned.
            const int MAXIMUM_NUMBER_MINUTES = 30;          // The maximum number of minutes that need to be calculated for.
            // While loop executes while the number of minutes is less than 30.
            while (counterMinutes < MAXIMUM_NUMBER_MINUTES)
            { 
                // Calculates the calories burned.
                caloriesBurnedAfterXMinutes = counterMinutes * CALORIES_PER_MINUTE; 
                // Displays the calories burned in the ListBox.
                caloriesBurnedListBox.Items.Add("After " + counterMinutes + " minutes, " +
                    caloriesBurnedAfterXMinutes + " calories are burned."); 
                // Will increment the counter minutes by 5 because the number of minutes needs to be 10, 15, 20, etc.
                counterMinutes = counterMinutes + 5;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
