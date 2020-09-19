using EntityAndBoundary.Boundary;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityAndBoundary.Marker_Response
{
    public class RemoveMarkerResponse : Response<MarkerBoundary>
    {
    }
    public class RemoveMarkerResponseOK : RemoveMarkerResponse
    {
    }
    public class RemoveMarkerResponseNoMarker : RemoveMarkerResponse
    {
        public string Message { get; set; }
    }
}
