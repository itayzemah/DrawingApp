using System;
using System.Collections.Generic;
using System.Text;

namespace AppContracts.DTO.Register
{
    public class RegisterResponse : Response
    {
        public RegisterRequest Request { get; }

        public RegisterResponse(RegisterRequest request)
        {
            this.Request = request;
        }
    }
}
