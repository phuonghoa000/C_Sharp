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
    public partial class Form_m1 : Form
    {
        public Form_m1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.tb1.Text != "" && this.tb2.Text != "")
            {
                double da, db, dre;

                da = Convert.ToDouble(this.tb1.Text);
                db = Convert.ToDouble(this.tb2.Text);
                dre = da + db;
                this.tbre.Text = dre.ToString();
            }
            else
                MessageBox.Show("Input data, please!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.tb1.Text != "" && this.tb2.Text != "")
            {
                double da, db, dre;

                da = Convert.ToDouble(this.tb1.Text);
                db = Convert.ToDouble(this.tb2.Text);
                dre = da - db;
                this.tbre.Text = dre.ToString();
            }
            else
                MessageBox.Show("Input data, please!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.tb1.Text != "" && this.tb2.Text != "")
            {
                double da, db, dre;

                da = Convert.ToDouble(this.tb1.Text);
                db = Convert.ToDouble(this.tb2.Text);
                dre = da * db;
                this.tbre.Text = dre.ToString();
            }
            else
                MessageBox.Show("Input data, please!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.tb1.Text != "" && this.tb2.Text != "")
            {
                double da, db, dre;

                da = Convert.ToDouble(this.tb1.Text);
                db = Convert.ToDouble(this.tb2.Text);
                if (db == 0)
                {
                    MessageBox.Show("Invalid Divisor", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.tb2.ResetText();
                    this.tb2.Focus();
                }
                else
                {
                    dre = da / db;
                    this.tbre.Text = dre.ToString();
                }
            }
            else
                MessageBox.Show("Input data, please!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.tb1.ResetText();
            this.tb2.ResetText();
            this.tbre.ResetText();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
