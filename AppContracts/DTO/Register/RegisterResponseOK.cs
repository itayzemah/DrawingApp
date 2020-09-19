using EntityAndBoundary.Boundary;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppContracts.DTO.Register
{
    public class RegisterResponseOK : RegisterResponse
    {
        public UserBoundary NewUser { get; set; }
        public RegisterResponseOK(RegisterRequest request): base(request)
        {

        }
    }
}
