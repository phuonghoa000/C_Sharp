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
    public partial class Form_PrintArray : Form
    {
        public Form_PrintArray()
        {
            InitializeComponent();
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            int[] iArray = new int[5] { 1, 2, 3, 4, 5 };
            string s = "Each item in array is:\n";

            foreach (int i in iArray)
                s = s + i.ToString() + ", ";
            this.lbArray.Text = s.Substring(0, s.Length - 2);
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            this.lbArray.ResetText();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
