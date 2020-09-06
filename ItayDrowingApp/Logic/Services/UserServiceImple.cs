using DAL;
using DAL.DALImlementations;
using EntityAndBoundary.Boundary;
using EntityAndBoundary.Entity;
using ItayDrowingApp.Logic.ServicesContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItayDrowingApp.Logic.Services
{
    public class UserServiceImple : IUserService
    {
        private Dictionary<string, UserEntity> _users;
        private UserConverter userConverter;
        private IUserDAL userDAL;

        public UserServiceImple(UserConverter userConverter, IUserDAL userDAL)
        {
            _users = new Dictionary<string, UserEntity>();
            this.userConverter = userConverter;
            this.userDAL = userDAL;

        }

        public UserBoundary CreateUser(NewUserBoundaey user)
        {
            if (_users.ContainsKey(user.Email))
            {
                return null;
            }
            else
            {
                string id = Guid.NewGuid().ToString();
                UserEntity retval = userDAL.Create(userConverter.BoundaryToEntity(id,user));
                _users.Add(user.Email, userConverter.BoundaryToEntity(new UserBoundary() { ID = id, UserEmail = user.Email, UserName = user.UserName }));
            }
            return userConverter.EntityToBoundary( _users[user.Email]);
        }

        public UserBoundary Login(string userEmail)
        {
            UserEntity retval = userDAL.Login(userEmail);

            return userConverter.EntityToBoundary(retval);
        }

        public UserBoundary Unsubscribe(string userEmail)
        {
            throw new NotImplementedException();
        }
    }
}
