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
    public partial class DocumentView : Form
    {
        public DocumentView()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        string docid;
        
        private void btn_home_Click(object sender, EventArgs e)
        {
            Hide();
            Home home = new Home();
            home.Show();
        }

        private void DocumentView_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-HFCPIOL;Initial Catalog=gadproject2;Integrated Security=True");
            try
            {
                con.Open();
                da = new SqlDataAdapter("Select DocID,DocDescription from Documents ", con);
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
            
            try
            {
                con.Open();
                da = new SqlDataAdapter("Select SDate,SPair,SBS,SEntry,SSL,STarget,SDescript from Signals ", con);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            docid = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void btn_Download_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() {Filter="PDF Documents(*.pdf)|*.pdf",ValidateNames = true })
            {
                if(sfd.ShowDialog()==DialogResult.OK)
                {
                    DialogResult dialog = MessageBox.Show("Are you sure you want to download this file?", "SMART MONEY", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(dialog == DialogResult.Yes)
                    {
                        string filename = sfd.FileName;
                        DownloadFile(filename);
                    }
                    else
                    {
                        return;
                    }
                }
            }

        }
        public void DownloadFile(string file)
        {
            con.Open();
            bool em = false;
            using (cmd = new SqlCommand("Select DocFile From Documents Where DocID='" + docid + "'",con))
            {
                using (var reader=cmd.ExecuteReader(CommandBehavior.Default))
                {
                    if (reader.Read())
                    {
                        em = true;
                        byte[] filedata = (byte[])reader.GetValue(0);
                        using (FileStream fs = new FileStream(file, FileMode.Create, FileAccess.ReadWrite))
                        {
                            using (BinaryWriter bw = new BinaryWriter(fs))
                            {
                                bw.Write(filedata);
                                bw.Close();
                            }
                        }
                        MessageBox.Show("Download Completed !");
                    }
                    if (em==false)
                    {
                        MessageBox.Show("File Cannot Download !");
                    }
                    reader.Close();
                    con.Close();
                }
            }
        }

        private void btn_Download_MouseHover(object sender, EventArgs e)
        {
            btn_Download.BackColor = Color.FromArgb(10, 189, 227);
        }

        private void btn_Download_MouseLeave(object sender, EventArgs e)
        {
            btn_Download.BackColor = Color.FromArgb(48, 57, 82);
        }
    }
}
