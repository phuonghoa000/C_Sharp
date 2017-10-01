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
    public partial class Form_First_Degree_Equation : Form
    {
        public Form_First_Degree_Equation()
        {
            InitializeComponent();
        }

        private void btCompute_Click(object sender, EventArgs e)
        {
            if (this.tbFirst.Text != "" && this.tbSecond.Text != "")
            {
                this.lbShowRoot.ResetText();
                try
                {
                    double a = double.Parse(this.tbFirst.Text);
                    double b = double.Parse(this.tbSecond.Text);

                    if (a == 0)
                        if (b == 0)
                            this.lbShowRoot.Text = "Countless Solutions";
                        else
                            this.lbShowRoot.Text = "Impossible Equation";
                    else
                    {
                        double x = -b / a;
                        this.lbShowRoot.Text = x.ToString();
                    }
                }
                catch (Exception ex)
                {
                    this.lbShowRoot.Text = "Error";
                }
            }
            else
                MessageBox.Show("Input number, please!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tbFirst.ResetText();
            this.tbSecond.ResetText();
            this.lbShowRoot.ResetText();
            this.tbFirst.Focus();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
