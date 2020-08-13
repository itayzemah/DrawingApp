using ItayDrowingApp.Boundary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItayDrowingApp.Logic.ServicesContracts
{
    public interface IUserService
    {
        public UserBoundary CreateUser(UserBoundary user);
        public UserBoundary Login(string userEmail, string userName);
        public UserBoundary Unsubscribe(UserBoundary user);

    }
}
