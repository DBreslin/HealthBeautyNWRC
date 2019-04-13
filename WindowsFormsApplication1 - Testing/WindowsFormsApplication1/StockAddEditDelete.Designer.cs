namespace HairBeautyNWRC
{
    partial class frm_StockAddEditDelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_StockAddEditDelete));
            this.lbl_StockTitle = new System.Windows.Forms.Label();
            this.lbl_StockNo = new System.Windows.Forms.Label();
            this.lbl_StockName = new System.Windows.Forms.Label();
            this.lbl_StockSpecs = new System.Windows.Forms.Label();
            this.lbl_StockSize = new System.Windows.Forms.Label();
            this.lbl_StockQty = new System.Windows.Forms.Label();
            this.lbl_StockCost = new System.Windows.Forms.Label();
            this.lbl_StockType = new System.Windows.Forms.Label();
            this.lbl_QtySold = new System.Windows.Forms.Label();
            this.lbl_StockPrice = new System.Windows.Forms.Label();
            this.txt_StockNo = new System.Windows.Forms.TextBox();
            this.txt_NoSold = new System.Windows.Forms.TextBox();
            this.txt_StockPrice = new System.Windows.Forms.TextBox();
            this.txt_StockType = new System.Windows.Forms.TextBox();
            this.txt_StockCost = new System.Windows.Forms.TextBox();
            this.txt_StockQty = new System.Windows.Forms.TextBox();
            this.txt_StockSize = new System.Windows.Forms.TextBox();
            this.txt_StockSpecs = new System.Windows.Forms.TextBox();
            this.txt_StockName = new System.Windows.Forms.TextBox();
            this.dgv_StockControl = new System.Windows.Forms.DataGridView();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_EditFoundRecord = new System.Windows.Forms.Button();
            this.btn_SaveChanges = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_AddItem = new System.Windows.Forms.Button();
            this.lbl_UseageType = new System.Windows.Forms.Label();
            this.cmb_UseageType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StockControl)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_StockTitle
            // 
            this.lbl_StockTitle.AutoSize = true;
            this.lbl_StockTitle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_StockTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StockTitle.Location = new System.Drawing.Point(64, 16);
            this.lbl_StockTitle.Name = "lbl_StockTitle";
            this.lbl_StockTitle.Size = new System.Drawing.Size(313, 20);
            this.lbl_StockTitle.TabIndex = 0;
            this.lbl_StockTitle.Text = "NWRC Hair and Beauty Stock Control";
            // 
            // lbl_StockNo
            // 
            this.lbl_StockNo.AutoSize = true;
            this.lbl_StockNo.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StockNo.Location = new System.Drawing.Point(28, 67);
            this.lbl_StockNo.Name = "lbl_StockNo";
            this.lbl_StockNo.Size = new System.Drawing.Size(93, 15);
            this.lbl_StockNo.TabIndex = 1;
            this.lbl_StockNo.Text = "Stock Number:";
            // 
            // lbl_StockName
            // 
            this.lbl_StockName.AutoSize = true;
            this.lbl_StockName.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StockName.Location = new System.Drawing.Point(28, 98);
            this.lbl_StockName.Name = "lbl_StockName";
            this.lbl_StockName.Size = new System.Drawing.Size(81, 15);
            this.lbl_StockName.TabIndex = 2;
            this.lbl_StockName.Text = "Stock Name:";
            // 
            // lbl_StockSpecs
            // 
            this.lbl_StockSpecs.AutoSize = true;
            this.lbl_StockSpecs.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StockSpecs.Location = new System.Drawing.Point(28, 129);
            this.lbl_StockSpecs.Name = "lbl_StockSpecs";
            this.lbl_StockSpecs.Size = new System.Drawing.Size(82, 15);
            this.lbl_StockSpecs.TabIndex = 3;
            this.lbl_StockSpecs.Text = "Stock Specs:";
            // 
            // lbl_StockSize
            // 
            this.lbl_StockSize.AutoSize = true;
            this.lbl_StockSize.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StockSize.Location = new System.Drawing.Point(28, 160);
            this.lbl_StockSize.Name = "lbl_StockSize";
            this.lbl_StockSize.Size = new System.Drawing.Size(72, 15);
            this.lbl_StockSize.TabIndex = 4;
            this.lbl_StockSize.Text = "Stock Size:";
            // 
            // lbl_StockQty
            // 
            this.lbl_StockQty.AutoSize = true;
            this.lbl_StockQty.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StockQty.Location = new System.Drawing.Point(28, 191);
            this.lbl_StockQty.Name = "lbl_StockQty";
            this.lbl_StockQty.Size = new System.Drawing.Size(68, 15);
            this.lbl_StockQty.TabIndex = 5;
            this.lbl_StockQty.Text = "Stock Qty:";
            // 
            // lbl_StockCost
            // 
            this.lbl_StockCost.AutoSize = true;
            this.lbl_StockCost.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StockCost.Location = new System.Drawing.Point(28, 222);
            this.lbl_StockCost.Name = "lbl_StockCost";
            this.lbl_StockCost.Size = new System.Drawing.Size(74, 15);
            this.lbl_StockCost.TabIndex = 6;
            this.lbl_StockCost.Text = "Stock Cost:";
            // 
            // lbl_StockType
            // 
            this.lbl_StockType.AutoSize = true;
            this.lbl_StockType.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StockType.Location = new System.Drawing.Point(28, 253);
            this.lbl_StockType.Name = "lbl_StockType";
            this.lbl_StockType.Size = new System.Drawing.Size(76, 15);
            this.lbl_StockType.TabIndex = 7;
            this.lbl_StockType.Text = "Stock Type:";
            // 
            // lbl_QtySold
            // 
            this.lbl_QtySold.AutoSize = true;
            this.lbl_QtySold.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QtySold.Location = new System.Drawing.Point(28, 346);
            this.lbl_QtySold.Name = "lbl_QtySold";
            this.lbl_QtySold.Size = new System.Drawing.Size(119, 15);
            this.lbl_QtySold.TabIndex = 8;
            this.lbl_QtySold.Text = "Number Sold/Used:";
            // 
            // lbl_StockPrice
            // 
            this.lbl_StockPrice.AutoSize = true;
            this.lbl_StockPrice.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StockPrice.Location = new System.Drawing.Point(28, 284);
            this.lbl_StockPrice.Name = "lbl_StockPrice";
            this.lbl_StockPrice.Size = new System.Drawing.Size(76, 15);
            this.lbl_StockPrice.TabIndex = 10;
            this.lbl_StockPrice.Text = "Stock Price:";
            // 
            // txt_StockNo
            // 
            this.txt_StockNo.Enabled = false;
            this.txt_StockNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StockNo.ForeColor = System.Drawing.Color.Yellow;
            this.txt_StockNo.Location = new System.Drawing.Point(214, 69);
            this.txt_StockNo.Name = "txt_StockNo";
            this.txt_StockNo.Size = new System.Drawing.Size(198, 21);
            this.txt_StockNo.TabIndex = 11;
            this.txt_StockNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_NoSold
            // 
            this.txt_NoSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NoSold.ForeColor = System.Drawing.Color.Yellow;
            this.txt_NoSold.Location = new System.Drawing.Point(214, 339);
            this.txt_NoSold.Name = "txt_NoSold";
            this.txt_NoSold.Size = new System.Drawing.Size(198, 21);
            this.txt_NoSold.TabIndex = 1;
            this.txt_NoSold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_StockPrice
            // 
            this.txt_StockPrice.Location = new System.Drawing.Point(214, 279);
            this.txt_StockPrice.Name = "txt_StockPrice";
            this.txt_StockPrice.Size = new System.Drawing.Size(198, 20);
            this.txt_StockPrice.TabIndex = 18;
            // 
            // txt_StockType
            // 
            this.txt_StockType.Location = new System.Drawing.Point(214, 249);
            this.txt_StockType.Name = "txt_StockType";
            this.txt_StockType.Size = new System.Drawing.Size(198, 20);
            this.txt_StockType.TabIndex = 17;
            // 
            // txt_StockCost
            // 
            this.txt_StockCost.Location = new System.Drawing.Point(214, 219);
            this.txt_StockCost.Name = "txt_StockCost";
            this.txt_StockCost.Size = new System.Drawing.Size(198, 20);
            this.txt_StockCost.TabIndex = 16;
            // 
            // txt_StockQty
            // 
            this.txt_StockQty.Location = new System.Drawing.Point(214, 189);
            this.txt_StockQty.Name = "txt_StockQty";
            this.txt_StockQty.Size = new System.Drawing.Size(198, 20);
            this.txt_StockQty.TabIndex = 15;
            // 
            // txt_StockSize
            // 
            this.txt_StockSize.Location = new System.Drawing.Point(214, 159);
            this.txt_StockSize.Name = "txt_StockSize";
            this.txt_StockSize.Size = new System.Drawing.Size(198, 20);
            this.txt_StockSize.TabIndex = 14;
            // 
            // txt_StockSpecs
            // 
            this.txt_StockSpecs.Location = new System.Drawing.Point(214, 129);
            this.txt_StockSpecs.Name = "txt_StockSpecs";
            this.txt_StockSpecs.Size = new System.Drawing.Size(198, 20);
            this.txt_StockSpecs.TabIndex = 13;
            // 
            // txt_StockName
            // 
            this.txt_StockName.Location = new System.Drawing.Point(214, 99);
            this.txt_StockName.Name = "txt_StockName";
            this.txt_StockName.Size = new System.Drawing.Size(198, 20);
            this.txt_StockName.TabIndex = 12;
            // 
            // dgv_StockControl
            // 
            this.dgv_StockControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_StockControl.Location = new System.Drawing.Point(489, 67);
            this.dgv_StockControl.Name = "dgv_StockControl";
            this.dgv_StockControl.Size = new System.Drawing.Size(779, 292);
            this.dgv_StockControl.TabIndex = 26;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.AccessibleDescription = "";
            this.btn_Cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cancel.BackgroundImage")));
            this.btn_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(214, 379);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(51, 49);
            this.btn_Cancel.TabIndex = 19;
            this.btn_Cancel.UseVisualStyleBackColor = false;
            // 
            // btn_EditFoundRecord
            // 
            this.btn_EditFoundRecord.BackgroundImage = global::HairBeautyNWRC.Properties.Resources.Edit_48x48;
            this.btn_EditFoundRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EditFoundRecord.Location = new System.Drawing.Point(144, 379);
            this.btn_EditFoundRecord.Name = "btn_EditFoundRecord";
            this.btn_EditFoundRecord.Size = new System.Drawing.Size(51, 49);
            this.btn_EditFoundRecord.TabIndex = 28;
            this.btn_EditFoundRecord.UseVisualStyleBackColor = true;
            this.btn_EditFoundRecord.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_SaveChanges
            // 
            this.btn_SaveChanges.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_SaveChanges.BackgroundImage")));
            this.btn_SaveChanges.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SaveChanges.Location = new System.Drawing.Point(144, 379);
            this.btn_SaveChanges.Name = "btn_SaveChanges";
            this.btn_SaveChanges.Size = new System.Drawing.Size(51, 49);
            this.btn_SaveChanges.TabIndex = 27;
            this.btn_SaveChanges.UseVisualStyleBackColor = true;
            this.btn_SaveChanges.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Delete.BackgroundImage")));
            this.btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Delete.Location = new System.Drawing.Point(144, 379);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(51, 49);
            this.btn_Delete.TabIndex = 25;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Search.BackgroundImage")));
            this.btn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Search.Location = new System.Drawing.Point(144, 379);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(51, 49);
            this.btn_Search.TabIndex = 24;
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_AddItem
            // 
            this.btn_AddItem.AccessibleDescription = "";
            this.btn_AddItem.BackColor = System.Drawing.Color.Transparent;
            this.btn_AddItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AddItem.BackgroundImage")));
            this.btn_AddItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_AddItem.Location = new System.Drawing.Point(144, 379);
            this.btn_AddItem.Name = "btn_AddItem";
            this.btn_AddItem.Size = new System.Drawing.Size(51, 49);
            this.btn_AddItem.TabIndex = 22;
            this.btn_AddItem.UseVisualStyleBackColor = false;
            this.btn_AddItem.Click += new System.EventHandler(this.btn_Click);
            // 
            // lbl_UseageType
            // 
            this.lbl_UseageType.AutoSize = true;
            this.lbl_UseageType.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UseageType.Location = new System.Drawing.Point(28, 315);
            this.lbl_UseageType.Name = "lbl_UseageType";
            this.lbl_UseageType.Size = new System.Drawing.Size(54, 15);
            this.lbl_UseageType.TabIndex = 29;
            this.lbl_UseageType.Text = "Useage:";
            // 
            // cmb_UseageType
            // 
            this.cmb_UseageType.FormattingEnabled = true;
            this.cmb_UseageType.Items.AddRange(new object[] {
            "Retail",
            "Internal"});
            this.cmb_UseageType.Location = new System.Drawing.Point(214, 308);
            this.cmb_UseageType.Name = "cmb_UseageType";
            this.cmb_UseageType.Size = new System.Drawing.Size(198, 21);
            this.cmb_UseageType.TabIndex = 30;
            // 
            // frm_StockAddEditDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(1305, 456);
            this.Controls.Add(this.cmb_UseageType);
            this.Controls.Add(this.lbl_UseageType);
            this.Controls.Add(this.btn_EditFoundRecord);
            this.Controls.Add(this.btn_SaveChanges);
            this.Controls.Add(this.dgv_StockControl);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_AddItem);
            this.Controls.Add(this.txt_StockName);
            this.Controls.Add(this.txt_StockSpecs);
            this.Controls.Add(this.txt_StockSize);
            this.Controls.Add(this.txt_StockQty);
            this.Controls.Add(this.txt_StockCost);
            this.Controls.Add(this.txt_StockType);
            this.Controls.Add(this.txt_StockPrice);
            this.Controls.Add(this.txt_NoSold);
            this.Controls.Add(this.txt_StockNo);
            this.Controls.Add(this.lbl_StockPrice);
            this.Controls.Add(this.lbl_QtySold);
            this.Controls.Add(this.lbl_StockType);
            this.Controls.Add(this.lbl_StockCost);
            this.Controls.Add(this.lbl_StockQty);
            this.Controls.Add(this.lbl_StockSize);
            this.Controls.Add(this.lbl_StockSpecs);
            this.Controls.Add(this.lbl_StockName);
            this.Controls.Add(this.lbl_StockNo);
            this.Controls.Add(this.lbl_StockTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_StockAddEditDelete";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Control";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StockControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_StockTitle;
        private System.Windows.Forms.Label lbl_StockNo;
        private System.Windows.Forms.Label lbl_StockName;
        private System.Windows.Forms.Label lbl_StockSpecs;
        private System.Windows.Forms.Label lbl_StockSize;
        private System.Windows.Forms.Label lbl_StockQty;
        private System.Windows.Forms.Label lbl_StockCost;
        private System.Windows.Forms.Label lbl_StockType;
        private System.Windows.Forms.Label lbl_QtySold;
        private System.Windows.Forms.Label lbl_StockPrice;
        private System.Windows.Forms.TextBox txt_StockNo;
        private System.Windows.Forms.TextBox txt_NoSold;
        private System.Windows.Forms.TextBox txt_StockPrice;
        private System.Windows.Forms.TextBox txt_StockType;
        private System.Windows.Forms.TextBox txt_StockCost;
        private System.Windows.Forms.TextBox txt_StockQty;
        private System.Windows.Forms.TextBox txt_StockSize;
        private System.Windows.Forms.TextBox txt_StockSpecs;
        private System.Windows.Forms.TextBox txt_StockName;
        private System.Windows.Forms.Button btn_AddItem;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridView dgv_StockControl;
        private System.Windows.Forms.Button btn_SaveChanges;
        private System.Windows.Forms.Button btn_EditFoundRecord;
        private System.Windows.Forms.Label lbl_UseageType;
        private System.Windows.Forms.ComboBox cmb_UseageType;
    }
}