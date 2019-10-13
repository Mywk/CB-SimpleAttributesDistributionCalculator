using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CBSimpleAttributesDistributionCalculator
{
    public partial class CBSLDC : Form
    {
        /// <summary>
        /// A better NumericUpDown
        /// </summary>
        public class BetterNumericUpDown : System.Windows.Forms.NumericUpDown
        {
            // Amount to increase/decrease
            private int incDec = 5;

            public BetterNumericUpDown(bool oneStep = false)
            {
                if (oneStep)
                    incDec = 1;
            }

            /// <summary>
            /// This override fixes that pesky over-increment/decrement for the numericUpDown controls
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            protected override void OnMouseWheel(MouseEventArgs e)
            {
                HandledMouseEventArgs hme = e as HandledMouseEventArgs;
                if (hme != null)
                    hme.Handled = true;

                if (e.Delta > 0)
                {
                    if (this.Value < this.Maximum)
                    {
                        if (this.Value + incDec < this.Maximum)
                            this.Value += incDec;
                        else
                            this.Value += 1;
                    }
                }
                else if (e.Delta < 0)
                {
                    if (this.Value > this.Minimum)
                    {
                        if (this.Value - incDec > this.Minimum)
                            this.Value -= incDec;
                        else
                            this.Value -= 1;
                    }
                }
            }

            // Old value tracker
            public decimal OldValue = 25;

            // Old operation tracker
            public bool WasIncreased = false;

            // Last active tracker
            public bool IsLastActive = false;
        }

        private BetterNumericUpDown[] numericUpDownControlList = null;
        private Label[] pointsLabelList = null;

        private void RestoreInfoLabel()
        {
            infoLabel.ForeColor = Color.DarkGreen;
            infoLabel.Text = "Tip: Use your mouse wheel to change the values!";
        }

        public CBSLDC()
        {

            InitializeComponent();

            numericUpDownControlList = new BetterNumericUpDown[] { strengthNumericUpDown, agilityNumericUpDown, armourNumericUpDown, thoughnessNumericUpDown };
            pointsLabelList = new Label[] { strengthLabel, agilityLabel, armourLabel, thoughnessLabel };

            RestoreInfoLabel();
            CalculateLabelPoints();
        }

        /// <summary>
        /// Awesome link to my website
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Label11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://techcoders.net");
        }

        /// <summary>
        ///  Aid method used below, this either returns the Max or Min value from the array of given NumericUpDown controls
        ///  Note: Currently unused
        /// </summary>
        /// <param name="min">Ascending or Descending</param>
        /// <param name="ignore">Ignored NumericUpDown</param>
        /// <param name="items"></param>
        /// <returns></returns>
        public static NumericUpDown MinMaxValueEntry(bool min, NumericUpDown ignore, params NumericUpDown[] items)
        {
            var itemsList = items.ToList();
            itemsList.Remove(ignore);

            var orderedItems = itemsList.OrderByDescending(x => x.Value);

            if (!min)
                return orderedItems.First();
            else
                return orderedItems.Last();
        }

        /// <summary>
        /// Gets the pct amount from all the given NumericUpDown controls
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        private decimal GetTotal(params NumericUpDown[] items)
        {
            return items.Sum(x => x.Value);
        }

        /// <summary>
        /// Sets all the point labels color
        /// </summary>
        /// <param name="color"></param>
        private void SetPointsLabelColor(Color color)
        {
            foreach (Label controller in pointsLabelList)
            {
                if (controller.Text != "17")
                    controller.ForeColor = color;
                else
                    controller.ForeColor = Color.Orange;
            }
        }

        /// <summary>
        /// Sets all the point as grey
        /// </summary>
        /// <param name="color"></param>
        private void SetPointsLabelDisabled()
        {
            foreach (Label controller in pointsLabelList)
                controller.ForeColor = Color.DarkGray;
        }

        static int StartingAttributePoints = 17;

        private int CalculatePoints(decimal percentage)
        {
            if (percentage < 0 || percentage > 100)
                return 0;

            return Convert.ToInt32((percentage * (pointsProgressNumericUpDown.Value)) / 100) + StartingAttributePoints;
        }

        private void CalculateLabelPoints()
        {
            // Before calculating anything we ensure the total is exactly 100
            decimal total = GetTotal(numericUpDownControlList);

            if (total != 100)
            {
                infoLabel.Text = "Please make sure the total is 100%";
                infoLabel.ForeColor = Color.DarkRed;
                autoAdjustButton.Visible = true;
                SetPointsLabelDisabled();
                return;
            }


            autoAdjustButton.Visible = false;
            RestoreInfoLabel();

            strengthLabel.Text = CalculatePoints(strengthNumericUpDown.Value).ToString();
            agilityLabel.Text = CalculatePoints(agilityNumericUpDown.Value).ToString();
            armourLabel.Text = CalculatePoints(armourNumericUpDown.Value).ToString();
            thoughnessLabel.Text = CalculatePoints(thoughnessNumericUpDown.Value).ToString();

            SetPointsLabelColor(Color.DarkGreen);

        }

        /// <summary>
        /// Do value changed stuff *cough*
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumericUpDownAll_ValueChanged(object sender, EventArgs e)
        {
            var control = (sender as BetterNumericUpDown);

            foreach (BetterNumericUpDown controller in numericUpDownControlList)
            {
                if (controller == sender)
                    controller.IsLastActive = true;
                else
                    controller.IsLastActive = false;
            }

            // Now we can calculate how many points should be where
            CalculateLabelPoints();

            // Update Decrement/Increment tracker
            if (control.OldValue > control.Value)
                control.WasIncreased = false;
            else if (control.OldValue < control.Value)
                control.WasIncreased = true;

            control.OldValue = control.Value;
        }

        private void LevelNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CalculateLabelPoints();
        }

        /// <summary>
        /// Just for fun, I was bored
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AutoAdjustButton_Click(object sender, EventArgs e)
        {
            BetterNumericUpDown lastActive = numericUpDownControlList.First(x => x.IsLastActive);

            decimal total = 0;

            do
            {
                NumericUpDown highestValueEntry = MinMaxValueEntry(false, lastActive, numericUpDownControlList);
                NumericUpDown lowestValueEntry = MinMaxValueEntry(true, lastActive, numericUpDownControlList);

                // Quick and dirty
                while (highestValueEntry == lowestValueEntry)
                    lowestValueEntry = numericUpDownControlList[(new Random()).Next(0, numericUpDownControlList.Length - 1)];

                // Decrement
                if (!lastActive.WasIncreased)
                {
                    if (lowestValueEntry.Value < lowestValueEntry.Maximum)
                        lowestValueEntry.Value += 1;
                    else
                        lowestValueEntry.Value = 0;
                }
                // Increment
                else
                {
                    if (highestValueEntry.Value > highestValueEntry.Minimum)
                        highestValueEntry.Value -= 1;
                    else
                        highestValueEntry.Value = 100;
                }

                total = GetTotal(numericUpDownControlList);

            } while (total != 100);

            autoAdjustButton.Visible = false;
            RestoreInfoLabel();

            CalculateLabelPoints();
        }


    }
}
