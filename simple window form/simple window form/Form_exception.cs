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
    public partial class Form_exception : Form
    {
        public Form_exception()
        {
            InitializeComponent();
        }

        private void btDiv_Click(object sender, EventArgs e)
        {
            this.lbShowResult.ResetText();
            try
            {
                int x = int.Parse(this.tbDivident.Text);
                int y = int.Parse(this.tbDivisor.Text);
                this.lbShowResult.Text += (float)x / y;
            }
            catch (Exception ex)
            {
                this.lbShowResult.Text = "Error";
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            this.tbDivident.ResetText();
            this.tbDivisor.ResetText();
            this.lbShowResult.ResetText();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
