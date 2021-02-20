namespace BCafe.UserUI
{
    partial class ProductsUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsUI));
            this.label17 = new System.Windows.Forms.Label();
            this.tbSearchProduct = new System.Windows.Forms.TextBox();
            this.dgwProductList = new System.Windows.Forms.DataGridView();
            this.ShowProductsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShowCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShowProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShowUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShowUnitsInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.mtbUnitsInStock = new System.Windows.Forms.TextBox();
            this.mtbUnitPrice = new System.Windows.Forms.TextBox();
            this.btnAdd = new Telerik.WinControls.UI.RadButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.gbxUpdateDelete = new System.Windows.Forms.GroupBox();
            this.mtbUpdateUnitsInStock = new System.Windows.Forms.TextBox();
            this.mtbUpdateUnitPrice = new System.Windows.Forms.TextBox();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            this.btnUpdate = new Telerik.WinControls.UI.RadButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxUpdateCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbUpdateProductName = new System.Windows.Forms.TextBox();
            this.radTitleBar1 = new Telerik.WinControls.UI.RadTitleBar();
            this.fluentDarkTheme1 = new Telerik.WinControls.Themes.FluentDarkTheme();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProductList)).BeginInit();
            this.gbxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            this.gbxUpdateDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(246, 39);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 18);
            this.label17.TabIndex = 30;
            this.label17.Text = "Arama:";
            // 
            // tbSearchProduct
            // 
            this.tbSearchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSearchProduct.Location = new System.Drawing.Point(307, 36);
            this.tbSearchProduct.Name = "tbSearchProduct";
            this.tbSearchProduct.Size = new System.Drawing.Size(211, 24);
            this.tbSearchProduct.TabIndex = 29;
            this.tbSearchProduct.TextChanged += new System.EventHandler(this.tbSearchProduct_TextChanged);
            // 
            // dgwProductList
            // 
            this.dgwProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProductList.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dgwProductList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgwProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ShowProductsID,
            this.ShowCategoryID,
            this.ShowProductName,
            this.ShowUnitPrice,
            this.ShowUnitsInStock});
            this.dgwProductList.Location = new System.Drawing.Point(6, 84);
            this.dgwProductList.Name = "dgwProductList";
            this.dgwProductList.ReadOnly = true;
            this.dgwProductList.RowHeadersVisible = false;
            this.dgwProductList.Size = new System.Drawing.Size(820, 238);
            this.dgwProductList.TabIndex = 26;
            this.dgwProductList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProductList_CellClick);
            // 
            // ShowProductsID
            // 
            this.ShowProductsID.DataPropertyName = "Id";
            this.ShowProductsID.HeaderText = "ID";
            this.ShowProductsID.Name = "ShowProductsID";
            this.ShowProductsID.ReadOnly = true;
            // 
            // ShowCategoryID
            // 
            this.ShowCategoryID.DataPropertyName = "CategoryId";
            this.ShowCategoryID.HeaderText = "Kategori ID";
            this.ShowCategoryID.Name = "ShowCategoryID";
            this.ShowCategoryID.ReadOnly = true;
            // 
            // ShowProductName
            // 
            this.ShowProductName.DataPropertyName = "Name";
            this.ShowProductName.HeaderText = "Ürün Adı";
            this.ShowProductName.Name = "ShowProductName";
            this.ShowProductName.ReadOnly = true;
            // 
            // ShowUnitPrice
            // 
            this.ShowUnitPrice.DataPropertyName = "UnitPrice";
            this.ShowUnitPrice.HeaderText = "Ürün Fiyatı";
            this.ShowUnitPrice.Name = "ShowUnitPrice";
            this.ShowUnitPrice.ReadOnly = true;
            // 
            // ShowUnitsInStock
            // 
            this.ShowUnitsInStock.DataPropertyName = "UnitsInStock";
            this.ShowUnitsInStock.HeaderText = "Stok Sayısı";
            this.ShowUnitsInStock.Name = "ShowUnitsInStock";
            this.ShowUnitsInStock.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(30, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ürün Adı:";
            // 
            // gbxAdd
            // 
            this.gbxAdd.BackColor = System.Drawing.Color.Transparent;
            this.gbxAdd.Controls.Add(this.mtbUnitsInStock);
            this.gbxAdd.Controls.Add(this.mtbUnitPrice);
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.label2);
            this.gbxAdd.Controls.Add(this.cbxCategory);
            this.gbxAdd.Controls.Add(this.label1);
            this.gbxAdd.Controls.Add(this.label7);
            this.gbxAdd.Controls.Add(this.label6);
            this.gbxAdd.Controls.Add(this.tbProductName);
            this.gbxAdd.ForeColor = System.Drawing.Color.Black;
            this.gbxAdd.Location = new System.Drawing.Point(84, 356);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(306, 273);
            this.gbxAdd.TabIndex = 27;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Ekle";
            // 
            // mtbUnitsInStock
            // 
            this.mtbUnitsInStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtbUnitsInStock.Location = new System.Drawing.Point(134, 128);
            this.mtbUnitsInStock.Name = "mtbUnitsInStock";
            this.mtbUnitsInStock.Size = new System.Drawing.Size(131, 24);
            this.mtbUnitsInStock.TabIndex = 3;
            // 
            // mtbUnitPrice
            // 
            this.mtbUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtbUnitPrice.Location = new System.Drawing.Point(134, 98);
            this.mtbUnitPrice.Name = "mtbUnitPrice";
            this.mtbUnitPrice.Size = new System.Drawing.Size(131, 24);
            this.mtbUnitPrice.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(134, 172);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(131, 27);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.ThemeName = "FluentDark";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(30, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Stok Sayısı:";
            // 
            // cbxCategory
            // 
            this.cbxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(134, 66);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(131, 26);
            this.cbxCategory.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(30, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Birim Fiyatı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(30, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Kategori:";
            // 
            // tbProductName
            // 
            this.tbProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbProductName.Location = new System.Drawing.Point(134, 36);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(131, 24);
            this.tbProductName.TabIndex = 0;
            // 
            // gbxUpdateDelete
            // 
            this.gbxUpdateDelete.BackColor = System.Drawing.Color.Transparent;
            this.gbxUpdateDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbxUpdateDelete.Controls.Add(this.mtbUpdateUnitsInStock);
            this.gbxUpdateDelete.Controls.Add(this.mtbUpdateUnitPrice);
            this.gbxUpdateDelete.Controls.Add(this.btnCancel);
            this.gbxUpdateDelete.Controls.Add(this.btnDelete);
            this.gbxUpdateDelete.Controls.Add(this.btnUpdate);
            this.gbxUpdateDelete.Controls.Add(this.label3);
            this.gbxUpdateDelete.Controls.Add(this.cbxUpdateCategory);
            this.gbxUpdateDelete.Controls.Add(this.label4);
            this.gbxUpdateDelete.Controls.Add(this.label5);
            this.gbxUpdateDelete.Controls.Add(this.label8);
            this.gbxUpdateDelete.Controls.Add(this.tbUpdateProductName);
            this.gbxUpdateDelete.Enabled = false;
            this.gbxUpdateDelete.ForeColor = System.Drawing.Color.Black;
            this.gbxUpdateDelete.Location = new System.Drawing.Point(437, 356);
            this.gbxUpdateDelete.Name = "gbxUpdateDelete";
            this.gbxUpdateDelete.Size = new System.Drawing.Size(310, 273);
            this.gbxUpdateDelete.TabIndex = 28;
            this.gbxUpdateDelete.TabStop = false;
            this.gbxUpdateDelete.Text = "Sil / Düzenle";
            // 
            // mtbUpdateUnitsInStock
            // 
            this.mtbUpdateUnitsInStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtbUpdateUnitsInStock.Location = new System.Drawing.Point(127, 128);
            this.mtbUpdateUnitsInStock.Name = "mtbUpdateUnitsInStock";
            this.mtbUpdateUnitsInStock.Size = new System.Drawing.Size(131, 24);
            this.mtbUpdateUnitsInStock.TabIndex = 3;
            // 
            // mtbUpdateUnitPrice
            // 
            this.mtbUpdateUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtbUpdateUnitPrice.Location = new System.Drawing.Point(127, 98);
            this.mtbUpdateUnitPrice.Name = "mtbUpdateUnitPrice";
            this.mtbUpdateUnitPrice.Size = new System.Drawing.Size(131, 24);
            this.mtbUpdateUnitPrice.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(127, 236);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 27);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "İptal";
            this.btnCancel.ThemeName = "FluentDark";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(127, 203);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(131, 27);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Sil";
            this.btnDelete.ThemeName = "FluentDark";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(127, 170);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(131, 27);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.ThemeName = "FluentDark";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(23, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = "Stok Sayısı:";
            // 
            // cbxUpdateCategory
            // 
            this.cbxUpdateCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxUpdateCategory.FormattingEnabled = true;
            this.cbxUpdateCategory.Location = new System.Drawing.Point(127, 66);
            this.cbxUpdateCategory.Name = "cbxUpdateCategory";
            this.cbxUpdateCategory.Size = new System.Drawing.Size(131, 26);
            this.cbxUpdateCategory.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(23, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "Birim Fiyatı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(23, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "Kategori:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(23, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 18);
            this.label8.TabIndex = 24;
            this.label8.Text = "Ürün Adı:";
            // 
            // tbUpdateProductName
            // 
            this.tbUpdateProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbUpdateProductName.Location = new System.Drawing.Point(127, 36);
            this.tbUpdateProductName.Name = "tbUpdateProductName";
            this.tbUpdateProductName.Size = new System.Drawing.Size(131, 24);
            this.tbUpdateProductName.TabIndex = 0;
            // 
            // radTitleBar1
            // 
            this.radTitleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radTitleBar1.Location = new System.Drawing.Point(0, 0);
            this.radTitleBar1.Name = "radTitleBar1";
            this.radTitleBar1.Size = new System.Drawing.Size(850, 23);
            this.radTitleBar1.TabIndex = 31;
            this.radTitleBar1.TabStop = false;
            this.radTitleBar1.ThemeName = "VisualStudio2012Dark";
            // 
            // ProductsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(850, 645);
            this.ControlBox = false;
            this.Controls.Add(this.radTitleBar1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.tbSearchProduct);
            this.Controls.Add(this.dgwProductList);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.gbxUpdateDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductsUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductsUI_FormClosed);
            this.Load += new System.EventHandler(this.ProductsUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProductList)).EndInit();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            this.gbxUpdateDelete.ResumeLayout(false);
            this.gbxUpdateDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbSearchProduct;
        private System.Windows.Forms.DataGridView dgwProductList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.GroupBox gbxUpdateDelete;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxUpdateCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbUpdateProductName;
        private Telerik.WinControls.UI.RadButton btnAdd;
        private Telerik.WinControls.UI.RadButton btnDelete;
        private Telerik.WinControls.UI.RadButton btnUpdate;
        private Telerik.WinControls.UI.RadTitleBar radTitleBar1;
        private Telerik.WinControls.Themes.FluentDarkTheme fluentDarkTheme1;
        private Telerik.WinControls.UI.RadButton btnCancel;
        private System.Windows.Forms.TextBox mtbUnitPrice;
        private System.Windows.Forms.TextBox mtbUnitsInStock;
        private System.Windows.Forms.TextBox mtbUpdateUnitPrice;
        private System.Windows.Forms.TextBox mtbUpdateUnitsInStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShowProductsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShowCategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShowProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShowUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShowUnitsInStock;
    }
}