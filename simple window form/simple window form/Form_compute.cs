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
    public partial class Form_compute : Form
    {
        public Form_compute()
        {
            InitializeComponent();
        }

        private void btCompute_Click(object sender, EventArgs e)
        {
            if (this.tbNumber1.Text == "" || this.tbNumber2.Text == "")
                MessageBox.Show("Input number, please!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (this.radiobtCD.Checked == false && this.radiobtMGCD.Checked == false)
                MessageBox.Show("Choice 'common divisor' or 'most grand common divisor', please!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string s = "";
                double da, db;

                da = Convert.ToDouble(this.tbNumber1.Text);
                db = Convert.ToDouble(this.tbNumber2.Text);

                if (this.radiobtCD.Checked)
                {
                    for (int i = 1; i <= da; i++)
                        if (da % i == 0 && db % i == 0)
                            s = s + i.ToString() + ", ";

                    this.tbResult.Text = s.Substring(0, s.Length - 2);
                }
                else
                {
                    while (da != db)
                    {
                        if (da > db)
                            da -= db;
                        else
                            db -= da;
                    }
                    this.tbResult.Text = da.ToString();
                }
                
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            this.tbNumber1.ResetText();
            this.tbNumber2.ResetText();
            this.tbResult.ResetText();
            this.radiobtCD.Checked = false;
            this.radiobtMGCD.Checked = false;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
