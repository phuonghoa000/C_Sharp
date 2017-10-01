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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            Form frm = new Form_m1();
            frm.ShowDialog();
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            Form frm = new Form_m2();
            frm.ShowDialog();
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            Form frm = new Form_m3();
            frm.ShowDialog();
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            Form frm = new Form_m4();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
