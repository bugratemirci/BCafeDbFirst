using BCafe.Business;
using BCafe.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCafe.UserUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(125, Color.Black);
            pictureBox1.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;

        }
        public string userName;
        
        private void Login_Load(object sender, EventArgs e)
        {
           

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                StaffManager staffManager = new StaffManager(new StaffDal());

                if (staffManager.Control(tbUserName.Text, tbPassword.Text))
                {

                    var user = staffManager.GetStaff(tbUserName.Text);
                    MainPage mainPage = new MainPage();
                    mainPage.UserName = user.FirstName + " " + user.LastName;
                    mainPage.IsAdmin = user.IsAdmin;
                    MessageBox.Show("Giriş başarıyla yapıldı.");
                    mainPage.Show();
                }
                else
                {
                    MessageBox.Show("Giriş başarısız, kullanıcı adı veya parolanızı gözden geçirin!", "Uyarı", MessageBoxButtons.OK);
                }
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
            
        }

        private void llForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPasswordUI forgotPasswordUI = new ForgotPasswordUI();
            forgotPasswordUI.Show();
        }
    }
}
