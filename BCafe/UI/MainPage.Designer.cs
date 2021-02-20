namespace BCafe.UserUI
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.dgwProductList = new System.Windows.Forms.DataGridView();
            this.ProductShowID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductShowName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductUnitsInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxDeskList = new System.Windows.Forms.ComboBox();
            this.dgwOrderList = new System.Windows.Forms.DataGridView();
            this.OrderShowId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDeskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderPriceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSelectedProduct = new System.Windows.Forms.Label();
            this.lblSelectedDesk = new System.Windows.Forms.Label();
            this.panelOrderOperations = new System.Windows.Forms.Panel();
            this.mtbProductCount = new System.Windows.Forms.TextBox();
            this.gbxDeskList = new System.Windows.Forms.GroupBox();
            this.btnAddOrder = new Telerik.WinControls.UI.RadButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelOrders = new System.Windows.Forms.Panel();
            this.lbOrders = new Telerik.WinControls.UI.RadListControl();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDeskSearch = new Telerik.WinControls.UI.RadTextBox();
            this.btnGetReceipt = new Telerik.WinControls.UI.RadButton();
            this.btnCancelOrder = new Telerik.WinControls.UI.RadButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tsmProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDesk = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panelSummary = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgwReceiptList = new System.Windows.Forms.DataGridView();
            this.ReceiptID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiptDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiptTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiptAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radTitleBar1 = new Telerik.WinControls.UI.RadTitleBar();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fluentDarkTheme1 = new Telerik.WinControls.Themes.FluentDarkTheme();
            this.office2010SilverTheme1 = new Telerik.WinControls.Themes.Office2010SilverTheme();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrderList)).BeginInit();
            this.panelOrderOperations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddOrder)).BeginInit();
            this.panelOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDeskSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGetReceipt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelOrder)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panelSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwReceiptList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwProductList
            // 
            this.dgwProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProductList.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dgwProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductShowID,
            this.ProductShowName,
            this.ProductCategoryName,
            this.ProductUnitPrice,
            this.ProductUnitsInStock});
            this.dgwProductList.Location = new System.Drawing.Point(572, 65);
            this.dgwProductList.Margin = new System.Windows.Forms.Padding(4);
            this.dgwProductList.Name = "dgwProductList";
            this.dgwProductList.ReadOnly = true;
            this.dgwProductList.RowHeadersVisible = false;
            this.dgwProductList.Size = new System.Drawing.Size(555, 483);
            this.dgwProductList.TabIndex = 7;
            this.dgwProductList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProductList_CellClick);
            // 
            // ProductShowID
            // 
            this.ProductShowID.DataPropertyName = "Id";
            this.ProductShowID.HeaderText = "ID";
            this.ProductShowID.Name = "ProductShowID";
            this.ProductShowID.ReadOnly = true;
            // 
            // ProductShowName
            // 
            this.ProductShowName.DataPropertyName = "Name";
            this.ProductShowName.HeaderText = "Ürün Adı";
            this.ProductShowName.Name = "ProductShowName";
            this.ProductShowName.ReadOnly = true;
            // 
            // ProductCategoryName
            // 
            this.ProductCategoryName.DataPropertyName = "CategoryName";
            this.ProductCategoryName.HeaderText = "Ürün Kategorisi";
            this.ProductCategoryName.Name = "ProductCategoryName";
            this.ProductCategoryName.ReadOnly = true;
            // 
            // ProductUnitPrice
            // 
            this.ProductUnitPrice.DataPropertyName = "UnitPrice";
            this.ProductUnitPrice.HeaderText = "Ürün Fiyatı";
            this.ProductUnitPrice.Name = "ProductUnitPrice";
            this.ProductUnitPrice.ReadOnly = true;
            // 
            // ProductUnitsInStock
            // 
            this.ProductUnitsInStock.DataPropertyName = "UnitsInStock";
            this.ProductUnitsInStock.HeaderText = "Stok Sayısı";
            this.ProductUnitsInStock.Name = "ProductUnitsInStock";
            this.ProductUnitsInStock.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(737, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Masa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(903, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sipariş İşlemleri";
            // 
            // cbxDeskList
            // 
            this.cbxDeskList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxDeskList.FormattingEnabled = true;
            this.cbxDeskList.Location = new System.Drawing.Point(847, 151);
            this.cbxDeskList.Margin = new System.Windows.Forms.Padding(4);
            this.cbxDeskList.Name = "cbxDeskList";
            this.cbxDeskList.Size = new System.Drawing.Size(136, 24);
            this.cbxDeskList.TabIndex = 3;
            // 
            // dgwOrderList
            // 
            this.dgwOrderList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwOrderList.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dgwOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderShowId,
            this.OrderDeskName,
            this.OrderProductName,
            this.OrderPriceAmount});
            this.dgwOrderList.Location = new System.Drawing.Point(21, 62);
            this.dgwOrderList.Margin = new System.Windows.Forms.Padding(4);
            this.dgwOrderList.Name = "dgwOrderList";
            this.dgwOrderList.ReadOnly = true;
            this.dgwOrderList.RowHeadersVisible = false;
            this.dgwOrderList.Size = new System.Drawing.Size(693, 224);
            this.dgwOrderList.TabIndex = 8;
            this.dgwOrderList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwOrderList_CellClick);
            // 
            // OrderShowId
            // 
            this.OrderShowId.DataPropertyName = "Id";
            this.OrderShowId.HeaderText = "ID";
            this.OrderShowId.Name = "OrderShowId";
            this.OrderShowId.ReadOnly = true;
            // 
            // OrderDeskName
            // 
            this.OrderDeskName.DataPropertyName = "DeskName";
            this.OrderDeskName.HeaderText = "Masa Adı";
            this.OrderDeskName.Name = "OrderDeskName";
            this.OrderDeskName.ReadOnly = true;
            // 
            // OrderProductName
            // 
            this.OrderProductName.DataPropertyName = "ProductName";
            this.OrderProductName.HeaderText = "Ürün";
            this.OrderProductName.Name = "OrderProductName";
            this.OrderProductName.ReadOnly = true;
            // 
            // OrderPriceAmount
            // 
            this.OrderPriceAmount.DataPropertyName = "OrderPrice";
            this.OrderPriceAmount.HeaderText = "Ürün Fiyatı";
            this.OrderPriceAmount.Name = "OrderPriceAmount";
            this.OrderPriceAmount.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(568, 587);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ürün Adedi:";
            // 
            // lblSelectedProduct
            // 
            this.lblSelectedProduct.AutoSize = true;
            this.lblSelectedProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSelectedProduct.Location = new System.Drawing.Point(568, 555);
            this.lblSelectedProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedProduct.Name = "lblSelectedProduct";
            this.lblSelectedProduct.Size = new System.Drawing.Size(89, 20);
            this.lblSelectedProduct.TabIndex = 7;
            this.lblSelectedProduct.Text = "Seçili Ürün:";
            // 
            // lblSelectedDesk
            // 
            this.lblSelectedDesk.AutoSize = true;
            this.lblSelectedDesk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSelectedDesk.Location = new System.Drawing.Point(17, 574);
            this.lblSelectedDesk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedDesk.Name = "lblSelectedDesk";
            this.lblSelectedDesk.Size = new System.Drawing.Size(93, 20);
            this.lblSelectedDesk.TabIndex = 6;
            this.lblSelectedDesk.Text = "Seçili Masa:";
            // 
            // panelOrderOperations
            // 
            this.panelOrderOperations.Controls.Add(this.mtbProductCount);
            this.panelOrderOperations.Controls.Add(this.gbxDeskList);
            this.panelOrderOperations.Controls.Add(this.btnAddOrder);
            this.panelOrderOperations.Controls.Add(this.label6);
            this.panelOrderOperations.Controls.Add(this.label5);
            this.panelOrderOperations.Controls.Add(this.dgwProductList);
            this.panelOrderOperations.Controls.Add(this.label1);
            this.panelOrderOperations.Controls.Add(this.lblSelectedDesk);
            this.panelOrderOperations.Controls.Add(this.lblSelectedProduct);
            this.panelOrderOperations.Location = new System.Drawing.Point(12, 74);
            this.panelOrderOperations.Name = "panelOrderOperations";
            this.panelOrderOperations.Size = new System.Drawing.Size(1160, 626);
            this.panelOrderOperations.TabIndex = 11;
            // 
            // mtbProductCount
            // 
            this.mtbProductCount.Location = new System.Drawing.Point(668, 587);
            this.mtbProductCount.Name = "mtbProductCount";
            this.mtbProductCount.Size = new System.Drawing.Size(46, 21);
            this.mtbProductCount.TabIndex = 0;
            // 
            // gbxDeskList
            // 
            this.gbxDeskList.BackColor = System.Drawing.Color.White;
            this.gbxDeskList.Location = new System.Drawing.Point(21, 65);
            this.gbxDeskList.Name = "gbxDeskList";
            this.gbxDeskList.Size = new System.Drawing.Size(526, 483);
            this.gbxDeskList.TabIndex = 15;
            this.gbxDeskList.TabStop = false;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(991, 586);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(136, 28);
            this.btnAddOrder.TabIndex = 1;
            this.btnAddOrder.Text = "Sipariş Ekle";
            this.btnAddOrder.ThemeName = "FluentDark";
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(568, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ürün Listesi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(17, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Masa Listesi";
            // 
            // panelOrders
            // 
            this.panelOrders.Controls.Add(this.lbOrders);
            this.panelOrders.Controls.Add(this.label11);
            this.panelOrders.Controls.Add(this.label7);
            this.panelOrders.Controls.Add(this.tbDeskSearch);
            this.panelOrders.Controls.Add(this.btnGetReceipt);
            this.panelOrders.Controls.Add(this.btnCancelOrder);
            this.panelOrders.Controls.Add(this.label4);
            this.panelOrders.Controls.Add(this.dgwOrderList);
            this.panelOrders.Controls.Add(this.label3);
            this.panelOrders.Controls.Add(this.label2);
            this.panelOrders.Controls.Add(this.cbxDeskList);
            this.panelOrders.Location = new System.Drawing.Point(12, 706);
            this.panelOrders.Name = "panelOrders";
            this.panelOrders.Size = new System.Drawing.Size(1160, 319);
            this.panelOrders.TabIndex = 12;
            // 
            // lbOrders
            // 
            this.lbOrders.Location = new System.Drawing.Point(847, 184);
            this.lbOrders.Name = "lbOrders";
            this.lbOrders.Size = new System.Drawing.Size(136, 80);
            this.lbOrders.TabIndex = 4;
            this.lbOrders.ThemeName = "Office2010Silver";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(737, 182);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "Sipariş Detay:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(737, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Masa Arama:";
            // 
            // tbDeskSearch
            // 
            this.tbDeskSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbDeskSearch.Location = new System.Drawing.Point(847, 121);
            this.tbDeskSearch.Name = "tbDeskSearch";
            this.tbDeskSearch.Size = new System.Drawing.Size(136, 23);
            this.tbDeskSearch.TabIndex = 2;
            this.tbDeskSearch.ThemeName = "Office2010Silver";
            this.tbDeskSearch.TextChanged += new System.EventHandler(this.tbDeskSearch_TextChanged);
            // 
            // btnGetReceipt
            // 
            this.btnGetReceipt.Location = new System.Drawing.Point(991, 150);
            this.btnGetReceipt.Name = "btnGetReceipt";
            this.btnGetReceipt.Size = new System.Drawing.Size(136, 28);
            this.btnGetReceipt.TabIndex = 5;
            this.btnGetReceipt.Text = "Fiş Kes";
            this.btnGetReceipt.ThemeName = "FluentDark";
            this.btnGetReceipt.Click += new System.EventHandler(this.btnGetReceipt_Click);
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Location = new System.Drawing.Point(991, 236);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(136, 28);
            this.btnCancelOrder.TabIndex = 6;
            this.btnCancelOrder.Text = "Sipariş İptal";
            this.btnCancelOrder.ThemeName = "FluentDark";
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(17, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Güncel Sipariş Listesi";
            // 
            // tsmProduct
            // 
            this.tsmProduct.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.tsmProduct.ForeColor = System.Drawing.Color.Black;
            this.tsmProduct.Name = "tsmProduct";
            this.tsmProduct.Size = new System.Drawing.Size(56, 41);
            this.tsmProduct.Text = "Ürün";
            this.tsmProduct.Click += new System.EventHandler(this.tsmProduct_Click);
            // 
            // tsmStaff
            // 
            this.tsmStaff.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.tsmStaff.ForeColor = System.Drawing.Color.Black;
            this.tsmStaff.Name = "tsmStaff";
            this.tsmStaff.Size = new System.Drawing.Size(70, 41);
            this.tsmStaff.Text = "Çalışan";
            this.tsmStaff.Click += new System.EventHandler(this.tsmStaff_Click);
            // 
            // tsmCategory
            // 
            this.tsmCategory.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.tsmCategory.ForeColor = System.Drawing.Color.Black;
            this.tsmCategory.Name = "tsmCategory";
            this.tsmCategory.Size = new System.Drawing.Size(81, 41);
            this.tsmCategory.Text = "Kategori";
            this.tsmCategory.Click += new System.EventHandler(this.tsmCategory_Click);
            // 
            // tsmDesk
            // 
            this.tsmDesk.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.tsmDesk.ForeColor = System.Drawing.Color.Black;
            this.tsmDesk.Name = "tsmDesk";
            this.tsmDesk.Size = new System.Drawing.Size(58, 41);
            this.tsmDesk.Text = "Masa";
            this.tsmDesk.Click += new System.EventHandler(this.tsmDesk_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmProduct,
            this.tsmStaff,
            this.tsmCategory,
            this.tsmDesk});
            this.menuStrip1.Location = new System.Drawing.Point(0, 1017);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1904, 47);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panelSummary
            // 
            this.panelSummary.Controls.Add(this.label12);
            this.panelSummary.Controls.Add(this.label10);
            this.panelSummary.Controls.Add(this.label8);
            this.panelSummary.Controls.Add(this.label9);
            this.panelSummary.Controls.Add(this.dgwReceiptList);
            this.panelSummary.Location = new System.Drawing.Point(1179, 706);
            this.panelSummary.Name = "panelSummary";
            this.panelSummary.Size = new System.Drawing.Size(713, 319);
            this.panelSummary.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(407, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "Günlük Kazanç: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(407, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Tarih:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(17, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Sipariş Geçmişi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(407, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Giriş Yapan Kullanıcı:";
            // 
            // dgwReceiptList
            // 
            this.dgwReceiptList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwReceiptList.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dgwReceiptList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwReceiptList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReceiptID,
            this.ReceiptDate,
            this.ReceiptTime,
            this.ReceiptAmount});
            this.dgwReceiptList.Location = new System.Drawing.Point(21, 62);
            this.dgwReceiptList.Name = "dgwReceiptList";
            this.dgwReceiptList.ReadOnly = true;
            this.dgwReceiptList.RowHeadersVisible = false;
            this.dgwReceiptList.Size = new System.Drawing.Size(371, 224);
            this.dgwReceiptList.TabIndex = 9;
            // 
            // ReceiptID
            // 
            this.ReceiptID.DataPropertyName = "Id";
            this.ReceiptID.HeaderText = "ID";
            this.ReceiptID.Name = "ReceiptID";
            this.ReceiptID.ReadOnly = true;
            // 
            // ReceiptDate
            // 
            this.ReceiptDate.DataPropertyName = "Date";
            this.ReceiptDate.HeaderText = "Tarih";
            this.ReceiptDate.Name = "ReceiptDate";
            this.ReceiptDate.ReadOnly = true;
            // 
            // ReceiptTime
            // 
            this.ReceiptTime.DataPropertyName = "Time";
            this.ReceiptTime.HeaderText = "Saat";
            this.ReceiptTime.Name = "ReceiptTime";
            this.ReceiptTime.ReadOnly = true;
            // 
            // ReceiptAmount
            // 
            this.ReceiptAmount.DataPropertyName = "Amount";
            this.ReceiptAmount.HeaderText = "Toplam Tutar";
            this.ReceiptAmount.Name = "ReceiptAmount";
            this.ReceiptAmount.ReadOnly = true;
            // 
            // radTitleBar1
            // 
            this.radTitleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radTitleBar1.Location = new System.Drawing.Point(0, 0);
            this.radTitleBar1.Name = "radTitleBar1";
            this.radTitleBar1.Size = new System.Drawing.Size(1904, 23);
            this.radTitleBar1.TabIndex = 14;
            this.radTitleBar1.TabStop = false;
            this.radTitleBar1.ThemeName = "VisualStudio2012Dark";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1179, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(714, 531);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Text = "Baskı önizleme";
            this.printPreviewDialog1.Visible = false;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1064);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radTitleBar1);
            this.Controls.Add(this.panelSummary);
            this.Controls.Add(this.panelOrders);
            this.Controls.Add(this.panelOrderOperations);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrderList)).EndInit();
            this.panelOrderOperations.ResumeLayout(false);
            this.panelOrderOperations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddOrder)).EndInit();
            this.panelOrders.ResumeLayout(false);
            this.panelOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDeskSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGetReceipt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelOrder)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelSummary.ResumeLayout(false);
            this.panelSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwReceiptList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dgwProductList;
        public System.Windows.Forms.DataGridView dgwOrderList;
        private System.Windows.Forms.Label lblSelectedProduct;
        private System.Windows.Forms.Label lblSelectedDesk;
        private System.Windows.Forms.ComboBox cbxDeskList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelOrderOperations;
        private System.Windows.Forms.Panel panelOrders;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem tsmProduct;
        private System.Windows.Forms.ToolStripMenuItem tsmStaff;
        private System.Windows.Forms.ToolStripMenuItem tsmCategory;
        private System.Windows.Forms.ToolStripMenuItem tsmDesk;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panelSummary;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.DataGridView dgwReceiptList;
        private Telerik.WinControls.UI.RadButton btnCancelOrder;
        private Telerik.WinControls.UI.RadButton btnGetReceipt;
        private Telerik.WinControls.UI.RadButton btnAddOrder;
        private Telerik.WinControls.UI.RadTitleBar radTitleBar1;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbxDeskList;
        private Telerik.WinControls.Themes.FluentDarkTheme fluentDarkTheme1;
        private System.Windows.Forms.Label label7;
        private Telerik.WinControls.UI.RadTextBox tbDeskSearch;
        private Telerik.WinControls.Themes.Office2010SilverTheme office2010SilverTheme1;
        private System.Windows.Forms.Label label11;
        private Telerik.WinControls.UI.RadListControl lbOrders;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TextBox mtbProductCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiptID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiptDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiptTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiptAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderShowId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDeskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderPriceAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductShowID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductShowName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductUnitsInStock;
    }
}