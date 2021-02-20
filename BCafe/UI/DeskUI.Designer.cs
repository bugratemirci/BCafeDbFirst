
namespace BCafe.UserUI
{
    partial class DeskUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeskUI));
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.dgwDeskList = new System.Windows.Forms.DataGridView();
            this.ShowDeskID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShowDeskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new Telerik.WinControls.UI.RadButton();
            this.gbxDelete = new System.Windows.Forms.GroupBox();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.tbDeskId = new Telerik.WinControls.UI.RadTextBox();
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.tbDeskCount = new Telerik.WinControls.UI.RadTextBox();
            this.office2010SilverTheme1 = new Telerik.WinControls.Themes.Office2010SilverTheme();
            this.radTitleBar1 = new Telerik.WinControls.UI.RadTitleBar();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.fluentDarkTheme1 = new Telerik.WinControls.Themes.FluentDarkTheme();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDeskList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            this.gbxDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDeskId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            this.gbxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDeskCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel1.Location = new System.Drawing.Point(38, 187);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(79, 21);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Masa Sayısı:";
            this.radLabel1.ThemeName = "Office2010Silver";
            // 
            // dgwDeskList
            // 
            this.dgwDeskList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwDeskList.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dgwDeskList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDeskList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ShowDeskID,
            this.ShowDeskName});
            this.dgwDeskList.Location = new System.Drawing.Point(6, 19);
            this.dgwDeskList.Name = "dgwDeskList";
            this.dgwDeskList.ReadOnly = true;
            this.dgwDeskList.RowHeadersVisible = false;
            this.dgwDeskList.Size = new System.Drawing.Size(228, 150);
            this.dgwDeskList.TabIndex = 2;
            this.dgwDeskList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwDeskList_CellClick);
            // 
            // ShowDeskID
            // 
            this.ShowDeskID.DataPropertyName = "Id";
            this.ShowDeskID.HeaderText = "Masa ID";
            this.ShowDeskID.Name = "ShowDeskID";
            this.ShowDeskID.ReadOnly = true;
            // 
            // ShowDeskName
            // 
            this.ShowDeskName.DataPropertyName = "DeskName";
            this.ShowDeskName.HeaderText = "Masa Adı";
            this.ShowDeskName.Name = "ShowDeskName";
            this.ShowDeskName.ReadOnly = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAdd.Location = new System.Drawing.Point(38, 226);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(151, 24);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.ThemeName = "FluentDark";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbxDelete
            // 
            this.gbxDelete.Controls.Add(this.btnCancel);
            this.gbxDelete.Controls.Add(this.radLabel3);
            this.gbxDelete.Controls.Add(this.tbDeskId);
            this.gbxDelete.Controls.Add(this.btnDelete);
            this.gbxDelete.Location = new System.Drawing.Point(12, 329);
            this.gbxDelete.Name = "gbxDelete";
            this.gbxDelete.Size = new System.Drawing.Size(240, 156);
            this.gbxDelete.TabIndex = 6;
            this.gbxDelete.TabStop = false;
            this.gbxDelete.Text = "Sil / Güncelle";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.Location = new System.Drawing.Point(38, 104);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(151, 24);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "İptal";
            this.btnCancel.ThemeName = "FluentDark";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel3.Location = new System.Drawing.Point(38, 37);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(58, 21);
            this.radLabel3.TabIndex = 2;
            this.radLabel3.Text = "Masa Id:";
            this.radLabel3.ThemeName = "Office2010Silver";
            // 
            // tbDeskId
            // 
            this.tbDeskId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbDeskId.Location = new System.Drawing.Point(110, 36);
            this.tbDeskId.Name = "tbDeskId";
            this.tbDeskId.ReadOnly = true;
            this.tbDeskId.Size = new System.Drawing.Size(79, 23);
            this.tbDeskId.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDelete.Location = new System.Drawing.Point(38, 74);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(151, 24);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Sil";
            this.btnDelete.ThemeName = "FluentDark";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.tbDeskCount);
            this.gbxAdd.Controls.Add(this.radLabel1);
            this.gbxAdd.Controls.Add(this.dgwDeskList);
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Location = new System.Drawing.Point(12, 44);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(240, 269);
            this.gbxAdd.TabIndex = 5;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Ekle";
            // 
            // tbDeskCount
            // 
            this.tbDeskCount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbDeskCount.Location = new System.Drawing.Point(123, 187);
            this.tbDeskCount.Name = "tbDeskCount";
            this.tbDeskCount.Size = new System.Drawing.Size(66, 23);
            this.tbDeskCount.TabIndex = 0;
            this.tbDeskCount.ThemeName = "Office2010Silver";
            // 
            // radTitleBar1
            // 
            this.radTitleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radTitleBar1.Location = new System.Drawing.Point(0, 0);
            this.radTitleBar1.Name = "radTitleBar1";
            this.radTitleBar1.Size = new System.Drawing.Size(265, 23);
            this.radTitleBar1.TabIndex = 7;
            this.radTitleBar1.TabStop = false;
            this.radTitleBar1.ThemeName = "VisualStudio2012Dark";
            // 
            // DeskUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(265, 496);
            this.ControlBox = false;
            this.Controls.Add(this.radTitleBar1);
            this.Controls.Add(this.gbxDelete);
            this.Controls.Add(this.gbxAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeskUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DeskUI_FormClosed);
            this.Load += new System.EventHandler(this.DeskUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDeskList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            this.gbxDelete.ResumeLayout(false);
            this.gbxDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDeskId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDeskCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private System.Windows.Forms.DataGridView dgwDeskList;
        private Telerik.WinControls.UI.RadButton btnAdd;
        private System.Windows.Forms.GroupBox gbxDelete;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBox tbDeskId;
        private Telerik.WinControls.UI.RadButton btnDelete;
        private System.Windows.Forms.GroupBox gbxAdd;
        private Telerik.WinControls.UI.RadTextBox tbDeskCount;
        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.Themes.Office2010SilverTheme office2010SilverTheme1;
        private Telerik.WinControls.UI.RadTitleBar radTitleBar1;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private Telerik.WinControls.Themes.FluentDarkTheme fluentDarkTheme1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShowDeskID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShowDeskName;
    }
}