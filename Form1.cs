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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Dhaka d1 = new Dhaka();
                d1.ShowDialog();
            }
            else if (radioButton2.Checked)
            {
                Chuadanga ch1 = new Chuadanga();
                ch1.ShowDialog();
            }
        }
    }
}
