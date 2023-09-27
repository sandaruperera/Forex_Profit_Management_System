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

namespace GADproject3
{
    
    public partial class ViewEntries : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        private PictureBox pic;
        private Label prc;
        public ViewEntries()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Hide();
            Home home = new Home();
            home.Show();
        }

        private void ViewEntries_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-HFCPIOL;Initial Catalog=gadproject2;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("Select EntryImage,EntryDescription from Entries", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ELpanel.AutoScroll = true;
                long len = dr.GetBytes(0, 0, null, 0, 0);
                byte[] array = new byte[System.Convert.ToInt32(len) + 1];
                dr.GetBytes(0, 0, array, 0, System.Convert.ToInt32(len));
                pic = new PictureBox();
                pic.Width = 800;
                pic.Height = 450;
                pic.BackgroundImageLayout = ImageLayout.Stretch;
                pic.BorderStyle = BorderStyle.FixedSingle;
                prc = new Label();
                prc.Font = new Font("Times New Roman", 16,FontStyle.Bold);
                prc.Text = dr["EntryDescription"].ToString();
                prc.ForeColor = Color.FromArgb(255, 71, 87);
                prc.Width = 800;
                prc.Height = 40;
                prc.BackColor = Color.White;
                prc.TextAlign = ContentAlignment.BottomCenter;
                

                MemoryStream ms = new MemoryStream(array);
                Bitmap bitmap = new Bitmap(ms);
                pic.BackgroundImage = bitmap;

                pic.Controls.Add(prc);
                pic.Cursor = Cursors.Hand;

                ELpanel.Controls.Add(pic);


            }
            dr.Close();
            con.Close();
        }
    }
}
