using EntityAndBoundary.Boundary;
using System;

namespace DAL
{
    public interface IUserDAL
    {
        public UserBoundary Create(NewUserBoundaey newUser);

        public UserBoundary RemoveUser(UserBoundary userToRemove);

        public UserBoundary Login(string userEmail);
    }
}
