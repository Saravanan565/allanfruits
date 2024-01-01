using System;
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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void Button_Au_Click(object sender, EventArgs e)
        {
            about obj = new about();
            obj.Show();
            this.Hide();
        }

        private void button_Sg_Click(object sender, EventArgs e)
        {
            shoping obj = new shoping();    
            obj.Show();
            this.Hide();
        }

        private void button_Pd_Click(object sender, EventArgs e)
        {
            pd obj = new pd();
            obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();    
            frm.Show();
            this.Hide();
        }
    }
}
