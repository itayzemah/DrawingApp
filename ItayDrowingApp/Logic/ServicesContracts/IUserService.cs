using EntityAndBoundary.Boundary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItayDrowingApp.Logic.ServicesContracts
{
    public interface IUserService
    {
        public UserBoundary CreateUser(NewUserBoundaey user);
        public UserBoundary Login(string userEmail);
        public UserBoundary Unsubscribe(string userEmail);

    }
}
