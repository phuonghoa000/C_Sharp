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
    public partial class Form_2DimArray : Form
    {
        static int iRow = 4, iCol = 3;
        int[,] i2DimArray = new int[iRow, iCol];

        public Form_2DimArray()
        {
            InitializeComponent();
        }

        private void btInput_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < iRow; i++)
                for (int j = 0; j < iCol; j++)
                    i2DimArray[i, j] = i - j;

            this.lbShow.Text = "The data has been inputed.";
        }

        private void btSort_Click(object sender, EventArgs e)
        {
            int[] t = new int[iCol];

            for (int i = 0; i < iRow; i++)
            {
                for (int j = 0; j < iCol; j++)
                    t[j] = i2DimArray[i, j];
                Array.Sort(t);
                for (int j = 0; j < iCol; j++)
                    i2DimArray[i, j] = t[j];
            }

            this.lbShow.Text = "The array has been sorted.";
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            this.lbShow.Text = "";
            for (int i = 0; i < iRow; i++)
            {
                for (int j = 0; j < iCol; j++)
                {
                    this.lbShow.Text += i2DimArray[i, j] + "   ";
                }
                    
                this.lbShow.Text += "\n";
            }                
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            this.lbShow.ResetText();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
