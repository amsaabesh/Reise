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
    public partial class Chuadanga : Form
    {
        public Chuadanga()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bus_Car bc = new Bus_Car();
            bc.ShowDialog();
        }
    }
}
