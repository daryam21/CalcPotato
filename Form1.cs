using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcPotato {
    public partial class FormCalcPotato : Form {
        public FormCalcPotato() {
            InitializeComponent();
        }

        private void clearIfPotato() {
            if (richTextBoxCalcResult.Text.Equals("potato")) {
                richTextBoxCalcResult.Clear();
            }
        }

        private void buttonZero_Click(object sender, EventArgs e) {
            clearIfPotato();
            richTextBoxCalcResult.Text += "0";
        }

        private void buttonOne_Click(object sender, EventArgs e) {
            clearIfPotato();
            richTextBoxCalcResult.Text += "1";
        }

        private void buttonTwo_Click(object sender, EventArgs e) {
            clearIfPotato();
            richTextBoxCalcResult.Text += "2";
        }

        private void buttonThree_Click(object sender, EventArgs e) {
            clearIfPotato();
            richTextBoxCalcResult.Text += "3";
        }

        private void buttonFour_Click(object sender, EventArgs e) {
            clearIfPotato();
            richTextBoxCalcResult.Text += "4";
        }

        private void buttonFive_Click(object sender, EventArgs e) {
            clearIfPotato();
            richTextBoxCalcResult.Text += "5";
        }

        private void buttonSix_Click(object sender, EventArgs e) {
            clearIfPotato();
            richTextBoxCalcResult.Text += "6";
        }

        private void buttonSeven_Click(object sender, EventArgs e) {
            clearIfPotato();
            richTextBoxCalcResult.Text += "7";
        }

        private void buttonEight_Click(object sender, EventArgs e) {
            clearIfPotato();
            richTextBoxCalcResult.Text += "8";
        }

        private void buttonNine_Click(object sender, EventArgs e) {
            clearIfPotato();
            richTextBoxCalcResult.Text += "9";
        }

        private void buttonCe_Click(object sender, EventArgs e) {
            clearIfPotato();
            richTextBoxCalcResult.Clear();
        }

        private void buttonC_Click(object sender, EventArgs e) {
            clearIfPotato();
            richTextBoxCalcResult.Clear();
        }

        private void buttonEqual_Click(object sender, EventArgs e) {
            clearIfPotato();
            richTextBoxCalcResult.Text = "potato";
        }

        private void buttonFraction_Click(object sender, EventArgs e) {
            clearIfPotato();
            richTextBoxCalcResult.Text = "potato";
        }

        private void buttonPercent_Click(object sender, EventArgs e) {
            clearIfPotato();
            richTextBoxCalcResult.Text = "potato";
        }

        private void buttonSqRt_Click(object sender, EventArgs e) {
            clearIfPotato();
            richTextBoxCalcResult.Text = "potato";
        }

        private void buttonNegate_Click(object sender, EventArgs e) {
            clearIfPotato();
            richTextBoxCalcResult.Clear();
        }

        private void buttonForwardSlash_Click(object sender, EventArgs e) {
            clearIfPotato();
            richTextBoxCalcResult.Clear();
        }

        private void buttonMultiply_Click(object sender, EventArgs e) {
            clearIfPotato();
            richTextBoxCalcResult.Clear();
        }

        private void buttonMinus_Click(object sender, EventArgs e) {
            clearIfPotato();
            richTextBoxCalcResult.Clear();
        }

        private void buttonPlus_Click(object sender, EventArgs e) {
            clearIfPotato();
            richTextBoxCalcResult.Clear();
        }

        private void buttonDecimal_Click(object sender, EventArgs e) {
            clearIfPotato();
            richTextBoxCalcResult.Text += ".";
        }

        private void aboutCalculatorToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Calc Potato.\nCoded by: Shawn M. Crawford",
                "About Calculator",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Carrot",
                "Carrot",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void programmerToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Carrot?",
                "Carrot.",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Potato",
                "yummy",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Potato",
                "Potato",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void unitConversionToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("P-O-T-A-T-O",
                "P-O-T-A-T-O",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void dateCalculationToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("C-A-R-R-O-T",
                "C-A-R-R-O-T",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void mortgageToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Potato",
                "C-a-r-r-o-t",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void vehicleLeaseToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Potato",
                "Carrot",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void fuelEconomympgToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Carrot",
                "Potato",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void fuelEconomyToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Potato",
                "P-o-t-a-t-o",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e) {
            richTextBoxCalcResult.SelectAll();
            if (richTextBoxCalcResult.SelectionLength > 0) {
                richTextBoxCalcResult.Copy();
            } else {
                Clipboard.Clear();
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e) {
            richTextBoxCalcResult.Clear();
            richTextBoxCalcResult.Paste();
        }
    }
}
