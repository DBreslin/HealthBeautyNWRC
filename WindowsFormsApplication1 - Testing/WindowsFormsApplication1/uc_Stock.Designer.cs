namespace HairBeautyNWRC
{
    partial class uc_Stock
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_Stock));
            this.tc_StockMain = new System.Windows.Forms.TabControl();
            this.tab_MainStock = new System.Windows.Forms.TabPage();
            this.pnl_Frequent = new System.Windows.Forms.Panel();
            this.lbl_FilterItems = new System.Windows.Forms.Label();
            this.lbl_TopSellers = new System.Windows.Forms.Label();
            this.cmb_StockType = new System.Windows.Forms.ComboBox();
            this.dgv_TopSellers = new System.Windows.Forms.DataGridView();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.lbl_StockTitle = new System.Windows.Forms.Label();
            this.pnl_Reorder = new System.Windows.Forms.Panel();
            this.dgv_LowStockItems = new System.Windows.Forms.DataGridView();
            this.lbl_ItemsLowOnStock = new System.Windows.Forms.Label();
            this.nWRCHairBeautyDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nWRC_HairBeautyDataSet = new HairBeautyNWRC.NWRC_HairBeautyDataSet();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_AddStock = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.tc_StockMain.SuspendLayout();
            this.tab_MainStock.SuspendLayout();
            this.pnl_Frequent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TopSellers)).BeginInit();
            this.pnl_Main.SuspendLayout();
            this.pnl_Reorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LowStockItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWRCHairBeautyDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWRC_HairBeautyDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tc_StockMain
            // 
            this.tc_StockMain.Controls.Add(this.tab_MainStock);
            this.tc_StockMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_StockMain.Location = new System.Drawing.Point(0, 0);
            this.tc_StockMain.Name = "tc_StockMain";
            this.tc_StockMain.SelectedIndex = 0;
            this.tc_StockMain.Size = new System.Drawing.Size(1265, 634);
            this.tc_StockMain.TabIndex = 0;
            // 
            // tab_MainStock
            // 
            this.tab_MainStock.BackColor = System.Drawing.Color.SkyBlue;
            this.tab_MainStock.Controls.Add(this.btn_Refresh);
            this.tab_MainStock.Controls.Add(this.btn_Delete);
            this.tab_MainStock.Controls.Add(this.btn_Search);
            this.tab_MainStock.Controls.Add(this.btn_Edit);
            this.tab_MainStock.Controls.Add(this.btn_AddStock);
            this.tab_MainStock.Controls.Add(this.pnl_Frequent);
            this.tab_MainStock.Controls.Add(this.pnl_Main);
            this.tab_MainStock.Controls.Add(this.pnl_Reorder);
            this.tab_MainStock.Location = new System.Drawing.Point(4, 22);
            this.tab_MainStock.Name = "tab_MainStock";
            this.tab_MainStock.Padding = new System.Windows.Forms.Padding(3);
            this.tab_MainStock.Size = new System.Drawing.Size(1257, 608);
            this.tab_MainStock.TabIndex = 0;
            // 
            // pnl_Frequent
            // 
            this.pnl_Frequent.BackColor = System.Drawing.Color.Cyan;
            this.pnl_Frequent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Frequent.Controls.Add(this.lbl_FilterItems);
            this.pnl_Frequent.Controls.Add(this.lbl_TopSellers);
            this.pnl_Frequent.Controls.Add(this.cmb_StockType);
            this.pnl_Frequent.Controls.Add(this.dgv_TopSellers);
            this.pnl_Frequent.Location = new System.Drawing.Point(6, 252);
            this.pnl_Frequent.Name = "pnl_Frequent";
            this.pnl_Frequent.Size = new System.Drawing.Size(1245, 350);
            this.pnl_Frequent.TabIndex = 11;
            // 
            // lbl_FilterItems
            // 
            this.lbl_FilterItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_FilterItems.AutoSize = true;
            this.lbl_FilterItems.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_FilterItems.Location = new System.Drawing.Point(1038, 38);
            this.lbl_FilterItems.Name = "lbl_FilterItems";
            this.lbl_FilterItems.Size = new System.Drawing.Size(50, 20);
            this.lbl_FilterItems.TabIndex = 6;
            this.lbl_FilterItems.Text = "Filter:";
            // 
            // lbl_TopSellers
            // 
            this.lbl_TopSellers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_TopSellers.AutoSize = true;
            this.lbl_TopSellers.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TopSellers.Location = new System.Drawing.Point(434, 18);
            this.lbl_TopSellers.Name = "lbl_TopSellers";
            this.lbl_TopSellers.Size = new System.Drawing.Size(421, 40);
            this.lbl_TopSellers.TabIndex = 3;
            this.lbl_TopSellers.Text = "Most Frequently Used Items\r\n";
            // 
            // cmb_StockType
            // 
            this.cmb_StockType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_StockType.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmb_StockType.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_StockType.FormattingEnabled = true;
            this.cmb_StockType.Items.AddRange(new object[] {
            "All",
            "Hair",
            "Beauty"});
            this.cmb_StockType.Location = new System.Drawing.Point(1108, 36);
            this.cmb_StockType.Name = "cmb_StockType";
            this.cmb_StockType.Size = new System.Drawing.Size(121, 22);
            this.cmb_StockType.TabIndex = 2;
            this.cmb_StockType.Text = "All";
            this.cmb_StockType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dgv_TopSellers
            // 
            this.dgv_TopSellers.AllowUserToAddRows = false;
            this.dgv_TopSellers.AllowUserToDeleteRows = false;
            this.dgv_TopSellers.AllowUserToResizeColumns = false;
            this.dgv_TopSellers.AllowUserToResizeRows = false;
            this.dgv_TopSellers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv_TopSellers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_TopSellers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_TopSellers.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_TopSellers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_TopSellers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TopSellers.Location = new System.Drawing.Point(11, 61);
            this.dgv_TopSellers.Name = "dgv_TopSellers";
            this.dgv_TopSellers.Size = new System.Drawing.Size(1218, 275);
            this.dgv_TopSellers.TabIndex = 4;
            // 
            // pnl_Main
            // 
            this.pnl_Main.AutoScroll = true;
            this.pnl_Main.BackColor = System.Drawing.Color.HotPink;
            this.pnl_Main.Controls.Add(this.lbl_StockTitle);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Main.Location = new System.Drawing.Point(3, 3);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(1251, 84);
            this.pnl_Main.TabIndex = 2;
            // 
            // lbl_StockTitle
            // 
            this.lbl_StockTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_StockTitle.AutoSize = true;
            this.lbl_StockTitle.Font = new System.Drawing.Font("Adobe Heiti Std R", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StockTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_StockTitle.Location = new System.Drawing.Point(473, 20);
            this.lbl_StockTitle.Name = "lbl_StockTitle";
            this.lbl_StockTitle.Size = new System.Drawing.Size(346, 46);
            this.lbl_StockTitle.TabIndex = 0;
            this.lbl_StockTitle.Text = "Stock Management";
            this.lbl_StockTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_Reorder
            // 
            this.pnl_Reorder.BackColor = System.Drawing.Color.Cyan;
            this.pnl_Reorder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Reorder.Controls.Add(this.dgv_LowStockItems);
            this.pnl_Reorder.Controls.Add(this.lbl_ItemsLowOnStock);
            this.pnl_Reorder.Location = new System.Drawing.Point(9, 92);
            this.pnl_Reorder.Name = "pnl_Reorder";
            this.pnl_Reorder.Size = new System.Drawing.Size(1245, 350);
            this.pnl_Reorder.TabIndex = 12;
            // 
            // dgv_LowStockItems
            // 
            this.dgv_LowStockItems.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_LowStockItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LowStockItems.Location = new System.Drawing.Point(12, 48);
            this.dgv_LowStockItems.Name = "dgv_LowStockItems";
            this.dgv_LowStockItems.Size = new System.Drawing.Size(844, 295);
            this.dgv_LowStockItems.TabIndex = 1;
            // 
            // lbl_ItemsLowOnStock
            // 
            this.lbl_ItemsLowOnStock.AutoSize = true;
            this.lbl_ItemsLowOnStock.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ItemsLowOnStock.Location = new System.Drawing.Point(288, 13);
            this.lbl_ItemsLowOnStock.Name = "lbl_ItemsLowOnStock";
            this.lbl_ItemsLowOnStock.Size = new System.Drawing.Size(245, 24);
            this.lbl_ItemsLowOnStock.TabIndex = 0;
            this.lbl_ItemsLowOnStock.Text = "Items Getting Low On Stock";
            this.lbl_ItemsLowOnStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nWRCHairBeautyDataSetBindingSource
            // 
            this.nWRCHairBeautyDataSetBindingSource.DataSource = this.nWRC_HairBeautyDataSet;
            this.nWRCHairBeautyDataSetBindingSource.Position = 0;
            // 
            // nWRC_HairBeautyDataSet
            // 
            this.nWRC_HairBeautyDataSet.DataSetName = "NWRC_HairBeautyDataSet";
            this.nWRC_HairBeautyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Delete.BackgroundImage")));
            this.btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Delete.Location = new System.Drawing.Point(1193, 92);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(58, 58);
            this.btn_Delete.TabIndex = 9;
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Search.BackgroundImage")));
            this.btn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Search.Location = new System.Drawing.Point(1130, 92);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(58, 58);
            this.btn_Search.TabIndex = 10;
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Edit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Edit.BackgroundImage")));
            this.btn_Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Edit.Location = new System.Drawing.Point(1067, 92);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(58, 58);
            this.btn_Edit.TabIndex = 8;
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_AddStock
            // 
            this.btn_AddStock.AccessibleDescription = "Add New Item";
            this.btn_AddStock.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_AddStock.BackgroundImage = global::HairBeautyNWRC.Properties.Resources.Add_48x48;
            this.btn_AddStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_AddStock.Location = new System.Drawing.Point(1004, 92);
            this.btn_AddStock.Name = "btn_AddStock";
            this.btn_AddStock.Size = new System.Drawing.Size(58, 58);
            this.btn_AddStock.TabIndex = 7;
            this.btn_AddStock.UseVisualStyleBackColor = false;
            this.btn_AddStock.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.AccessibleDescription = "Add New Item";
            this.btn_Refresh.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Refresh.BackgroundImage = global::HairBeautyNWRC.Properties.Resources.Refresh_48x48;
            this.btn_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Refresh.Location = new System.Drawing.Point(937, 92);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(58, 58);
            this.btn_Refresh.TabIndex = 8;
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Click);
            // 
            // uc_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tc_StockMain);
            this.Name = "uc_Stock";
            this.Size = new System.Drawing.Size(1265, 634);
            this.Load += new System.EventHandler(this.uc_Stock_Load);
            this.tc_StockMain.ResumeLayout(false);
            this.tab_MainStock.ResumeLayout(false);
            this.pnl_Frequent.ResumeLayout(false);
            this.pnl_Frequent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TopSellers)).EndInit();
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            this.pnl_Reorder.ResumeLayout(false);
            this.pnl_Reorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LowStockItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWRCHairBeautyDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWRC_HairBeautyDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc_StockMain;
        private System.Windows.Forms.TabPage tab_MainStock;
        private System.Windows.Forms.BindingSource nWRCHairBeautyDataSetBindingSource;
        private NWRC_HairBeautyDataSet nWRC_HairBeautyDataSet;
        private System.Windows.Forms.Button btn_AddStock;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl_TopSellers;
        private System.Windows.Forms.Label lbl_FilterItems;
        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.ComboBox cmb_StockType;
        private System.Windows.Forms.DataGridView dgv_TopSellers;
        private System.Windows.Forms.Panel pnl_Frequent;
        private System.Windows.Forms.Label lbl_StockTitle;
        private System.Windows.Forms.Panel pnl_Reorder;
        private System.Windows.Forms.Label lbl_ItemsLowOnStock;
        private System.Windows.Forms.DataGridView dgv_LowStockItems;
        private System.Windows.Forms.Button btn_Refresh;
    }
}
