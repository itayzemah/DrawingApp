using System;
using System.Collections.Generic;
using System.Text;

namespace AppContracts.DTO.Register
{
    public class RegisterResponseUserExist : RegisterResponse
    {
        public RegisterResponseUserExist(RegisterRequest request) : base(request)
        {

        }
    }
}
