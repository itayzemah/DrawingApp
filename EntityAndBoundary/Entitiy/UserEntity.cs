using System;
using System.Collections.Generic;
using System.Text;

namespace EntityAndBoundary.Entity
{
    public class UserEntity
    {
        public string UserID { get; set; }

        public string userEmail { get; set; }

        public string UserName { get; set; }

        public UserEntity()
        {
        }
        public UserEntity(string userID, string userEmail, string userName)
        {
            UserID = userID;
            this.userEmail = userEmail;
            UserName = userName;
        }

        public override bool Equals(object obj)
        {
            return obj is UserEntity entity &&
                   UserID == entity.UserID &&
                   userEmail == entity.userEmail &&
                   UserName == entity.UserName;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
