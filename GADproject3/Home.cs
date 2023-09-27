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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            Hide();
            AdminLogin login = new AdminLogin();
            login.Show();
        }

        private void btn_ExitApp_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(" Are you sure you want to Exit?", "SMART MONEY", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_Trader_Click(object sender, EventArgs e)
        {
            Hide();
            UserLogin ulog = new UserLogin();
            ulog.Show();


        }

        private void btn_Documents_Click(object sender, EventArgs e)
        {
            Hide();
            DocumentView doc = new DocumentView();
            doc.Show();
        }

        private void btn_Meetings_Click(object sender, EventArgs e)
        {
            Hide();
            MeetingView mv = new MeetingView();
            mv.Show();

        }

        private void btn_Entries_Click(object sender, EventArgs e)
        {
            Hide();
            ViewEntries ve = new ViewEntries();
            ve.Show();
        }

        private void btn_ContactUs_Click(object sender, EventArgs e)
        {
            Hide();
            ContactUs cu = new ContactUs();
            cu.Show();
        }

        private void btn_AboutUs_Click(object sender, EventArgs e)
        {
            Hide();
            AboutUs ab = new AboutUs();
            ab.Show();
        }
    }
}
