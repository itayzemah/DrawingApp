using EntityAndBoundary.Boundary;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppContracts.DTO.Share
{
    public class CreateShareResponseOK:Response
    {
        public ShareBoundary Share { get; set; }
    }
}
