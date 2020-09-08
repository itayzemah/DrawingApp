using EntityAndBoundary.Boundary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItayDrowingApp.AppContracts
{
    public interface IMarkerService
    {
        public MarkerBoundary CreateMarker(MarkerBoundary marker);
        public MarkerBoundary RemoveMarker(string docID);
        public List<MarkerBoundary> getAll(string userEmail,string docID );


    }
}
