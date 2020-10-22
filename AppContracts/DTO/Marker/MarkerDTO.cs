using System;
using System.Collections.Generic;
using System.Text;

namespace AppContracts.DTO.Marker
{
    public class MarkerDTO
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
