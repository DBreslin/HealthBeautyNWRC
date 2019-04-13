using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HairBeautyNWRC
{
    public partial class uc_Stock : UserControl
    {
        SqlDataAdapter daStock, daTopSellers, daLowStockItems;
        DataSet dsNWRC_HairBeauty = new DataSet(), dsTopSellers = new DataSet(), dsLowStockItems = new DataSet();
        SqlCommandBuilder cmdBStock, cmdBTopSellers, cmdBLowStockItems;
        DataRow drLowStockItems;
        String connStr, sqlStock, sqlLowStockItems, sqlTopSellers;
        
        private System.Windows.Forms.ErrorProvider errP;

        public uc_Stock()
        {
            InitializeComponent();
        }

        private void uc_Stock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nWRC_HairBeautyDataSet.Client' table. You can move, or remove it, as needed.
            //  this.clientTableAdapter.Fill(this.nWRC_HairBeautyDataSet.Client);
            pnl_Frequent.Width += 400;
            pnl_Frequent.Height += 35;
            pnl_Frequent.Location = new Point(pnl_Main.Left + 10, pnl_Main.Top + 460);
            pnl_Reorder.Width -= 370;
            pnl_Reorder.Height += 10;
            pnl_Reorder.Location = new Point(pnl_Main.Left + 10, pnl_Main.Top + 90);btn_Refresh.Location = 
            btn_Refresh.Location = new Point(btn_Refresh.Left - 40, btn_Refresh.Top + 10);
            btn_AddStock.Location = new Point(btn_AddStock.Left + 410, btn_AddStock.Top + 10);
            btn_Delete.Location = new Point(btn_Delete.Left + 410, btn_Delete.Top + 10);
            btn_Edit.Location = new Point(btn_Edit.Left + 410, btn_Edit.Top + 10);
            btn_Search.Location = new Point(btn_Search.Left + 410, btn_Search.Top + 10);

            dgv_TopSellers.Width += 400;

            errP = new ErrorProvider();

            //connStr = @"Data Source = .\SQLEXPRESS; Initial Catalog = NWRC_HairBeauty; Integrated Security = true";
            connStr = @"Data Source = .; Initial Catalog = NWRC_HairBeauty; Integrated Security = true";
            
            cmb_StockType.SelectedIndex = 0;

            sqlStock = @"SELECT * from Stock";
            daStock = new SqlDataAdapter(sqlStock, connStr);
            cmdBStock = new SqlCommandBuilder(daStock);
            daStock.FillSchema(dsNWRC_HairBeauty, SchemaType.Source, "Stock");
            daStock.Fill(dsNWRC_HairBeauty, "Stock");

            //Populatuing the frequently used items
            dsTopSellers.Tables.Add(dsNWRC_HairBeauty.Tables["Stock"].Copy());
            dsTopSellers.Tables["Stock"].Clear();
            sqlTopSellers = @"SELECT TOP 10 * FROM Stock
                                ORDER BY QtySold DESC";
            daTopSellers = new SqlDataAdapter(sqlTopSellers, connStr);
            cmdBTopSellers = new SqlCommandBuilder(daTopSellers);
            daTopSellers.FillSchema(dsTopSellers, SchemaType.Source, "Stock");
            daTopSellers.Fill(dsTopSellers, "Stock");
            dgv_TopSellers.DataSource = dsTopSellers.Tables["Stock"];
            //// Resize the DatagridView columns to fit the newly loaded content
            dgv_TopSellers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            // Set Font Size 
            dgv_TopSellers.Font = new Font("Times", 10);
            //Fill Columns to panel view
            dgv_TopSellers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            //populating the low stock items dgv
            //Populatuing the frequently used items
            dsLowStockItems.Tables.Add(dsNWRC_HairBeauty.Tables["Stock"].Copy());
            dsLowStockItems.Tables["Stock"].Clear();
            sqlLowStockItems = @"SELECT * FROM Stock
                                WHERE StockQty < 10
                                ORDER BY StockQty ASC";
            daLowStockItems = new SqlDataAdapter(sqlLowStockItems, connStr);
            cmdBLowStockItems = new SqlCommandBuilder(daLowStockItems);
            daLowStockItems.FillSchema(dsLowStockItems, SchemaType.Source, "Stock");
            daLowStockItems.Fill(dsLowStockItems, "Stock");
            dgv_LowStockItems.DataSource = dsLowStockItems.Tables["Stock"];
            //// Resize the DatagridView columns to fit the newly loaded content
            dgv_LowStockItems.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            // Set Font Size 
            dgv_LowStockItems.Font = new Font("Times", 10);
            //Fill Columns to panel view
            dgv_LowStockItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        /// <summary>
        /// Deals with updating the data in the main DGV based on the combo box value
        /// </summary>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dsNWRC_HairBeauty.Tables["Stock"].Clear();

            if (cmb_StockType.SelectedIndex == 0)
            {
                //Populatuing the frequently used items
                dsTopSellers.Tables["Stock"].Clear();
                sqlTopSellers = @"SELECT TOP 10 * FROM Stock
                                ORDER BY QtySold DESC";
                daTopSellers = new SqlDataAdapter(sqlTopSellers, connStr);
                cmdBTopSellers = new SqlCommandBuilder(daTopSellers);
                daTopSellers.FillSchema(dsTopSellers, SchemaType.Source, "Stock");
                daTopSellers.Fill(dsTopSellers, "Stock");
            }
            else if (cmb_StockType.SelectedIndex == 1)
            { //Populatuing the frequently used items
                dsTopSellers.Tables["Stock"].Clear();
                sqlTopSellers = @"SELECT TOP 10 * FROM Stock
                                WHERE StockType = 'Hair'
                                ORDER BY QtySold DESC";
                daTopSellers = new SqlDataAdapter(sqlTopSellers, connStr);
                cmdBTopSellers = new SqlCommandBuilder(daTopSellers);
                daTopSellers.FillSchema(dsTopSellers, SchemaType.Source, "Stock");
                daTopSellers.Fill(dsTopSellers, "Stock");
            }
            else if (cmb_StockType.SelectedIndex == 2)
            {
                //Populatuing the frequently used items
                dsTopSellers.Tables["Stock"].Clear();
                sqlTopSellers = @"SELECT TOP 10 * FROM Stock
                                WHERE StockType = 'Beauty'
                                ORDER BY QtySold DESC";
                daTopSellers = new SqlDataAdapter(sqlTopSellers, connStr);
                cmdBTopSellers = new SqlCommandBuilder(daTopSellers);
                daTopSellers.FillSchema(dsTopSellers, SchemaType.Source, "Stock");
                daTopSellers.Fill(dsTopSellers, "Stock");
            }
            
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (sender == btn_AddStock)
            {
                frm_StockAddEditDelete frm = new frm_StockAddEditDelete("Add");
                frm.ShowDialog();
            }
            else if(sender == btn_Edit)
            {
                frm_StockAddEditDelete frm = new frm_StockAddEditDelete("Edit");
                frm.ShowDialog();
            }
            else if(sender == btn_Delete)
            {
                frm_StockAddEditDelete frm = new frm_StockAddEditDelete("Delete");
                frm.ShowDialog();
            }
            else if (sender == btn_Refresh)
            {
                //Populatuing the frequently used items
                dsTopSellers.Tables["Stock"].Clear();
                sqlTopSellers = @"SELECT TOP 10 * FROM Stock
                                ORDER BY QtySold DESC";
                daTopSellers = new SqlDataAdapter(sqlTopSellers, connStr);
                cmdBTopSellers = new SqlCommandBuilder(daTopSellers);
                daTopSellers.FillSchema(dsTopSellers, SchemaType.Source, "Stock");
                daTopSellers.Fill(dsTopSellers, "Stock");
                dgv_TopSellers.DataSource = dsTopSellers.Tables["Stock"];
                //// Resize the DatagridView columns to fit the newly loaded content
                dgv_TopSellers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                // Set Font Size 
                dgv_TopSellers.Font = new Font("Times", 10);
                //Fill Columns to panel view
                dgv_TopSellers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


                //populating the low stock items dgv
                //Populatuing the frequently used items
                dsLowStockItems.Tables["Stock"].Clear();
                sqlLowStockItems = @"SELECT * FROM Stock
                                WHERE StockQty < 10
                                ORDER BY StockQty ASC";
                daLowStockItems = new SqlDataAdapter(sqlLowStockItems, connStr);
                cmdBLowStockItems = new SqlCommandBuilder(daLowStockItems);
                daLowStockItems.FillSchema(dsLowStockItems, SchemaType.Source, "Stock");
                daLowStockItems.Fill(dsLowStockItems, "Stock");
                dgv_LowStockItems.DataSource = dsLowStockItems.Tables["Stock"];
                //// Resize the DatagridView columns to fit the newly loaded content
                dgv_LowStockItems.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                // Set Font Size 
                dgv_LowStockItems.Font = new Font("Times", 10);
                //Fill Columns to panel view
                dgv_LowStockItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
    }
}
