using EntityAndBoundary.Boundary;
using EntityAndBoundary.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DALImlementations
{
    public class UserDAL : IUserDAL
    {

        public UserBoundary Create(NewUserBoundaey newUser)
        {
            throw new NotImplementedException();
        }

        public UserBoundary Login(string userEmail)
        {
            throw new NotImplementedException();
        }

        public UserBoundary RemoveUser(UserBoundary userToRemove)
        {
            throw new NotImplementedException();
        }
    }
}
