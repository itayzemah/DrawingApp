using EntityAndBoundary.Entity;
using System;

namespace DAL
{
    public interface IUserDAL
    {
        public UserEntity Create(UserEntity newUser);

        public UserEntity RemoveUser(UserEntity userToRemove);

        public UserEntity Login(string userEmail);
    }
}
