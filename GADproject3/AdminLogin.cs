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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }
        
        SqlConnection con;
        SqlDataAdapter da;
        public static string adUserName = "";
        private void btn_CAdminLogin_Click(object sender, EventArgs e)
        {
            Hide();
            Home home = new Home();
            home.Show();
        }
        private void AdminLogin_Load(object sender, EventArgs e)
        {
            
        }
        private void btn_AdminLogin_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source=DESKTOP-HFCPIOL;Initial Catalog=gadproject2;Integrated Security=True");
                con.Open();
                
                da = new SqlDataAdapter("select * from Admins where AdminUsername='"+ txt_AdminUsername.Text+ "'and AdminPassword='"+txt_AdminPassword.Text+"'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                

                if(dt.Rows.Count>0)
                {
                    adUserName = txt_AdminUsername.Text;
                    Admin admin = new Admin();
                    admin.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Invaild UserName and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


    }
}
