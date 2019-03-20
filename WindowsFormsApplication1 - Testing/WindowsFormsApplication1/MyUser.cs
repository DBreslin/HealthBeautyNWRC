using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairBeautyNWRC
{
    class MyUser
    {
        private int userID;
        private String username;
        private String userSurname;
        private String userForename;
        private String userLevel;
        private String userEmail;
        private String super;

        public MyUser()
        {
            userID = 0;
            username = "";
            userSurname = "";
            userForename = "";
            userLevel = "";
            UserPassword = "";
            userEmail = "";
            super = "";
    }

        public MyUser(int userID, string username, string userSurname, string userForename, string userLevel, string userPassword, string userEmail, string super)
        {
            this.userID = userID;
            this.username = username;
            this.userSurname = userSurname;
            this.userForename = userForename;
            this.userLevel = userLevel;
            this.UserPassword = userPassword;
            this.userEmail = userEmail;
            this.super = super;
        }

        public int UserID { get => userID; set => userID = value; }
        public string Username { get => username; set => username = value; }
        public string UserSurname { get => userSurname; set => userSurname = value; }
        public string UserForename { get => userForename; set => userForename = value; }
        public string UserLevel { get => userLevel; set => userLevel = value; }
        public string UserPassword { get; set; }
        public string UserEmail { get => userEmail; set => userEmail = value; }
        public string Super { get => super; set => super = value; }
    }
}
