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
    public partial class CreateAcoount : Form
    {
        public CreateAcoount()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        private void CreateAcoount_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-HFCPIOL;Initial Catalog=gadproject2;Integrated Security=True");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (txt_Password.Text != txt_ConfirmPassword.Text)
            {
                lbl_UserConfirmError.Text = "Password Is not Matching";
            }
            else if (string.IsNullOrEmpty(txt_ConfirmPassword.Text))
            {
                lbl_UserConfirmError.Text = "Please Confirm Your Password";
                txt_ConfirmPassword.Focus();
            }
            else { 
            try
            {
                
                con.Open();
                cmd = new SqlCommand("Insert into Users(UserFName ,UserLName ,Username ,Email ,Contact ,Passwords ) values ('" + txt_Firstname.Text + "', '" + txt_Lastname.Text + "', '" + txt_Username.Text + "',  '" + txt_Email.Text + "', '" + txt_Contact.Text + "', '" + txt_Password.Text + "') ", con);
                int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        lbl_UserConfirmError.Text = "";
                        MessageBox.Show(this, "Data save Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Hide();
                        UserLogin newuser = new UserLogin();
                        newuser.Show();

                    }
                    else
                        MessageBox.Show(this, "Data Cannot Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();
                        cmd.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
        }

        private void btn_CAcancel_Click(object sender, EventArgs e)
        {
            Hide();
            UserLogin newuser = new UserLogin();
            newuser.Show();
        }

        private void txt_Lastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Lastname_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Firstname.Text))
            {
                lbl_firstnameError.Text = "First Name Cannot Be Blank";
                txt_Firstname.Focus();

            }
            else if (txt_Firstname.Text.Any(char.IsDigit))
            {
                lbl_firstnameError.Text = "First Name Cannot Have Digits";
                txt_Firstname.Focus();
            }
            else
            {
                lbl_firstnameError.Text = "";
            }
        }

        private void txt_Username_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Lastname.Text))
            {
                lbl_LastnameError.Text = "Last Name Cannot Be Blank";
                txt_Lastname.Focus();

            }
            else if (txt_Lastname.Text.Any(char.IsDigit))
            {
                lbl_LastnameError.Text = "Last Name Cannot Have Digits";
                txt_Lastname.Focus();
            }
            else
            {
                lbl_LastnameError.Text = "";
            }
        }

        private void txt_Email_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Username.Text))
            {
                lbl_UsernameError.Text = "User Name Cannot Be Blank";
                txt_Lastname.Focus();

            }
            else
            {
                lbl_UsernameError.Text = "";
            }
        }

        private void txt_Contact_Click(object sender, EventArgs e)
        {
            if (txt_Email.Text.Length == 0)
            {
                lbl_EmailError.Text = "Please Enter Email Address";
                txt_Email.Focus();
            }
            else if (!Regex.IsMatch(txt_Email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                lbl_EmailError.Text = "Enter a Valid Email. Ex:name@gmail.com";
                txt_Email.Focus();
                txt_Email.Clear();
            }
            else
            {
                lbl_EmailError.Text = "";
            }
        }

        private void txt_Password_Click(object sender, EventArgs e)
        {
            if (txt_Contact.Text.Length != 10 || txt_Contact.Text.Any(char.IsLetter))
            {
                lbl_UserContactError.Text = "Please Enter Valid Telephone Number";
                txt_Contact.Focus();
                txt_Contact.Clear();
            }
            else if (!Regex.IsMatch(txt_Contact.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
            {
                lbl_UserContactError.Text = "Telephone Number must have 10 numbers";
                txt_Contact.Focus();
            }
            else
            {
                lbl_UserContactError.Text = "";
            }
        }

        private void txt_ConfirmPassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Password.Text))
            {
                lbl_UserPasswordError.Text = "Please Enter Your Password";
                txt_Password.Focus();
            }
            
           
        }

        private void txt_ConfirmPassword_Leave(object sender, EventArgs e)
        {
           
        }

        private void btn_CAclear_Click(object sender, EventArgs e)
        {
            txt_Firstname.Clear();
            txt_Lastname.Clear();
            txt_Email.Clear();
            txt_Username.Clear();
            txt_Contact.Clear();
            txt_Password.Clear();
            txt_ConfirmPassword.Clear();
        }
    }
    
}
