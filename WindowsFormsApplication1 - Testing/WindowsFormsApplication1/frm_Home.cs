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
        public static string selDate; // Public String to show the selected Date on the calendar
        public static string salon ;
        public static string salonNo;
        public static string BookNo = "";
        public static int screenWidth = 0;
        public static int screenHeight = 0;
        private bool scheduleClicked = false;
        private bool firstload = true;

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
            btn_Test.Visible = true;
            btn_Test.Location = new Point(pnl_Side.Width / 3 - button_Wth / 5, ((Cal_Month.Height + pnl_TopSeperation.Height + (button_Hgt + 20) * 7)));

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
            
            cb_Salon.SelectedIndex = 1;
            lbl_SalonSelection.Location = new Point(screenWidth - pb_NwrcLogo.Width * 2, pnl_top.Height / 2 - lbl_SalonSelection.Height);
            lbl_SalonNoSelection.Location = new Point(screenWidth-pb_NwrcLogo.Width*2, pnl_top.Height / 2 + lbl_SalonNoSelection.Height/2 - pnl_TopSeperation.Height);

            salon = cb_Salon.SelectedItem.ToString();
            if (rb_Salon1.Checked)
                salonNo = rb_Salon1.Text.ToString();
            else if (rb_Salon2.Checked)
                salonNo = rb_Salon2.Text.ToString();
            else if (rb_Salon3.Checked)
                salonNo = rb_Salon3.Text.ToString();
            else if (rb_Salon4.Checked)
                salonNo = rb_Salon4.Text.ToString();
            selectDate();
            firstload = false;
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

        private void clearControls()
        {
            schInstance.Dispose();
            clientInstance.Dispose();
            userInstance.Dispose();
            stockInstance.Dispose();
            treatInstance.Dispose();
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
            //userButton = new uc_Cust_Btn();

            //pnl_Home.Controls.Add(userButton);
            //userButton.Dock = DockStyle.Fill;
            //userButton.BringToFront();
            //userButton.Show();

            //--- Extra testing will be removed or assigned to a button
            treatInstance = new uc_Treatments();

            pnl_Home.Controls.Add(treatInstance);
            treatInstance.Dock = DockStyle.Fill;
            treatInstance.BringToFront();
            treatInstance.Show();
            //****************************************************************************
        }



        private void customBtn_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox btnTemp = new PictureBox();
            btnTemp = (PictureBox)sender;
            buttonDown(btnTemp);
        }

        private void customBtn_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox btnTemp = new PictureBox();
            btnTemp = (PictureBox)sender;
            btnReports.Image = Properties.Resources.Round_Button_reportup;
            buttonUp(btnTemp);
        }

        private void customBtn_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox btnTemp = new PictureBox();
            btnTemp = (PictureBox)sender;
            buttonHigh(btnTemp);
            //btnTemp.Image = imageList1.Images[Convert.ToInt32(btnTemp.Tag)]; // to pull from image list based on location number 
        }

        private void customBtn_MouseLeave(object sender, EventArgs e)
        {
            PictureBox btnTemp = new PictureBox();
            btnTemp = (PictureBox)sender;
            buttonReset(btnTemp);
        }


        // Below Possibly be replaced with custom uc version if we have the time !!!
        private void buttonUp(PictureBox buttonName)
        {

            switch (buttonName.Name)
            {
                case "btnHome":
                    //Update Button Picture
                    buttonName.Image = Properties.Resources.Round_Buttonh_bUp;
                    // Reset Calendar and clear controls
                    resetCal();
                    clearControls();
                    scheduleClicked = false;
                    //*************************************************************************
                   
                    break;

                case "btnSch":
                    //Update Button Picture
                    buttonName.Image = Properties.Resources.Round_Button_calup;
                    //Reset Calendar
                    resetCal();
                    Cal_Month.Enabled = true; // should I only ,make calendar available in schedule ?????
                    updateSched();
                    scheduleClicked = true;
                    break;

                case "btnSales":
                    //Update Button Picture
                    buttonName.Image = Properties.Resources.Round_Button_salesup;
                    break;

                case "btnStock":
                    //Update Button Picture
                    buttonName.Image = Properties.Resources.Round_Button_stockup;
                    //Reset Calendar and dispose of running Instance
                    resetCal();
                    stockInstance.Dispose();
                    //Redo updated instance and populate Panel
                    stockInstance = new uc_Stock();
                    pnl_Home.Controls.Add(stockInstance);
                    stockInstance.Dock = DockStyle.Fill;
                    stockInstance.BringToFront();
                    stockInstance.Show();
                    break;

                case "btnClients":
                    //Update Button Picture
                    buttonName.Image = Properties.Resources.Round_Button_clientsup;
                    //Reset Calendar and dispose of running Instance
                    resetCal();
                    clientInstance.Dispose();
                    //Redo updated instance and populate Panel
                    clientInstance = new uc_Clients();
                    pnl_Home.Controls.Add(clientInstance);
                    clientInstance.Dock = DockStyle.Fill;
                    clientInstance.BringToFront();
                    clientInstance.Show();
                    break;

                case "btnUsers":
                    //Update Button Picture
                    buttonName.Image = Properties.Resources.Round_Button_userup;
                    //Reset Calendar and dispose of running Instance
                    resetCal();
                    userInstance.Dispose();
                    //Redo updated instance and populate Panel
                    userInstance = new uc_Users();
                    pnl_Home.Controls.Add(userInstance);
                    userInstance.Dock = DockStyle.Fill;
                    userInstance.BringToFront();
                    userInstance.Show();
                    break;

                case "btnReports":
                    //Update Button Picture
                    buttonName.Image = Properties.Resources.Round_Button_reportup;
                    break;

                default:
                    MessageBox.Show("Nothing Was Clicked !"); // shows button clicked
                    break;
            }

        }
        private void buttonDown(PictureBox buttonName)
        {

            switch (buttonName.Name)
            {
                case "btnHome":
                    buttonName.Image = Properties.Resources.Round_Buttonh_bDown;
                    break;
                case "btnSch":
                    buttonName.Image = Properties.Resources.Round_Button_caldown;
                    break;
                case "btnSales":
                    buttonName.Image = Properties.Resources.Round_Button_salesdown;
                    break;
                case "btnStock":
                    buttonName.Image = Properties.Resources.Round_Button_stockdown;
                    break;
                case "btnClients":
                    buttonName.Image = Properties.Resources.Round_Button_clientsdown;
                    break;
                case "btnUsers":
                    buttonName.Image = Properties.Resources.Round_Button_userdown;
                    break;
                case "btnReports":
                    buttonName.Image = Properties.Resources.Round_Button_reportdown;
                    break;

                default:
                    MessageBox.Show("Nothing Was Clicked !"); // shows button clicked
                    break;
            }

        }
        private void buttonHigh(PictureBox buttonName)
        {

            switch (buttonName.Name)
            {
                case "btnHome":
                    
                    // Insert Picture Change code here
                    break;
                case "btnSch":
                    // Insert Picture Change code here
                    break;
                case "btnSales":
                    // Insert Picture Change code here
                    break;
                case "btnStock":
                    // Insert Picture Change code here
                    break;
                case "btnClients":
                    // Insert Picture Change code here
                    break;
                case "btnUsers":
                    // Insert Picture Change code here
                    break;
                case "btnReports":
                    buttonName.Image = Properties.Resources.Round_Button_reporthigh;
                    break;

                default:
                    MessageBox.Show("Nothing Was Clicked !"); // shows button clicked
                    break;
            }

        }
        private void buttonReset(PictureBox buttonName)
        {

            switch (buttonName.Name)
            {
                case "btnHome":
                    buttonName.Image = Properties.Resources.Round_Buttonh_bUp;
                    break;
                case "btnSch":
                    buttonName.Image = Properties.Resources.Round_Button_calup;
                    break;
                case "btnSales":
                    buttonName.Image = Properties.Resources.Round_Button_salesup;
                    break;
                case "btnStock":
                    buttonName.Image = Properties.Resources.Round_Button_stockup;
                    break;
                case "btnClients":
                    buttonName.Image = Properties.Resources.Round_Button_clientsup;
                    break;
                case "btnUsers":
                    buttonName.Image = Properties.Resources.Round_Button_userup;
                    break;
                case "btnReports":
                    buttonName.Image = Properties.Resources.Round_Button_reportup;
                    break;

                default:
                    MessageBox.Show("Nothing Was Clicked !"); // shows button clicked
                    break;
            }

        }

        private void cb_Salon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (scheduleClicked)
            {
                salon = cb_Salon.SelectedItem.ToString();
                lbl_SalonSelection.Text = salon;
                if (!firstload)
                    updateSched();
            }
        }

        private void rb_Salon_CheckedChanged(object sender, EventArgs e)
        {
            if (scheduleClicked)
            {
                RadioButton radioTemp = new RadioButton();
                radioTemp = (RadioButton)sender;
                salonNo = radioTemp.Text.ToString();
                lbl_SalonNoSelection.Text = salonNo;
                if (scheduleClicked)
                    updateSched();
            }
        }
    }   
}
