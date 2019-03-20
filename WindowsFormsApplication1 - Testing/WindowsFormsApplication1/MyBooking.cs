using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairBeautyNWRC
{
    class MyBooking
    {
        private int bookNo;
        private String clientNo;
        private String title;
        private String surname;
        private String forename;
        private String treatment;
        private bool check1;
        private bool check2;
        private bool check3;
        private bool check4;
        private bool check5;
        private bool check6;
        private bool check7;
        private bool check8;
        private bool check9;
        private bool check10;
        private bool check11;
        private bool check12;
        private bool check13;
        private bool check14;
        private bool check15;
        private bool check16;
        private bool check17;
        private bool check18;
        private bool check19;
        private bool check20;


        public MyBooking()
        {
            bookNo = 0;
            clientNo = "";
            title = "";
            surname = "";
            forename = "";
            treatment = "";
            check1 = false;
            check2 = false;
            check3 = false;
            check4 = false;
            check5 = false;
            check6 = false;
            check7 = false;
            check8 = false;
            check9 = false;
            check10 = false;
            check11 = false;
            check12 = false;
            check13 = false;
            check14 = false;
            check15 = false;
            check16 = false;
            check17 = false;
            check18 = false;
            check19 = false;
            check20 = false;
        }

        public MyBooking(int bookNo, string clientNo, string title, string surname, string forename, string treatment, bool check1, bool check2, bool check3, bool check4, bool check5, bool check6, bool check7, bool check8, bool check9, bool check10, bool check11, bool check12, bool check13, bool check14, bool check15, bool check16, bool check17, bool check18, bool check19, bool check20)
        {
            this.bookNo = bookNo;
            this.clientNo = clientNo;
            this.title = title;
            this.surname = surname;
            this.forename = forename;
            this.treatment = treatment;
            this.check1 = check1;
            this.check2 = check2;
            this.check3 = check3;
            this.check4 = check4;
            this.check5 = check5;
            this.check6 = check6;
            this.check7 = check7;
            this.check8 = check8;
            this.check9 = check9;
            this.check10 = check10;
            this.check11 = check11;
            this.check12 = check12;
            this.check13 = check13;
            this.check14 = check14;
            this.check15 = check15;
            this.check16 = check16;
            this.check17 = check17;
            this.check18 = check18;
            this.check19 = check19;
            this.check20 = check20;
        }

        public int BookNo { get => bookNo; set => bookNo = value; }
        public string ClientNo { get => clientNo; set => clientNo = value; }
        public string Title { get => title; set => title = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Forename { get => forename; set => forename = value; }
        public string Treatment { get => treatment; set => treatment = value; }
        public bool Check1 { get => check1; set => check1 = value; }
        public bool Check2 { get => check2; set => check2 = value; }
        public bool Check3 { get => check3; set => check3 = value; }
        public bool Check4 { get => check4; set => check4 = value; }
        public bool Check5 { get => check5; set => check5 = value; }
        public bool Check6 { get => check6; set => check6 = value; }
        public bool Check7 { get => check7; set => check7 = value; }
        public bool Check8 { get => check8; set => check8 = value; }
        public bool Check9 { get => check9; set => check9 = value; }
        public bool Check10 { get => check10; set => check10 = value; }
        public bool Check11 { get => check11; set => check11 = value; }
        public bool Check12 { get => check12; set => check12 = value; }
        public bool Check13 { get => check13; set => check13 = value; }
        public bool Check14 { get => check14; set => check14 = value; }
        public bool Check15 { get => check15; set => check15 = value; }
        public bool Check16 { get => check16; set => check16 = value; }
        public bool Check17 { get => check17; set => check17 = value; }
        public bool Check18 { get => check18; set => check18 = value; }
        public bool Check19 { get => check19; set => check19 = value; }
        public bool Check20 { get => check20; set => check20 = value; }

        public override string ToString()
        {
            return bookNo + "," + ClientNo +"," + Title + "," + Forename + "," + Surname +"," 
                   + treatment +"," + Check1 +"," + Check2 +"," + Check3 + "," 
                   + Check4 +"," + Check5 +"," + Check6 +"," + Check7 +"," 
                   + Check8 + "," + Check9 + "," + Check10 +"," + Check11 
                   + Check12 +"," + Check13 +"," + Check14 +"," + Check15 
                   + "," + Check16 + "," + Check17 + "," + Check18 + "," 
                   + Check19 + "," +Check20;
        }

    }

}
