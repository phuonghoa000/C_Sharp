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
    public partial class Form_string_exercise : Form
    {
        public Form_string_exercise()
        {
            InitializeComponent();
        }
              
        private void btLen_Count_Click(object sender, EventArgs e)
        {
            this.lbShowResult.ResetText();
            if (this.tbFullName.Text != "")
            {
                string s = this.tbFullName.Text;

                this.lbShowResult.Text = "Length is " + s.Length;
                this.lbShowResult.Text += "\nCount of words is " + s.Split(' ').Length;
            }
            else
                MessageBox.Show("Input your full name, please!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btUpperFC_Click(object sender, EventArgs e)
        {
            this.lbShowResult.ResetText();
            if (this.tbFullName.Text != "")
            {
                string[] s = this.tbFullName.Text.Split(' ');

                foreach (string ele in s)
                {
                    if (ele != "")
                    {
                        this.lbShowResult.Text += ele.Substring(0, 1).ToUpper();
                        this.lbShowResult.Text += ele.Substring(1, ele.Length - 1) + " ";
                    }
                }
            }
            else
                MessageBox.Show("Input your full name, please!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.lbShowResult.ResetText();
            if (this.tbFullName.Text != "")
            {
                string[] s = this.tbFullName.Text.Split(' ');

                foreach (string ele in s)
                {
                    if (ele != "")
                        this.lbShowResult.Text += ele + " ";
                }
            }
            else
                MessageBox.Show("Input your full name, please!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btUpper_Click(object sender, EventArgs e)
        {
            this.lbShowResult.ResetText();
            if (this.tbFullName.Text != "")
            {
                string[] s = this.tbFullName.Text.Split(' ');

                foreach (string ele in s)
                {
                    if (ele != "")
                        this.lbShowResult.Text += ele.ToUpper() + " ";
                }
            }
            else
                MessageBox.Show("Input your full name, please!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btLower_Click(object sender, EventArgs e)
        {
            this.lbShowResult.ResetText();
            if (this.tbFullName.Text != "")
            {
                string[] s = this.tbFullName.Text.Split(' ');

                foreach (string ele in s)
                {
                    if (ele != "")
                        this.lbShowResult.Text += ele.ToLower() + " ";
                }
            }
            else
                MessageBox.Show("Input your full name, please!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            this.tbFullName.ResetText();
            this.lbShowResult.ResetText();
            this.tbFullName.Focus();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
