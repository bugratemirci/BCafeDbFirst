using BCafe.Business;
using BCafe.DataAccess;
using BCafe.Entities;
using Bunifu.Framework.UI;
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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            panelOrderOperations.BackColor = Color.FromArgb(90, Color.Black);
            panelOrders.BackColor = Color.FromArgb(90, Color.Black);
            panelSummary.BackColor = Color.FromArgb(90, Color.Black);
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            lblSelectedDesk.BackColor = Color.Transparent;
            lblSelectedProduct.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            lblSelectedDesk.ForeColor = Color.White;
            lblSelectedProduct.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label4.BackColor = Color.Transparent;
            label5.ForeColor = Color.White;
            label5.BackColor = Color.Transparent;
            label6.ForeColor = Color.White;
            label6.BackColor = Color.Transparent;

            label12.BackColor = Color.Transparent;
            label8.ForeColor = Color.White;
            label8.BackColor = Color.Transparent;

            label9.BackColor = Color.Transparent;

            label10.BackColor = Color.Transparent;
            GetData();
        }
        public string UserName { get; set; }
        public bool IsAdmin { get; set; }
        DeskManager deskManager = new DeskManager(new DeskDal());
        OrderManager orderManager = new OrderManager(new OrderDal());
        ProductManager productManager = new ProductManager(new ProductDal());
        ReceiptManager receiptManager = new ReceiptManager(new ReceiptDal());
        Login login = new Login();

        int deskId, productId, orderId;
        private void MainPage_Load(object sender, EventArgs e)
        {

            if (!IsAdmin)
            {
                tsmCategory.Visible = false;
                tsmDesk.Visible = false;
                tsmStaff.Visible = false;
                tsmProduct.Visible = false;
            }
            else
            {
                if (deskManager.GetAll().Count == 0)
                {
                    AddDesk();
                }
            }
            cbxDeskList.DisplayMember = "DeskName";
            cbxDeskList.ValueMember = "Id";
            GetData();
            GetDesks();
        }
        public void GetData()
        {

            dgwProductList.DataSource = productManager.ShowProducts();
            dgwOrderList.DataSource = orderManager.ShowOrders();
            cbxDeskList.DataSource = deskManager.GetAll();

            label12.Text = "Günlük kazanç: " + receiptManager.DailySell(DateTime.Now.ToShortDateString()).ToString() + " TL";
            label9.Text = "Giriş yapan kullanıcı: " + UserName;
            label10.Text = "Tarih: " + DateTime.Now.ToShortDateString();
            dgwReceiptList.DataSource = receiptManager.GetAll();
        }
        private void GetDesks()
        {


            int deskCount = deskManager.DeskCount() + 1;
            BunifuImageButton[] desks = new BunifuImageButton[deskCount];
            int x = 20, y = 30;
            var deskList = deskManager.GetAll();
            int i = 1;
            foreach (var desk in deskList)
            {
                desks[i] = new BunifuImageButton();
                desks[i].Name = desk.DeskName;
                desks[i].Location = new Point(x, y);
                desks[i].ImageLocation = "E:\\Görsel\\GorselFinal\\dbfirst\\BCafe\\BCafe\\BCafe\\Resources\\table.png";
                desks[i].Visible = true;
                desks[i].BackColor = Color.Transparent;
                desks[i].SizeMode = PictureBoxSizeMode.AutoSize;
                desks[i].Zoom = 5;



                gbxDeskList.Controls.Add(desks[i]);
                desks[i].Click += this.PictureClick;
                desks[i].BringToFront();
                x += 80;
                if (i % 6 == 0)
                {
                    y += 70;
                    x = 20;
                }
                i++;
            }
        }
        private void PictureClick(object sender, EventArgs e)
        {
            PictureBox oPictureBox = (PictureBox)sender;
            lblSelectedDesk.Text = "Seçili Masa: " + oPictureBox.Name;
            var desk = deskManager.GetDesk(oPictureBox.Name);
            deskId = desk.Id;
        }
        private void AddDesk()
        {
            for (int i = 0; i < 10; i++)
            {

                deskManager.Add(new Desk
                {
                    DeskName = (i + 1).ToString() + ". Masa"

                });
            }
        }



        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            try
            {
                var product = productManager.GetById(productId);
                if (productId != 0 && deskId != 0 && (mtbProductCount.Text.Length != 0 && Convert.ToInt32(mtbProductCount.Text) != 0))
                {
                    if (product.UnitsInStock - Convert.ToInt32(mtbProductCount.Text) >= 0)
                    {
                        var result = orderManager.getOrderPrice(productId);

                        for (int i = 0; i < Convert.ToInt32(mtbProductCount.Text); i++)
                        {
                            orderManager.Add(new Order
                            {
                                DeskId = deskId,
                                ProductId = productId,
                                OrderPrice = result.UnitPrice
                            });
                            productManager.Update(new Product
                            {
                                Id = productId,
                                UnitsInStock = result.UnitsInStock - Convert.ToInt32(mtbProductCount.Text),
                                CategoryId = result.CategoryId,
                                Name = result.Name,
                                UnitPrice = result.UnitPrice
                            });
                        }
                        MessageBox.Show("Sipariş başarıyla eklendi.");
                        GetData();
                        mtbProductCount.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Elimizde bu üründen istediğiniz miktarda yoktur.");
                    }
                }

                else
                {
                    MessageBox.Show("Ürün, masa ve ürün adedi seçiniz.");
                }
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
                    productId = Convert.ToInt32(dgwProductList.CurrentRow.Cells[0].Value.ToString());
                    lblSelectedProduct.Text = "Seçili Ürün: " + dgwProductList.CurrentRow.Cells[1].Value.ToString();
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

        private void tsmProduct_Click(object sender, EventArgs e)
        {
            ProductsUI productsUI = new ProductsUI();
            productsUI.UserName = UserName;
            productsUI.Show();
            this.Close();
        }

        private void tsmStaff_Click(object sender, EventArgs e)
        {
            StaffUI staffUI = new StaffUI();
            staffUI.UserName = UserName;
            staffUI.Show();
            this.Close();
        }

        private void tsmCategory_Click(object sender, EventArgs e)
        {
            CategoryUI categoryUI = new CategoryUI();
            categoryUI.UserName = UserName;
            categoryUI.Show();
            this.Close();
        }
        string masaName, time, date;
        int masaId;
        decimal sumOfOrder;
        private void btnGetReceipt_Click(object sender, EventArgs e)
        {
            try
            {
                
                masaId = Convert.ToInt32(cbxDeskList.SelectedValue);
                masaName = cbxDeskList.Text;
                if (orderManager.OrderControl(masaId))
                {
                    sumOfOrder = orderManager.SumofOrders(masaId);
                    date = DateTime.Now.ToShortDateString();
                    time = DateTime.Now.ToShortTimeString();
                    receiptManager.Add(new Receipt
                    {
                        Amount = sumOfOrder,
                        Date = date,
                        Time = time
                    });
                    orderManager.Delete(masaId);

                    MessageBox.Show("Fişiniz başarıyla kesildi ve masaya ait siparişler güncel siparişlerden düşüldü.\n" +
                        "Toplam tutar: " + sumOfOrder.ToString() + "\nMasa Numarası: " + masaName + "\nFiş kesim tarihi: " + date + "\nFiş kesim saati:" + time);

                    printPreviewDialog1.ShowDialog();
                    GetData();
                    lbOrders.Items.Clear();
                }
                else
                {
                    MessageBox.Show("Masada sipariş bulunmamaktadır.");
                }
                
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
            

        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (orderId != 0)
                {
                    var order = orderManager.GetById(orderId);
                    var product = productManager.GetById(order.ProductId);
                    orderManager.Delete(new Order
                    {
                        Id = orderId
                    });
                    productManager.Update(new Product
                    {
                        Id = product.Id,
                        Name = product.Name,
                        UnitsInStock = product.UnitsInStock + 1,
                        CategoryId = product.CategoryId,
                        UnitPrice = product.UnitPrice
                    });
                    GetData();
                    lbOrders.Items.Clear();
                    orderId = 0;
                }
                else
                {
                    MessageBox.Show("Lütfen iptal edeceğiniz siparişi seçin.");
                }
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetData();
        }

        private void tbDeskSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbDeskSearch.Text))
            {
                dgwOrderList.DataSource = orderManager.ShowOrders(tbDeskSearch.Text);
            }
            else
            {
                dgwOrderList.DataSource = orderManager.ShowOrders();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font myFont = new Font("Calibri", 28);
            SolidBrush sbrush = new SolidBrush(Color.Black);
            Pen myPen = new Pen(Color.Black);

            //Bu kısımda sipariş formu yazısını ve çizgileri yazdırıyorum
            e.Graphics.DrawLine(myPen, 120, 120, 750, 120);
            e.Graphics.DrawLine(myPen, 120, 180, 750, 180);
            e.Graphics.DrawString("FİŞ", myFont, sbrush, 250, 120);


            e.Graphics.DrawString("Masa Numarası: " + masaName, myFont, sbrush, 250, 320);
            e.Graphics.DrawString("Toplam tutar: " + sumOfOrder, myFont, sbrush, 250, 420);
            e.Graphics.DrawString("Tarih: " + date, myFont, sbrush, 250, 520);
            e.Graphics.DrawString("Saat: "  + time, myFont, sbrush, 250, 620);
        }

        private void tsmDesk_Click(object sender, EventArgs e)
        {
            DeskUI deskUI = new DeskUI();
            deskUI.UserName = UserName;
            deskUI.Show();
            this.Close();
        }

        private void dgwOrderList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lbOrders.Items.Clear();

                if (dgwOrderList.RowCount != 0)
                {
                    orderId = Convert.ToInt32(dgwOrderList.CurrentRow.Cells[0].Value.ToString());
                    string orderDesk = dgwOrderList.CurrentRow.Cells[1].Value.ToString();
                    string orderProduct = dgwOrderList.CurrentRow.Cells[2].Value.ToString();
                    lbOrders.Items.Add(orderId.ToString());
                    lbOrders.Items.Add(orderDesk);
                    lbOrders.Items.Add(orderProduct);
                }
                else
                {
                    MessageBox.Show("Güncel sipariş bulunmamaktadır!");
                }
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
            
        }

    }
}
