using System;
using System.Data;
using System.Windows.Forms;
using TradingExchange.Screens;
using TradingExchange.Screens.Users;

namespace TradingExchange
{
    public partial class Login : Form
    {
        BL.LOGIN log = new BL.LOGIN();
        public Login()
        {
            InitializeComponent();
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }
        

        private void label3_Click(object sender, EventArgs e)
        {

         
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        //Close&Minimize
        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void minbtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //MuseMove&MouseLeave
        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.BackgroundImage = Properties.Resources._4a;
        }
        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.Cursor = Cursors.Default;
            btnLogin.BackgroundImage = Properties.Resources._2d;
        }

        private void closebtn_MouseMove(object sender, MouseEventArgs e)
        {
            closebtn.BackgroundImage= Properties.Resources._10;
        }
        private void closebtn_MouseLeave(object sender, EventArgs e)
        {
            closebtn.BackgroundImage = Properties.Resources._9;
        }

        private void minbtn_MouseMove(object sender, MouseEventArgs e)
        {
            minbtn.BackgroundImage = Properties.Resources._12;
        }
        private void minbtn_MouseLeave(object sender, EventArgs e)
        {
            minbtn.BackgroundImage = Properties.Resources._11;
        }

        //Form Draggble
        private void Form1_Load(object sender, EventArgs e)
        {
            ControlExtension.Draggable(this, true);
        }

        //login check
        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable Dt = log.USERLOGIN(txtEmail.Text, txtPassword.Text);
            if (Dt.Rows.Count > 0)
            {
                Main frm = new Main();
                MessageBox.Show("welcom");

            }
            else
            {
                MessageBox.Show("Password not correct");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            NewUser frm = new NewUser();
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.Cancel)
            {
                this.Show();
            }



        }
    }
}
