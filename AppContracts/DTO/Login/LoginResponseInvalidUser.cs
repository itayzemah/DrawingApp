using EntityAndBoundary.Boundary;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppContracts.DTO.Login
{
    public class LoginResponseInvalidUser : LoginResponse
    {
        public LoginResponseInvalidUser(UserBoundary user) : base(user) 
        {

        }
    }
}
