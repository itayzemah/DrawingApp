using DAL.Converters;
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

        public UserServiceImple()
        {
            _users = new Dictionary<string, UserEntity>();
            this.userConverter = new UserConverter();
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
                _users.Add(user.Email, userConverter.BoundaryToEntity(new UserBoundary() { ID = id, UserEmail = user.Email, UserName = user.UserName }));
            }
            return userConverter.EntityToBoundary( _users[user.Email]);
        }

        public UserBoundary Login(string userEmail)
        {
            return new UserBoundary() { UserEmail = userEmail };
        }

        public UserBoundary Unsubscribe(string userEmail)
        {
            throw new NotImplementedException();
        }
    }
}
