using System;
using System.Collections.Generic;
using System.Text;

namespace AppContracts.DTO.Marker
{
    public class MarkerRequest
    {
        public string requestType { get; set; }
        public MarkerDTO drawingMsg { get; set; }
    }
}
