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
    public partial class EditTrades : Form
    {
        public EditTrades()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        double entry, closed, lotsize, profit;
        string FileName;
        private void EditTrades_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-HFCPIOL;Initial Catalog=gadproject2;Integrated Security=True");
            try
            {
                con.Open();
                da = new SqlDataAdapter("Select * from Trade where UsID = '" + User.userid.ToString() + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_TradeID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cmb_Pair.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cmb_Zone.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cmb_BS.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_Lotsize.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_Entry.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txt_Closed.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txt_StopLoss.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txt_TakeProfit.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txt_Profit.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            txt_Editdescription.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();  
            
            byte[] TradeImage = (byte[])dataGridView1.CurrentRow.Cells[11].Value;
            MemoryStream ms = new MemoryStream(TradeImage);
            pb_edit.Image = Image.FromStream(ms);
          
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            
            try
            {
                con.Open();
                da = new SqlDataAdapter("Select * from Trade where UsID = '" + User.userid.ToString() + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
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

        

        private void btn_EditCalculate_Click(object sender, EventArgs e)
        {
            entry = Convert.ToDouble(txt_Entry.Text);
            closed = Convert.ToDouble(txt_Closed.Text);
            lotsize = Convert.ToDouble(txt_Lotsize.Text);
            if (cmb_BS.SelectedIndex == 0)
            {
                profit = ((closed - entry) * lotsize) / 0.00001;
                profit = Math.Round(profit, 2);
                txt_Profit.Text = profit.ToString();
            }
            else if (cmb_BS.SelectedIndex == 1)
            {
                profit = ((entry - closed) * lotsize) / 0.00001;
                profit = Math.Round(profit, 2);
                txt_Profit.Text = profit.ToString();
            }
        }

       

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
                            pb_edit.Load(FileName);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        

        private void btn_TradeUpdate_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show(" Are you sure you want to update these details to specified trade?", "SMART MONEY", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {

                Image img = pb_edit.Image;
                byte[] arr;
                ImageConverter converter = new ImageConverter();
                arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
                con.Open();
                SqlCommand cmd = new SqlCommand("Update Trade set TradeDate='" + dateTimePicker1.Value.ToString() + "',Pair='" + cmb_Pair.Text + "',Zone='" + cmb_Zone.Text + "',BuySell='" + cmb_BS.Text + "',Lotsize='" + Convert.ToDecimal(txt_Lotsize.Text) + "',EntryPrice='" + Convert.ToDecimal(txt_Entry.Text) + "',ClosedPrice='" + Convert.ToDecimal(txt_Closed.Text) + "',StopLoss='" + Convert.ToDecimal(txt_StopLoss.Text) + "',TakeProfit='" + Convert.ToDecimal(txt_TakeProfit.Text) + "',ProfitAmount='" + Convert.ToDecimal(txt_Profit.Text) + "',TradeImage=@p,Description='" + txt_Editdescription.Text + "'where TradeID='" + Convert.ToInt32(lbl_TradeID.Text) + "'", con);
                cmd.Parameters.AddWithValue("@p", arr);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Updated Successfuly..!");
            }
        }
        private void btn_Editdelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(" Are you sure you want to delete this trade details?", "SMART MONEY", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete from Trade where TradeID='" + Convert.ToInt32(lbl_TradeID.Text) + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Deleted Successfuly..!");
            }
           
        }
        private void btn_EditClear_Click(object sender, EventArgs e)
        {
            txt_Lotsize.Clear();
            txt_Entry.Clear();
            txt_Closed.Clear();
            txt_Profit.Clear();
            txt_StopLoss.Clear();
            txt_TakeProfit.Clear();
            txt_Editdescription.Clear();
            cmb_BS.Text = string.Empty;
            cmb_Pair.Text = string.Empty;
            cmb_Zone.Text = string.Empty;
            dateTimePicker1.Text = string.Empty;
            pb_edit.Image = null;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            TradingJournal tj = new TradingJournal();
            tj.Show();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Hide();
            Home home = new Home();
            home.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {}
    }
}
