using EntityAndBoundary.Boundary;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public interface IMarkerDAL
    {
        public MarkerBoundary Create(MarkerBoundary marker);

        public MarkerBoundary Remove(MarkerBoundary markerToRemove);

        public MarkerBoundary GetAllMarkersForDoc(string documentID);
    }
}
