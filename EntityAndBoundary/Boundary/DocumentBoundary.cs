using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityAndBoundary.Boundary
{
    public class DocumentBoundary
    {
        public string OwnerID { get; set; }

        public string URL { get; set; }

        public string DocumentName { get; set; }

        public string docID { get; set; }

        public MarkerBoundary[] Markers { get; set; }

        public Boolean IsActive { get; set; }
    }
}
