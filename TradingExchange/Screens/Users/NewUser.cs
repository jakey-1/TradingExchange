using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TradingExchange.BL;
using System.IO;

namespace TradingExchange.Screens.Users
{
    public partial class NewUser : Form
    {
        BL.CLS_NewUser nu = new CLS_NewUser();
        public NewUser()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }


        //Add Image (KYC)
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = " ملفات الصور |*.JPG; *.PNG";
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.BackgroundImage = null;
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }

        }
        
        //Picture Box
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Cursor = Cursors.Default;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Cursor = Cursors.Hand;
        }

        //Close&Minimize
        private void closebtn_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void minbtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        //MuseMove&MouseLeave
        private void closebtn_MouseLeave(object sender, EventArgs e)
        {
            closebtn.BackgroundImage = Properties.Resources._9;
        }
        private void closebtn_MouseMove(object sender, MouseEventArgs e)
        {
            closebtn.BackgroundImage = Properties.Resources._10;
        }

        private void minbtn_MouseMove(object sender, MouseEventArgs e)
        {
            minbtn.BackgroundImage = Properties.Resources._12;
        }
        private void minbtn_MouseLeave(object sender, EventArgs e)
        {
            minbtn.BackgroundImage = Properties.Resources._11;
        }

        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.BackgroundImage = Properties.Resources._8;
        }
        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            btnRegister.Cursor = Cursors.Default;
            btnRegister.BackgroundImage = Properties.Resources._7;
        }

        //Form Draggble
        private void NewUser_Load(object sender, EventArgs e)
        {
            ControlExtension.Draggable(this, true);
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedCountry = cmbCountry.SelectedItem.ToString();
            Cities cities = new Cities();
            List<string> citiesList = cities.GetCitiesOfCountry(selectedCountry);
            cmbCity.DataSource = citiesList;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCity.DataSource != null)
            {
                string selectedCity = cmbCity.SelectedValue.ToString();
                
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] byteImage = ms.ToArray();

            DateTime date = DateTime.Now;
            string Regster_Date = date.ToString("yyyy-MM-dd");

            nu.AddNewUser(
                txtFName.Text, // First name from a text box
                txtLName.Text, // Last name from a text box
                $"{txtFName.Text} {txtLName.Text}", // Full name, combining first and last name
                txtEmail.Text, // Email address from a text box
                txtPassword.Text, // Password from a text box
                (dateTPicker.Text), // Date of birth, converted from a date picker's text
                Regster_Date, // Registration date, likely a DateTime variable
                cmbCountry.Text, // Selected country from a combo box
                cmbCity.Text, // Selected city from a combo box
                byteImage // User's image, likely in byte array format
            );
            MessageBox.Show("مرحبا بك في منصتنا", "ترحيب", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
