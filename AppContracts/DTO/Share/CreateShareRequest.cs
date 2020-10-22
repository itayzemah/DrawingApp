using EntityAndBoundary.Boundary;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppContracts.DTO.Share
{
    public class CreateShareRequest
    {
        public ShareBoundary Share { get; set; }
        public string UserIDWantShare { get; set; }

        public string DocID { get; set; }
    }
}
