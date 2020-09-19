using AppContracts;
using AppContracts.DTO.Login;
using AppContracts.DTO.Register;
using EntityAndBoundary.Boundary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItayDrowingApp.AppContracts
{
    public interface IUserService
    {
        public Response CreateUser(RegisterRequest request);
        public Response Login(LoginRequest request);
        public UserBoundary Unsubscribe(string userEmail);

    }
}
