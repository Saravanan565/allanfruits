﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project2
{
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            home obj = new home();  
            obj.Show();
            this.Hide();
        }
    }
}
