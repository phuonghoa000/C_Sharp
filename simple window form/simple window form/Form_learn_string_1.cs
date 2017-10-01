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
    public partial class Form_learn_string_1 : Form
    {
        public Form_learn_string_1()
        {
            InitializeComponent();
        }

        private void tbFirstNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCompare_Click(object sender, EventArgs e)
        {
            if (this.tbFirstString.Text != "" && this.tbSecondString.Text != "")
            {
                int compare = string.Compare(tbFirstString.Text, tbSecondString.Text);
                if (compare == 1)
                    this.lbResult.Text = this.tbFirstString.Text + " > " + this.tbSecondString.Text;
                else if (compare == 0)
                    this.lbResult.Text = this.tbFirstString.Text + " = " + this.tbSecondString.Text;
                else
                    this.lbResult.Text = this.tbFirstString.Text + " < " + this.tbSecondString.Text;
            }
            else
                MessageBox.Show("Input string, please!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btCompare2_Click(object sender, EventArgs e)
        {
            if (this.tbFirstString.Text != "" && this.tbSecondString.Text != "")
            {
                int compare = string.Compare(this.tbFirstString.Text, this.tbSecondString.Text, true);
                if (compare == 1)
                    this.lbResult.Text = this.tbFirstString.Text + " > " + this.tbSecondString.Text;
                else if (compare == 0)
                    this.lbResult.Text = this.tbFirstString.Text + " = " + this.tbSecondString.Text;
                else
                    this.lbResult.Text = this.tbFirstString.Text + " < " + this.tbSecondString.Text;
            }
            else
                MessageBox.Show("Input string, please!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btConcat_Click(object sender, EventArgs e)
        {
            if (this.tbFirstString.Text != "" && this.tbSecondString.Text != "")
            {
                this.lbResult.Text = string.Concat(this.tbFirstString.Text,
                    this.tbSecondString.Text);
            }
            else
                MessageBox.Show("Input string, please!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btIndexOf_Click(object sender, EventArgs e)
        {
            if (this.tbFirstString.Text != "" && this.tbSecondString.Text != "")
            {
                int idx = this.tbFirstString.Text.IndexOf(tbSecondString.Text);
                if (idx >= 0)
                {
                    string s = this.tbFirstString.Text.Replace(this.tbSecondString.Text,
                        "in there");

                    this.lbResult.Text = "First string include second string at "
                        + idx;
                    this.lbResult.Text += "\n\rWe has replaced the second string by 'in there'.";
                    this.lbResult.Text += "\n\rResult is: " + s;
                }
                else
                    this.lbResult.Text = "First string is not include second string";
            }
            else
                MessageBox.Show("Input string, please!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            if (this.tbFirstString.Text != "" && this.tbSecondString.Text != "")
            {
                string s1 = this.tbFirstString.Text;
                string s2 = this.tbSecondString.Text;
                string s = s1.Insert(s1.IndexOf(" ") + 1, s2);
                s = s.Insert(s.LastIndexOf(" ") + 1, s2);

                this.lbResult.Text = "Result is: " + s;
            }
            else
                MessageBox.Show("Input string, please!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btSubstring_Click(object sender, EventArgs e)
        {
            if (this.tbFirstString.Text != "" && this.tbSecondString.Text != "")
            {
                string s = "Processing Program";
                int idx = this.lbTitle.Text.IndexOf(s);

                if (idx >= 0)
                {
                    string ss = this.lbTitle.Text.Remove(idx, s.Length);
                    this.lbResult.Text = "Result is: " + ss;
                }
                else
                    this.lbResult.Text = "'Processing Program' is not in '" + this.lbTitle.Text
                        + "'";
            }
            else
                MessageBox.Show("Input string, please!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            this.tbFirstString.ResetText();
            this.tbSecondString.ResetText();
            this.lbResult.ResetText();
            this.tbFirstString.Focus();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
