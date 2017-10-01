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
    public partial class Form_m4 : Form
    {
        public Form_m4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.tbName.Text == "")
                MessageBox.Show("Input your full name, please!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (this.chkMale.Checked == false && this.chkFemale.Checked == false)
                MessageBox.Show("Check your gender, please!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (this.tbLit.Text == "" && this.tbMat.Text == "" && this.tbEng.Text == "")
                MessageBox.Show("Input your point, please!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                double dLit, dMath, dEng;
                double dMin, dTotal;
                int check = (this.chkFemale.Checked) ? 1 : 0;

                dLit = Convert.ToDouble(this.tbLit.Text);
                dMath = Convert.ToDouble(this.tbMat.Text);
                dEng = Convert.ToDouble(this.tbEng.Text);

                dMin = (dLit < dMath) ? dLit : dMath;
                dMin = (dMin < dEng) ? dMin : dEng;
                dTotal = 2 * dLit + 2 * dMath + dEng + check * 0.5;

                this.tbMin.Text = dMin.ToString();
                this.tbTot.Text = dTotal.ToString();
                if (dTotal >= 40 && dMin >= 7)
                    this.tbRate.Text = "Excellent";
                else if (dTotal >= 35 && dMin >= 6)
                    this.tbRate.Text = "Good";
                else if (dTotal >= 25 && dMin >= 5)
                    this.tbRate.Text = "Average";
                else
                    this.tbRate.Text = "Poor";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tbName.ResetText();
            this.chkMale.Checked = false;
            this.chkFemale.Checked = false;
            this.tbLit.ResetText();
            this.tbMat.ResetText();
            this.tbEng.ResetText();
            this.tbMin.ResetText();
            this.tbTot.ResetText();
            this.tbRate.ResetText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
