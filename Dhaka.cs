using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reise
{
    public partial class Dhaka : Form
    {
        public Dhaka()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Bus_Car bc = new Bus_Car();
                bc.ShowDialog();
            }
            else if (radioButton2.Checked)
            {
                Launch l1 = new Launch();
                l1.ShowDialog();
            }
        }
    }
}
