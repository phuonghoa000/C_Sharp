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
    public partial class Form_m2 : Form
    {
        public Form_m2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double da, db;

            if (this.tba.Text != "" && this.tbb.Text != "")
            {
                da = Convert.ToDouble(this.tba.Text);
                db = Convert.ToDouble(this.tbb.Text);

                if (da == 0)
                    if (db == 0)
                        this.tbroot.Text = "Countless Solutions";
                    else
                        this.tbroot.Text = "Impossible Equation";
                else
                {
                    double dx = -db / da;
                    this.tbroot.Text = dx.ToString();
                }
            }
            else
                MessageBox.Show("Input data, please!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tba.ResetText();
            this.tbb.ResetText();
            this.tbroot.ResetText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
