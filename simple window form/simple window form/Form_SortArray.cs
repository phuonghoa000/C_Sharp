using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simple_window_form
{
    public partial class Form_SortArray : Form
    {
        int[] iArray = new int[5];
        int i = 0;

        public Form_SortArray()
        {
            InitializeComponent();
        }

        private void btInput_Click(object sender, EventArgs e)
        {
            if (i == 5)
                MessageBox.Show("You've input enough 5 number. Please press 'Increase' or 'Decrease' to sort array, please!",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (this.tbInput.Text == "")
                MessageBox.Show("Input a number, please!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                iArray[i] = Convert.ToInt32(this.tbInput.Text);
                this.tbInput.ResetText();
                this.tbInput.Focus();
                i++;
            }
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            if (i == 5)
            {
                this.lbShowResult.ResetText();
                foreach (int number in iArray)
                {
                    this.lbShowResult.Text += number + "  ";
                }
            }
            else
                MessageBox.Show("Your need to input more number, please!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }

        private void btIncrease_Click(object sender, EventArgs e)
        {
            if (i == 5)
            {
                Array.Sort(iArray);
                this.lbShowResult.Text = "The array has been sorted.";
            }
                
            else
                MessageBox.Show("Your need to input more number, please!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btDecrease_Click(object sender, EventArgs e)
        {
            if (i == 5)
            {
                Array.Reverse(iArray);
                this.lbShowResult.Text = "The array has been sorted.";
            }
                
            else
                MessageBox.Show("Your need to input more number, please!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            i = 0;
            this.tbInput.ResetText();
            this.lbShowResult.ResetText();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
