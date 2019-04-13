using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HairBeautyNWRC
{
    public partial class frm_StockAddEditDelete : Form
    {
        SqlDataAdapter daStock;
        DataSet dsNWRC_HairBeauty = new DataSet(), dsRecent10Items = new DataSet();
        SqlCommandBuilder cmdBStock;
        DataRow drStock;
        String connStr, sqlStock, btnEditorDelete;

        public frm_StockAddEditDelete()
        {
            InitializeComponent();
        }

        public frm_StockAddEditDelete(string sender)
        {
            InitializeComponent();

            connStr = @"Data Source = .; Initial Catalog = NWRC_HairBeauty; Integrated Security = true";

            sqlStock = @"SELECT * from Stock";
            daStock = new SqlDataAdapter(sqlStock, connStr);
            cmdBStock = new SqlCommandBuilder(daStock);
            daStock.FillSchema(dsNWRC_HairBeauty, SchemaType.Source, "Stock");
            daStock.Fill(dsNWRC_HairBeauty, "Stock");

            if (sender == "Add")
            {
                btn_AddItem.Visible = true;
                btn_Delete.Visible = false;
                btn_Search.Visible = false;
                btn_SaveChanges.Visible = false;
                btn_EditFoundRecord.Visible = false;
                
                handleControlStatus("StockName");
                
                int noRows;
                try
                {
                    noRows = dsNWRC_HairBeauty.Tables["Stock"].Rows.Count;
                }
                catch (Exception)
                {
                    noRows = 800;
                }

                if (noRows == 0)
                {
                    txt_StockNo.Text = "err";
                }
                else
                {
                    getNumber(noRows);
                }
            }
            else if (sender == "Edit")
            {
                btn_AddItem.Visible = false;
                btn_Delete.Visible = false;
                btn_Search.Visible = true;
                btn_SaveChanges.Visible = false;
                btn_EditFoundRecord.Visible = false;
                btnEditorDelete = "Edit";
                handleControlStatus("StockNo");
                
            }
            else if (sender == "Delete")
            {
                //search and cancel buttons initially,
                //once a search is conducted, the system
                //will replace the search button with the
                //delete button
                btn_AddItem.Visible = false;
                btn_Delete.Visible = false;
                btn_Search.Visible = true;
                btn_SaveChanges.Visible = false;
                btn_EditFoundRecord.Visible = false;
                btnEditorDelete = "Delete";
                handleControlStatus("StockNo");
            }

            //connStr = @"Data Source = .\SQLEXPRESS; Initial Catalog = NWRC_HairBeauty; Integrated Security = true";
            connStr = @"Data Source = .; Initial Catalog = NWRC_HairBeauty; Integrated Security = true";
            dsRecent10Items.Tables.Add(dsNWRC_HairBeauty.Tables["Stock"].Copy());
            dsRecent10Items.Tables["Stock"].Clear();
            sqlStock = @"SELECT Top 10 * from Stock
                           ORDER BY StockNo Desc";
            daStock = new SqlDataAdapter(sqlStock, connStr);
            cmdBStock = new SqlCommandBuilder(daStock);
            daStock.FillSchema(dsRecent10Items, SchemaType.Source, "Stock");
            daStock.Fill(dsRecent10Items, "Stock");
            dgv_StockControl.DataSource = dsRecent10Items.Tables["Stock"];

            // Set Font Size 
            dgv_StockControl.Font = new Font("Times", 10);
            //// Resize the DatagridView columns to fit the newly loaded content
            dgv_StockControl.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            //Fill Columns to panel view
            dgv_StockControl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btn_Click(Object sender, EventArgs e)
        {
            if (sender == btn_AddItem)
            {
                int noRows = dsNWRC_HairBeauty.Tables["Stock"].Rows.Count;
                // (String stockName, String stockSpecs, String stockType, int stockSize, int stockQty,  double stockCost, double stockPrice)
                if (noRows == 0)
                {
                    txt_StockNo.Text = "800";
                    txt_StockNo.ForeColor = System.Drawing.Color.Blue;
                }
                else
                {
                    getNumber(noRows);
                }
                
                MyStock myStock = new MyStock();
                bool ok = true;

                try
                {
                    myStock.StockName = txt_StockName.Text.Trim();
                }
                catch (MyException)
                {
                    ok = false;
                }

                try
                {
                    myStock.StockSpecs = txt_StockSpecs.Text.Trim();
                }
                catch (MyException)
                {
                    ok = false;
                }

                try
                {
                    myStock.StockType = txt_StockType.Text.Trim();
                }
                catch (MyException)
                {
                    ok = false;
                }

                try
                {
                    myStock.StockSize = Convert.ToInt32(txt_StockNo.Text.Trim());
                }
                catch (MyException)
                {
                    ok = false;
                }

                try
                {
                    myStock.StockQty = Convert.ToInt32(txt_StockQty.Text.Trim());
                }
                catch (MyException)
                {
                    ok = false;
                }

                try
                {
                    myStock.StockCost = Convert.ToDouble(txt_StockCost.Text.Trim());
                }
                catch (MyException)
                {
                    ok = false;
                }

                try
                {
                    myStock.StockPrice = Convert.ToDouble(txt_StockPrice.Text.Trim());
                }
                catch (MyException)
                {
                    ok = false;
                }
                try
                {
                    myStock.UseageType = cmb_UseageType.SelectedItem.ToString().Trim();
                }
                catch (MyException)
                {
                    ok = false;
                }

                try
                {
                    if (ok)
                    {

                        // Insert into statement = (StockName, StockSpecs, StockSize, StockQty, StockCost, StockType, StockPrice, TotalCost, QtySold)
                        drStock = dsNWRC_HairBeauty.Tables["Stock"].NewRow();
                        drStock["StockName"] = myStock.StockName;
                        drStock["StockSpecs"] = myStock.StockSpecs;
                        drStock["StockSize"] = myStock.StockSize;
                        drStock["StockQty"] = myStock.StockQty;
                        drStock["StockCost"] = myStock.StockCost;
                        drStock["StockType"] = myStock.StockType;
                        drStock["StockPrice"] = myStock.StockPrice;
                        drStock["TotalCost"] = myStock.TotalCost;
                        drStock["UseageType"] = myStock.UseageType;
                        drStock["QtySold"] = 0;

                        dsNWRC_HairBeauty.Tables["Stock"].Rows.Add(drStock);
                        daStock.Update(dsNWRC_HairBeauty, "Stock");

                        MessageBox.Show("New Item " + txt_StockNo.Text + " added !!!");

                        

                        if (MessageBox.Show("Do you wish to add another item?", "Add More Items", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                        {
                            getNumber(dsNWRC_HairBeauty.Tables["Stock"].Rows.Count);
                            handleControlStatus("StockName");
                        }
                        else
                            handleControlStatus("StockNo");
                        
                        refreshDGVs();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                }

            }
            else if(sender == btn_Search)
            {
                if (btnEditorDelete == "Edit")
                {
                    if (txt_StockNo.Text == "")
                    {
                        MessageBox.Show("You must enter a valid stock number!",
                                    "Invalid Stock Number", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        drStock = dsNWRC_HairBeauty.Tables["Stock"].Rows.Find(txt_StockNo.Text);
                        txt_StockName.Text = drStock["StockName"].ToString();
                        txt_StockCost.Text = drStock["StockCost"].ToString();
                        txt_NoSold.Text = drStock["QtySold"].ToString();
                        txt_StockPrice.Text = drStock["StockPrice"].ToString();
                        txt_StockQty.Text = drStock["StockQty"].ToString();
                        txt_StockSize.Text = drStock["StockSize"].ToString();
                        txt_StockSpecs.Text = drStock["StockSpecs"].ToString();
                        txt_StockType.Text = drStock["StockType"].ToString();
                        cmb_UseageType.SelectedText = drStock["UseageType"].ToString();

                        btn_Search.Visible = false;
                        btn_EditFoundRecord.Visible = true;
                        this.AcceptButton = btn_EditFoundRecord;
                    }
                }
                else if(btnEditorDelete == "Delete")
                {
                    if (txt_StockNo.Text == "")
                    {
                        MessageBox.Show("You must enter a valid stock number!",
                                    "Invalid Stock Number", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        drStock = dsNWRC_HairBeauty.Tables["Stock"].Rows.Find(txt_StockNo.Text);
                        txt_StockName.Text = drStock["StockName"].ToString();
                        txt_StockCost.Text = drStock["StockCost"].ToString();
                        txt_NoSold.Text = drStock["QtySold"].ToString();
                        txt_StockPrice.Text = drStock["StockPrice"].ToString();
                        txt_StockQty.Text = drStock["StockQty"].ToString();
                        txt_StockSize.Text = drStock["StockSize"].ToString();
                        txt_StockSpecs.Text = drStock["StockSpecs"].ToString();
                        txt_StockType.Text = drStock["StockType"].ToString();
                        cmb_UseageType.SelectedText = drStock["UseageType"].ToString();

                        txt_StockNo.Enabled = false;
                        txt_StockName.Enabled = false;
                        txt_StockCost.Enabled = false;
                        txt_NoSold.Enabled = false;
                        txt_StockPrice.Enabled = false;
                        txt_StockQty.Enabled = false;
                        txt_StockSize.Enabled = false;
                        txt_StockSpecs.Enabled = false;
                        txt_StockType.Enabled = false;
                        cmb_UseageType.Enabled = false;

                        btn_Search.Visible = false;
                        btn_Delete.Visible = true;
                        this.AcceptButton = btn_Delete;
                    }
                }

            }
            else if(sender == btn_EditFoundRecord)
            {
                txt_StockNo.Enabled = false;
                txt_StockName.Enabled = true;
                txt_StockCost.Enabled = true;
                txt_NoSold.Text = drStock["QtySold"].ToString();
                txt_StockPrice.Enabled = true;
                txt_StockQty.Enabled = true;
                txt_StockSize.Enabled = true;
                txt_StockSpecs.Enabled = true;
                txt_StockType.Enabled = true;
                cmb_UseageType.Enabled = true;

                btn_EditFoundRecord.Visible = false;
                btn_SaveChanges.Visible = true;
                this.AcceptButton = btn_SaveChanges;
                
            }
            else if(sender == btn_Delete)
            {
                if(MessageBox.Show("Are you sure you want to *Permanently* delete this item?\n\n\t\tStock No: " + 
                                    txt_StockNo.Text + "\n\t\tStock Name: " + txt_StockName.Text + "\n\t\tStock Specs: " + txt_StockSpecs.Text, "Delete Stock Item" + 
                                    txt_StockNo.Text, MessageBoxButtons.YesNo) 
                                    == System.Windows.Forms.DialogResult.Yes)
                {
                    drStock.Delete();
                    daStock.Update(dsNWRC_HairBeauty, "Stock");
                    MessageBox.Show("Record Deleted Successfully", "Record Deleted", MessageBoxButtons.OK);
                    refreshDGVs();
                    handleControlStatus("StockNo");
                }
            }
            else if(sender == btn_SaveChanges)
            {
               // txt_StockName.Text, txt_StockCost.Text, txt_StockPrice.Text, txt_StockQty.Text, txt_StockSize.Text, txt_StockSpecs.Text, txt_StockType.Text;

                MyStock myStock = new MyStock();
                bool ok = true;

                try
                {
                    myStock.StockNo = Convert.ToInt32(txt_StockNo.Text.Trim());
                }
                catch (Exception)
                {
                    ok = false;
                }
                try
                {
                    myStock.StockName = txt_StockName.Text.Trim();
                }
                catch (Exception)
                {
                    ok = false;
                }
                try
                {
                    myStock.StockSpecs = txt_StockSpecs.Text.Trim();
                }
                catch (Exception)
                {
                    ok = false;
                }
                try
                {
                    myStock.StockType = txt_StockType.Text.Trim();
                }
                catch (Exception)
                {
                    ok = false;
                }
                try
                {
                    myStock.StockSize = Convert.ToInt32(txt_StockSize.Text.Trim());
                }
                catch (Exception)
                {
                    ok = false;
                }
                try
                {
                    myStock.StockQty = Convert.ToInt32(txt_StockQty.Text.Trim());
                }
                catch (Exception)
                {
                    ok = false;
                }
                try
                {
                    myStock.QtySold = Convert.ToInt32(txt_NoSold.Text.Trim());
                }
                catch (Exception)
                {
                    ok = false;
                }
                try
                {
                    myStock.StockCost = Convert.ToDouble(txt_StockCost.Text.Trim());
                }
                catch (Exception)
                {
                    ok = false;
                }
                try
                {
                    myStock.StockPrice = Convert.ToDouble(txt_StockPrice.Text.Trim());
                }
                catch (Exception)
                {
                    ok = false;
                }

                if ((MessageBox.Show("Are you sure you wish to commit these changes?",
                                "Double Check", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                                    == System.Windows.Forms.DialogResult.Yes))
                {
                    if (ok)
                    {


                        drStock.BeginEdit();

                        drStock["StockName"] = myStock.StockName;
                        drStock["StockSpecs"] = myStock.StockSpecs;
                        drStock["StockType"] = myStock.StockType;
                        drStock["StockSize"] = myStock.StockSize;
                        drStock["StockQty"] = myStock.StockQty;
                        drStock["QtySold"] = myStock.QtySold;
                        drStock["StockCost"] = myStock.StockCost;
                        drStock["StockPrice"] = myStock.StockPrice;
                        drStock["TotalCost"] = myStock.TotalCost;

                        drStock.EndEdit();
                        daStock.Update(dsNWRC_HairBeauty, "Stock");

                        MessageBox.Show("The changes have been saved successfully!",
                                    "Changes Saved", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                        handleControlStatus("StockNo");

                        refreshDGVs();
                    }
                }
            }
            else
                MessageBox.Show("You will loss any unsaved data. Do you wish to continue?",
                                "Unsaved Progress", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
        }
       
        private void getNumber(int noRows)
        {
            drStock = dsNWRC_HairBeauty.Tables["Stock"].Rows[noRows - 1];
            txt_StockNo.Text = (int.Parse(drStock["StockNo"].ToString()) + 1).ToString();
            txt_StockNo.ForeColor = Color.Yellow;
            txt_NoSold.Text = "0";
            txt_StockName.Focus();
        }


        /// <summary>
        /// This method either enables the controls or disables them depending on input.
        /// This method will accept StockNo or StockName as a parameter.
        /// </summary>
        private void handleControlStatus(string focusControl)
        {
            if (focusControl == "StockNo")
            {
                txt_StockNo.ForeColor = System.Drawing.Color.Black;
                txt_StockNo.Enabled = true;
                txt_StockNo.Focus();

                txt_NoSold.Enabled = false;
                txt_StockCost.Enabled = false;
                txt_StockName.Enabled = false;
                txt_StockPrice.Enabled = false;
                txt_StockQty.Enabled = false;
                txt_StockSize.Enabled = false;
                txt_StockSpecs.Enabled = false;
                txt_StockType.Enabled = false;
                cmb_UseageType.Enabled = false;

                txt_StockName.Text = "";
                txt_StockNo.Text = "";
                txt_NoSold.Text = "";
                txt_StockCost.Text = "";
                txt_StockPrice.Text = "";
                txt_StockQty.Text = "";
                txt_StockSize.Text = "";
                txt_StockSpecs.Text = "";
                txt_StockType.Text = "";
                cmb_UseageType.SelectedText = "";

                this.AcceptButton = btn_Search;
            }
            if (focusControl == "StockName")
            {
                txt_StockNo.ForeColor = System.Drawing.Color.Blue;
                int noRows = dsNWRC_HairBeauty.Tables["Stock"].Rows.Count;
                getNumber(noRows);
                txt_StockName.Enabled = true;
                txt_StockName.Text = "";
                txt_StockName.Focus();
               
                txt_StockNo.Enabled = false;
                txt_NoSold.Enabled = false;
                txt_NoSold.Text = "0";
                txt_NoSold.ForeColor = Color.Yellow;
                txt_StockCost.Enabled = true;
                txt_StockPrice.Enabled = true;
                txt_StockQty.Enabled = true;
                txt_StockSize.Enabled = true;
                txt_StockSpecs.Enabled = true;
                txt_StockType.Enabled = true;
                cmb_UseageType.Enabled = true;

                txt_NoSold.Text = "";
                txt_StockCost.Text = "";
                txt_StockPrice.Text = "";
                txt_StockQty.Text = "";
                txt_StockSize.Text = "";
                txt_StockSpecs.Text = "";
                txt_StockType.Text = "";
                cmb_UseageType.SelectedText = "";

                this.AcceptButton = btn_AddItem;
            }
        }

        private void clearAddForm()
        {
            getNumber(dsNWRC_HairBeauty.Tables["Stock"].Rows.Count);
            txt_StockName.Clear();
            txt_StockSpecs.Clear();
            txt_StockType.Clear();
            txt_StockSize.Clear();
            txt_StockQty.Clear();
            txt_NoSold.Clear();
            txt_StockCost.Clear();
            txt_StockPrice.Clear();
        }

        private void refreshDGVs()
        {
            dsNWRC_HairBeauty.Tables["Stock"].Clear();
            dsRecent10Items.Tables["Stock"].Clear();
            sqlStock = @"SELECT Top 10 * from Stock
                           ORDER BY StockNo Desc";
            daStock = new SqlDataAdapter(sqlStock, connStr);
            cmdBStock = new SqlCommandBuilder(daStock);
            daStock.FillSchema(dsRecent10Items, SchemaType.Source, "Stock");
            daStock.Fill(dsRecent10Items, "Stock");
            dgv_StockControl.DataSource = dsRecent10Items.Tables["Stock"];
        }
    }
}

