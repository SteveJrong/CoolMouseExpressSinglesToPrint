using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 酷鼠快递助手
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            new setup().ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            new addform().ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            new toform().ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            new help().ShowDialog();
        }
    }
}
