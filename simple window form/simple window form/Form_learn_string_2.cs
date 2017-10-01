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
    public partial class Form_learn_string_2 : Form
    {
        public Form_learn_string_2()
        {
            InitializeComponent();
        }

        private void btCount_Click(object sender, EventArgs e)
        {
            if (this.tbFullName.Text != "")
            {
                const char space = ' ';
                string s = this.tbFullName.Text.Trim();
                int count = s.Split(space).Length;

                this.lbShowResult.Text = "Your name has " + count + " words";
            }
            else
                MessageBox.Show("Input your full name, please!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btProper_Click(object sender, EventArgs e)
        {
            if (this.tbFullName.Text != "")
            {
                string[] s = this.tbFullName.Text.Split(' ');
                this.lbShowResult.Text = "Upper the first character of each word.\n\rThe result is: ";

                foreach (string element in s)
                {
                    this.lbShowResult.Text += element.Substring(0, 1).ToUpper()
                        + element.Substring(1, element.Length - 1) + " ";
                }
            }
            else
                MessageBox.Show("Input your full name, please!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btLeft_Click(object sender, EventArgs e)
        {
            if (this.tbFullName.Text != "")
            {
                string s = this.tbFullName.Text;

                this.lbShowResult.Text = s.Substring(0, s.IndexOf(" "));
            }
            else
                MessageBox.Show("Input your full name, please!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btRight_Click(object sender, EventArgs e)
        {
            if (this.tbFullName.Text != "")
            {
                string s = this.tbFullName.Text;

                this.lbShowResult.Text = s.Substring(s.LastIndexOf(" ") + 1);                
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
