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
    public partial class uc_Schedule : UserControl
    {
        public String bookingNumber = "";
        public Color treatColour = new Color();

        SqlDataAdapter daBook,daClient;
        DataSet dsNWRC_HairBeauty = new DataSet();
        SqlCommandBuilder cmdBBook, cmdBClient;
        String connStr, sqlBook, sqlClient;
        DataRow drBook,drClient;
        private System.Windows.Forms.ErrorProvider errP;

        private DateTime start;
        private bool pause = false;
        private bool cellClicked = false;
        private int rowindex = 0;
        private int columnindex = 0;


        public uc_Schedule()
        {
            InitializeComponent();
        }

        private void uc_Schedule_Load(object sender, EventArgs e)
        {
            errP = new ErrorProvider();

            connStr = @"Data Source = .\SQLEXPRESS; Initial Catalog = NWRC_HairBeauty; Integrated Security = true";
            //connStr = @"Data Source = .; Initial Catalog = NWRC_HairBeauty; Integrated Security = true";

            sqlBook = @"SELECT * from Booking";
            daBook = new SqlDataAdapter(sqlBook, connStr);
            cmdBBook = new SqlCommandBuilder(daBook);
            daBook.FillSchema(dsNWRC_HairBeauty, SchemaType.Source, "Booking");
            daBook.Fill(dsNWRC_HairBeauty, "Booking");

            sqlClient = @"SELECT * from Client";
            daClient = new SqlDataAdapter(sqlClient, connStr);
            cmdBClient = new SqlCommandBuilder(daClient);
            daClient.FillSchema(dsNWRC_HairBeauty, SchemaType.Source, "Client");
            daClient.Fill(dsNWRC_HairBeauty, "Client");

            dg_Schedule.EnableHeadersVisualStyles = false;
            dg_Schedule.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))); ;
            dg_Schedule.ColumnHeadersDefaultCellStyle.ForeColor = Color.DarkSlateGray;
            dg_Schedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg_Schedule.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dg_Schedule.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            timer1.Start();
            // Run method to get next booking number
            getNumber();
        
                Time rowTime = new Time(9, 0);
            dg_Schedule.Rows.Add(rowTime.ToString());

            for (int x = 0; x < 48; x++)
            {
                rowTime.AddInteval();
                dg_Schedule.Rows.Add(rowTime.ToString());
            }

           

            foreach (DataRow dr in dsNWRC_HairBeauty.Tables["Booking"].Rows)
            {

                if (dr["DateofApp"].ToString() == frm_Home.selDate) // check calendar date
                {
                    drClient = dsNWRC_HairBeauty.Tables["Client"].Rows.Find(dr["ClientNo"].ToString());

                    String details = ("Client No: " + dr["ClientNo"].ToString()
                               + "\nName: " + drClient["Title"].ToString() +" " + drClient["Forename"].ToString() +" " + drClient["Surname"].ToString()
                               + "\nTreatment: " + dr["TreatmentNo"].ToString());

                    int storedLocX = Convert.ToInt32(dr["LocX"]);
                    int storedLocY = Convert.ToInt32(dr["LocY"]);

                    checkTreat(dr["TreatmentNo"].ToString());

                    dg_Schedule.Rows[storedLocY].Cells[storedLocX].Value = details;
                    dg_Schedule.Rows[storedLocY].Cells[storedLocX].Style.BackColor = treatColour;

                    for (int i = 2; i < 21; i++)
                    {
                        String columnName = "Check" + i;

                        if (Convert.ToInt32(dr[columnName]) == 1)
                        {
                            dg_Schedule.Rows[storedLocY + (i - 1)].Cells[storedLocX].Value = details;
                            dg_Schedule.Rows[storedLocY + (i - 1)].Cells[storedLocX].Style.BackColor = treatColour;
                        }
                    }
                }
            }

        }
        // Finds current time and offsets that against position of middle index and highlights that row. It will also unhighlight the previous row when using timer
        private void higlightCurrent()
        {
            DateTime currentDateTime = DateTime.Now;
            Time timeNow = new Time(currentDateTime);
            uint curHr = unchecked((uint)timeNow.Hours);
            uint curMin = unchecked((uint)timeNow.Minutes);

            if (curHr >= 21 && curMin > 0 || curHr < 9)
            {

            }
            else
            {
                if (timeNow.Minutes < 15)
                    curMin = 0;
                else if (timeNow.Minutes < 30)
                    curMin = 15;
                else if (timeNow.Minutes < 45)
                    curMin = 30;
                else if (timeNow.Minutes < 60)
                    curMin = 45;

                Time currentRow = new Time(curHr, curMin);

                // Count visible rows on screen
                int rowCount = dg_Schedule.DisplayedRowCount(false);

                foreach (DataGridViewRow row in dg_Schedule.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(currentRow.ToString()))
                    {
                        row.DefaultCellStyle.BackColor = Color.LightSteelBlue;

                        int current = row.Index;
                        int previous = row.Index - 1;

                        if ((curMin >= 15 && curHr != 9))
                        {
                            dg_Schedule.Rows[previous].DefaultCellStyle.BackColor = Color.White;
                            dg_Schedule.Rows[previous].Cells[0].Style.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
                        }

                        if (current - (rowCount / 2) <= 0)
                        {
                            current = 0;
                            dg_Schedule.FirstDisplayedScrollingRowIndex = current;
                        }
                        else
                            dg_Schedule.FirstDisplayedScrollingRowIndex = current - (rowCount / 2);
                        //dg_Schedule.Refresh();
                        break;
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!(pause) && !(cellClicked))
               higlightCurrent();
        }

        private void dgv_Scroll(object sender, ScrollEventArgs e)
        {
            // If user scrolls Delay autocenter 
            if (e.OldValue > e.NewValue || e.OldValue < e.NewValue)
            {
                timer2.Start();
                pause = true;
                start = DateTime.Now;
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            // Delay Timer by seconds shown
            if ((DateTime.Now - start).TotalSeconds > 5)
            {
                timer2.Stop();
                pause = false;
            }

        }

        private void checkTreat(String temp)
        {
            switch (temp)
            {
                case "Fake Treatment 1":
                    {
                        treatColour = Color.Azure;
                        break;
                    }
                case "Fake Treatment 2":
                    {
                        treatColour = Color.Pink;
                        break;
                    }
                case "Fake Treatment 3":
                    {
                        treatColour = Color.LightBlue;
                        break;
                    }
                case "Fake Treatment 4":
                    {
                        treatColour = Color.Lavender;
                        break;
                    }
                case "Fake Treatment 5":
                    {
                        treatColour = Color.LightSeaGreen;
                        break;
                    }
                case "Fake Treatment 6":
                    {
                        treatColour = Color.LightCoral;
                        break;
                    }
            }
        }
        private void dg_Schedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bool canMakeBook = true;
            if (dg_Schedule.CurrentCell.Value == null)
            {

                // Run method to get next booking number
                getNumber();
                cellClicked = true;

                // Get current Cells Location and store in variable
                rowindex = dg_Schedule.CurrentCellAddress.Y;
                columnindex = dg_Schedule.CurrentCellAddress.X;

                // Open booking Form and make booking
                frm_Booking makeBooking = new frm_Booking();
                makeBooking.ShowDialog();

                try
                {
                    checkTreat(frm_Booking.bookList[5]);

                    // deselect the current cell - asthetic reason only
                    dg_Schedule.CurrentCell = null;

                    // Set a count on filled cells so it can be rolled back if needed - maybe use this in delete as a method ?
                    int countPopCells = 0;

                    // Check for which cells have been asked for and colour them while inputing booking information into cell
                    for (int i = 6; i < 26; i++)
                    {
                        if (frm_Booking.bookList[i].ToString() == "True")
                        {
                            if (dg_Schedule.Rows[rowindex + (i - 6)].Cells[columnindex].Value == null)
                            {
                                dg_Schedule.Rows[rowindex + (i - 6)].Cells[columnindex].Style.BackColor = treatColour;
                                dg_Schedule.Rows[rowindex + (i - 6)].Cells[columnindex].Value
                                    = ("Client No: " + frm_Booking.bookList[1].ToString()
                                    + "\nName: " + frm_Booking.bookList[2].ToString()
                                    + " " + frm_Booking.bookList[3].ToString()
                                    + " " + frm_Booking.bookList[4].ToString()
                                    + "\nTreatment: " + frm_Booking.bookList[5].ToString());
                                countPopCells++;
                            }
                            else
                            {
                                for (int j = 1; j <= countPopCells; j++)
                                {
                                    dg_Schedule.Rows[rowindex + (i - 6)-j].Cells[columnindex].Style.BackColor = Color.White;
                                    dg_Schedule.Rows[rowindex + (i - 6)-j].Cells[columnindex].Value = null;
                                }
                                canMakeBook = false;
                                break;

                                // Need to find a way to remove the entries placed when there is an error
                            }
                        }
                    }

                    if (canMakeBook)
                    {
                        saveBooking();
                    }
                    else
                        MessageBox.Show("Cannot Make booking no Available Free Slots. Please Check and try again", "Booking Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                catch (ArgumentOutOfRangeException b)
                {
                    if (b.ActualValue != null)
                        Console.WriteLine("{0} is an invalid value for {1}: ", b.ActualValue, b.ParamName);
                    Console.WriteLine(b.Message);
                }
            }
            else
            {
                // Enter code to edit or delete booking here 
            }
        }

        private void saveBooking()
        {
            cellClicked = false;
            MyBooking mybooking = new MyBooking();
            bool ok = true;
            errP.Clear();

            try // Booking Number
            { mybooking.BookNo = Convert.ToInt32(frm_Booking.bookList[0].ToString()); }
            catch (MyException)
            { ok = false; }
            try // Client Number
            { mybooking.ClientNo = frm_Booking.bookList[1].ToString(); }
            catch (MyException)
            { ok = false; }
            try // Title
            { mybooking.Forename = frm_Booking.bookList[2].ToString(); }
            catch (MyException)
            { ok = false; }
            try // Forename
            { mybooking.Surname = frm_Booking.bookList[3].ToString(); }
            catch (MyException)
            { ok = false; }
            try // Surname
            { mybooking.Surname = frm_Booking.bookList[4].ToString(); }
            catch (MyException)
            { ok = false; }
            try // Treatment
            { mybooking.Treatment = frm_Booking.bookList[5].ToString(); }
            catch (MyException)
            { ok = false; }
            try // CheckBox 1
            { mybooking.Check1 = Boolean.Parse(frm_Booking.bookList[6]); }
            catch (MyException)
            { ok = false; }
            try // CheckBox 2
            { mybooking.Check2 = Boolean.Parse(frm_Booking.bookList[7]); }
            catch (MyException)
            { ok = false; }
            try // CheckBox 3
            { mybooking.Check3 = Boolean.Parse(frm_Booking.bookList[8]); }
            catch (MyException)
            { ok = false; }
            try // CheckBox 4
            { mybooking.Check4 = Boolean.Parse(frm_Booking.bookList[9]); }
            catch (MyException)
            { ok = false; }
            try // CheckBox 5
            { mybooking.Check5 = Boolean.Parse(frm_Booking.bookList[10]); }
            catch (MyException)
            { ok = false; }
            try// CheckBox 6
            { mybooking.Check6 = Boolean.Parse(frm_Booking.bookList[11]); }
            catch (MyException)
            { ok = false; }
            try// CheckBox 7
            { mybooking.Check7 = Boolean.Parse(frm_Booking.bookList[12]); }
            catch (MyException)
            { ok = false; }
            try// CheckBox 8
            { mybooking.Check8 = Boolean.Parse(frm_Booking.bookList[13]); }
            catch (MyException)
            { ok = false; }
            try// CheckBox 9
            { mybooking.Check9 = Boolean.Parse(frm_Booking.bookList[14]); }
            catch (MyException)
            { ok = false; }
            try// CheckBox 10
            { mybooking.Check10 = Boolean.Parse(frm_Booking.bookList[15]); }
            catch (MyException)
            { ok = false; }
            try// CheckBox 11
            { mybooking.Check11 = Boolean.Parse(frm_Booking.bookList[16]); }
            catch (MyException)
            { ok = false; }
            try// CheckBox 12
            { mybooking.Check13 = Boolean.Parse(frm_Booking.bookList[17]); }
            catch (MyException)
            { ok = false; }
            try// CheckBox 13
            { mybooking.Check13 = Boolean.Parse(frm_Booking.bookList[18]); }
            catch (MyException)
            { ok = false; }
            try// CheckBox 14
            { mybooking.Check14 = Boolean.Parse(frm_Booking.bookList[19]); }
            catch (MyException)
            { ok = false; }
            try// CheckBox 15
            { mybooking.Check15 = Boolean.Parse(frm_Booking.bookList[20]); }
            catch (MyException)
            { ok = false; }
            try// CheckBox 16
            { mybooking.Check16 = Boolean.Parse(frm_Booking.bookList[21]); }
            catch (MyException)
            { ok = false; }
            try// CheckBox 17
            { mybooking.Check17 = Boolean.Parse(frm_Booking.bookList[22]); }
            catch (MyException)
            { ok = false; }
            try// CheckBox 18
            { mybooking.Check18 = Boolean.Parse(frm_Booking.bookList[23]); }
            catch (MyException)
            { ok = false; }
            try// CheckBox 19
            { mybooking.Check19 = Boolean.Parse(frm_Booking.bookList[24]); }
            catch (MyException)
            { ok = false; }
            try// CheckBox 20
            { mybooking.Check20 = Boolean.Parse(frm_Booking.bookList[25]); }
            catch (MyException)
            { ok = false; }

            try
            {
                if (ok)
                {
                    drBook = dsNWRC_HairBeauty.Tables["Booking"].NewRow();
                    drBook["BookingNo"] = mybooking.BookNo;
                    drBook["ClientNo"] = mybooking.ClientNo;
                    drBook["UserID"] = 1001;
                    drBook["DateofApp"] = frm_Home.selDate;
                    drBook["TreatmentNo"] = mybooking.Treatment;
                    drBook["BookingTotal"] = 0.0;
                    drBook["Salon"] = "Hair";
                    drBook["Check1"] = mybooking.Check1;
                    drBook["Check2"] = mybooking.Check2;
                    drBook["Check3"] = mybooking.Check3;
                    drBook["Check4"] = mybooking.Check4;
                    drBook["Check5"] = mybooking.Check5;
                    drBook["Check6"] = mybooking.Check6;
                    drBook["Check7"] = mybooking.Check7;
                    drBook["Check8"] = mybooking.Check8;
                    drBook["Check9"] = mybooking.Check9;
                    drBook["Check10"] = mybooking.Check10;
                    drBook["Check11"] = mybooking.Check11;
                    drBook["Check12"] = mybooking.Check12;
                    drBook["Check13"] = mybooking.Check13;
                    drBook["Check14"] = mybooking.Check14;
                    drBook["Check15"] = mybooking.Check15;
                    drBook["Check16"] = mybooking.Check16;
                    drBook["Check17"] = mybooking.Check17;
                    drBook["Check18"] = mybooking.Check18;
                    drBook["Check19"] = mybooking.Check19;
                    drBook["Check20"] = mybooking.Check20;
                    drBook["LocY"] = rowindex;
                    drBook["LocX"] = columnindex;

                    dsNWRC_HairBeauty.Tables["Booking"].Rows.Add(drBook);
                    daBook.Update(dsNWRC_HairBeauty, "Booking");

                    rowindex = 0;
                    columnindex = 0;

                    MessageBox.Show("New Booking " + mybooking.BookNo + " added !!!");

                    timer2.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }

        private void getNumber()
        {
            // Count current Rows in booking Table 
            int noRows = dsNWRC_HairBeauty.Tables["Booking"].Rows.Count;
            if (noRows == 0)
                bookingNumber = "1000";
            else
            {
                drBook = dsNWRC_HairBeauty.Tables["Booking"].Rows[noRows - 1];
                bookingNumber = (int.Parse(drBook["BookingNo"].ToString()) + 1).ToString();
            }
            frm_Home.BookNo = bookingNumber;

        }
    }
}
