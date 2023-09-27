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
using System.IO;

namespace GADproject3
{
    public partial class ContactUs : Form
    {
        public ContactUs()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        
        private void btn_home_Click(object sender, EventArgs e)
        {
            Hide();
            Home home = new Home();
            home.Show();


            }

        private void ContactUs_Load(object sender, EventArgs e)
        {

            con = new SqlConnection("Data Source=DESKTOP-HFCPIOL;Initial Catalog=gadproject2;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("Select AdminFName,AdminLName,AdminEmail,AdminContact from Admins Where AdminID='1200'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            for (int i = 0; i < 4; i++)
            {
                flowLayoutPanel1.Controls.Add(panel1);

           
            while (dr.Read())
            {
              txt_Fname.Text = dr.GetValue(0).ToString();
              txt_LName.Text = dr.GetValue(1).ToString();
              txt_Email.Text = dr.GetValue(2).ToString();
              txt_Contact.Text = dr.GetValue(3).ToString();
              
            }

        }
            

        }
        

        private void txt_Fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
