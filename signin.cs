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
using project2;

namespace project2
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void Su_btn_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection(@"Data Source=SARAN\SQLEXPRESS;Initial Catalog=aug;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_signup", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param1 = new SqlParameter("@newuser_name", SqlDbType.VarChar);
                cmd.Parameters.Add(param1).Value = Su_name.Text;
                SqlParameter param2 = new SqlParameter("@newuser_email", SqlDbType.VarChar);
                cmd.Parameters.Add(param2).Value = Su_Email.Text;
                SqlParameter param3 = new SqlParameter("@newuser_username", SqlDbType.VarChar);
                cmd.Parameters.Add(param3).Value = Su_Username.Text;
                SqlParameter param4 = new SqlParameter("@newuser_password", SqlDbType.VarChar);
                cmd.Parameters.Add(param4).Value = Su_Password.Text;
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Registered successfully");
                else
                    MessageBox.Show("Registration Failed");
                con.Close();
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       
       
    }
    
}


