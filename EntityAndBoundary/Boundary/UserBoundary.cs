using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityAndBoundary.Boundary
{
    public class UserBoundary
    {
        public string ID { get; set; }
        public string UserEmail { get; set; }

        public string UserName { get; set; }

        public UserBoundary()
        {
        }

        public UserBoundary(string id, string userEmail, string userName)
        {
            ID = id;
            UserEmail = userEmail;
            UserName = userName;
        }


    }
}
