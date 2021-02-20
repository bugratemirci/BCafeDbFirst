using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCafe.DataAccess;
using BCafe.Business;

namespace BCafe.UserUI
{
    public partial class ForgotPasswordUI : Form
    {
        public ForgotPasswordUI()
        {
            InitializeComponent();
        }
        StaffManager staffManager = new StaffManager(new StaffDal());
        private void btnGetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(tbUserName.Text) && mtbIdentityNumber.Text.Length == 11)
                {
                    if (staffManager.CheckPassword(tbUserName.Text, mtbIdentityNumber.Text))
                    {
                        string password = staffManager.GetStaff(tbUserName.Text).Password;
                        MessageBox.Show("Parolanız: " + password + "'dır.");
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya kimlik numaranız hatalı!");
                    }

                }
                else
                {
                    MessageBox.Show("Lütfen bilgileri eksiksiz girin!!!");
                }
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
            
            
        }
    }
}
