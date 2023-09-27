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
using System.Text.RegularExpressions;

namespace GADproject3
{
    public partial class Signals : Form
    {
        public Signals()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;

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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Signals_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-HFCPIOL;Initial Catalog=gadproject2;Integrated Security=True");
            try
            {
                con.Open();
                da = new SqlDataAdapter("Select * from Signals ", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                signalDataGrid.DataSource = dt;
                con.Close();

            }
            catch (SqlException)
            {
                MessageBox.Show(this, "error occured with database server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_TradeSubmit_Click(object sender, EventArgs e)
        {
            if (cmb_SPair.SelectedItem == null)
            {
                MessageBox.Show("Please Select a Pair", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmb_SBS.SelectedItem == null)
            {
                MessageBox.Show("Please Select Your Order Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txt_SEntry.Text))
            {
                MessageBox.Show("Please Enter a Entry Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_SEntry.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Entry Price Cannot Contain Letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_SEntry.Clear();
            }
            else if (string.IsNullOrEmpty(txt_SStopLoss.Text))
            {
                MessageBox.Show("Please Enter a Stop Loss", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_SStopLoss.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Stop Loss Cannot Contain Letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_SStopLoss.Clear();
            }
            else if (string.IsNullOrEmpty(txt_STarget.Text))
            {
                MessageBox.Show("Please Enter a Profit Target", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_STarget.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Profit Target Cannot Contain Letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_STarget.Clear();
            }
            else if (string.IsNullOrEmpty(txt_Sdescription.Text))
            {
                MessageBox.Show("Description Cannot be Blank");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into Signals(SDate,SPair,SBS,SEntry,SSL,STarget,SDescript,SAID) values('" + Sdate.Value.ToString() + "','" + cmb_SPair.Text + "','" + cmb_SBS.Text + "','" + Convert.ToDecimal(txt_SEntry.Text) + "','" + Convert.ToDecimal(txt_SStopLoss.Text) + "','" + Convert.ToDecimal(txt_STarget.Text) + "','" + txt_Sdescription.Text + "','" + Admin.adminid.ToString() + "')", con);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Signal Submitted Successfuly..!");
                }
                catch (SqlException)
                {
                    MessageBox.Show(this, "Error Occured with Database Server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void btn_Editdelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                DialogResult dialog = MessageBox.Show(" Are you sure you want to remove this Signal?", "SMART MONEY", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("Delete from Signals where SignalID='" + signalDataGrid.CurrentCell.Value + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Signal Removed Successfuly..!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Please Select a Signal ID");
            }
            catch (Exception)
            {
                MessageBox.Show("Please Select a Signal ID");
            }
        }

        private void btn_SRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                da = new SqlDataAdapter("Select * from Signals ", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                signalDataGrid.DataSource = dt;
                con.Close();

            }
            catch (SqlException)
            {
                MessageBox.Show(this, "error occured with database server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
