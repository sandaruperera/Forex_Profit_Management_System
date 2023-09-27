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
using System.Drawing.Imaging;
using System.IO;
using System.Text.RegularExpressions;


namespace GADproject3
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        public static int userid;
        string FileName;

        //Load data when User Form Load//
        private void User_Load(object sender, EventArgs e)
        {
            lbl_ProfileUsername.Text = UserLogin.username;
            
            
            con = new SqlConnection("Data Source=DESKTOP-HFCPIOL;Initial Catalog=gadproject2;Integrated Security=True");
            con.Open();
            try
            {
                cmd = new SqlCommand("Select * from Users where Username='" + lbl_ProfileUsername.Text + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txt_FirstName.Text = dr.GetValue(1).ToString();
                    txt_LastName.Text = dr.GetValue(2).ToString();
                    txt_Username.Text = dr.GetValue(3).ToString();
                    txt_Email.Text = dr.GetValue(4).ToString();
                    txt_Contact.Text = dr.GetValue(5).ToString();
                    txt_Password.Text = dr.GetValue(6).ToString();
                    lbl_userPK.Text = dr.GetValue(0).ToString();
                    userid = Convert.ToInt32(lbl_userPK.Text);
                }
                con.Close();
                cmd.Dispose();
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Data Cannot Load", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con = new SqlConnection("Data Source=DESKTOP-HFCPIOL;Initial Catalog=gadproject2;Integrated Security=True");
            try
            {
                con.Open();

                da = new SqlDataAdapter("Select * from Entries where UsID = '" + User.userid.ToString() + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                entrydatagrid.DataSource = dt;
                con.Close();

            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Data Cannot Load", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //update User Data//
        private void btn_Update_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(" Are you sure you want to Update your profile with this new details?", "SMART MONEY", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(txt_FirstName.Text))
                {
                    MessageBox.Show("Please Enter First Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (string.IsNullOrEmpty(txt_LastName.Text))
                {
                    MessageBox.Show("Please Enter Last Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (txt_FirstName.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("Firs Nname Cannot Have Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_LastName.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("Last Name Cannot Have Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_Email.Text.Length == 0)
                {
                    MessageBox.Show("Please Enter Email Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!Regex.IsMatch(txt_Email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                {
                    MessageBox.Show("Please Enter Valid Email Address :Ex:name@gmail.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_Contact.Text.Length != 10 || txt_Contact.Text.Any(char.IsLetter))
                {
                    MessageBox.Show("Please Enter Valid Contact Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_Password.Text.Length == 0)
                {
                    MessageBox.Show("Password Cannot be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrEmpty(txt_ConfirmPassword.Text))
                {
                    MessageBox.Show("Please confirm your new password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_Password.Text != txt_ConfirmPassword.Text)
                {
                    MessageBox.Show("Password not matching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                else
                {
                    try
                    {
                        con.Open();
                        cmd = new SqlCommand("Update Users set  UserFName = '" + txt_FirstName.Text + "', UserLName = '" + txt_LastName.Text + "', Username = '" + txt_Username.Text + "', Email = '" + txt_Email.Text + "', Contact = '" + txt_Contact.Text + "', Passwords = '" + txt_Password.Text + "' where UserID = '" + lbl_userPK.Text + "'", con);
                        int i = cmd.ExecuteNonQuery();
                        if (i == 1)
                            MessageBox.Show(this, "Data Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        //Load to Trade Journal//
        private void btn_TradeJournal_Click(object sender, EventArgs e)
        {
            Hide();
            TradingJournal tj = new TradingJournal();
            tj.Show();
        }

       

   
        //Browse images to Upload to Entries//
        private void btn_Editbrowse_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog op = new OpenFileDialog();


            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    if ((myStream = op.OpenFile()) != null)
                    {
                        FileName = op.FileName;
                        if (myStream.Length > 512000)
                        {
                            MessageBox.Show("File Size Limit Exceeded", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            enrtyPB.Load(FileName);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //Upload images to Entries//
        private void btn_Uploadpic_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_EntryDescription.Text))
            {
                MessageBox.Show("Description Cannot be Blank");
            }
            else if (enrtyPB.Image == null)
            {
                MessageBox.Show("Please Select an Image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-HFCPIOL;Initial Catalog=gadproject2;Integrated Security=True");
                Image img = enrtyPB.Image;
                byte[] arr;
                ImageConverter converter = new ImageConverter();
                arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into Entries(EntryDescription,EntryImage,UsID) values('" + txt_EntryDescription.Text + "',@p,'" + User.userid.ToString() + "')", con);
                cmd.Parameters.AddWithValue("@p", arr);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Entry Uploaded Successfuly..!");
                
            }
            
        }

        // Get the Entry ID into EntryID Label for delete data//
        private void entrydatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_EntryID.Text = entrydatagrid.CurrentRow.Cells[0].Value.ToString();
        }


        // Delete the selected Entry data according to the EntryID//
        private void btn_DeleteEntry_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-HFCPIOL;Initial Catalog=gadproject2;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete from Entries where EntryID='" + Convert.ToInt32(lbl_EntryID.Text) + "'", con);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)

                    MessageBox.Show("Data Deleted Successfuly..!");
                else
                    MessageBox.Show(this, "Data Cannot delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Error with database server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();
            cmd.Dispose();
            Hide();
            User user = new User();
            user.Show();
            
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //Back to Home//
        private void btn_home_Click(object sender, EventArgs e)
        {
            Hide();
            Home home = new Home();
            home.Show();
        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-HFCPIOL;Initial Catalog=gadproject2;Integrated Security=True");
            try
            {
                con.Open();

                da = new SqlDataAdapter("Select * from Entries where UsID = '" + User.userid.ToString() + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                entrydatagrid.DataSource = dt;
                con.Close();

            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Data Cannot Load", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
