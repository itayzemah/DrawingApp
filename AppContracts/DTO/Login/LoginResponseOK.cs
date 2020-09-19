using EntityAndBoundary.Boundary;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppContracts.DTO.Login
{
    public class LoginResponseOK : LoginResponse
    {
        public LoginResponseOK(UserBoundary user) : base(user) {
        }
    }
}
