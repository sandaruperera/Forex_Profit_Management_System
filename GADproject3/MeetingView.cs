using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;

namespace GADproject3
{
    public partial class MeetingView : Form
    {
        public MeetingView()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        string codelink;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dialog = MessageBox.Show(" Are you sure you want to join this meeting now?", "SMART MONEY", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                codelink = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                Process.Start(codelink);
            }
        }

        private void MeetingView_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-HFCPIOL;Initial Catalog=gadproject2;Integrated Security=True");
            try
            {
                con.Open();
                da = new SqlDataAdapter("Select MeetingID,MPasscode,MeetingDate,MDescription,Mlink from Meetings", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
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

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Home home = new Home();
            home.Show();
        }
    }
}
