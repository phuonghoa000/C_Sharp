using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace learn_c_sharp
{
    public partial class Form_m3 : Form
    {
        public Form_m3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double da, db, dc;

            if (this.tba.Text != "" && this.tbb.Text != "" && this.tbc.Text != "")
            {
                da = Convert.ToDouble(this.tba.Text);
                db = Convert.ToDouble(this.tbb.Text);
                dc = Convert.ToDouble(this.tbc.Text);

                double delta = db * db - 4 * da * dc;

                if (delta < 0)
                    this.tbroot.Text = "Impossible Equation";
                else if (delta == 0)
                {
                    double dx;

                    dx = -db / 2 / da;

                    this.tbroot.Text = "Double Root";
                    this.tbroot1.Text = dx.ToString();
                }
                else
                {
                    double dx1, dx2;

                    dx1 = (-db - Math.Sqrt(delta)) / 2 / da;
                    dx2 = (-db + Math.Sqrt(delta)) / 2 / da;

                    this.tbroot.Text = "Two Simple Root";
                    this.tbroot1.Text = dx1.ToString();
                    this.tbroot2.Text = dx2.ToString();
                }
            }
            else
            {
                MessageBox.Show("Input data, please!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tba.ResetText();
            this.tbb.ResetText();
            this.tbc.ResetText();
            this.tbroot.ResetText();
            this.tbroot1.ResetText();
            this.tbroot2.ResetText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
