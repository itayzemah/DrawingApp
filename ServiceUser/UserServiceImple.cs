using AppContracts;
using AppContracts.DTO.Login;
using AppContracts.DTO.Register;
using DAL;
using DAL.DALImlementations;
using EntityAndBoundary.Boundary;
using EntityAndBoundary.Entity;
using ItayDrowingApp.AppContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItayDrowingApp.Logic.Services
{
    [Register(Policy.Scoped, typeof(IUserService))]
    public class UserServiceImple : IUserService
    {
        private UserConverter userConverter;
        private IUserDAL userDAL;

        public UserServiceImple()
        {
        }

        public UserServiceImple(UserConverter userConverter, IUserDAL userDAL)
        {
            this.userConverter = userConverter;
            this.userDAL = userDAL;

        }

        public Response CreateUser(RegisterRequest request)
        {
            string id = Guid.NewGuid().ToString();

            UserEntity userRetval = userDAL.Create(userConverter.BoundaryToEntity(id, request));
            RegisterResponse retval = null;
            if(userRetval != null)
            {
                retval = new RegisterResponseOK(request) { NewUser = userConverter.EntityToBoundary(userRetval) };
            }
            else
            {
                retval = new RegisterResponseUserExist(request);
            }
            return retval;
        }

        public Response Login(LoginRequest request)
        {
            UserEntity user = userDAL.Login(request.Login.UserEmail);
            LoginResponse retval = null;
            if (user != null)
            {
                retval = new LoginResponseOK(this.userConverter.EntityToBoundary(user));
            }
            else
            {
                retval = new LoginResponseInvalidUser(new UserBoundary() { UserEmail = request.Login.UserEmail + " - User Not Valid!" });
            }

            return retval;
        }

        public UserBoundary Unsubscribe(string userEmail)
        {
            throw new NotImplementedException();
        }
    }
}
