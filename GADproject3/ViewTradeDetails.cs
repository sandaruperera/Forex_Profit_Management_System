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

namespace GADproject3
{
    public partial class ViewTradeDetails : Form
    {
        public ViewTradeDetails()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ViewTradeDetails_Load(object sender, EventArgs e)
        {
             
            con = new SqlConnection("Data Source=DESKTOP-HFCPIOL;Initial Catalog=gadproject2;Integrated Security=True");
            try
            {
                con.Open();
                da = new SqlDataAdapter("Select * from Trade where UsID = '" + User.userid.ToString() + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                lbl_totalProfit.Text = "0";
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    lbl_totalProfit.Text = Convert.ToString(double.Parse(lbl_totalProfit.Text) + double.Parse(dataGridView1.Rows[i].Cells[10].Value.ToString()));
                }
                con.Close();

            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Data Cannot Load", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Description.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            byte[] TradeImage = (byte[])dataGridView1.CurrentRow.Cells[11].Value;
            MemoryStream ms = new MemoryStream(TradeImage);
            pictureboxload.Image = Image.FromStream(ms);
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Hide();
            Home home = new Home();
            home.Show();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Hide();
            TradingJournal tj = new TradingJournal();
            tj.Show();
        }

        /*private void btn_View_Click(object sender, EventArgs e)
        {
        }*/
    }
}
