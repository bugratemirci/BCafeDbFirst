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
    public partial class CategoryUI : Form
    {
        public CategoryUI()
        {
            InitializeComponent();
        }
        CategoryManager categoryManager = new CategoryManager(new CategoryDal());
        public string UserName { get; set; }
        private void CategoryUI_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            dgwCategoryList.DataSource = categoryManager.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                categoryManager.Add(new Category
                {
                    Name = tbCategoryName.Text
                });
                MessageBox.Show("Kategori başarıyla eklendi.");
                GetData();
                tbCategoryName.Clear();
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
                categoryManager.Update(new Category
                {
                    Id = Convert.ToInt32(dgwCategoryList.CurrentRow.Cells[0].Value.ToString()),
                    Name = tbUpdateCategoryName.Text
                });
                MessageBox.Show("Kategori başarıyla güncellendi.");

                GetData();
                gbxUpdate.Enabled = false;
                UpdateClear();
                gbxAdd.Enabled = true;
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
            
        }

        private void dgwCategoryList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgwCategoryList.RowCount != 0)
                {
                    gbxUpdate.Enabled = true;
                    gbxAdd.Enabled = false;
                    tbUpdateCategoryName.Text = dgwCategoryList.CurrentRow.Cells[1].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Kategori bulunmamaktadır.");
                }
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
            
     
        }

        private void UpdateClear()
        {
            tbUpdateCategoryName.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                categoryManager.Delete(new Category
                {
                    Id = Convert.ToInt32(dgwCategoryList.CurrentRow.Cells[0].Value.ToString())
                });
                MessageBox.Show("Kategori başarıyla silindi.");
                GetData();
                gbxUpdate.Enabled = false;
                UpdateClear();
                gbxAdd.Enabled = true;
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
            
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(tbSearch.Text))
                {
                    dgwCategoryList.DataSource = categoryManager.GetByName(tbSearch.Text);
                }
                else
                {
                    GetData();
                }
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            gbxUpdate.Enabled = false;
            UpdateClear();
            gbxAdd.Enabled = true;
        }

        private void CategoryUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.UserName = UserName;
            mainPage.IsAdmin = true;
            mainPage.Show();
        }
    }
}
