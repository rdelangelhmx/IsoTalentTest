using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestIsoTalent
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var test1 = new frmTest1();
            test1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var test2 = new frmTest2();
            test2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var test3 = new frmTest3();
            test3.ShowDialog();
        }
    }
}
