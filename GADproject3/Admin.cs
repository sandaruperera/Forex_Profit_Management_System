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
using System.Text.RegularExpressions;

namespace GADproject3
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        public static int adminid;
        SqlConnection con;
        SqlCommand cmd;
        private void Admin_Load(object sender, EventArgs e)
        {
            /*lbl_AdminHeader.Text = AdminLogin.adminUsername;
            this.Text = "Admin : " + AdminLogin.adminUsername;*/

            lbl_ProfileUsername.Text = AdminLogin.adUserName;


            con = new SqlConnection("Data Source=DESKTOP-HFCPIOL;Initial Catalog=gadproject2;Integrated Security=True");
            con.Open();

            try
            {
                cmd = new SqlCommand("Select * from Admins where AdminUsername='" + lbl_ProfileUsername.Text + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txt_AFirstName.Text = dr.GetValue(1).ToString();
                    txt_ALastName.Text = dr.GetValue(2).ToString();
                    txt_AUsername.Text = dr.GetValue(3).ToString();
                    txt_AEmail.Text = dr.GetValue(4).ToString();
                    txt_AContact.Text = dr.GetValue(5).ToString();
                    txt_APassword.Text = dr.GetValue(6).ToString();
                    lbl_AdminID.Text = dr.GetValue(0).ToString();
                    adminid = Convert.ToInt32(lbl_AdminID.Text);
                }
                con.Close();
                cmd.Dispose();
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Data Cannot Load", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_ManageDoc_Click(object sender, EventArgs e)
        {
            Hide();
            ManageDocuments md = new ManageDocuments();
            md.Show();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(" Are you sure you want to Update your profile with this new details?", "SMART MONEY", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(txt_AFirstName.Text))
                {
                    MessageBox.Show("Please Enter First Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (string.IsNullOrEmpty(txt_ALastName.Text))
                {
                    MessageBox.Show("Please Enter Last Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (txt_AFirstName.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("Firs Nname Cannot Have Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_ALastName.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("Last Name Cannot Have Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_AEmail.Text.Length == 0)
                {
                    MessageBox.Show("Please Enter Email Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!Regex.IsMatch(txt_AEmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                {
                    MessageBox.Show("Please Enter Valid Email Address :Ex:name@gmail.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_AContact.Text.Length != 10 || txt_AContact.Text.Any(char.IsLetter))
                {
                    MessageBox.Show("Please Enter Valid Contact Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_APassword.Text.Length == 0)
                {
                    MessageBox.Show("Password Cannot be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrEmpty(txt_ConfirmPass.Text))
                {
                    MessageBox.Show("Please confirm your new password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_APassword.Text != txt_ConfirmPass.Text)
                {
                    MessageBox.Show("Password not matching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                else
                {
                    try
                    {
                        con.Open();
                        cmd = new SqlCommand("Update Admins set  AdminFName= '" + txt_AFirstName.Text + "', AdminLName = '" + txt_ALastName.Text + "', AdminUsername=  '" + txt_AUsername.Text + "', AdminEmail= '" + txt_AEmail.Text + "', AdminContact= '" + txt_AContact.Text + "',AdminPassword='" + txt_APassword.Text + "' where AdminID='" + lbl_AdminID.Text + "'", con);
                        int i = cmd.ExecuteNonQuery();
                        if (i == 1)
                            MessageBox.Show(this, "Data Update Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show(this, "Data Cannot Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();
                        cmd.Dispose();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, "Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_Manage_Click(object sender, EventArgs e)
        {
            Hide();
            ManageAU manage = new ManageAU();
            manage.Show();
        }

        private void btn_ManageMeetings_Click(object sender, EventArgs e)
        {
            Hide();
            Meetings ms = new Meetings();
            ms.Show();

        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Hide();
            Home home = new Home();
            home.Show();
        }

        private void btn_ManageSignals_Click(object sender, EventArgs e)
        {
            Hide();
            Signals sg = new Signals();
            sg.Show();
        }

        private void btn_Manage_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btn_Manage_MouseLeave(object sender, EventArgs e)
        {
            btn_Manage.BackColor = Color.FromArgb(87, 101, 116);
        }

        private void btn_ManageDoc_MouseHover(object sender, EventArgs e)
        {
            btn_Manage.BackColor = Color.FromArgb(131, 149, 167);
        }

        private void btn_ManageDoc_MouseLeave(object sender, EventArgs e)
        {
            btn_Manage.BackColor = Color.FromArgb(87, 101, 116);
        }

        private void btn_ManageMeetings_MouseHover(object sender, EventArgs e)
        {
            btn_Manage.BackColor = Color.FromArgb(131, 149, 167);
        }

        private void btn_ManageMeetings_MouseLeave(object sender, EventArgs e)
        {
            btn_Manage.BackColor = Color.FromArgb(87, 101, 116);
        }

        private void btn_ManageSignals_MouseHover(object sender, EventArgs e)
        {
            btn_Manage.BackColor = Color.FromArgb(131, 149, 167);
        }

        private void btn_ManageSignals_MouseLeave(object sender, EventArgs e)
        {
            btn_Manage.BackColor = Color.FromArgb(87, 101, 116);
        }
    }
}
