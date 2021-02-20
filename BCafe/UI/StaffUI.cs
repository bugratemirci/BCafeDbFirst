using BCafe.Business;
using BCafe.DataAccess;
using BCafe.Entities;
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
    public partial class StaffUI : Form
    {
        public StaffUI()
        {
            InitializeComponent();
        }
        StaffManager staffManager = new StaffManager(new StaffDal());
        public string UserName { get; set; }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                bool isAdmin;
                if (rbAuthorized.Checked)
                {
                    isAdmin = true;
                }
                else
                {
                    isAdmin = false;
                }
                if (staffManager.AddControl(tbUserName.Text, mtbIdentityNumber.Text, tbMail.Text))
                {
                    MessageBox.Show("Bu kişi sistemde kayıtlıdır.");

                }
                else
                {
                    if (!string.IsNullOrEmpty(tbFirstName.Text) && !string.IsNullOrEmpty(tbLastName.Text) && !string.IsNullOrEmpty(mtbSalary.Text)
                        && mtbIdentityNumber.Text.Length == 11 && !string.IsNullOrEmpty(tbMail.Text) && !string.IsNullOrEmpty(tbPassword.Text)
                        && mtbPhone.Text.Length == 11 && !string.IsNullOrEmpty(tbUserName.Text) && (rbAuthorized.Checked || rbNonAuthorized.Checked))
                    {
                        staffManager.Add(new Staff
                        {
                            FirstName = tbFirstName.Text,
                            LastName = tbLastName.Text,
                            Salary = Convert.ToInt32(mtbSalary.Text),
                            IdentityNumber = mtbIdentityNumber.Text,
                            Mail = tbMail.Text,
                            Password = tbPassword.Text,
                            Phone = mtbPhone.Text,
                            UserName = tbUserName.Text,
                            IsAdmin = isAdmin
                        });
                        MessageBox.Show("Çalışan başarıyla eklendi.");
                        GetData();
                        AddClear();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen tüm alanları eksiksiz doldurunuz.");
                    }

                }
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                bool isAdminUpdate;
                if (rbUpdateAuthorized.Checked)
                {
                    isAdminUpdate = true;
                }
                else
                {
                    isAdminUpdate = false;
                }


                if (!string.IsNullOrEmpty(tbUpdateFirstName.Text) && !string.IsNullOrEmpty(tbUpdateLastName.Text) && !string.IsNullOrEmpty(mtbUpdateSalary.Text)
                    && mtbUpdateIdentityNumber.Text.Length == 11 && !string.IsNullOrEmpty(tbUpdateMail.Text) && !string.IsNullOrEmpty(tbUpdatePassword.Text)
                    && mtbUpdatePhone.Text.Length == 11 && !string.IsNullOrEmpty(tbUpdateUserName.Text) && (rbUpdateAuthorized.Checked || rbUpdateNonAuthorized.Checked))
                {
                    staffManager.Update(new Staff
                    {
                        Id = Convert.ToInt32(dgwStaffList.CurrentRow.Cells[0].Value.ToString()),
                        FirstName = tbUpdateFirstName.Text,
                        LastName = tbUpdateLastName.Text,
                        Salary = Convert.ToInt32(mtbUpdateSalary.Text),
                        IdentityNumber = mtbUpdateIdentityNumber.Text,
                        Mail = tbUpdateMail.Text,
                        Password = tbUpdatePassword.Text,
                        Phone = mtbUpdatePhone.Text,
                        UserName = tbUpdateUserName.Text,
                        IsAdmin = isAdminUpdate
                    });
                    MessageBox.Show("Çalışan başarıyla güncellendi.");
                    GetData();
                    gbxUpdateDelete.Enabled = false;
                    UpdateClear();
                    gbxAdd.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Lütfen tüm alanları eksiksiz doldurunuz.");
                }
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }

        }

        private void dgwStaffList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgwStaffList.RowCount != 0)
                {
                    gbxUpdateDelete.Enabled = true;
                    gbxAdd.Enabled = false;
                    int id = Convert.ToInt32(dgwStaffList.CurrentRow.Cells[0].Value.ToString());
                    var result = staffManager.GetStaff(id);
                    if (result.IsAdmin)
                    {
                        rbUpdateAuthorized.Checked = true;
                    }
                    else
                    {
                        rbUpdateNonAuthorized.Checked = true;
                    }
                    tbUpdateFirstName.Text = dgwStaffList.CurrentRow.Cells[1].Value.ToString();
                    tbUpdateLastName.Text = dgwStaffList.CurrentRow.Cells[2].Value.ToString();
                    mtbUpdateSalary.Text = dgwStaffList.CurrentRow.Cells[6].Value.ToString();
                    mtbUpdateIdentityNumber.Text = dgwStaffList.CurrentRow.Cells[3].Value.ToString();
                    tbUpdateMail.Text = dgwStaffList.CurrentRow.Cells[4].Value.ToString();
                    tbUpdateUserName.Text = dgwStaffList.CurrentRow.Cells[8].Value.ToString();
                    mtbUpdatePhone.Text = dgwStaffList.CurrentRow.Cells[5].Value.ToString();
                    tbUpdatePassword.Text = dgwStaffList.CurrentRow.Cells[7].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Çalışan bulunmamaktadır.");
                }
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
           

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                staffManager.Delete(new Staff
                {
                    Id = Convert.ToInt32(dgwStaffList.CurrentRow.Cells[0].Value.ToString())
                });
                MessageBox.Show("Çalışan başarıyla silindi.");
                GetData();
                gbxUpdateDelete.Enabled = false;
                UpdateClear();
                gbxAdd.Enabled = true;
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
            
        }
        private void SearchData(string key)
        {

            dgwStaffList.DataSource = staffManager.SearchStaff(key);
        }
        private void UpdateClear()
        {
            tbUpdateFirstName.Clear();
            tbUpdateLastName.Clear();
            mtbUpdateSalary.Clear();
            mtbUpdateIdentityNumber.Clear();
            tbUpdateMail.Clear();
            tbUpdateUserName.Clear();
            mtbUpdatePhone.Clear();
            tbUpdatePassword.Clear();
        }
        private void GetData()
        {

            dgwStaffList.DataSource = staffManager.GetAll();
        }
        private void AddClear()
        {
            tbFirstName.Clear();
            tbLastName.Clear();
            mtbSalary.Clear();
            mtbIdentityNumber.Clear();
            tbMail.Clear();
            tbUserName.Clear();
            mtbPhone.Clear();
            tbPassword.Clear();
        }
        private void StaffUI_Load(object sender, EventArgs e)
        {
            GetData();

        }

        private void tbSearchStaff_TextChanged(object sender, EventArgs e)
        {
            if (tbSearchStaff.Text.Length != 0)
            {
                SearchData(tbSearchStaff.Text);
            }
            else
            {
                GetData();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            gbxUpdateDelete.Enabled = false;
            UpdateClear();
            gbxAdd.Enabled = true;
        }

        private void StaffUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.UserName = UserName;
            mainPage.IsAdmin = true;
            mainPage.Show();
        }
    }
}
