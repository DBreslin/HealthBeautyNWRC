using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairBeautyNWRC
{
    class MyClient
    {
        private int clientNo;
        private String title;
        private String surname;
        private String forename;
        private String street;
        private String town;
        private String county;
        private String postcode;
        private String country;
        private String telNo;
        private String email;
        private String skinTest;

        

       public MyClient()
        {
            clientNo = 0;
            title = "";
            surname = "";
            forename = "";
            street = "";
            town = "";
            postcode = "";
            telNo = "";
            email = "";
            skinTest = "";
        }

        public MyClient(int clientNo, string title, string surname, string forename, string street, string town, string county, string postcode, string country, string telNo, string email, string skinTest)
        {
            this.clientNo = clientNo;
            this.title = title;
            this.surname = surname;
            this.forename = forename;
            this.street = street;
            this.town = town;
            this.county = county;
            this.postcode = postcode;
            this.country = country;
            this.telNo = telNo;
            this.email = email;
            this.skinTest = skinTest;
        }

        public int ClientNo { get => clientNo; set => clientNo = value; }
        public string Title { get => title; set => title = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Forename { get => forename; set => forename = value; }
        public string Street { get => street; set => street = value; }
        public string Town { get => town; set => town = value; }
        public string County { get => county; set => county = value; }
        public string Postcode { get => postcode; set => postcode = value; }
        public string Country { get => country; set => country = value; }
        public string TelNo { get => telNo; set => telNo = value; }
        public string Email { get => email; set => email = value; }
        public string SkinTest { get => skinTest; set => skinTest = value; }
    }
}
