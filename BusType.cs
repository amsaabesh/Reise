﻿using System;
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
    public partial class BusType : Form
    {
        public BusType()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SItConfirm sc = new SItConfirm();
            sc.ShowDialog();
        }
    }
}
