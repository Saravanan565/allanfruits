using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {

            SqlConnection conn = new SqlConnection(@"Data Source=SARAN\SQLEXPRESS;
            Initial Catalog=aug;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_login", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param1 = new SqlParameter("@username", SqlDbType.VarChar);
            cmd.Parameters.Add(param1).Value = lg_txtbox_username.Text;
            SqlParameter param2 = new SqlParameter("@cus_password", SqlDbType.VarChar);
            cmd.Parameters.Add(param2).Value = lg_txtbox_pwd.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            int a = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
            if (a > 0)
            {
                MessageBox.Show("Valid User");
                home obj1 = new home();
                this.Hide();
                obj1.Show();
            }
            else
            {
                MessageBox.Show("Invalid User");
            }
        }



        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signup obj = new signup();
            obj.Show();
            this.Hide();
        }


    }
}
