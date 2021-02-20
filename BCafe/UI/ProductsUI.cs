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
    public partial class ProductsUI : Form
    {
        public ProductsUI()
        {
            InitializeComponent();
        }
        ProductManager productManager = new ProductManager(new ProductDal());
        CategoryManager categoryManager = new CategoryManager(new CategoryDal());
        public string UserName { get; set; }
        private void ProductsUI_Load(object sender, EventArgs e)
        {
            GetData();
            var result = categoryManager.GetAll();

            cbxCategory.DataSource = result;
            cbxCategory.DisplayMember = "Name";
            cbxCategory.ValueMember = "Id";

            var result2 = categoryManager.GetAll();
            cbxUpdateCategory.DataSource = result2;
            cbxUpdateCategory.DisplayMember = "Name";
            cbxUpdateCategory.ValueMember = "Id";
        }
        private void GetData()
        {
            
            dgwProductList.DataSource = productManager.GetAll();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                productManager.Add(new Product
                {
                    CategoryId = Convert.ToInt32(cbxCategory.SelectedValue),
                    UnitsInStock = Convert.ToInt32(mtbUnitsInStock.Text),
                    UnitPrice = Convert.ToDecimal(mtbUnitPrice.Text),
                    Name = tbProductName.Text
                });
                MessageBox.Show("Ürün başarıyla eklendi.");

                GetData();
                AddClear();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
            
        }

        private void dgwProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgwProductList.RowCount != 0)
                {
                    gbxAdd.Enabled = false;
                    gbxUpdateDelete.Enabled = true;
                    cbxUpdateCategory.SelectedValue = Convert.ToInt32(dgwProductList.CurrentRow.Cells[1].Value.ToString());
                    tbUpdateProductName.Text = dgwProductList.CurrentRow.Cells[2].Value.ToString();
                    mtbUpdateUnitPrice.Text = Convert.ToInt32(dgwProductList.CurrentRow.Cells[3].Value).ToString();
                    mtbUpdateUnitsInStock.Text = Convert.ToInt32(dgwProductList.CurrentRow.Cells[4].Value).ToString();
                }
                else
                {
                    MessageBox.Show("Ürün bulunmamaktadır.");
                }
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
           
        }

        private void UpdateClear()
        {
            cbxUpdateCategory.SelectedIndex = 0;
            tbUpdateProductName.Clear();
            mtbUpdateUnitPrice.Clear();
            mtbUpdateUnitsInStock.Clear();
        }
        private void AddClear()
        {
            cbxCategory.SelectedIndex = 0;
            tbProductName.Clear();
            mtbUnitPrice.Clear();
            mtbUnitsInStock.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                productManager.Update(new Product
                {
                    Id = Convert.ToInt32(dgwProductList.CurrentRow.Cells[0].Value.ToString()),
                    CategoryId = Convert.ToInt32(cbxUpdateCategory.SelectedValue),
                    UnitsInStock = Convert.ToInt32(mtbUpdateUnitsInStock.Text),
                    UnitPrice = Convert.ToDecimal(mtbUpdateUnitPrice.Text),
                    Name = tbUpdateProductName.Text
                });
                MessageBox.Show("Ürün başarıyla güncellendi.");

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
        MainPage mainPage = new MainPage();
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                productManager.Delete(new Product
                {
                    Id = Convert.ToInt32(dgwProductList.CurrentRow.Cells[0].Value.ToString())
                });
                MessageBox.Show("Ürün başarıyla silindi.");

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

        private void SearchByName(string key)
        {
            dgwProductList.DataSource = productManager.SearchByName(key);
        }
        private void tbSearchProduct_TextChanged(object sender, EventArgs e)
        {
            if(tbSearchProduct.Text.Length != 0)
            {
                SearchByName(tbSearchProduct.Text);
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

        private void ProductsUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.UserName = UserName;
            mainPage.IsAdmin = true;
            mainPage.Show();
        }
    }
}
