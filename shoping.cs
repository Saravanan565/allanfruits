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
    public partial class shoping : Form
    {
        public shoping()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void shoping_Load(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            home ob = new home();
            ob.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_total_Click(object sender, EventArgs e)
        {
            double sum = 0.0;
            double price;
            double qty;
            double cal = 0.0;

            if (chb_apple.Checked)
            {
                String apple =chb_apple.Text;
                String mes = cmp_apple.SelectedItem.ToString();
                price = 140.0;
                qty = int.Parse(txt_apple.Text);

                if (mes.Equals("KG"))
                {
                    cal = (qty * price);
                    this.dataGridView1.Rows.Add(apple, price, qty, cal);

                }
                else
                {
                    cal = (qty / 1000 * price);

                    this.dataGridView1.Rows.Add(apple, price, qty, cal);
                }

            }

            if (chb_orange.Checked)
            {
                String orange = chb_orange.Text;
                String mes1 = cmp_orange.SelectedItem.ToString();
                price = 150.0;
                qty = int.Parse(txt_orange.Text);

                if (mes1.Equals("KG"))
                {
                    cal = (qty * price);
                    this.dataGridView1.Rows.Add(orange, price, qty, cal);
                }
                else
                {
                    cal = (qty / 1000 * price);

                    this.dataGridView1.Rows.Add(orange, price, qty, cal);
                }

            }
            if (chb_pomo.Checked)
            {
                String pomo = chb_pomo.Text;
                String mes2 = cmp_pomo.SelectedItem.ToString();
                price = 260.0;
                qty = int.Parse(txt_pomo.Text);

                if (mes2.Equals("KG"))
                {
                    cal = (qty * price);
                    this.dataGridView1.Rows.Add(pomo, price, qty, cal);
                }
                else
                {
                    cal = (qty / 1000 * price);
                    this.dataGridView1.Rows.Add(pomo, price, qty, cal);
                }

            }

            if (chb_grapes.Checked)
            {
                String grapes = chb_grapes.Text;
                String mes3 = cmp_grapes.SelectedItem.ToString();
                price = 250.0;
                qty = int.Parse(txt_grapes.Text);

                if (mes3.Equals("KG"))
                {
                    cal = (qty * price);
                    this.dataGridView1.Rows.Add(grapes, price, qty, cal);
                }
                else
                {
                    cal = (qty / 1000 * price);
                    this.dataGridView1.Rows.Add(grapes, price, qty, cal);
                }

            }

            if (chb_guava.Checked)
            {
                String guava = chb_guava.Text;
                String mes4 = cmp_guava.SelectedItem.ToString();
                price = 300.0;
                qty = int.Parse(txt_guava.Text);

                if (mes4.Equals("KG"))
                {
                    cal = (qty * price);
                    this.dataGridView1.Rows.Add(guava, price, qty, cal);
                }
                else
                {
                    cal = (qty / 1000 * price);
                    this.dataGridView1.Rows.Add(guava, price, qty, cal);
                }
            }
            if (chb_mango.Checked)
            {
                String mango = chb_mango.Text;
                String mes5 = cmp_mango.SelectedItem.ToString();
                price = 300.0;
                qty = int.Parse(txt_mango.Text);

                if (mes5.Equals("KG"))
                {
                    cal = (qty * price);
                    this.dataGridView1.Rows.Add(mango, price, qty, cal);
                }
                else
                {
                    cal = (qty / 1000 * price);
                    this.dataGridView1.Rows.Add(mango, price, qty, cal);
                }
            }
            if (chb_wm.Checked)
            {
                String wm = chb_wm.Text;
                String mes6 = cmp_wm.SelectedItem.ToString();
                price = 300.0;
                qty = int.Parse(txt_wm.Text);

                if (mes6.Equals("KG"))
                {
                    cal = (qty * price);
                    this.dataGridView1.Rows.Add(wm, price, qty, cal);
                }
                else
                {
                    cal = (qty / 1000 * price);
                    this.dataGridView1.Rows.Add(wm, price, qty, cal);
                }
            }
            for (int row = 0; row < dataGridView1.Rows.Count; row++)
            {
                sum = sum + Convert.ToInt32(dataGridView1.Rows[row].Cells[3].Value);
            }
            txtbill.Text = sum.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("payment sucessfull");
            payment obj = new payment();
            obj.Show();
            this.Hide();
        }
    }
}
