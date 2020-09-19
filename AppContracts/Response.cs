using System;
using System.Collections.Generic;
using System.Text;

namespace AppContracts
{
    public class Response
    {
        public string ResponseType { get; }

        public Response()
        {
            ResponseType = this.GetType().Name;
        }
    }
}
