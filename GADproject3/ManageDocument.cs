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
    public partial class ManageDocuments : Form
    {
        public ManageDocuments()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        private void ManageDocuments_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_DocUpload_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_AddDescription.Text))
            {
                MessageBox.Show("Please Add a Description", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                using (OpenFileDialog dlg = new OpenFileDialog() { Filter = "PDF Documents(*.pdf)|*.pdf", ValidateNames = true })
                {
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        DialogResult dialog = MessageBox.Show(" Are you sure you want to upload this PDF file?", "SMART MONEY", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialog == DialogResult.Yes)
                        {
                            string filename = dlg.FileName;
                            UploadFile(filename);
                        }
                    }
                }
            }
            
        }
        public void UploadFile(string file)
        {
            con = new SqlConnection("Data Source=DESKTOP-HFCPIOL;Initial Catalog=gadproject2;Integrated Security=True");
            con.Open();
            FileStream fstream = File.OpenRead(file);
            byte[] contents = new byte[fstream.Length];
            fstream.Read(contents,0,(int) fstream.Length);
            fstream.Close();

            using (cmd = new SqlCommand("Insert into  Documents(DocDescription,DocFile,AID) values(@descrip,@pdf,'"+Admin.adminid+"')", con))
            {
                cmd.Parameters.AddWithValue("@descrip", txt_AddDescription.Text);
                cmd.Parameters.AddWithValue("@pdf", contents);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            MessageBox.Show("Uploaded Successfully");
        }

        private void btn_DocView_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-HFCPIOL;Initial Catalog=gadproject2;Integrated Security=True");
            try
            {
                con.Open();
                da = new SqlDataAdapter("Select DocID,DocDescription from Documents where AID = '" + Admin.adminid.ToString() + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                docdatagrid.DataSource = dt;
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

        private void btn_DocDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-HFCPIOL;Initial Catalog=gadproject2;Integrated Security=True");

            try
            {
                con.Open();
                DialogResult dialog = MessageBox.Show(" Are you sure you want to upload this PDF file?", "SMART MONEY", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("Delete from Documents where DocID='" + docdatagrid.CurrentCell.Value + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data Deleted Successfuly..!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Please Select a Document ID");
            }
            catch (Exception)
            {
                MessageBox.Show("Please Select a Document ID");
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
    }
}
