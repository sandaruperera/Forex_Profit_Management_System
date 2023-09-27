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
using System.Diagnostics;

namespace GADproject3
{
    public partial class Meetings : Form
    {
        public Meetings()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        string meetingid;
        private void btn_home_Click(object sender, EventArgs e)
        {
            Hide();
            Home home = new Home();
            home.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Admin admin = new Admin();
            admin.Show();

        }
           private void MeetingsSignals_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-HFCPIOL;Initial Catalog=gadproject2;Integrated Security=True");
            try
            {
                con.Open();
                da = new SqlDataAdapter("Select * from Meetings", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Data Cannot Load", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_AddMeeting_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MeetingID.Text))
            {
                MessageBox.Show("Please Enter a Meeting ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (string.IsNullOrEmpty(txt_MDescription.Text))
            {
                MessageBox.Show("Please Enter Meeting Description", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txt_Link.Text))
            {
                MessageBox.Show("Please Insert Meeting Link", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("Insert into Meetings(MeetingID ,MPasscode,MeetingDate ,MDescription ,MLink,AMID ) values ('" + txt_MeetingID.Text + "','" + txt_Passcode.Text + "','" + meetingDate.Value.ToString()+"', '" + txt_MDescription.Text + "', '" + txt_Link.Text + "','" + Admin.adminid.ToString() + "') ", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {

                        MessageBox.Show(this, "Meeting Submitted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                        MessageBox.Show(this, "Meeting data Cannot Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                    cmd.Dispose();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(this, "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            meetingid = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-HFCPIOL;Initial Catalog=gadproject2;Integrated Security=True");
            try
            {
                DialogResult dialog = MessageBox.Show(" Are you sure you want to Remove this Meeting?", "SMART MONEY", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from Meetings where MeetingID='"+meetingid+"'",con);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Meeting Removed Successfuly..!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Error Occured with Server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot Remove this Trader", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-HFCPIOL;Initial Catalog=gadproject2;Integrated Security=True");
            try
            {
                con.Open();
                da = new SqlDataAdapter("Select * from Meetings", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Data Cannot Load", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            meetingDate.Text = string.Empty;
            txt_MeetingID.Clear();
            txt_MDescription.Clear();
            txt_Passcode.Clear();
            txt_Link.Clear();
            
        }
    }
}

     
    

