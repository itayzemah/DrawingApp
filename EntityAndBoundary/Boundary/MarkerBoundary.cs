using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityAndBoundary.Boundary
{
    public class MarkerBoundary
    {
        public string MarkerID { get; set; }

        public string shape { get; set; }

        public string docID { get; set; }

        public string LocationJson { get; set; }

        public string ForeColor { get; set; }

        public string BackColor { get; set; }

        public string CreatedBy { get; set; }
    }
}
