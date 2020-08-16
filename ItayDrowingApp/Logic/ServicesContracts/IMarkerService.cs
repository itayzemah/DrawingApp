using EntityAndBoundary.Boundary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItayDrowingApp.Logic.ServicesContracts
{
    public interface IMarkerService
    {
        public MarkerBoundary CreateMarker(MarkerBoundary marker);
        public MarkerBoundary RemoveMarker(MarkerBoundary marker);
        public List<MarkerBoundary> getAll();


    }
}
