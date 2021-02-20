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
    public partial class DeskUI : Form
    {
        public DeskUI()
        {
            InitializeComponent();
        }
        DeskManager deskManager = new DeskManager(new DeskDal());
        public string UserName { get; set; }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int DeskCount = deskManager.DeskCount() + 1;
                for (int i = 0; i < Convert.ToInt32(tbDeskCount.Text); i++)
                {
                    deskManager.Add(new Desk
                    {
                        DeskName = DeskCount.ToString() + ". Masa"
                    });
                    DeskCount++;
                }
                tbDeskCount.Clear();
                MessageBox.Show("Masalar başarıyla eklendi.");
                GetData();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
            
        }

        private void DeskUI_Load(object sender, EventArgs e)
        {
            GetData();
            gbxDelete.Enabled = false;
        }
        private void GetData()
        {
            dgwDeskList.DataSource = deskManager.GetAll();
        }

        private void dgwDeskList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgwDeskList.RowCount != 0)
                {
                    tbDeskId.Text = dgwDeskList.CurrentRow.Cells[0].Value.ToString();
                    gbxDelete.Enabled = true;
                    btnAdd.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Masa bulunmamaktadır.");
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
                deskManager.Delete(new Desk
                {
                    Id = Convert.ToInt32(tbDeskId.Text)
                });
                btnAdd.Enabled = true;
                MessageBox.Show("Masa başarıyla silindi.");
                GetData();
                gbxDelete.Enabled = false;
                tbDeskId.Clear();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbDeskId.Clear();
            gbxDelete.Enabled = false;
            btnAdd.Enabled = true;
        }

        private void DeskUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.UserName = UserName;
            mainPage.IsAdmin = true;
            mainPage.Show();
        }
    }
}
