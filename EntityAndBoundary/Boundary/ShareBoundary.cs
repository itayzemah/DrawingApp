using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityAndBoundary.Boundary
{
    public class ShareBoundary
    {
        public string DocID { get; set; }
        public string OwnerID { get; set; }

        public string[] users { get; set; }
    }
}
