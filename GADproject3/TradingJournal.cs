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
using Microsoft.Win32;
using System.IO;

namespace GADproject3
{
    public partial class TradingJournal : Form
    {
        public TradingJournal()
        {
            InitializeComponent();
        }
        double entry, closed, lotsize, profit;
        string FileName;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
        private void TradingJournal_Load(object sender, EventArgs e)
        {
            lbl_userPK.Text = User.userid.ToString();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Hide();
            Home home = new Home();
            home.Show();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Lotsize.Clear();
            txt_Entry.Clear();
            txt_Closed.Clear();
            txt_Profit.Clear();
            txt_StopLoss.Clear();
            txt_TakeProfit.Clear();
            txt_Description.Clear();
            cmb_BS.Text=string.Empty;
            cmb_Pair.Text = string.Empty;
            cmb_Zone.Text = string.Empty;
            dateTimePicker1.Text=string.Empty;
            pictureBox1.Image = null;
        }

        private void btn_History_Click(object sender, EventArgs e)
        {
            Hide();
            ViewTradeDetails detail = new ViewTradeDetails();
            detail.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            User user = new User();
            user.Show();
        }

        private void btn_editTrade_Click(object sender, EventArgs e)
        {
            Hide();
            EditTrades et = new EditTrades();
            et.Show();
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            entry = Convert.ToDouble(txt_Entry.Text);
            closed = Convert.ToDouble(txt_Closed.Text);
            lotsize = Convert.ToDouble(txt_Lotsize.Text);
            if(cmb_BS.SelectedIndex==0)
            {
                profit = ((closed - entry) * lotsize) / 0.00001;
                profit = Math.Round(profit, 2);
                txt_Profit.Text = profit.ToString();
            }
            else if(cmb_BS.SelectedIndex==1)
            {
                profit = ((entry - closed) * lotsize) / 0.00001;
                profit = Math.Round(profit, 2);
                txt_Profit.Text = profit.ToString();
            }
            



        }
        private void btn_browse_Click(object sender, EventArgs e)
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
                            pictureBox1.Load(FileName);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btn_TradeSubmit_Click(object sender, EventArgs e)
        {
            if(cmb_Pair.SelectedItem==null)
            {
                MessageBox.Show("Please Select a Pair", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmb_Zone.SelectedItem == null)
            {
                MessageBox.Show("Please Select a Zone", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(cmb_BS.SelectedItem==null)
            {
                MessageBox.Show("Please Select Your Order Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txt_Lotsize.Text))
            {
                MessageBox.Show("Please Enter a Lot Size", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txt_Lotsize.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Lot Size Cannot Contain Letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Lotsize.Clear();
            }
            else if (string.IsNullOrEmpty(txt_Entry.Text))
            {
                MessageBox.Show("Please Enter a Entry Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_Entry.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Entry Price Cannot Contain Letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Entry.Clear();
            }
            else if (string.IsNullOrEmpty(txt_Closed.Text))
            {
                MessageBox.Show("Please Enter a Closed Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_Closed.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Closed Price Cannot Contain Letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Closed.Clear();
            }
            else if (string.IsNullOrEmpty(txt_StopLoss.Text))
            {
                MessageBox.Show("Please Enter a Stop Loss", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_StopLoss.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Stop Loss Cannot Contain Letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_StopLoss.Clear();
            }
            
            else if (string.IsNullOrEmpty(txt_TakeProfit.Text))
            {
                MessageBox.Show("Please Enter a Profit Target", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_TakeProfit.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Profit Target Cannot Contain Letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_TakeProfit.Clear();
            }
            else if (string.IsNullOrEmpty(txt_Profit.Text))
            {
                MessageBox.Show("Please Calculate the Profit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txt_Description.Text))
            {
                MessageBox.Show("Description Cannot be Blank");
            }
            else if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please Select an Image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                DialogResult dialog = MessageBox.Show(" Are you sure you want to submit these details to your Journal?", "SMART MONEY", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection con = new SqlConnection("Data Source=DESKTOP-HFCPIOL;Initial Catalog=gadproject2;Integrated Security=True");
                        Image img = pictureBox1.Image;
                        byte[] arr;
                        ImageConverter converter = new ImageConverter();
                        arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
                        con.Open();
                        SqlCommand cmd = new SqlCommand("Insert into Trade(TradeDate,Pair,Zone,BuySell,Lotsize,EntryPrice,ClosedPrice,StopLoss,TakeProfit,ProfitAmount,TradeImage,Description,UsID) values('" + dateTimePicker1.Value.ToString() + "','" + cmb_Pair.Text + "','" + cmb_Zone.Text + "','" + cmb_BS.Text + "','" + Convert.ToDecimal(txt_Lotsize.Text) + "','" + Convert.ToDecimal(txt_Entry.Text) + "','" + Convert.ToDecimal(txt_Closed.Text) + "','" + Convert.ToDecimal(txt_StopLoss.Text) + "','" + Convert.ToDecimal(txt_TakeProfit.Text) + "','" + Convert.ToDecimal(txt_Profit.Text) + "',@p,'" + txt_Description.Text + "','" + Convert.ToInt32(lbl_userPK.Text) + "')", con);
                        cmd.Parameters.AddWithValue("@p", arr);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Data Submitted Successfuly..!");
                    }

                    catch (SqlException)
                    {
                        MessageBox.Show(this, "Error Occured with Database Server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            
            
        }

    }




}
