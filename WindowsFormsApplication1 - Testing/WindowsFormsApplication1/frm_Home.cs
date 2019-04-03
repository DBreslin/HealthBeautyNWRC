using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HairBeautyNWRC
{

    public partial class frm_Home : Form
    {
        public static String selDate; // Public String to show the selected Date on the calendar
        public static String BookNo = "";
        public static int screenWidth = 0;
        public static int screenHeight = 0;
        private bool scheduleClicked = false;

        uc_Schedule schInstance = new uc_Schedule();
        uc_Clients clientInstance = new uc_Clients();
        uc_Users userInstance = new uc_Users();
        uc_Stock stockInstance = new uc_Stock();
        uc_Cust_Btn userButton= new uc_Cust_Btn();
        uc_Treatments treatInstance = new uc_Treatments();

        public frm_Home()
        {

            //frm_Login loginScreen = new frm_Login();
            //loginScreen.ShowDialog();

            InitializeComponent();

            //int screenWidth = Screen.PrimaryScreen.Bounds.Width; //-- Full Screen Limits
            screenWidth = Screen.PrimaryScreen.WorkingArea.Width;   //-- only the usable screen limits 
            screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            this.Size = new Size(screenWidth, screenHeight);

            //with additional settings of the form:
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;

            pnl_top.Width = screenWidth;
            int pnl_Height = pnl_top.Height;

            pb_NwrcLogo.Location = new Point(screenWidth - (pb_NwrcLogo.Image.Width - 100) / 2, -10);
            pb_hb.Location = new Point(0, 2);

            pnl_Side.Height = (screenHeight - pnl_Height);
            pnl_Side.Width = 230;   // Calendar is 227
            pnl_Side.Location = new Point(0, pnl_Height);

            pnl_Home.Width = screenWidth - (pnl_Side.Width - 2);
            pnl_Home.Height = (screenHeight - pnl_Height - 2);
            pnl_Home.Location = new Point(pnl_Side.Width + 2, pnl_Height+4);

            pnl_TopSeperation.Width = screenWidth;
            pnl_TopSeperation.Height = 10;
            pnl_TopSeperation.Location = new Point(0, pnl_top.Height - 1);

            pnl_SideSeperation.Width = 10;
            pnl_SideSeperation.Height = (screenHeight - pnl_Height - 2);
            pnl_SideSeperation.Location = new Point(pnl_Side.Width - 1, pnl_Height);

            int button_Wth = (pnl_Side.Width / 2 -30 - pnl_SideSeperation.Width);
            int button_Hgt = (pnl_Side.Width / 2 -30 - pnl_SideSeperation.Width);

            // -- Custome Button Details --------------- Temp possible User control will be used
            //btnHome.Size = new Size(button_Wth, button_Hgt);
            //btnHome.Location = new Point(pnl_Side.Width / 4 - button_Wth / 2, (Cal_Month.Height + pnl_TopSeperation.Height));
            //btnSch.Size = new Size(button_Wth, button_Hgt);
            //btnSch.Location = new Point(pnl_Side.Width  - button_Wth - pnl_SideSeperation.Width, (Cal_Month.Height + pnl_TopSeperation.Height));
            //btnSales.Size = new Size(button_Wth, button_Hgt);
            //btnSales.Location = new Point(pnl_Side.Width / 4 - button_Wth / 2, (Cal_Month.Height + pnl_TopSeperation.Height + button_Hgt));
            //btnStock.Size = new Size(button_Wth, button_Hgt);
            //btnStock.Location = new Point(pnl_Side.Width - button_Wth - pnl_SideSeperation.Width, (Cal_Month.Height + pnl_TopSeperation.Height + button_Hgt));
            //btnClients.Size = new Size(button_Wth, button_Hgt);
            //btnClients.Location = new Point(pnl_Side.Width / 4 - button_Wth / 2, (Cal_Month.Height + pnl_TopSeperation.Height + button_Hgt*2));
            //btnUsers.Size = new Size(button_Wth, button_Hgt);
            //btnUsers.Location = new Point(pnl_Side.Width - button_Wth - pnl_SideSeperation.Width, (Cal_Month.Height + pnl_TopSeperation.Height + button_Hgt*2));
            //btnReports.Size = new Size(button_Wth, button_Hgt);
            //btnReports.Location = new Point(pnl_Side.Width/3 - pnl_SideSeperation.Width, (Cal_Month.Height + pnl_TopSeperation.Height + button_Hgt * 3));
            btnHome.Size = new Size(button_Wth, button_Hgt);
            btnHome.Location = new Point(pnl_Side.Width / 3-button_Wth/5, (Cal_Month.Height + pnl_TopSeperation.Height));
            btnSch.Size = new Size(button_Wth, button_Hgt);
            btnSch.Location = new Point(pnl_Side.Width / 3 - button_Wth / 5, ((Cal_Month.Height + pnl_TopSeperation.Height + (button_Hgt + 20) * 2)));
            btnSales.Size = new Size(button_Wth, button_Hgt);
            btnSales.Location = new Point(pnl_Side.Width / 3 - button_Wth / 5, (Cal_Month.Height + pnl_TopSeperation.Height + (button_Hgt + 20)));
            btnStock.Size = new Size(button_Wth, button_Hgt);
            btnStock.Location = new Point(pnl_Side.Width / 3 - button_Wth / 5, (Cal_Month.Height + pnl_TopSeperation.Height + (button_Hgt + 20) * 3));
            btnClients.Size = new Size(button_Wth, button_Hgt);
            btnClients.Location = new Point(pnl_Side.Width / 3 - button_Wth / 5, ((Cal_Month.Height + pnl_TopSeperation.Height + (button_Hgt+20) * 4)));
            btnUsers.Size = new Size(button_Wth, button_Hgt);
            btnUsers.Location = new Point(pnl_Side.Width / 3 - button_Wth / 5, ((Cal_Month.Height + pnl_TopSeperation.Height + (button_Hgt + 20) * 5)));
            btnReports.Size = new Size(button_Wth, button_Hgt);
            btnReports.Location = new Point(pnl_Side.Width / 3 - button_Wth / 5, ((Cal_Month.Height + pnl_TopSeperation.Height + (button_Hgt + 20) * 6)));
            //btn_LoadClient.Size = new Size(button_Wth, button_Hgt);
            //btn_Schedule.Size = new Size(button_Wth, button_Hgt);
            //btn_home.Size = new Size(button_Wth, button_Hgt);
            //btn_Users.Size = new Size(button_Wth, button_Hgt);
            //btn_Stock.Size = new Size(button_Wth, button_Hgt);
            //btn_Sales.Size = new Size(button_Wth, button_Hgt);
            //btn_Reports.Size = new Size(button_Wth, button_Hgt);
            //btn_Test.Size = new Size(button_Wth, button_Hgt);
            btn_LoadClient.Visible = false;
            btn_Schedule.Visible = false;
            btn_home.Visible = false;
            btn_Users.Visible = false;
            btn_Stock.Visible = false;
            btn_Sales.Visible = false;
            btn_Reports.Visible = false;
            btn_Test.Visible = false;

            /// <summary>
            /// This is the location of the buttons based on panel size and button size ------------ this is an example of method notation.
            /// </summary>

            
            //btn_home.Location = new Point(pnl_Side.Width / 2 - btn_LoadClient.Width / 2 - pnl_SideSeperation.Width, (Cal_Month.Height + pnl_TopSeperation.Height + button_Hgt));
            //btn_Schedule.Location = new Point(pnl_Side.Width/2 - btn_LoadClient.Width/2 - pnl_SideSeperation.Width, (Cal_Month.Height + pnl_TopSeperation.Height+ (button_Hgt * 2)));
            //btn_Sales.Location = new Point(pnl_Side.Width / 2 - btn_LoadClient.Width / 2 - pnl_SideSeperation.Width, (Cal_Month.Height + pnl_TopSeperation.Height + (button_Hgt * 3)));
            //btn_Stock.Location = new Point(pnl_Side.Width / 2 - btn_LoadClient.Width / 2 - pnl_SideSeperation.Width, (Cal_Month.Height + pnl_TopSeperation.Height + (button_Hgt * 4)));
            //btn_LoadClient.Location = new Point(pnl_Side.Width / 2 - btn_LoadClient.Width / 2 - pnl_SideSeperation.Width, (Cal_Month.Height + pnl_TopSeperation.Height + (button_Hgt * 5)));
            //btn_Users.Location = new Point(pnl_Side.Width / 2 - btn_LoadClient.Width / 2 - pnl_SideSeperation.Width, (Cal_Month.Height + pnl_TopSeperation.Height + (button_Hgt * 6)));
            //btn_Reports.Location = new Point(pnl_Side.Width / 2 - btn_LoadClient.Width / 2 - pnl_SideSeperation.Width, (Cal_Month.Height + pnl_TopSeperation.Height + (button_Hgt * 7)));
            //btn_Test.Location = new Point(pnl_Side.Width / 2 - btn_LoadClient.Width / 2 - pnl_SideSeperation.Width, (Cal_Month.Height + pnl_TopSeperation.Height + (button_Hgt * 8)));

            lbl_DayDate.Location = new Point(pnl_top.Width / 2 - lbl_DayDate.Width / 2, pnl_top.Height / 2 - lbl_DayDate.Height / 2);
            lbl_DayDate.Text = Cal_Month.SelectionRange.Start.DayOfWeek + " "
                        + Cal_Month.SelectionRange.Start.ToLongDateString();

            selectDate();
        }

        private void btn_LoadClient_Click(object sender, EventArgs e)
        {
            resetCal();
            clientInstance.Dispose();

            clientInstance = new uc_Clients();

            pnl_Home.Controls.Add(clientInstance);
            clientInstance.Dock = DockStyle.Fill;
            clientInstance.BringToFront();
            clientInstance.Show();
        }

        private void btn_Schedule_Click(object sender, EventArgs e)
        {
            resetCal();
            Cal_Month.Enabled = true; // should I only ,ake calendar available in schedule ?????
            updateSched();
            scheduleClicked = true;
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            resetCal();
            clearControls();
            scheduleClicked = false;
        }

        private void Cal_Month_DateSelected(object sender, DateRangeEventArgs e)
        {
            
            if (scheduleClicked)
            {
                selectDate();
                updateSched();
                lbl_DayDate.Text = Cal_Month.SelectionRange.Start.DayOfWeek + " "
                    + Cal_Month.SelectionRange.Start.ToLongDateString();
            }
        }

        private void selectDate()
        {
            selDate = Cal_Month.SelectionRange.Start.ToShortDateString() + " 00:00:00";
        }

        private void updateSched()
        {
            schInstance.Dispose();

            schInstance = new uc_Schedule();

            pnl_Home.Controls.Add(schInstance);
            schInstance.Dock = DockStyle.Fill;
            schInstance.BringToFront();
            schInstance.Show();

            BookNo = schInstance.bookingNumber.ToString();
        }

        private void btn_Users_Click(object sender, EventArgs e)
        {
            resetCal();
            userInstance.Dispose();

            userInstance = new uc_Users();

            pnl_Home.Controls.Add(userInstance);
            userInstance.Dock = DockStyle.Fill;
            userInstance.BringToFront();
            userInstance.Show();
        }
        private void clearControls()
        {
            schInstance.Dispose();
            clientInstance.Dispose();
            userInstance.Dispose();
            stockInstance.Dispose();
            Cal_Month.Enabled = false;
        }

        private void resetCal()
        {
            Cal_Month.Enabled = false;
            lbl_DayDate.Text = DateTime.Now.DayOfWeek + " " + DateTime.Now.ToLongDateString();
            Cal_Month.SetDate(DateTime.Now);
        }

        private void btn_Test_Click(object sender, EventArgs e)
        {
            userButton = new uc_Cust_Btn();

            pnl_Home.Controls.Add(userButton);
            userButton.Dock = DockStyle.Fill;
            userButton.BringToFront();
            userButton.Show();
        }

        private void cust_Sch_Click(object sender, EventArgs e)
        {
            resetCal();
            Cal_Month.Enabled = true; // should I only ,make calendar available in schedule ?????
            updateSched();
            scheduleClicked = true;
        }

        private void cust_Sch_MouseDown(object sender, MouseEventArgs e)
        {
            resetCal();
            Cal_Month.Enabled = true; // should I only ,make calendar available in schedule ?????
            updateSched();
            scheduleClicked = true;
        }
        // Change picture to make button behave like a button --- to be replaced by user control
        private void btnHome_MouseDown(object sender, MouseEventArgs e)
        {
            btnHome.Image = Properties.Resources.Round_Buttonh_bDown;
        }

        private void btnHome_MouseUp(object sender, MouseEventArgs e)
        {
            btnHome.Image = Properties.Resources.Round_Buttonh_bUp;
            resetCal();
            clearControls();
            scheduleClicked = false;


            //--- Extra testing will be removed or assigned to a button
            treatInstance = new uc_Treatments();

            pnl_Home.Controls.Add(treatInstance);
            treatInstance.Dock = DockStyle.Fill;
            treatInstance.BringToFront();
            treatInstance.Show();
        }

        private void btnSch_MouseDown(object sender, MouseEventArgs e)
        {
            btnSch.Image = Properties.Resources.Round_Button_caldown;
        }

        private void btnSch_MouseUp(object sender, MouseEventArgs e)
        {
            btnSch.Image = Properties.Resources.Round_Button_calup;
            resetCal();
            Cal_Month.Enabled = true; // should I only ,ake calendar available in schedule ?????
            updateSched();
            scheduleClicked = true;
        }

        private void btnSales_MouseDown(object sender, MouseEventArgs e)
        {
            btnSales.Image = Properties.Resources.Round_Button_salesdown;
        }

        private void btnSales_MouseUp(object sender, MouseEventArgs e)
        {
            btnSales.Image = Properties.Resources.Round_Button_salesup;
        }

        private void btnStock_MouseDown(object sender, MouseEventArgs e)
        {
            btnStock.Image = Properties.Resources.Round_Button_stockdown;
        }

        private void btnStock_MouseUp(object sender, MouseEventArgs e)
        {
            btnStock.Image = Properties.Resources.Round_Button_stockup;
            resetCal();
            stockInstance.Dispose();

            stockInstance = new uc_Stock();

            pnl_Home.Controls.Add(stockInstance);
            stockInstance.Dock = DockStyle.Fill;
            stockInstance.BringToFront();
            stockInstance.Show();
        }

        private void btnClients_MouseDown(object sender, MouseEventArgs e)
        {
            btnClients.Image = Properties.Resources.Round_Button_clientsdown;
        }

        private void btnClients_MouseUp(object sender, MouseEventArgs e)
        {
            btnClients.Image = Properties.Resources.Round_Button_clientsup;
            resetCal();
            clientInstance.Dispose();

            clientInstance = new uc_Clients();

            pnl_Home.Controls.Add(clientInstance);
            clientInstance.Dock = DockStyle.Fill;
            clientInstance.BringToFront();
            clientInstance.Show();
        }

        private void btnUsers_MouseDown(object sender, MouseEventArgs e)
        {
            btnUsers.Image = Properties.Resources.Round_Button_userdown;
        }

        private void btnUsers_MouseUp(object sender, MouseEventArgs e)
        {
            btnUsers.Image = Properties.Resources.Round_Button_userup;
            resetCal();
            userInstance.Dispose();

            userInstance = new uc_Users();

            pnl_Home.Controls.Add(userInstance);
            userInstance.Dock = DockStyle.Fill;
            userInstance.BringToFront();
            userInstance.Show();
        }

        private void btnReports_MouseDown(object sender, MouseEventArgs e)
        {
            btnReports.Image = Properties.Resources.Round_Button_reportdown;
        }

        private void btnReports_MouseUp(object sender, MouseEventArgs e)
        {
            btnReports.Image = Properties.Resources.Round_Button_reportup;
        }

        private void btnReports_MouseMove(object sender, MouseEventArgs e)
        {
            btnReports.Image = Properties.Resources.Round_Button_reporthigh;
        }

        private void btnReports_MouseLeave(object sender, EventArgs e)
        {
            btnReports.Image = Properties.Resources.Round_Button_reportup;
        }
    }   
}
