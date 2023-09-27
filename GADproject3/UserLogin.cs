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

namespace GADproject3
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlDataAdapter da;
        public static string username="";
        public static string userpassword = "";
        private void btn_CreateAccount_Click(object sender, EventArgs e)
        {
            Hide();
            CreateAcoount ca = new CreateAcoount();
            ca.Show();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

            try
            {
                con = new SqlConnection("Data Source=DESKTOP-HFCPIOL;Initial Catalog=gadproject2;Integrated Security=True");
                con.Open();

                da = new SqlDataAdapter("select * from Users where Username='" + txt_Username.Text + "' and Passwords='" + txt_Password.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    username = txt_Username.Text;
                    userpassword = txt_Password.Text;
                    User user = new User();
                    user.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Invaild UserName or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void btn_CLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            Home homepage = new Home();
            homepage.Show();
        }
    }
}
