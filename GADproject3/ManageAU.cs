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
    public partial class ManageAU : Form
    {
        public ManageAU()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        private void ManageAU_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-HFCPIOL;Initial Catalog=gadproject2;Integrated Security=True");
            try
            {
                con.Open();
                da = new SqlDataAdapter("Select UserID,UserFName,UserLName,Email,Contact from Users", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                con.Close();

            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Error Occured Wih Database Server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                con.Open();
                da = new SqlDataAdapter("Select * from Entries", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                entrymanageview.DataSource = dt;
                con.Close();

            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Error Occured Wih Database Server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           txt_TraderID.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-HFCPIOL;Initial Catalog=gadproject2;Integrated Security=True");
            if (string.IsNullOrEmpty(txt_TraderID.Text))
            {
                MessageBox.Show("There is no Trader to remove", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {


                try
                {
                    DialogResult dialog = MessageBox.Show(" Are you sure you want to Remove this Trader?", "SMART MONEY", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    

                  
                    if (dialog == DialogResult.Yes)
                    {
                        con.Open();
                        SqlCommand bmd = new SqlCommand("Delete from Users where UserID = '"+txt_TraderID.Text+"' ", con);

                        bmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Data Deleted Successfuly..!");
                        
                        
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


        }

        private void btn_EntryRemove_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-HFCPIOL;Initial Catalog=gadproject2;Integrated Security=True");
            if (string.IsNullOrEmpty(txt_EntryID.Text))
            {
                MessageBox.Show("There is no any enrty to remove", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                

            }
            else
            {
                try
                {
                    DialogResult dialog = MessageBox.Show(" Are you sure you want to Remove this Entry?", "SMART MONEY", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("Delete from Entries where EntryID='" + txt_EntryID.Text + "'", con);

                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Data Deleted Successfuly..!");
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
            
        }

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

        private void entrymanageview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_EntryID.Text = entrymanageview.CurrentRow.Cells[0].Value.ToString();
        }

        private void btn_UserRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                da = new SqlDataAdapter("Select * from Users", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                con.Close();

            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_EntryRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                da = new SqlDataAdapter("Select * from Entries", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                entrymanageview.DataSource = dt;
                con.Close();

            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
